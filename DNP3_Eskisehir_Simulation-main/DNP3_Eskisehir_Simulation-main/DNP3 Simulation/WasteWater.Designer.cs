namespace DNP3_Simulation
{
    partial class WasteWater
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.TextBox();
            this.tds = new System.Windows.Forms.TextBox();
            this.conductivity = new System.Windows.Forms.TextBox();
            this.tss = new System.Windows.Forms.TextBox();
            this.turbidity = new System.Windows.Forms.TextBox();
            this.colour = new System.Windows.Forms.TextBox();
            this.sulphate = new System.Windows.Forms.TextBox();
            this.nh3 = new System.Windows.Forms.TextBox();
            this.cod = new System.Windows.Forms.TextBox();
            this.bod = new System.Windows.Forms.TextBox();
            this.pH = new System.Windows.Forms.TextBox();
            this.dissolvedoxygen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label1.Location = new System.Drawing.Point(40, 73);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(248, 32);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Temperature (°C) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Dissolved Solid (mg/l) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conductivity (μS/cm):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(40, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Colour (TCU) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(40, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Turbidity (mg/l) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(40, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(397, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Suspended Solid (mg/l) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(40, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dissolved Oxygen (mg/l) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(40, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "pH :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(40, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(453, 32);
            this.label9.TabIndex = 8;
            this.label9.Text = "Biological Oxygen Demand (mg/l) :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(40, 570);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 32);
            this.label10.TabIndex = 9;
            this.label10.Text = "NH3- N (mg/l) :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(40, 521);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(447, 32);
            this.label11.TabIndex = 10;
            this.label11.Text = "Chemical Oxygen Demand (mg/l) :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(40, 619);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 32);
            this.label12.TabIndex = 11;
            this.label12.Text = "Sulphate (mg/l) :";
            // 
            // temperature
            // 
            this.temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temperature.Location = new System.Drawing.Point(524, 73);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(272, 38);
            this.temperature.TabIndex = 12;
            // 
            // tds
            // 
            this.tds.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tds.Location = new System.Drawing.Point(524, 121);
            this.tds.Name = "tds";
            this.tds.Size = new System.Drawing.Size(272, 38);
            this.tds.TabIndex = 13;
            // 
            // conductivity
            // 
            this.conductivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.conductivity.Location = new System.Drawing.Point(524, 168);
            this.conductivity.Name = "conductivity";
            this.conductivity.Size = new System.Drawing.Size(272, 38);
            this.conductivity.TabIndex = 14;
            // 
            // tss
            // 
            this.tss.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tss.Location = new System.Drawing.Point(524, 317);
            this.tss.Name = "tss";
            this.tss.Size = new System.Drawing.Size(272, 38);
            this.tss.TabIndex = 17;
            // 
            // turbidity
            // 
            this.turbidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turbidity.Location = new System.Drawing.Point(524, 269);
            this.turbidity.Name = "turbidity";
            this.turbidity.Size = new System.Drawing.Size(272, 38);
            this.turbidity.TabIndex = 16;
            // 
            // colour
            // 
            this.colour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colour.Location = new System.Drawing.Point(524, 221);
            this.colour.Name = "colour";
            this.colour.Size = new System.Drawing.Size(272, 38);
            this.colour.TabIndex = 15;
            // 
            // sulphate
            // 
            this.sulphate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sulphate.Location = new System.Drawing.Point(524, 611);
            this.sulphate.Name = "sulphate";
            this.sulphate.Size = new System.Drawing.Size(272, 38);
            this.sulphate.TabIndex = 23;
            // 
            // nh3
            // 
            this.nh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nh3.Location = new System.Drawing.Point(524, 564);
            this.nh3.Name = "nh3";
            this.nh3.Size = new System.Drawing.Size(272, 38);
            this.nh3.TabIndex = 22;
            // 
            // cod
            // 
            this.cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cod.Location = new System.Drawing.Point(524, 516);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(272, 38);
            this.cod.TabIndex = 21;
            // 
            // bod
            // 
            this.bod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bod.Location = new System.Drawing.Point(524, 463);
            this.bod.Name = "bod";
            this.bod.Size = new System.Drawing.Size(272, 38);
            this.bod.TabIndex = 20;
            // 
            // pH
            // 
            this.pH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pH.Location = new System.Drawing.Point(524, 416);
            this.pH.Name = "pH";
            this.pH.Size = new System.Drawing.Size(272, 38);
            this.pH.TabIndex = 19;
            // 
            // dissolvedoxygen
            // 
            this.dissolvedoxygen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dissolvedoxygen.Location = new System.Drawing.Point(524, 368);
            this.dissolvedoxygen.Name = "dissolvedoxygen";
            this.dissolvedoxygen.Size = new System.Drawing.Size(272, 38);
            this.dissolvedoxygen.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(113, 693);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 75);
            this.button1.TabIndex = 24;
            this.button1.Text = "Go back to Map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WasteWater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(860, 780);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sulphate);
            this.Controls.Add(this.nh3);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.bod);
            this.Controls.Add(this.pH);
            this.Controls.Add(this.dissolvedoxygen);
            this.Controls.Add(this.tss);
            this.Controls.Add(this.turbidity);
            this.Controls.Add(this.colour);
            this.Controls.Add(this.conductivity);
            this.Controls.Add(this.tds);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Name = "WasteWater";
            this.Text = "WasteWater";
            this.Load += new System.EventHandler(this.WasteWater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox temperature;
        private System.Windows.Forms.TextBox tds;
        private System.Windows.Forms.TextBox conductivity;
        private System.Windows.Forms.TextBox tss;
        private System.Windows.Forms.TextBox turbidity;
        private System.Windows.Forms.TextBox colour;
        private System.Windows.Forms.TextBox sulphate;
        private System.Windows.Forms.TextBox nh3;
        private System.Windows.Forms.TextBox cod;
        private System.Windows.Forms.TextBox bod;
        private System.Windows.Forms.TextBox pH;
        private System.Windows.Forms.TextBox dissolvedoxygen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}