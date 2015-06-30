namespace PDAapplicatie {
    partial class DinerTussen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.components = new System.ComponentModel.Container();
            this.btn_vissoep_min = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_terug = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_vissoep_plus = new System.Windows.Forms.Button();
            this.btn_consomme_min = new System.Windows.Forms.Button();
            this.btn_consomme_plus = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_vissoep = new System.Windows.Forms.Label();
            this.lbl_vissoep_count = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_consomme_count = new System.Windows.Forms.Label();
            this.lbl_consomme = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_vissoep_min
            // 
            this.btn_vissoep_min.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_vissoep_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vissoep_min.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_vissoep_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vissoep_min.Font = new System.Drawing.Font("MS Reference Sans Serif", 128.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vissoep_min.Location = new System.Drawing.Point(0, 97);
            this.btn_vissoep_min.Name = "btn_vissoep_min";
            this.btn_vissoep_min.Size = new System.Drawing.Size(315, 472);
            this.btn_vissoep_min.TabIndex = 0;
            this.btn_vissoep_min.Text = "-";
            this.btn_vissoep_min.UseVisualStyleBackColor = false;
            this.btn_vissoep_min.Click += new System.EventHandler(this.button1_Click);
            this.btn_vissoep_min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.btn_vissoep_min.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(281, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 26);
            this.label3.TabIndex = 8;
            // 
            // lbl_terug
            // 
            this.lbl_terug.AutoSize = true;
            this.lbl_terug.BackColor = System.Drawing.Color.Crimson;
            this.lbl_terug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_terug.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.lbl_terug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_terug.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_terug.ForeColor = System.Drawing.Color.White;
            this.lbl_terug.Location = new System.Drawing.Point(-27, 1041);
            this.lbl_terug.Name = "lbl_terug";
            this.lbl_terug.Size = new System.Drawing.Size(862, 189);
            this.lbl_terug.TabIndex = 9;
            this.lbl_terug.Text = "Terug";
            this.lbl_terug.UseVisualStyleBackColor = false;
            this.lbl_terug.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(687, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 10;
            // 
            // btn_vissoep_plus
            // 
            this.btn_vissoep_plus.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_vissoep_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vissoep_plus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_vissoep_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vissoep_plus.Font = new System.Drawing.Font("MS Reference Sans Serif", 128.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vissoep_plus.Location = new System.Drawing.Point(485, 97);
            this.btn_vissoep_plus.Name = "btn_vissoep_plus";
            this.btn_vissoep_plus.Size = new System.Drawing.Size(315, 472);
            this.btn_vissoep_plus.TabIndex = 11;
            this.btn_vissoep_plus.Text = "+";
            this.btn_vissoep_plus.UseVisualStyleBackColor = false;
            this.btn_vissoep_plus.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_consomme_min
            // 
            this.btn_consomme_min.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_consomme_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consomme_min.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_consomme_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consomme_min.Font = new System.Drawing.Font("MS Reference Sans Serif", 128.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consomme_min.Location = new System.Drawing.Point(0, 569);
            this.btn_consomme_min.Name = "btn_consomme_min";
            this.btn_consomme_min.Size = new System.Drawing.Size(315, 472);
            this.btn_consomme_min.TabIndex = 12;
            this.btn_consomme_min.Text = "-";
            this.btn_consomme_min.UseVisualStyleBackColor = false;
            this.btn_consomme_min.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_consomme_plus
            // 
            this.btn_consomme_plus.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_consomme_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consomme_plus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_consomme_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consomme_plus.Font = new System.Drawing.Font("MS Reference Sans Serif", 128.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consomme_plus.Location = new System.Drawing.Point(485, 569);
            this.btn_consomme_plus.Name = "btn_consomme_plus";
            this.btn_consomme_plus.Size = new System.Drawing.Size(315, 472);
            this.btn_consomme_plus.TabIndex = 13;
            this.btn_consomme_plus.Text = "+";
            this.btn_consomme_plus.UseVisualStyleBackColor = false;
            this.btn_consomme_plus.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_vissoep);
            this.panel2.Controls.Add(this.lbl_vissoep_count);
            this.panel2.Location = new System.Drawing.Point(315, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 472);
            this.panel2.TabIndex = 17;
            // 
            // lbl_vissoep
            // 
            this.lbl_vissoep.AutoSize = true;
            this.lbl_vissoep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_vissoep.Location = new System.Drawing.Point(3, 346);
            this.lbl_vissoep.Name = "lbl_vissoep";
            this.lbl_vissoep.Size = new System.Drawing.Size(159, 58);
            this.lbl_vissoep.TabIndex = 1;
            this.lbl_vissoep.Text = "Provencaalse\r\nvissoep";
            // 
            // lbl_vissoep_count
            // 
            this.lbl_vissoep_count.AutoSize = true;
            this.lbl_vissoep_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_vissoep_count.Location = new System.Drawing.Point(56, 98);
            this.lbl_vissoep_count.Name = "lbl_vissoep_count";
            this.lbl_vissoep_count.Size = new System.Drawing.Size(50, 37);
            this.lbl_vissoep_count.TabIndex = 0;
            this.lbl_vissoep_count.Text = "0x";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_consomme_count);
            this.panel1.Controls.Add(this.lbl_consomme);
            this.panel1.Location = new System.Drawing.Point(315, 569);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 472);
            this.panel1.TabIndex = 18;
            // 
            // lbl_consomme_count
            // 
            this.lbl_consomme_count.AutoSize = true;
            this.lbl_consomme_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_consomme_count.Location = new System.Drawing.Point(56, 112);
            this.lbl_consomme_count.Name = "lbl_consomme_count";
            this.lbl_consomme_count.Size = new System.Drawing.Size(50, 37);
            this.lbl_consomme_count.TabIndex = 3;
            this.lbl_consomme_count.Text = "0x";
            // 
            // lbl_consomme
            // 
            this.lbl_consomme.AutoSize = true;
            this.lbl_consomme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_consomme.Location = new System.Drawing.Point(19, 345);
            this.lbl_consomme.Name = "lbl_consomme";
            this.lbl_consomme.Size = new System.Drawing.Size(125, 26);
            this.lbl_consomme.TabIndex = 3;
            this.lbl_consomme.Text = "Consommé";
            // 
            // DinerTussen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 1204);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_consomme_plus);
            this.Controls.Add(this.btn_consomme_min);
            this.Controls.Add(this.btn_vissoep_plus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_terug);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_vissoep_min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 1280);
            this.MinimizeBox = false;
            this.Name = "DinerTussen";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_vissoep_min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button lbl_terug;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_vissoep_plus;
        private System.Windows.Forms.Button btn_consomme_min;
        private System.Windows.Forms.Button btn_consomme_plus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_vissoep;
        private System.Windows.Forms.Label lbl_vissoep_count;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_consomme_count;
        private System.Windows.Forms.Label lbl_consomme;
    }
}
