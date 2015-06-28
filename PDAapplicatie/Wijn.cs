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
    public partial class Wijn: Form {
        public string naam;
        private int een = 0;
        private int twee = 0;
        private int drie = 0;
        private int vier = 0;
        private int vijf = 0;
        private int zes = 0;
        private DbHandeler db;
        public Waarden wrd;
        public Wijn () {
            InitializeComponent ();
        }

        public Wijn (Waarden waarden, string naam) {
            InitializeComponent ();
            wrd = waarden;
            label1.Text = naam;
            this.naam = naam;
            db = new DbHandeler ();
        }

        private void button1_Click (object sender, EventArgs e) {
            if (een == 0) return;
            een--;
            label4.Text = een + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 32);
            for (int x = 0; x < een; x++) {
                wrd.Bestelling.Add (new Product { id = 32, prijs = 6.50 });
            }
        }
        // Hoi ik ben een comment
        private void button1_MouseDown (object sender, MouseEventArgs e) {
            button1.BackColor = Color.BurlyWood;

        }

        private void button1_MouseUp (object sender, MouseEventArgs e) {
            button1.BackColor = Color.LemonChiffon;
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
            int max = db.Voorraad (21);
            if (een == max) {
                return;
            } else if (een > max) {
                een = max;
            } else {
                een++;
            }
            label4.Text = een + "x";
            wrd.Bestelling.Add (new Product { id = 32, prijs = 6.50 });
        }

        private void button6_Click (object sender, EventArgs e) {
            int max = db.Voorraad (31);
            if (twee == max) {
                return;
            } else if (twee > max) {
                twee = max;
            } else {
                twee++;
            }
            label8.Text = twee + "x";
            wrd.Bestelling.Add (new Product { id = 31, prijs = 28.50 });
        }

        private void button2_Click (object sender, EventArgs e) {
            if (twee == 0) return;
            twee--;
            label8.Text = twee + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 31);
            for (int x = 0; x < twee; x++) {
                wrd.Bestelling.Add (new Product { id = 31, prijs = 28.50 });
            }
        }

        private void button5_Click (object sender, EventArgs e) {
            var form = new Fris (wrd, naam) {
                Location = this.Location,
                StartPosition = this.StartPosition
            };
            form.Show ();
            this.Hide ();
        }

        private void button9_Click (object sender, EventArgs e) {
            if (drie == 0) return;
            drie--;
            label11.Text = drie + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 34);
            for (int x = 0; x < drie; x++) {
                wrd.Bestelling.Add (new Product { id = 34, prijs = 7.50 });

            }
        }

        private void button8_Click (object sender, EventArgs e) {
            int max = db.Voorraad (34);
            if (drie == max) {
                return;
            } else if (drie > max) {
                drie = max;
            } else {
                drie++;
            }
            label11.Text = drie + "x";
            wrd.Bestelling.Add (new Product { id = 34, prijs = 7.50 });
        }

        private void button7_Click_1 (object sender, EventArgs e) {
            if (vier == 0) return;
            vier--;
            label6.Text = vier + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 33);
            for (int x = 0; x < vier; x++) {
                wrd.Bestelling.Add (new Product { id = 33, prijs = 32.00 });

            }
        }

        private void button4_Click_1 (object sender, EventArgs e) {
            int max = db.Voorraad (33);
            if (vier == max) {
                return;
            } else if (vier > max) {
                vier = max;
            } else {
                vier++;
            }
            label6.Text = vier + "x";
            wrd.Bestelling.Add (new Product { id = 33, prijs = 32.00 });
        }

        private void button13_Click (object sender, EventArgs e) {
            if (vijf == 0) return;
            vijf--;
            label15.Text = vijf + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 35);
            for (int x = 0; x < vijf; x++) {
                wrd.Bestelling.Add (new Product { id = 35, prijs = 50.00});

            }
        }

        private void button12_Click (object sender, EventArgs e) {
            int max = db.Voorraad (35);
            if (vijf == max) {
                return;
            } else if (vijf > max) {
                vijf = max;
            } else {
                vijf++;
            }
            label15.Text = vijf + "x";
            wrd.Bestelling.Add (new Product { id = 35, prijs = 50.00 });
        }

        private void panel6_Paint (object sender, PaintEventArgs e) {

        }
    }
}