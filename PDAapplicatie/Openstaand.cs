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
    public partial class Openstaand: Form {
        Waarden wrd = new Waarden ();
        public string naam;
        public Openstaand () {
            InitializeComponent ();
        }

        public Openstaand (string naam) {
            InitializeComponent ();
            label1.Text = naam;
            this.naam = naam;
        }

        private void timer1_Tick (object sender, EventArgs e) {
            DbHandeler db = new DbHandeler ();
            label2.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute.ToString ("00");
            label3.Text = ( SystemInformation.PowerStatus.BatteryLifePercent * 100 ) + "%";

            Tafelbezet[] klaar = db.TafelsKlaar();
            Button[] buttons = {btn_tafel1, btn_tafel2, btn_tafel3, btn_tafel4, btn_tafel5, btn_tafel6, btn_tafel7, btn_tafel8, btn_tafel9, btn_tafel10};

            for (int i = 0; i < klaar.Length; i++)
            {
                setButtonColor(buttons[i], i, klaar);   
            }
        }

        private void setButtonColor(Button button, int klaarCount, Tafelbezet[] klaar){
            button.BackColor = klaar[klaarCount].bezet ? Color.IndianRed : Color.DarkKhaki;
        }

        private void button2_Click (object sender, EventArgs e) {

        }

        private void button3_Click (object sender, EventArgs e) {
        }

        private void button4_Click (object sender, EventArgs e) {
        }

        private void button5_Click (object sender, EventArgs e) {
        }

        private void button6_Click (object sender, EventArgs e) {
        }

        private void button7_Click (object sender, EventArgs e) {
        }

        private void button8_Click (object sender, EventArgs e) {
        }

        private void button9_Click (object sender, EventArgs e) {
        }

        private void button10_Click (object sender, EventArgs e) {
        }

        private void button11_Click (object sender, EventArgs e) {
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
