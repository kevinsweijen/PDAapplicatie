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
    public partial class LunchVoor: Form {
        public string naam;
        private int top;
        private int mid;
        private int bot;
        private DbHandeler db;
        public Waarden wrd;
        public LunchVoor () {
            InitializeComponent ();
        }

        public LunchVoor (Waarden waarden, string naam) {
            InitializeComponent ();
            wrd = waarden;
            label1.Text = naam;
            this.naam = naam;
            db = new DbHandeler();
        }

        private void button1_Click (object sender, EventArgs e) {
            if (top == 0) return;
            top--;
            label4.Text = top + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 1);
            for (int x = 0; x < top; x++) {
                wrd.Bestelling.Add (new Product { id = 1, prijs = 7.00 });
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
            foreach (Product p in wrd.Bestelling) {
                if (p.id == 1) {
                    top++;
                } else if (p.id == 2) {
                    mid++;
                } else if (p.id == 3) {
                    bot++;
                }
            }
            label4.Text = top + "x";
            label8.Text = mid + "x";
            label6.Text = bot + "x";
        }

        private void button3_Click (object sender, EventArgs e) {
            int max = db.Voorraad (1);
            if (top == max) {
                return;
            } else if (top > max) {
                top = max;
            } else {
                top++;
            }
            label4.Text = top + "x";
            wrd.Bestelling.Add (new Product { id = 1, prijs = 7.00 });
        }

        private void button6_Click (object sender, EventArgs e) {
            int max = db.Voorraad (2);
            if (mid == max) {
                return;
            } else if (mid > max) {
                mid = max;
            } else {
                mid++;
            }
            label8.Text = mid + "x";
            wrd.Bestelling.Add (new Product { id = 2, prijs = 8.50 });
        }

        private void button2_Click (object sender, EventArgs e) {
            if (mid == 0) return;
            mid--;
            label8.Text = mid + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 2);
            for (int x = 0; x < mid; x++) {
                wrd.Bestelling.Add (new Product { id = 2, prijs = 8.50 });
            }
        }

        private void button7_Click (object sender, EventArgs e) {
            if (bot == 0) return;
            bot--;
            label6.Text = bot + "x";
            wrd.Bestelling.RemoveAll (product => product.id == 3);
            for (int x = 0; x < mid; x++) {
                wrd.Bestelling.Add (new Product { id = 3, prijs = 6.50 });
            }
        }

        private void button4_Click (object sender, EventArgs e) {
            int max = db.Voorraad (3);
            if (bot == max) {
                return;
            } else if (bot > max) {
                bot = max;
            } else {
                 bot++;
            }
            label6.Text = bot + "x";
            wrd.Bestelling.Add (new Product { id = 3, prijs = 6.50 });
        }

        private void button5_Click (object sender, EventArgs e) {
            var form = new LunchBestellen (wrd, naam) {
                Location = this.Location,
                StartPosition = this.StartPosition
            };
            form.Show ();
            this.Hide ();
        }
    }
}