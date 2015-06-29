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
    public partial class Fris: Form {
        public string naam;
        private int een = 0;
        private int twee = 0;
        private int drie = 0;
        private int vier = 0;
        private int vijf = 0;
        private int zes = 0;
        private DbHandeler db;
        public Waarden wrd;
        public Fris () {
            InitializeComponent ();
        }

        public Fris (Waarden waarden, string naam) {
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
            wrd.Bestelling.RemoveAll (product => product.id == 21);
            for (int x = 0; x < een; x++) {
                wrd.Bestelling.Add (new Product { id = 21, prijs = 2.50 });
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
            wrd.Bestelling.Add (new Product { id = 21, prijs = 2.50 });
        }

        private void button6_Click (object sender, EventArgs e) {
            int max = db.Voorraad (22);
            if (twee == max) {
                return;
            } else if (twee > max) {
                twee = max;
            } else {
                twee++;
            }
            label8.Text = twee + "x";
            wrd.Bestelling.Add (new Product { id = 22, prijs = 2.50 });
        }

        private void button2_Click (object sender, EventArgs e) {
            if (twee == 0) return;
            twee--;
            label8.Text = twee + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 22);
            for (int x = 0; x < twee; x++) {
                wrd.Bestelling.Add (new Product { id = 22, prijs = 2.50 });
            }
        }

        private void button5_Click (object sender, EventArgs e) {
            var form = new Dranken(wrd, naam) {
                Location = this.Location,
                StartPosition = this.StartPosition
            };
            form.Show ();
            this.Hide ();
        }

        private void button9_Click(object sender, EventArgs e) {
            if (drie == 0) return;
            drie--;
            label11.Text = drie + "x";
            wrd.Bestelling.RemoveAll(product => product.id == 23);
            for (int x = 0; x < drie; x++) {
                wrd.Bestelling.Add(new Product {id = 23, prijs = 2.50});

            }
        }

        private void button8_Click (object sender, EventArgs e) {
            int max = db.Voorraad (23);
            if (drie == max) {
                return;
            } else if (drie > max) {
                drie = max;
            } else {
                drie++;
            }
            label11.Text = drie + "x";
            wrd.Bestelling.Add (new Product { id = 23, prijs = 2.50 });
        }

        private void button7_Click_1 (object sender, EventArgs e) {
            if (vier == 0) return;
            vier--;
            label6.Text = vier + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 24);
            for (int x = 0; x < vier; x++) {
                wrd.Bestelling.Add (new Product { id = 24, prijs = 2.50 });

            }
        }

        private void button4_Click_1 (object sender, EventArgs e) {
            int max = db.Voorraad (24);
            if (vier == max) {
                return;
            } else if (vier > max) {
                vier = max;
            } else {
                vier++;
            }
            label6.Text = vier + "x";
            wrd.Bestelling.Add (new Product { id = 24, prijs = 2.50 });
        }

        private void button13_Click (object sender, EventArgs e) {
            if (vijf == 0) return;
            vijf--;
            label15.Text = vijf + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 25);
            for (int x = 0; x < vijf; x++) {
                wrd.Bestelling.Add (new Product { id = 25, prijs = 2.50 });

            }
        }

        private void button12_Click (object sender, EventArgs e) {
            int max = db.Voorraad (25);
            if (vijf == max) {
                return;
            } else if (vijf > max) {
                vijf = max;
            } else {
                vijf++;
            }
            label15.Text = vijf + "x";
            wrd.Bestelling.Add (new Product { id = 25, prijs = 2.50 });
        }

        private void button11_Click (object sender, EventArgs e) {
            if (zes == 0) return;
            zes--;
            label12.Text = zes + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 26);
            for (int x = 0; x < zes; x++) {
                wrd.Bestelling.Add (new Product { id = 26, prijs = 2.50 });

            }
        }

        private void button10_Click (object sender, EventArgs e) {
            int max = db.Voorraad (26);
            if (zes == max) {
                return;
            } else if (zes > max) {
                zes = max;
            } else {
                zes++;
            }
            label12.Text = zes + "x";
            wrd.Bestelling.Add (new Product { id = 26, prijs = 2.50 });
        }
    }
}