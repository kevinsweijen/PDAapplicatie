using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.DesignerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDAapplicatie {
    public partial class Tafelselect: Form {
        Waarden wrd = new Waarden ();
        public string naam;
        public Tafelselect () {
            InitializeComponent ();
        }

        public Tafelselect(string naam) {
            InitializeComponent();
            label1.Text = naam;
            this.naam = naam;
        }

        private void timer1_Tick (object sender, EventArgs e) {
            DbHandeler db = new DbHandeler();
            label2.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute.ToString ("00");
            label3.Text = ( SystemInformation.PowerStatus.BatteryLifePercent * 100 ) + "%";
            Tafelbezet[] bezet = db.TafelsBezet();
            Tafelbezet[] gereserveerd = db.TafelsRes();
            double OwnTime =
                Convert.ToDouble(string.Format("{0}.{1}", DateTime.Now.Hour, DateTime.Now.Minute));
            for(int i = 0; i < bezet.Length; i++){
                    switch (i) {
                        case 0:
                            button2.BackColor = bezet[i].bezet ? Color.IndianRed : Color.DarkKhaki;
                            if (button2.BackColor == Color.IndianRed) break;
                            button2.BackColor = gereserveerd[i].bezet ? Color.DeepSkyBlue : Color.DarkKhaki;
                            break;
                        case 1:
                            button3.BackColor = bezet[i].bezet ? Color.IndianRed : Color.DarkKhaki;
                            if (button3.BackColor == Color.IndianRed) break;
                            button3.BackColor = gereserveerd[i].bezet ? Color.DeepSkyBlue : Color.DarkKhaki;
                            break;
                        case 2:
                            button4.BackColor = bezet[i].bezet ? Color.IndianRed : Color.DarkKhaki;
                            if (button4.BackColor == Color.IndianRed) break;
                            button4.BackColor = gereserveerd[i].bezet ? Color.DeepSkyBlue : Color.DarkKhaki;
                            break;
                        case 3:
                            button5.BackColor = bezet[i].bezet ? Color.IndianRed : Color.DarkKhaki;
                            if (button5.BackColor == Color.IndianRed) break;
                            button5.BackColor = gereserveerd[i].bezet ? Color.DeepSkyBlue : Color.DarkKhaki;
                            break;
                        case 4:
                            button6.BackColor = bezet[i].bezet ? Color.IndianRed : Color.DarkKhaki;
                            if (button6.BackColor == Color.IndianRed) break;
                            button6.BackColor = gereserveerd[i].bezet ? Color.DeepSkyBlue : Color.DarkKhaki;
                            break;
                        case 5:
                            button7.BackColor = bezet[i].bezet ? Color.IndianRed : Color.DarkKhaki;
                            if (button7.BackColor == Color.IndianRed) break;
                            button7.BackColor = gereserveerd[i].bezet ? Color.DeepSkyBlue : Color.DarkKhaki;
                            break;
                        case 6:
                            button8.BackColor = bezet[i].bezet ? Color.IndianRed : Color.DarkKhaki;
                            if (button8.BackColor == Color.IndianRed) break;
                            button8.BackColor = gereserveerd[i].bezet ? Color.DeepSkyBlue : Color.DarkKhaki;
                            break;
                        case 7:
                            button9.BackColor = bezet[i].bezet ? Color.IndianRed : Color.DarkKhaki;
                            if (button9.BackColor == Color.IndianRed) break;
                            button9.BackColor = gereserveerd[i].bezet ? Color.DeepSkyBlue : Color.DarkKhaki;
                            break;
                        case 8:
                            button10.BackColor = bezet[i].bezet ? Color.IndianRed : Color.DarkKhaki;
                            if (button10.BackColor == Color.IndianRed) break;
                            button10.BackColor = gereserveerd[i].bezet ? Color.DeepSkyBlue : Color.DarkKhaki;
                            break;
                        case 9:
                            button11.BackColor = bezet[i].bezet ? Color.IndianRed : Color.DarkKhaki;
                            if (button11.BackColor == Color.IndianRed) break;
                            button11.BackColor = gereserveerd[i].bezet ? Color.DeepSkyBlue : Color.DarkKhaki;
                            break;
                    }
                }
            }

        private void button2_Click (object sender, EventArgs e) {
            wrd.Tafelnummer = 1;
            var form = new Bestellen (wrd, naam);
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show ();
            this.Hide ();
        }

        private void button3_Click (object sender, EventArgs e) {
            wrd.Tafelnummer = 2;
            var form = new Bestellen (wrd, naam);
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show ();
            this.Hide ();
        }

        private void button4_Click (object sender, EventArgs e) {
            wrd.Tafelnummer = 3;
            var form = new Bestellen (wrd, naam);
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show ();
            this.Hide ();
        }

        private void button5_Click (object sender, EventArgs e) {
            wrd.Tafelnummer = 4;
            var form = new Bestellen (wrd, naam);
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show ();
            this.Hide ();
        }

        private void button6_Click (object sender, EventArgs e) {
            wrd.Tafelnummer = 5;
            var form = new Bestellen (wrd, naam);
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show ();
            this.Hide ();
        }

        private void button7_Click (object sender, EventArgs e) {
            wrd.Tafelnummer = 6;
            var form = new Bestellen (wrd, naam);
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show ();
            this.Hide ();
        }

        private void button8_Click (object sender, EventArgs e) {
            wrd.Tafelnummer = 7;
            var form = new Bestellen (wrd, naam);
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show ();
            this.Hide ();
        }

        private void button9_Click (object sender, EventArgs e) {
            wrd.Tafelnummer = 8;
            var form = new Bestellen (wrd, naam);
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show ();
            this.Hide ();
        }

        private void button10_Click (object sender, EventArgs e) {
            wrd.Tafelnummer = 9;
            var form = new Bestellen (wrd, naam);
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show ();
            this.Hide ();
        }

        private void button11_Click (object sender, EventArgs e) {
            wrd.Tafelnummer = 10;
            var form = new Bestellen (wrd, naam);
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show ();
            this.Hide ();
        }

        public void Tafelselect_Load (object sender, EventArgs e) {
        }

        private void button1_Click (object sender, EventArgs e) {
            var form = new Hoofdmenu (naam);
            form.Location = this.Location;
            form.StartPosition = this.StartPosition;
            form.Show ();
            this.Hide ();
        }
    }
}
