﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDAapplicatie {
    public partial class DinerNa: Form {
        public string naam;
        private int top = 0;
        private int mid = 0;
        private int bot = 0;
        private DbHandeler db;
        public Waarden wrd;
        public DinerNa () {
            InitializeComponent ();
        }

        public DinerNa (Waarden waarden, string naam) {
            InitializeComponent ();
            wrd = waarden;
            label1.Text = naam;
            this.naam = naam;
            db = new DbHandeler ();
        }

        private void button1_Click (object sender, EventArgs e) {
            if (top == 0) return;
            top--;
            lbl_cafe_count.Text = top + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 18);
            for (int x = 0; x < top; x++) {
                wrd.Bestelling.Add (new Product { id = 18, prijs = 5.50 });
            }
        }
        // Hoi ik ben een comment
        private void button1_MouseDown (object sender, MouseEventArgs e) {
            btn_cafe_min.BackColor = Color.BurlyWood;

        }

        private void button1_MouseUp (object sender, MouseEventArgs e) {
            btn_cafe_min.BackColor = Color.LemonChiffon;
        }

        private void label1_Click (object sender, EventArgs e) {

        }

        private void timer1_Tick (object sender, EventArgs e) {
            label3.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute.ToString ("00");
            label2.Text = ( SystemInformation.PowerStatus.BatteryLifePercent * 100 ) + "%";
        }

        private void Form1_Load (object sender, EventArgs e) {
        }

        private void button3_Click (object sender, EventArgs e) {
            int max = db.Voorraad (18);
            if (top == max) {
                return;
            } else if (top > max) {
                top = max;
            } else {
                top++;
            }
            lbl_cafe_count.Text = top + "x";
            wrd.Bestelling.Add (new Product { id = 18, prijs = 5.50 });
        }

        private void button6_Click (object sender, EventArgs e) {
            int max = db.Voorraad (19);
            if (mid == max) {
                return;
            } else if (mid > max) {
                mid = max;
            } else {
                mid++;
            }
            lbl_cherry_count.Text = mid + "x";
            wrd.Bestelling.Add (new Product { id = 19, prijs = 6.50 });
        }

        private void button2_Click (object sender, EventArgs e) {
            if (mid == 0) return;
            mid--;
            lbl_cherry_count.Text = mid + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 19);
            for (int x = 0; x < mid; x++) {
                wrd.Bestelling.Add (new Product { id = 19, prijs = 6.50 });
            }
        }

        private void button7_Click (object sender, EventArgs e) {
            if (bot == 0) return;
            bot--;
            lbl_port_count.Text = bot + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 20);
            for (int x = 0; x < mid; x++) {
                wrd.Bestelling.Add (new Product { id = 20, prijs = 7.50 });
            }
        }

        private void button4_Click (object sender, EventArgs e) {
            int max = db.Voorraad (20);
            if (bot == max) {
                return;
            } else if (bot > max) {
                bot = max;
            } else {
                bot++;
            }
            lbl_port_count.Text = bot + "x";
            wrd.Bestelling.Add (new Product { id = 20, prijs = 7.50 });
        }

        private void button5_Click (object sender, EventArgs e) {
            var form = new DinerBestellen (wrd, naam) {
                Location = this.Location,
                StartPosition = this.StartPosition
            };
            form.Show ();
            this.Hide ();
        }
    }
}