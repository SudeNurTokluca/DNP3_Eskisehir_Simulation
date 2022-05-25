namespace DNP3_Simulation
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btn_E_1 = new System.Windows.Forms.Button();
            this.btn_N_1 = new System.Windows.Forms.Button();
            this.btn_WW_1 = new System.Windows.Forms.Button();
            this.btn_WD_1 = new System.Windows.Forms.Button();
            this.btn_WW_2 = new System.Windows.Forms.Button();
            this.btn_WW_3 = new System.Windows.Forms.Button();
            this.btn_WW_4 = new System.Windows.Forms.Button();
            this.btn_WW_5 = new System.Windows.Forms.Button();
            this.btn_WW_6 = new System.Windows.Forms.Button();
            this.btn_WW_7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DNP3_Simulation.Properties.Resources.Ekran_görüntüsü_2022_05_24_213923;
            this.pictureBox1.Location = new System.Drawing.Point(2, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1129, 593);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1261, 201);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ELECTRIC";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1261, 246);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Natural Gas";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(1261, 294);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(111, 21);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Waste Water";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(1261, 338);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(142, 21);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Water Distribution";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // btn_E_1
            // 
            this.btn_E_1.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_E_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_E_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_E_1.Location = new System.Drawing.Point(1218, 385);
            this.btn_E_1.Name = "btn_E_1";
            this.btn_E_1.Size = new System.Drawing.Size(20, 20);
            this.btn_E_1.TabIndex = 5;
            this.btn_E_1.Text = "button1";
            this.btn_E_1.UseVisualStyleBackColor = false;
            this.btn_E_1.Visible = false;
            // 
            // btn_N_1
            // 
            this.btn_N_1.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_N_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_N_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_N_1.Location = new System.Drawing.Point(1244, 385);
            this.btn_N_1.Name = "btn_N_1";
            this.btn_N_1.Size = new System.Drawing.Size(20, 20);
            this.btn_N_1.TabIndex = 6;
            this.btn_N_1.Text = "button1";
            this.btn_N_1.UseVisualStyleBackColor = false;
            this.btn_N_1.Visible = false;
            // 
            // btn_WW_1
            // 
            this.btn_WW_1.BackColor = System.Drawing.Color.Cyan;
            this.btn_WW_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_WW_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_WW_1.Location = new System.Drawing.Point(898, 202);
            this.btn_WW_1.Name = "btn_WW_1";
            this.btn_WW_1.Size = new System.Drawing.Size(20, 20);
            this.btn_WW_1.TabIndex = 7;
            this.btn_WW_1.UseVisualStyleBackColor = false;
            this.btn_WW_1.Visible = false;
            this.btn_WW_1.Click += new System.EventHandler(this.btn_WW_1_Click);
            // 
            // btn_WD_1
            // 
            this.btn_WD_1.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_WD_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_WD_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_WD_1.Location = new System.Drawing.Point(1270, 385);
            this.btn_WD_1.Name = "btn_WD_1";
            this.btn_WD_1.Size = new System.Drawing.Size(20, 20);
            this.btn_WD_1.TabIndex = 8;
            this.btn_WD_1.Text = "button1";
            this.btn_WD_1.UseVisualStyleBackColor = false;
            this.btn_WD_1.Visible = false;
            // 
            // btn_WW_2
            // 
            this.btn_WW_2.BackColor = System.Drawing.Color.Cyan;
            this.btn_WW_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_WW_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_WW_2.Location = new System.Drawing.Point(771, 338);
            this.btn_WW_2.Name = "btn_WW_2";
            this.btn_WW_2.Size = new System.Drawing.Size(20, 20);
            this.btn_WW_2.TabIndex = 9;
            this.btn_WW_2.UseVisualStyleBackColor = false;
            this.btn_WW_2.Visible = false;
            this.btn_WW_2.Click += new System.EventHandler(this.btn_WW_2_Click);
            // 
            // btn_WW_3
            // 
            this.btn_WW_3.BackColor = System.Drawing.Color.Cyan;
            this.btn_WW_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_WW_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_WW_3.Location = new System.Drawing.Point(429, 232);
            this.btn_WW_3.Name = "btn_WW_3";
            this.btn_WW_3.Size = new System.Drawing.Size(20, 20);
            this.btn_WW_3.TabIndex = 10;
            this.btn_WW_3.UseVisualStyleBackColor = false;
            this.btn_WW_3.Visible = false;
            this.btn_WW_3.Click += new System.EventHandler(this.btn_WW_3_Click);
            // 
            // btn_WW_4
            // 
            this.btn_WW_4.BackColor = System.Drawing.Color.Cyan;
            this.btn_WW_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_WW_4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_WW_4.Location = new System.Drawing.Point(482, 371);
            this.btn_WW_4.Name = "btn_WW_4";
            this.btn_WW_4.Size = new System.Drawing.Size(20, 20);
            this.btn_WW_4.TabIndex = 11;
            this.btn_WW_4.UseVisualStyleBackColor = false;
            this.btn_WW_4.Visible = false;
            this.btn_WW_4.Click += new System.EventHandler(this.btn_WW_4_Click);
            // 
            // btn_WW_5
            // 
            this.btn_WW_5.BackColor = System.Drawing.Color.Cyan;
            this.btn_WW_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_WW_5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_WW_5.Location = new System.Drawing.Point(453, 481);
            this.btn_WW_5.Name = "btn_WW_5";
            this.btn_WW_5.Size = new System.Drawing.Size(20, 20);
            this.btn_WW_5.TabIndex = 12;
            this.btn_WW_5.UseVisualStyleBackColor = false;
            this.btn_WW_5.Visible = false;
            this.btn_WW_5.Click += new System.EventHandler(this.btn_WW_5_Click);
            // 
            // btn_WW_6
            // 
            this.btn_WW_6.BackColor = System.Drawing.Color.Cyan;
            this.btn_WW_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_WW_6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_WW_6.Location = new System.Drawing.Point(87, 191);
            this.btn_WW_6.Name = "btn_WW_6";
            this.btn_WW_6.Size = new System.Drawing.Size(20, 20);
            this.btn_WW_6.TabIndex = 13;
            this.btn_WW_6.UseVisualStyleBackColor = false;
            this.btn_WW_6.Visible = false;
            this.btn_WW_6.Click += new System.EventHandler(this.btn_WW_6_Click);
            // 
            // btn_WW_7
            // 
            this.btn_WW_7.BackColor = System.Drawing.Color.Cyan;
            this.btn_WW_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_WW_7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_WW_7.Location = new System.Drawing.Point(671, 462);
            this.btn_WW_7.Name = "btn_WW_7";
            this.btn_WW_7.Size = new System.Drawing.Size(20, 20);
            this.btn_WW_7.TabIndex = 14;
            this.btn_WW_7.UseVisualStyleBackColor = false;
            this.btn_WW_7.Visible = false;
            this.btn_WW_7.Click += new System.EventHandler(this.btn_WW_7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(668, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "ESART Eskişehir Su Atıksu Arıt Tes";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(468, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "EOSB";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(568, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Eskişehir Merkez Atıksu Arıtma Tesisi ";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bozüyük OSB Atıksu Arıtma Tesisi";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(365, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Eskişehir Sağlık Su Arıtma";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(434, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Essu";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(835, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Eski Arıtma Tesisleri";
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1456, 856);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_WW_7);
            this.Controls.Add(this.btn_WW_6);
            this.Controls.Add(this.btn_WW_5);
            this.Controls.Add(this.btn_WW_4);
            this.Controls.Add(this.btn_WW_3);
            this.Controls.Add(this.btn_WW_2);
            this.Controls.Add(this.btn_WD_1);
            this.Controls.Add(this.btn_WW_1);
            this.Controls.Add(this.btn_N_1);
            this.Controls.Add(this.btn_E_1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btn_E_1;
        private System.Windows.Forms.Button btn_N_1;
        private System.Windows.Forms.Button btn_WW_1;
        private System.Windows.Forms.Button btn_WD_1;
        private System.Windows.Forms.Button btn_WW_2;
        private System.Windows.Forms.Button btn_WW_3;
        private System.Windows.Forms.Button btn_WW_4;
        private System.Windows.Forms.Button btn_WW_5;
        private System.Windows.Forms.Button btn_WW_6;
        private System.Windows.Forms.Button btn_WW_7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

