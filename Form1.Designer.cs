namespace _179controllerinterface
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.acidValvebtn = new System.Windows.Forms.Button();
            this.sampleValvebtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.airInValvebtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.samOutValvebtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.wasteValvebtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pumpBackwardsbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pumpForwardbtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.primePumpbtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.airPumpbtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pumpForwardTxtBx = new System.Windows.Forms.TextBox();
            this.pumpBackwardsTxtBx = new System.Windows.Forms.TextBox();
            this.sample2valvebtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.initializebtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.measureBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "squirt acid";
            // 
            // acidValvebtn
            // 
            this.acidValvebtn.Location = new System.Drawing.Point(14, 92);
            this.acidValvebtn.Name = "acidValvebtn";
            this.acidValvebtn.Size = new System.Drawing.Size(100, 24);
            this.acidValvebtn.TabIndex = 6;
            this.acidValvebtn.Text = "squirt";
            this.acidValvebtn.UseVisualStyleBackColor = true;
            this.acidValvebtn.Click += new System.EventHandler(this.acidValvebtn_Click);
            // 
            // sampleValvebtn
            // 
            this.sampleValvebtn.Location = new System.Drawing.Point(132, 92);
            this.sampleValvebtn.Name = "sampleValvebtn";
            this.sampleValvebtn.Size = new System.Drawing.Size(100, 24);
            this.sampleValvebtn.TabIndex = 8;
            this.sampleValvebtn.Text = "closed";
            this.sampleValvebtn.UseVisualStyleBackColor = true;
            this.sampleValvebtn.Click += new System.EventHandler(this.sampleValvebtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sample valve";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // airInValvebtn
            // 
            this.airInValvebtn.Location = new System.Drawing.Point(356, 92);
            this.airInValvebtn.Name = "airInValvebtn";
            this.airInValvebtn.Size = new System.Drawing.Size(100, 24);
            this.airInValvebtn.TabIndex = 10;
            this.airInValvebtn.Text = "closed";
            this.airInValvebtn.UseVisualStyleBackColor = true;
            this.airInValvebtn.Click += new System.EventHandler(this.airInValvebtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Air inlet valve";
            // 
            // samOutValvebtn
            // 
            this.samOutValvebtn.Location = new System.Drawing.Point(582, 92);
            this.samOutValvebtn.Name = "samOutValvebtn";
            this.samOutValvebtn.Size = new System.Drawing.Size(100, 24);
            this.samOutValvebtn.TabIndex = 14;
            this.samOutValvebtn.Text = "closed";
            this.samOutValvebtn.UseVisualStyleBackColor = true;
            this.samOutValvebtn.Click += new System.EventHandler(this.samOutValvebtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(579, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "CO2 outlet valve";
            // 
            // wasteValvebtn
            // 
            this.wasteValvebtn.Location = new System.Drawing.Point(462, 92);
            this.wasteValvebtn.Name = "wasteValvebtn";
            this.wasteValvebtn.Size = new System.Drawing.Size(100, 24);
            this.wasteValvebtn.TabIndex = 12;
            this.wasteValvebtn.Text = "closed";
            this.wasteValvebtn.UseVisualStyleBackColor = true;
            this.wasteValvebtn.Click += new System.EventHandler(this.wasteValvebtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Waste valve";
            // 
            // pumpBackwardsbtn
            // 
            this.pumpBackwardsbtn.Location = new System.Drawing.Point(651, 137);
            this.pumpBackwardsbtn.Name = "pumpBackwardsbtn";
            this.pumpBackwardsbtn.Size = new System.Drawing.Size(100, 24);
            this.pumpBackwardsbtn.TabIndex = 22;
            this.pumpBackwardsbtn.Text = "start";
            this.pumpBackwardsbtn.UseVisualStyleBackColor = true;
            this.pumpBackwardsbtn.Click += new System.EventHandler(this.pumpBackwardsbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(455, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Pull sample";
            // 
            // pumpForwardbtn
            // 
            this.pumpForwardbtn.Location = new System.Drawing.Point(226, 133);
            this.pumpForwardbtn.Name = "pumpForwardbtn";
            this.pumpForwardbtn.Size = new System.Drawing.Size(100, 24);
            this.pumpForwardbtn.TabIndex = 20;
            this.pumpForwardbtn.Text = "start";
            this.pumpForwardbtn.UseVisualStyleBackColor = true;
            this.pumpForwardbtn.Click += new System.EventHandler(this.pumpForwardbtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Push sample";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // primePumpbtn
            // 
            this.primePumpbtn.Location = new System.Drawing.Point(794, 92);
            this.primePumpbtn.Name = "primePumpbtn";
            this.primePumpbtn.Size = new System.Drawing.Size(100, 24);
            this.primePumpbtn.TabIndex = 18;
            this.primePumpbtn.Text = "start!";
            this.primePumpbtn.UseVisualStyleBackColor = true;
            this.primePumpbtn.Click += new System.EventHandler(this.primePumpbtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(803, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Prime pump";
            // 
            // airPumpbtn
            // 
            this.airPumpbtn.Location = new System.Drawing.Point(688, 92);
            this.airPumpbtn.Name = "airPumpbtn";
            this.airPumpbtn.Size = new System.Drawing.Size(100, 24);
            this.airPumpbtn.TabIndex = 16;
            this.airPumpbtn.Text = "off";
            this.airPumpbtn.UseVisualStyleBackColor = true;
            this.airPumpbtn.Click += new System.EventHandler(this.airPumpbtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(697, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Air pump";
            // 
            // pumpForwardTxtBx
            // 
            this.pumpForwardTxtBx.Location = new System.Drawing.Point(116, 136);
            this.pumpForwardTxtBx.Name = "pumpForwardTxtBx";
            this.pumpForwardTxtBx.Size = new System.Drawing.Size(95, 22);
            this.pumpForwardTxtBx.TabIndex = 23;
            this.pumpForwardTxtBx.Text = "3000";
            this.pumpForwardTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pumpBackwardsTxtBx
            // 
            this.pumpBackwardsTxtBx.Location = new System.Drawing.Point(541, 139);
            this.pumpBackwardsTxtBx.Name = "pumpBackwardsTxtBx";
            this.pumpBackwardsTxtBx.Size = new System.Drawing.Size(95, 22);
            this.pumpBackwardsTxtBx.TabIndex = 24;
            this.pumpBackwardsTxtBx.Text = "3000";
            this.pumpBackwardsTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sample2valvebtn
            // 
            this.sample2valvebtn.Location = new System.Drawing.Point(244, 92);
            this.sample2valvebtn.Name = "sample2valvebtn";
            this.sample2valvebtn.Size = new System.Drawing.Size(100, 24);
            this.sample2valvebtn.TabIndex = 26;
            this.sample2valvebtn.Text = "closed";
            this.sample2valvebtn.UseVisualStyleBackColor = true;
            this.sample2valvebtn.Click += new System.EventHandler(this.sample2valvebtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "sample2valve";
            // 
            // initializebtn
            // 
            this.initializebtn.Location = new System.Drawing.Point(395, 24);
            this.initializebtn.Name = "initializebtn";
            this.initializebtn.Size = new System.Drawing.Size(128, 23);
            this.initializebtn.TabIndex = 30;
            this.initializebtn.Text = "initialize";
            this.initializebtn.UseVisualStyleBackColor = true;
            this.initializebtn.Click += new System.EventHandler(this.initializebtn_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 191);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1098, 410);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // measureBtn
            // 
            this.measureBtn.Location = new System.Drawing.Point(819, 159);
            this.measureBtn.Name = "measureBtn";
            this.measureBtn.Size = new System.Drawing.Size(188, 26);
            this.measureBtn.TabIndex = 32;
            this.measureBtn.Text = "Measure!";
            this.measureBtn.UseVisualStyleBackColor = true;
            this.measureBtn.Click += new System.EventHandler(this.measureBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1024, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 710);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.measureBtn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.initializebtn);
            this.Controls.Add(this.sample2valvebtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pumpBackwardsTxtBx);
            this.Controls.Add(this.pumpForwardTxtBx);
            this.Controls.Add(this.pumpBackwardsbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pumpForwardbtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.primePumpbtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.airPumpbtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.samOutValvebtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.wasteValvebtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.airInValvebtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sampleValvebtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.acidValvebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button acidValvebtn;
        private System.Windows.Forms.Button sampleValvebtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button airInValvebtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button samOutValvebtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button wasteValvebtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button pumpBackwardsbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button pumpForwardbtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button primePumpbtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button airPumpbtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox pumpForwardTxtBx;
        private System.Windows.Forms.TextBox pumpBackwardsTxtBx;
        private System.Windows.Forms.Button sample2valvebtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button initializebtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button measureBtn;
        private System.Windows.Forms.Button button3;
    }
}

