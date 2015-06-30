namespace PDAapplicatie {
    partial class Hoofdmenu {
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
            this.btn_opnemen = new System.Windows.Forms.Button();
            this.btn_inzien = new System.Windows.Forms.Button();
            this.btn_teserveren = new System.Windows.Forms.Button();
            this.btn_wijzigen = new System.Windows.Forms.Button();
            this.btn_dagmenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btn_terug = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_opnemen
            // 
            this.btn_opnemen.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_opnemen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_opnemen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_opnemen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opnemen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_opnemen.Location = new System.Drawing.Point(-27, 96);
            this.btn_opnemen.Name = "btn_opnemen";
            this.btn_opnemen.Size = new System.Drawing.Size(862, 189);
            this.btn_opnemen.TabIndex = 0;
            this.btn_opnemen.Text = "Bestelling opnemen";
            this.btn_opnemen.UseVisualStyleBackColor = false;
            this.btn_opnemen.Click += new System.EventHandler(this.button1_Click);
            this.btn_opnemen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.btn_opnemen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // btn_inzien
            // 
            this.btn_inzien.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_inzien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inzien.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_inzien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inzien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_inzien.Location = new System.Drawing.Point(-27, 285);
            this.btn_inzien.Name = "btn_inzien";
            this.btn_inzien.Size = new System.Drawing.Size(862, 189);
            this.btn_inzien.TabIndex = 1;
            this.btn_inzien.Text = "Bestelling inzien";
            this.btn_inzien.UseVisualStyleBackColor = false;
            this.btn_inzien.Click += new System.EventHandler(this.button2_Click);
            this.btn_inzien.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.btn_inzien.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // btn_teserveren
            // 
            this.btn_teserveren.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_teserveren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_teserveren.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_teserveren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teserveren.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_teserveren.Location = new System.Drawing.Point(-27, 663);
            this.btn_teserveren.Name = "btn_teserveren";
            this.btn_teserveren.Size = new System.Drawing.Size(862, 189);
            this.btn_teserveren.TabIndex = 2;
            this.btn_teserveren.Text = "Te serveren bestellingen";
            this.btn_teserveren.UseVisualStyleBackColor = false;
            this.btn_teserveren.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.btn_teserveren.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // btn_wijzigen
            // 
            this.btn_wijzigen.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_wijzigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wijzigen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_wijzigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wijzigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_wijzigen.Location = new System.Drawing.Point(-27, 474);
            this.btn_wijzigen.Name = "btn_wijzigen";
            this.btn_wijzigen.Size = new System.Drawing.Size(862, 189);
            this.btn_wijzigen.TabIndex = 3;
            this.btn_wijzigen.Text = "Bestelling wijzigen";
            this.btn_wijzigen.UseVisualStyleBackColor = false;
            this.btn_wijzigen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.btn_wijzigen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // btn_dagmenu
            // 
            this.btn_dagmenu.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_dagmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dagmenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_dagmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dagmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_dagmenu.Location = new System.Drawing.Point(-27, 852);
            this.btn_dagmenu.Name = "btn_dagmenu";
            this.btn_dagmenu.Size = new System.Drawing.Size(862, 189);
            this.btn_dagmenu.TabIndex = 5;
            this.btn_dagmenu.Text = "Dagmenu";
            this.btn_dagmenu.UseVisualStyleBackColor = false;
            this.btn_dagmenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button6_MouseDown);
            this.btn_dagmenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button6_MouseUp);
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
            // Hoofdmenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 1204);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_terug);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dagmenu);
            this.Controls.Add(this.btn_wijzigen);
            this.Controls.Add(this.btn_teserveren);
            this.Controls.Add(this.btn_inzien);
            this.Controls.Add(this.btn_opnemen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 1280);
            this.MinimizeBox = false;
            this.Name = "Hoofdmenu";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_opnemen;
        private System.Windows.Forms.Button btn_inzien;
        private System.Windows.Forms.Button btn_teserveren;
        private System.Windows.Forms.Button btn_wijzigen;
        private System.Windows.Forms.Button btn_dagmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_terug;
        private System.Windows.Forms.Label label2;
    }
}

