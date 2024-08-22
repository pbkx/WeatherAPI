namespace WeatherAPI
{
    partial class WeatherAPIForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.getWeatherXML = new System.Windows.Forms.Button();
            this.getWeatherJSON = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.txtFeels = new System.Windows.Forms.TextBox();
            this.txtClouds = new System.Windows.Forms.TextBox();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a Zip Code:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Longitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Latitude";
            // 
            // getWeatherXML
            // 
            this.getWeatherXML.Location = new System.Drawing.Point(26, 41);
            this.getWeatherXML.Name = "getWeatherXML";
            this.getWeatherXML.Size = new System.Drawing.Size(279, 38);
            this.getWeatherXML.TabIndex = 4;
            this.getWeatherXML.Text = "Get Weather [XML]";
            this.getWeatherXML.UseVisualStyleBackColor = true;
            this.getWeatherXML.Click += new System.EventHandler(this.btnWeatherXML_Click);
            // 
            // getWeatherJSON
            // 
            this.getWeatherJSON.Location = new System.Drawing.Point(26, 85);
            this.getWeatherJSON.Name = "getWeatherJSON";
            this.getWeatherJSON.Size = new System.Drawing.Size(279, 38);
            this.getWeatherJSON.TabIndex = 5;
            this.getWeatherJSON.Text = "Get Weather [JSON]";
            this.getWeatherJSON.UseVisualStyleBackColor = true;
            this.getWeatherJSON.Click += new System.EventHandler(this.btnWeatherJSON_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Low";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "High";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Feels Like";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Clouds";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Wind";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Temperature";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(26, 180);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(279, 20);
            this.txtZip.TabIndex = 12;
            this.txtZip.TextChanged += new System.EventHandler(this.txtZip_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(26, 226);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(279, 20);
            this.txtCity.TabIndex = 13;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtLatitude
            // 
            this.txtLatitude.Enabled = false;
            this.txtLatitude.Location = new System.Drawing.Point(26, 277);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(87, 20);
            this.txtLatitude.TabIndex = 14;
            this.txtLatitude.TextChanged += new System.EventHandler(this.txtLatitude_TextChanged);
            // 
            // txtLongitude
            // 
            this.txtLongitude.Enabled = false;
            this.txtLongitude.Location = new System.Drawing.Point(119, 277);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(93, 20);
            this.txtLongitude.TabIndex = 15;
            this.txtLongitude.TextChanged += new System.EventHandler(this.txtLongitude_TextChanged);
            // 
            // txtTemp
            // 
            this.txtTemp.Enabled = false;
            this.txtTemp.Location = new System.Drawing.Point(218, 277);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(87, 20);
            this.txtTemp.TabIndex = 16;
            // 
            // txtLow
            // 
            this.txtLow.Enabled = false;
            this.txtLow.Location = new System.Drawing.Point(27, 335);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(46, 20);
            this.txtLow.TabIndex = 17;
            this.txtLow.TextChanged += new System.EventHandler(this.txtLow_TextChanged);
            // 
            // txtHigh
            // 
            this.txtHigh.Enabled = false;
            this.txtHigh.Location = new System.Drawing.Point(78, 335);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(46, 20);
            this.txtHigh.TabIndex = 18;
            // 
            // txtFeels
            // 
            this.txtFeels.Enabled = false;
            this.txtFeels.Location = new System.Drawing.Point(130, 335);
            this.txtFeels.Name = "txtFeels";
            this.txtFeels.Size = new System.Drawing.Size(83, 20);
            this.txtFeels.TabIndex = 19;
            // 
            // txtClouds
            // 
            this.txtClouds.Enabled = false;
            this.txtClouds.Location = new System.Drawing.Point(27, 389);
            this.txtClouds.Name = "txtClouds";
            this.txtClouds.Size = new System.Drawing.Size(125, 20);
            this.txtClouds.TabIndex = 21;
            // 
            // txtWind
            // 
            this.txtWind.Enabled = false;
            this.txtWind.Location = new System.Drawing.Point(219, 335);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(86, 20);
            this.txtWind.TabIndex = 20;
            this.txtWind.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(-9, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(349, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-231, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 23;
            // 
            // close
            // 
            this.close.ForeColor = System.Drawing.Color.Red;
            this.close.Location = new System.Drawing.Point(162, 387);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(144, 23);
            this.close.TabIndex = 24;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(-7, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(349, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // WeatherAPIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(331, 449);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtClouds);
            this.Controls.Add(this.txtWind);
            this.Controls.Add(this.txtFeels);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.getWeatherJSON);
            this.Controls.Add(this.getWeatherXML);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WeatherAPIForm";
            this.Text = "Weather API Application";
            this.Load += new System.EventHandler(this.WeatherAPIForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getWeatherXML;
        private System.Windows.Forms.Button getWeatherJSON;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.TextBox txtFeels;
        private System.Windows.Forms.TextBox txtClouds;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label13;
    }
}

