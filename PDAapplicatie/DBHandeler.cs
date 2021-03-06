﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Management.Instrumentation;
using System.Net.Sockets;

namespace PDAapplicatie {
    internal class DbHandeler {
        public string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=C:\\Users\\kevin\\Downloads\\Bestelsysteem.accdb;" +
                                   "Persist Security Info=True";


        public string login(string code) {
            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            string sql = string.Format("SELECT Naam FROM Werknemer WHERE ID = {0}", code);
            OleDbCommand command = new OleDbCommand(sql, conn);
            string naam = "";
            try {
                naam = command.ExecuteScalar().ToString();
            }
            catch (Exception e) {
                return naam;
            }
            return naam;
        }

        public int Bestellingsnummer(Waarden wrd) {
            int tflnummer = wrd.Tafelnummer;
            OleDbConnection conn = new OleDbConnection (connString);
            conn.Open ();
            int bestelnummer = 0;


            OleDbCommand command = new OleDbCommand (string.Format ("SELECT Bestelnummer FROM Bestelling WHERE Status='Bezet' AND Tafel ='{0}'", tflnummer), conn);
            bestelnummer = Convert.ToInt32 (command.ExecuteScalar ());
            conn.Close();
            return bestelnummer;
        }

        public void SchrijfProducten(Waarden wrd) {
            int bestelnummer = wrd.bestelnummer;
            List<Product> bestelling = wrd.Bestelling;
            double prijs = 0;
            int nummer = wrd.Tafelnummer;
            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            OleDbCommand command = new OleDbCommand();
            foreach (Product p in bestelling) {
                prijs += p.prijs;
                string sql = string.Format("INSERT INTO Bevat (Bestelnummer, [Product ID]) " + "values ('{0}', '{1}')",
                    bestelnummer, p.id);
                command = new OleDbCommand(sql, conn);
                command.ExecuteNonQuery();
            }
            string SQL =
                string.Format("UPDATE Bestelling SET Prijs='{0}' WHERE Status='Bezet' AND Tafel = '{1}'", prijs, nummer);
            command = new OleDbCommand(SQL, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public Tafelbezet[] TafelsBezet() {
            Tafelbezet[] tafelbezet  = new Tafelbezet[10];
            OleDbConnection conn =  new OleDbConnection(connString);
            conn.Open();
            OleDbCommand command = new OleDbCommand("SELECT Tafel FROM Bestelling WHERE Status='Bezet';", conn);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                int i = Convert.ToInt32(reader.GetString(0)) -1;
                tafelbezet[i].bezet = true;
            }
            conn.Close();
            return tafelbezet;
        }

        public Tafelbezet[] TafelsKlaar()
        {
            Tafelbezet[] tafelbezet = new Tafelbezet[10];
            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            OleDbCommand command = new OleDbCommand("SELECT Tafel,Tijd FROM Bestelling WHERE Status='Klaar';", conn);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int i = Convert.ToInt32(reader.GetString(0)) - 1;
                tafelbezet[i].bezet = true;
            }
            conn.Close();
            return tafelbezet;
        }

        public int Voorraad(int id) {
            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            string sql = String.Format("SELECT Aantal FROM Product WHERE ID={0}", id);
            OleDbCommand command = new OleDbCommand(sql, conn);
            int ID = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            return ID;
        }

        public void Bezetten(Waarden wrd) {
            int nummer = wrd.Tafelnummer;
            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open(); 
            string sql = string.Format("INSERT INTO Bestelling (Status, Tafel) " + "values ('{0}', '{1}')", "Bezet",
                nummer);
            OleDbCommand command = new OleDbCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public Tafelbezet[] TafelsRes() {
            Tafelbezet[] tafelbezet = new Tafelbezet[10];
            OleDbConnection conn = new OleDbConnection (connString);
            conn.Open ();
            OleDbCommand command = new OleDbCommand ("SELECT Tafel FROM Bestelling WHERE Status='Gereserveerd';", conn);
            OleDbDataReader reader = command.ExecuteReader ();
            while (reader.Read ()) {
                int i = Convert.ToInt32 (reader.GetString (0)) - 1;
                tafelbezet[i].bezet = true;
            }
            conn.Close ();
            return tafelbezet;
        }

        public double Prijs(int nummer) {
            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            OleDbCommand command = new OleDbCommand(string.Format("SELECT Prijs FROM Bestelling WHERE Bestelnummer ={0}", nummer), conn);
            double Prijs = Convert.ToDouble(command.ExecuteScalar());
            return Prijs;
        }

        public List<Product> GetProuctenByBestelNumber(int bestelNummer)
        {
            List<Product> products = new List<Product> { };

            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();

            OleDbCommand command = new OleDbCommand(string.Format("SELECT `Product ID` FROM Bestelling b JOIN Bevat be ON b.Tafel=be.`Product ID`  WHERE Bestelnummer={0} ", bestelNummer), conn);
            try
            {
                //bestelNummer = (int) command.ExecuteScalar();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Product p = new Product();
                    p.id = Convert.ToInt32(reader.GetString(0));
                    products.Add(p);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return products;
        }

        //public Waarden UpdateWaarden() {
            
        //}

    }
}
