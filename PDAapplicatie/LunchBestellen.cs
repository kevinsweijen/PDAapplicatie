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
    public partial class LunchBestellen: Form {
        private string naam;
        private Waarden wrd;
        public LunchBestellen () {
            InitializeComponent ();
        }

        public LunchBestellen (Waarden waarden, string naam) {
            wrd = waarden;
            InitializeComponent ();
            label1.Text = naam;
            this.naam = naam;
        }

        private void button1_Click (object sender, EventArgs e) {
            var form = new LunchVoor(wrd, naam);
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show ();
            this.Hide ();
        }
        // Hoi ik ben een comment
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

        private void button2_Click (object sender, EventArgs e) {
            var form = new LunchHoofd(wrd, naam) {
                Location = this.Location,
                StartPosition = this.StartPosition
            };
            form.Show ();
            this.Hide ();
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
            var form = new Bestellen (wrd, naam) {
                Location = this.Location,
                StartPosition = this.StartPosition
            };
            form.Show ();
            this.Hide ();
        }

        private void button4_Click (object sender, EventArgs e) {
            var form = new LunchNa (wrd, naam) {
                Location = this.Location,
                StartPosition = this.StartPosition
            };
            form.Show ();
            this.Hide ();
        }
    }
}
