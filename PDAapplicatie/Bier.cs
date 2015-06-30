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
    public partial class Bier: Form {
        public string naam;
        private int een = 0;
        private int twee = 0;
        private int vier = 0;
        private int vijf = 0;
        private DbHandeler db;
        public Waarden wrd;
        public Bier () {
            InitializeComponent ();
        }

        public Bier (Waarden waarden, string naam) {
            InitializeComponent ();
            wrd = waarden;
            label1.Text = naam;
            this.naam = naam;
            db = new DbHandeler ();
        }

        private void button1_Click (object sender, EventArgs e) {
            if (een == 0) return;
            een--;
            lbl_hertog_count.Text = een + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 27);
            for (int x = 0; x < een; x++) {
                wrd.Bestelling.Add (new Product { id = 27, prijs = 3.00 });
            }
        }
        // Hoi ik ben een comment
        private void button1_MouseDown (object sender, MouseEventArgs e) {
            btn_hertog_min.BackColor = Color.BurlyWood;

        }

        private void button1_MouseUp (object sender, MouseEventArgs e) {
            btn_hertog_min.BackColor = Color.LemonChiffon;
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
            int max = db.Voorraad (27);
            if (een == max) {
                return;
            } else if (een > max) {
                een = max;
            } else {
                een++;
            }
            lbl_hertog_count.Text = een + "x";
            wrd.Bestelling.Add (new Product { id = 27, prijs = 3.00 });
        }

        private void button6_Click (object sender, EventArgs e) {
            int max = db.Voorraad (28);
            if (twee == max) {
                return;
            } else if (twee > max) {
                twee = max;
            } else {
                twee++;
            }
            lbl_duvel_count.Text = twee + "x";
            wrd.Bestelling.Add (new Product { id = 28, prijs = 4.50 });
        }

        private void button2_Click (object sender, EventArgs e) {
            if (twee == 0) return;
            twee--;
            lbl_duvel_count.Text = twee + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 28);
            for (int x = 0; x < twee; x++) {
                wrd.Bestelling.Add (new Product { id = 28, prijs = 4.50 });
            }
        }

        private void button5_Click (object sender, EventArgs e) {
            var form = new Dranken (wrd, naam) {
                Location = this.Location,
                StartPosition = this.StartPosition
            };
            form.Show ();
            this.Hide ();
        }

        private void button7_Click_1 (object sender, EventArgs e) {
            if (vier == 0) return;
            vier--;
            lbl_kriek_count.Text = vier + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 29);
            for (int x = 0; x < vier; x++) {
                wrd.Bestelling.Add (new Product { id = 29, prijs = 4.00 });

            }
        }

        private void button4_Click_1 (object sender, EventArgs e) {
            int max = db.Voorraad (29);
            if (vier == max) {
                return;
            } else if (vier > max) {
                vier = max;
            } else {
                vier++;
            }
            lbl_kriek_count.Text = vier + "x";
            wrd.Bestelling.Add (new Product { id = 29, prijs = 4.00 });
        }

        private void button13_Click (object sender, EventArgs e) {
            if (vijf == 0) return;
            vijf--;
            lbl_leffe_count.Text = vijf + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 30);
            for (int x = 0; x < vijf; x++) {
                wrd.Bestelling.Add (new Product { id = 30, prijs = 4.50 });

            }
        }

        private void button12_Click (object sender, EventArgs e) {
            int max = db.Voorraad (30);
            if (vijf == max) {
                return;
            } else if (vijf > max) {
                vijf = max;
            } else {
                vijf++;
            }
            lbl_leffe_count.Text = vijf + "x";
            wrd.Bestelling.Add (new Product { id = 30, prijs = 4.50 });
        }
    }
}