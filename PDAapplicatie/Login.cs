using System;
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
    public partial class Login: Form {
        public string login = "";
        public Login () {
            InitializeComponent ();
        }

        private void label1_Click (object sender, EventArgs e) {

        }

        private void timer1_Tick (object sender, EventArgs e) {
            label3.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute.ToString ("00");
            label2.Text = ( SystemInformation.PowerStatus.BatteryLifePercent * 100 ) + "%";
        }

        private void Form1_Load (object sender, EventArgs e) {
        }

        private void button5_Click (object sender, EventArgs e) {
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");
        }

        private void button6_Click (object sender, EventArgs e) {
            login += "5";
            txtbox_pincode.Text += "*";
        }

        private void button1_Click (object sender, EventArgs e) {
            login += "1";
            txtbox_pincode.Text += "*";
        }

        private void button3_Click (object sender, EventArgs e) {
            login += "2";
            txtbox_pincode.Text += "*";
        }

        private void button13_Click (object sender, EventArgs e) {
            login += "4";
            txtbox_pincode.Text += "*";
        }

        private void button12_Click (object sender, EventArgs e) {
            login += "6";
            txtbox_pincode.Text += "*";
        }

        private void button10_Click (object sender, EventArgs e) {
            login += "7";
            txtbox_pincode.Text += "*";
        }

        private void button4_Click (object sender, EventArgs e) {
            login += "8";
            txtbox_pincode.Text += "*";
        }

        private void button11_Click (object sender, EventArgs e) {
            login += "9";
            txtbox_pincode.Text += "*";
        }

        private void button8_Click (object sender, EventArgs e) {
            login += "0";
            txtbox_pincode.Text += "*";
        }

        private void button2_Click (object sender, EventArgs e) {
            login += "3";
            txtbox_pincode.Text += "*";
        }

        private void button7_Click (object sender, EventArgs e) {
            if (login.Length > 0) {
                login = login.Remove(login.Length - 1);
                txtbox_pincode.Text = txtbox_pincode.Text.Remove(txtbox_pincode.Text.Length - 1);
            }
        }


        private void button9_Click_1 (object sender, EventArgs e) {
            DbHandeler db = new DbHandeler ();
            string naam = db.login(login);
            if (naam != "") {
                var form = new Hoofdmenu (naam);
                form.Location = this.Location;
                form.StartPosition = this.StartPosition;
                form.Show ();
                this.Hide ();
            } else {
                txtbox_pincode.Text = "";
                login = "";
                txtbox_pincode.BackColor = Color.Crimson;
            }
        }
    }
}
