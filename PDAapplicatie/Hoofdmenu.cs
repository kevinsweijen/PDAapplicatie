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
    public partial class Hoofdmenu: Form {
        public string naam;
        public Hoofdmenu () {
            InitializeComponent ();
        }

        public Hoofdmenu(string naam) {
            InitializeComponent();
            label1.Text = naam;
            this.naam = naam;
        }

        private void button1_Click (object sender, EventArgs e) {
            var form = new Tafelselect(naam);
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show();
            this.Hide();
        }

        private void button1_MouseDown (object sender, MouseEventArgs e) {
            button1.BackColor = Color.BurlyWood;

        }

        private void button1_MouseUp (object sender, MouseEventArgs e) {
            button1.BackColor = Color.LemonChiffon;
        }

        private void button2_MouseDown (object sender, MouseEventArgs e) {
            button2.BackColor = Color.BurlyWood;
        }

        private void button2_MouseUp (object sender, MouseEventArgs e) {
            button2.BackColor = Color.LemonChiffon;
        }

        private void button4_MouseDown (object sender, MouseEventArgs e) {
            button4.BackColor = Color.BurlyWood;
        }

        private void button4_MouseUp (object sender, MouseEventArgs e) {
            button4.BackColor = Color.LemonChiffon;
        }

        private void button3_MouseDown (object sender, MouseEventArgs e) {
            button3.BackColor = Color.BurlyWood;
        }

        private void button3_MouseUp (object sender, MouseEventArgs e) {
            button3.BackColor = Color.LemonChiffon;
        }

        private void button6_MouseDown (object sender, MouseEventArgs e) {
            button6.BackColor = Color.BurlyWood;
        }

        private void button6_MouseUp (object sender, MouseEventArgs e) {
            button6.BackColor = Color.LemonChiffon;
        }

        private void button2_Click (object sender, EventArgs e) {

        }

        private void label1_Click (object sender, EventArgs e) {

        }

        private void timer1_Tick (object sender, EventArgs e) {
            label3.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute.ToString("00");
            label2.Text = (SystemInformation.PowerStatus.BatteryLifePercent*100) + "%";
        }

        private void Form1_Load (object sender, EventArgs e) {
        }
    }
}
