namespace PDAapplicatie {
    partial class Login  {
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btn_terug = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.txtbox_pincode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(321, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naam ingelogd";
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
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 26);
            this.label3.TabIndex = 8;
            // 
            // btn_terug
            // 
            this.btn_terug.BackColor = System.Drawing.Color.Crimson;
            this.btn_terug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_terug.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_terug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_terug.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_terug.ForeColor = System.Drawing.Color.White;
            this.btn_terug.Location = new System.Drawing.Point(-27, 1042);
            this.btn_terug.Name = "btn_terug";
            this.btn_terug.Size = new System.Drawing.Size(862, 242);
            this.btn_terug.TabIndex = 9;
            this.btn_terug.Text = "Afsluiten";
            this.btn_terug.UseVisualStyleBackColor = false;
            this.btn_terug.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(687, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_enter);
            this.panel1.Controls.Add(this.btn_4);
            this.panel1.Controls.Add(this.btn_6);
            this.panel1.Controls.Add(this.btn_9);
            this.panel1.Controls.Add(this.btn_7);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Controls.Add(this.btn_0);
            this.panel1.Controls.Add(this.btn_5);
            this.panel1.Controls.Add(this.btn_8);
            this.panel1.Controls.Add(this.btn_2);
            this.panel1.Controls.Add(this.btn_3);
            this.panel1.Controls.Add(this.btn_1);
            this.panel1.Controls.Add(this.txtbox_pincode);
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 930);
            this.panel1.TabIndex = 12;
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.btn_enter.Location = new System.Drawing.Point(542, 760);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(258, 168);
            this.btn_enter.TabIndex = 14;
            this.btn_enter.Text = "ENT";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.btn_4.Location = new System.Drawing.Point(-2, 430);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(258, 168);
            this.btn_4.TabIndex = 13;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.button13_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.btn_6.Location = new System.Drawing.Point(542, 430);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(258, 168);
            this.btn_6.TabIndex = 12;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.button12_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.btn_9.Location = new System.Drawing.Point(542, 594);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(258, 168);
            this.btn_9.TabIndex = 11;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.button11_Click);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.btn_7.Location = new System.Drawing.Point(-2, 594);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(258, 168);
            this.btn_7.TabIndex = 10;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.btn_del.Location = new System.Drawing.Point(-2, 760);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(258, 168);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "DEL";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.btn_0.Location = new System.Drawing.Point(256, 760);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(286, 168);
            this.btn_0.TabIndex = 7;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.btn_5.Location = new System.Drawing.Point(256, 430);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(286, 168);
            this.btn_5.TabIndex = 5;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.btn_8.Location = new System.Drawing.Point(256, 594);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(286, 168);
            this.btn_8.TabIndex = 4;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.btn_2.Location = new System.Drawing.Point(256, 265);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(286, 168);
            this.btn_2.TabIndex = 3;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.btn_3.Location = new System.Drawing.Point(542, 265);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(258, 168);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.btn_1.Location = new System.Drawing.Point(-2, 265);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(258, 168);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbox_pincode
            // 
            this.txtbox_pincode.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.txtbox_pincode.Location = new System.Drawing.Point(176, 58);
            this.txtbox_pincode.Name = "txtbox_pincode";
            this.txtbox_pincode.ReadOnly = true;
            this.txtbox_pincode.Size = new System.Drawing.Size(450, 116);
            this.txtbox_pincode.TabIndex = 0;
            this.txtbox_pincode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 1204);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_terug);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 1280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 0);
            this.Name = "Login";
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_terug;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.TextBox txtbox_pincode;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_enter;
    }
}