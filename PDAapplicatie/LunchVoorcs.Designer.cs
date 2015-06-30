namespace PDAapplicatie {
    partial class LunchVoor  {
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
            this.btn_steak_min = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_steak_plus = new System.Windows.Forms.Button();
            this.lbl_fazant_min = new System.Windows.Forms.Button();
            this.lbl_fazant_plus = new System.Windows.Forms.Button();
            this.btn_vis_plus = new System.Windows.Forms.Button();
            this.btn_vis_min = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_steak = new System.Windows.Forms.Label();
            this.lbl_steak_count = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_fazant_count = new System.Windows.Forms.Label();
            this.lbl_fazant = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_vis_count = new System.Windows.Forms.Label();
            this.lbl_vis = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_steak_min
            // 
            this.btn_steak_min.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_steak_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_steak_min.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_steak_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_steak_min.Font = new System.Drawing.Font("MS Reference Sans Serif", 128.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_steak_min.Location = new System.Drawing.Point(0, 96);
            this.btn_steak_min.Name = "btn_steak_min";
            this.btn_steak_min.Size = new System.Drawing.Size(315, 315);
            this.btn_steak_min.TabIndex = 0;
            this.btn_steak_min.Text = "-";
            this.btn_steak_min.UseVisualStyleBackColor = false;
            this.btn_steak_min.Click += new System.EventHandler(this.button1_Click);
            this.btn_steak_min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.btn_steak_min.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
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
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(-27, 1041);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(862, 189);
            this.button5.TabIndex = 9;
            this.button5.Text = "Terug";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            // btn_steak_plus
            // 
            this.btn_steak_plus.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_steak_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_steak_plus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_steak_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_steak_plus.Font = new System.Drawing.Font("MS Reference Sans Serif", 128.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_steak_plus.Location = new System.Drawing.Point(485, 96);
            this.btn_steak_plus.Name = "btn_steak_plus";
            this.btn_steak_plus.Size = new System.Drawing.Size(315, 315);
            this.btn_steak_plus.TabIndex = 11;
            this.btn_steak_plus.Text = "+";
            this.btn_steak_plus.UseVisualStyleBackColor = false;
            this.btn_steak_plus.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_fazant_min
            // 
            this.lbl_fazant_min.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbl_fazant_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_fazant_min.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.lbl_fazant_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_fazant_min.Font = new System.Drawing.Font("MS Reference Sans Serif", 128.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fazant_min.Location = new System.Drawing.Point(0, 411);
            this.lbl_fazant_min.Name = "lbl_fazant_min";
            this.lbl_fazant_min.Size = new System.Drawing.Size(315, 315);
            this.lbl_fazant_min.TabIndex = 12;
            this.lbl_fazant_min.Text = "-";
            this.lbl_fazant_min.UseVisualStyleBackColor = false;
            this.lbl_fazant_min.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_fazant_plus
            // 
            this.lbl_fazant_plus.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbl_fazant_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_fazant_plus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.lbl_fazant_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_fazant_plus.Font = new System.Drawing.Font("MS Reference Sans Serif", 128.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fazant_plus.Location = new System.Drawing.Point(485, 411);
            this.lbl_fazant_plus.Name = "lbl_fazant_plus";
            this.lbl_fazant_plus.Size = new System.Drawing.Size(315, 315);
            this.lbl_fazant_plus.TabIndex = 13;
            this.lbl_fazant_plus.Text = "+";
            this.lbl_fazant_plus.UseVisualStyleBackColor = false;
            this.lbl_fazant_plus.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_vis_plus
            // 
            this.btn_vis_plus.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_vis_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vis_plus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_vis_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vis_plus.Font = new System.Drawing.Font("MS Reference Sans Serif", 128.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vis_plus.Location = new System.Drawing.Point(485, 726);
            this.btn_vis_plus.Name = "btn_vis_plus";
            this.btn_vis_plus.Size = new System.Drawing.Size(315, 315);
            this.btn_vis_plus.TabIndex = 14;
            this.btn_vis_plus.Text = "+";
            this.btn_vis_plus.UseVisualStyleBackColor = false;
            this.btn_vis_plus.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_vis_min
            // 
            this.btn_vis_min.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_vis_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vis_min.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_vis_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vis_min.Font = new System.Drawing.Font("MS Reference Sans Serif", 128.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vis_min.Location = new System.Drawing.Point(0, 726);
            this.btn_vis_min.Name = "btn_vis_min";
            this.btn_vis_min.Size = new System.Drawing.Size(315, 315);
            this.btn_vis_min.TabIndex = 15;
            this.btn_vis_min.Text = "-";
            this.btn_vis_min.UseVisualStyleBackColor = false;
            this.btn_vis_min.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_steak);
            this.panel2.Controls.Add(this.lbl_steak_count);
            this.panel2.Location = new System.Drawing.Point(315, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 315);
            this.panel2.TabIndex = 17;
            // 
            // lbl_steak
            // 
            this.lbl_steak.AutoSize = true;
            this.lbl_steak.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_steak.Location = new System.Drawing.Point(6, 201);
            this.lbl_steak.Name = "lbl_steak";
            this.lbl_steak.Size = new System.Drawing.Size(157, 29);
            this.lbl_steak.TabIndex = 1;
            this.lbl_steak.Text = "Steak Tartaar";
            // 
            // lbl_steak_count
            // 
            this.lbl_steak_count.AutoSize = true;
            this.lbl_steak_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_steak_count.Location = new System.Drawing.Point(56, 52);
            this.lbl_steak_count.Name = "lbl_steak_count";
            this.lbl_steak_count.Size = new System.Drawing.Size(50, 37);
            this.lbl_steak_count.TabIndex = 0;
            this.lbl_steak_count.Text = "0x";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_fazant_count);
            this.panel1.Controls.Add(this.lbl_fazant);
            this.panel1.Location = new System.Drawing.Point(315, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 315);
            this.panel1.TabIndex = 18;
            // 
            // lbl_fazant_count
            // 
            this.lbl_fazant_count.AutoSize = true;
            this.lbl_fazant_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_fazant_count.Location = new System.Drawing.Point(59, 65);
            this.lbl_fazant_count.Name = "lbl_fazant_count";
            this.lbl_fazant_count.Size = new System.Drawing.Size(50, 37);
            this.lbl_fazant_count.TabIndex = 3;
            this.lbl_fazant_count.Text = "0x";
            // 
            // lbl_fazant
            // 
            this.lbl_fazant.AutoSize = true;
            this.lbl_fazant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_fazant.Location = new System.Drawing.Point(6, 204);
            this.lbl_fazant.Name = "lbl_fazant";
            this.lbl_fazant.Size = new System.Drawing.Size(144, 26);
            this.lbl_fazant.TabIndex = 3;
            this.lbl_fazant.Text = "Fazantenpaté";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BurlyWood;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_vis_count);
            this.panel3.Controls.Add(this.lbl_vis);
            this.panel3.Location = new System.Drawing.Point(315, 726);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 315);
            this.panel3.TabIndex = 19;
            // 
            // lbl_vis_count
            // 
            this.lbl_vis_count.AutoSize = true;
            this.lbl_vis_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_vis_count.Location = new System.Drawing.Point(56, 42);
            this.lbl_vis_count.Name = "lbl_vis_count";
            this.lbl_vis_count.Size = new System.Drawing.Size(50, 37);
            this.lbl_vis_count.TabIndex = 2;
            this.lbl_vis_count.Text = "0x";
            // 
            // lbl_vis
            // 
            this.lbl_vis.AutoSize = true;
            this.lbl_vis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_vis.Location = new System.Drawing.Point(6, 204);
            this.lbl_vis.Name = "lbl_vis";
            this.lbl_vis.Size = new System.Drawing.Size(144, 52);
            this.lbl_vis.TabIndex = 5;
            this.lbl_vis.Text = "Provencaalse\r\nvissoep";
            // 
            // LunchVoor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 1204);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_vis_min);
            this.Controls.Add(this.btn_vis_plus);
            this.Controls.Add(this.lbl_fazant_plus);
            this.Controls.Add(this.lbl_fazant_min);
            this.Controls.Add(this.btn_steak_plus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_steak_min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 1280);
            this.MinimizeBox = false;
            this.Name = "LunchVoor";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_steak_min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_steak_plus;
        private System.Windows.Forms.Button lbl_fazant_min;
        private System.Windows.Forms.Button lbl_fazant_plus;
        private System.Windows.Forms.Button btn_vis_plus;
        private System.Windows.Forms.Button btn_vis_min;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_steak;
        private System.Windows.Forms.Label lbl_steak_count;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_fazant_count;
        private System.Windows.Forms.Label lbl_fazant;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_vis_count;
        private System.Windows.Forms.Label lbl_vis;
    }
}
