namespace PDAapplicatie {
    partial class Dranken {
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
            this.btn_fris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btn_terug = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_gedistilleerd = new System.Windows.Forms.Button();
            this.btn_koffieEnThee = new System.Windows.Forms.Button();
            this.btn_wijn = new System.Windows.Forms.Button();
            this.btn_bier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_fris
            // 
            this.btn_fris.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_fris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fris.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_fris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_fris.Location = new System.Drawing.Point(-27, 96);
            this.btn_fris.Name = "btn_fris";
            this.btn_fris.Size = new System.Drawing.Size(862, 189);
            this.btn_fris.TabIndex = 0;
            this.btn_fris.Text = "Fris";
            this.btn_fris.UseVisualStyleBackColor = false;
            this.btn_fris.Click += new System.EventHandler(this.button1_Click);
            this.btn_fris.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.btn_fris.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
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
            // btn_terug
            // 
            this.btn_terug.AutoSize = true;
            this.btn_terug.BackColor = System.Drawing.Color.Crimson;
            this.btn_terug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_terug.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_terug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_terug.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_terug.ForeColor = System.Drawing.Color.White;
            this.btn_terug.Location = new System.Drawing.Point(-27, 1041);
            this.btn_terug.Name = "btn_terug";
            this.btn_terug.Size = new System.Drawing.Size(862, 189);
            this.btn_terug.TabIndex = 9;
            this.btn_terug.Text = "Terug";
            this.btn_terug.UseVisualStyleBackColor = false;
            this.btn_terug.Click += new System.EventHandler(this.button5_Click);
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
            // btn_gedistilleerd
            // 
            this.btn_gedistilleerd.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_gedistilleerd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gedistilleerd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_gedistilleerd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gedistilleerd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_gedistilleerd.Location = new System.Drawing.Point(-27, 663);
            this.btn_gedistilleerd.Name = "btn_gedistilleerd";
            this.btn_gedistilleerd.Size = new System.Drawing.Size(862, 189);
            this.btn_gedistilleerd.TabIndex = 1;
            this.btn_gedistilleerd.Text = "Gedistilleerd";
            this.btn_gedistilleerd.UseVisualStyleBackColor = false;
            this.btn_gedistilleerd.Click += new System.EventHandler(this.button2_Click);
            this.btn_gedistilleerd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.btn_gedistilleerd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // btn_koffieEnThee
            // 
            this.btn_koffieEnThee.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_koffieEnThee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_koffieEnThee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_koffieEnThee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_koffieEnThee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_koffieEnThee.Location = new System.Drawing.Point(-27, 852);
            this.btn_koffieEnThee.Name = "btn_koffieEnThee";
            this.btn_koffieEnThee.Size = new System.Drawing.Size(862, 189);
            this.btn_koffieEnThee.TabIndex = 3;
            this.btn_koffieEnThee.Text = "Koffie en Thee";
            this.btn_koffieEnThee.UseVisualStyleBackColor = false;
            this.btn_koffieEnThee.Click += new System.EventHandler(this.button4_Click);
            this.btn_koffieEnThee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.btn_koffieEnThee.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // btn_wijn
            // 
            this.btn_wijn.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_wijn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wijn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_wijn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wijn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_wijn.Location = new System.Drawing.Point(-31, 474);
            this.btn_wijn.Name = "btn_wijn";
            this.btn_wijn.Size = new System.Drawing.Size(862, 189);
            this.btn_wijn.TabIndex = 11;
            this.btn_wijn.Text = "Wijn";
            this.btn_wijn.UseVisualStyleBackColor = false;
            this.btn_wijn.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_bier
            // 
            this.btn_bier.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_bier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_bier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_bier.Location = new System.Drawing.Point(-31, 285);
            this.btn_bier.Name = "btn_bier";
            this.btn_bier.Size = new System.Drawing.Size(862, 189);
            this.btn_bier.TabIndex = 12;
            this.btn_bier.Text = "Bier";
            this.btn_bier.UseVisualStyleBackColor = false;
            this.btn_bier.Click += new System.EventHandler(this.button6_Click);
            // 
            // Dranken
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 1204);
            this.Controls.Add(this.btn_bier);
            this.Controls.Add(this.btn_wijn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_terug);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_koffieEnThee);
            this.Controls.Add(this.btn_gedistilleerd);
            this.Controls.Add(this.btn_fris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 1280);
            this.MinimizeBox = false;
            this.Name = "Dranken";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_terug;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_gedistilleerd;
        private System.Windows.Forms.Button btn_koffieEnThee;
        private System.Windows.Forms.Button btn_wijn;
        private System.Windows.Forms.Button btn_bier;
    }
}
