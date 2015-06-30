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
    public partial class Dranken: Form {
        private string naam;
        private Waarden wrd;
        public Dranken () {
            InitializeComponent ();
        }

        public Dranken (Waarden waarden, string naam) {
            wrd = waarden;
            InitializeComponent ();
            label1.Text = naam;
            this.naam = naam;
        }

        private void button1_Click (object sender, EventArgs e) {
            var form = new Fris (wrd, naam);
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show ();
            this.Hide ();
        }
        // Hoi ik ben een comment
        private void button1_MouseDown (object sender, MouseEventArgs e) {
            btn_fris.BackColor = Color.BurlyWood;

        }

        private void button1_MouseUp (object sender, MouseEventArgs e) {
            btn_fris.BackColor = Color.LemonChiffon;
        }

        private void button2_MouseDown (object sender, MouseEventArgs e) {
            btn_gedistilleerd.BackColor = Color.BurlyWood;
        }

        private void button2_MouseUp (object sender, MouseEventArgs e) {
            btn_gedistilleerd.BackColor = Color.LemonChiffon;
        }

        private void button4_MouseDown (object sender, MouseEventArgs e) {
            btn_koffieEnThee.BackColor = Color.BurlyWood;
        }

        private void button4_MouseUp (object sender, MouseEventArgs e) {
            btn_koffieEnThee.BackColor = Color.LemonChiffon;
        }

        private void button2_Click (object sender, EventArgs e) {
            var form = new SterkeDrank (wrd, naam) {
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
            var form = new KoffieThee (wrd, naam) {
                Location = this.Location,
                StartPosition = this.StartPosition
            };
            form.Show ();
            this.Hide ();
        }

        private void button3_Click (object sender, EventArgs e) {
            var form = new Wijn (wrd, naam) {
                Location = this.Location,
                StartPosition = this.StartPosition
            };
            form.Show ();
            this.Hide ();
        }

        private void button6_Click (object sender, EventArgs e) {
            var form = new Bier (wrd, naam) {
                Location = this.Location,
                StartPosition = this.StartPosition
            };
            form.Show ();
            this.Hide ();
        }
    }
}
