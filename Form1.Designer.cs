namespace WeatherAppp
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
            this.tbTown = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbMaxT = new System.Windows.Forms.Label();
            this.lbMinT = new System.Windows.Forms.Label();
            this.lbWind = new System.Windows.Forms.Label();
            this.lbClouds = new System.Windows.Forms.Label();
            this.btnSent = new System.Windows.Forms.Button();
            this.lbLon = new System.Windows.Forms.Label();
            this.lbLat = new System.Windows.Forms.Label();
            this.dgForecast = new System.Windows.Forms.DataGridView();
            this.DayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaxT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMinT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clClouds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgForecast)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTown
            // 
            this.tbTown.Location = new System.Drawing.Point(37, 67);
            this.tbTown.Multiline = true;
            this.tbTown.Name = "tbTown";
            this.tbTown.Size = new System.Drawing.Size(183, 26);
            this.tbTown.TabIndex = 0;
            this.tbTown.TextChanged += new System.EventHandler(this.tbZip_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please, enter the Town:\r\n\r\n\r\n";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(34, 138);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(66, 16);
            this.lbCountry.TabIndex = 2;
            this.lbCountry.Text = "Countries:";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(34, 195);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(32, 16);
            this.lbCity.TabIndex = 3;
            this.lbCity.Text = "City:";
            // 
            // lbMaxT
            // 
            this.lbMaxT.AutoSize = true;
            this.lbMaxT.Location = new System.Drawing.Point(34, 254);
            this.lbMaxT.Name = "lbMaxT";
            this.lbMaxT.Size = new System.Drawing.Size(116, 16);
            this.lbMaxT.TabIndex = 4;
            this.lbMaxT.Text = "Temperature max:";
            // 
            // lbMinT
            // 
            this.lbMinT.AutoSize = true;
            this.lbMinT.Location = new System.Drawing.Point(34, 312);
            this.lbMinT.Name = "lbMinT";
            this.lbMinT.Size = new System.Drawing.Size(112, 16);
            this.lbMinT.TabIndex = 5;
            this.lbMinT.Text = "Temperature min:";
            // 
            // lbWind
            // 
            this.lbWind.AutoSize = true;
            this.lbWind.Location = new System.Drawing.Point(34, 367);
            this.lbWind.Name = "lbWind";
            this.lbWind.Size = new System.Drawing.Size(41, 16);
            this.lbWind.TabIndex = 6;
            this.lbWind.Text = "Wind:";
            // 
            // lbClouds
            // 
            this.lbClouds.AutoSize = true;
            this.lbClouds.Location = new System.Drawing.Point(34, 425);
            this.lbClouds.Name = "lbClouds";
            this.lbClouds.Size = new System.Drawing.Size(52, 16);
            this.lbClouds.TabIndex = 7;
            this.lbClouds.Text = "Clouds:";
            // 
            // btnSent
            // 
            this.btnSent.Location = new System.Drawing.Point(117, 560);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(137, 69);
            this.btnSent.TabIndex = 8;
            this.btnSent.Text = "Sent";
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // lbLon
            // 
            this.lbLon.AutoSize = true;
            this.lbLon.Location = new System.Drawing.Point(243, 138);
            this.lbLon.Name = "lbLon";
            this.lbLon.Size = new System.Drawing.Size(28, 16);
            this.lbLon.TabIndex = 9;
            this.lbLon.Text = "lon:";
            // 
            // lbLat
            // 
            this.lbLat.AutoSize = true;
            this.lbLat.Location = new System.Drawing.Point(243, 195);
            this.lbLat.Name = "lbLat";
            this.lbLat.Size = new System.Drawing.Size(24, 16);
            this.lbLat.TabIndex = 10;
            this.lbLat.Text = "lat:";
            // 
            // dgForecast
            // 
            this.dgForecast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgForecast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DayOfWeek,
            this.clHour,
            this.clMaxT,
            this.clMinT,
            this.clWind,
            this.clClouds,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgForecast.Location = new System.Drawing.Point(320, 13);
            this.dgForecast.Name = "dgForecast";
            this.dgForecast.RowHeadersWidth = 51;
            this.dgForecast.RowTemplate.Height = 24;
            this.dgForecast.Size = new System.Drawing.Size(747, 616);
            this.dgForecast.TabIndex = 11;
            this.dgForecast.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgForecast_CellContentClick);
            // 
            // DayOfWeek
            // 
            this.DayOfWeek.HeaderText = "Day";
            this.DayOfWeek.MinimumWidth = 6;
            this.DayOfWeek.Name = "DayOfWeek";
            this.DayOfWeek.Width = 125;
            // 
            // clHour
            // 
            this.clHour.HeaderText = "Time period";
            this.clHour.MinimumWidth = 6;
            this.clHour.Name = "clHour";
            this.clHour.Width = 125;
            // 
            // clMaxT
            // 
            this.clMaxT.HeaderText = "Temperature max";
            this.clMaxT.MinimumWidth = 6;
            this.clMaxT.Name = "clMaxT";
            this.clMaxT.Width = 125;
            // 
            // clMinT
            // 
            this.clMinT.HeaderText = "Temperature min";
            this.clMinT.MinimumWidth = 6;
            this.clMinT.Name = "clMinT";
            this.clMinT.Width = 125;
            // 
            // clWind
            // 
            this.clWind.HeaderText = "Wind";
            this.clWind.MinimumWidth = 6;
            this.clWind.Name = "clWind";
            this.clWind.Width = 125;
            // 
            // clClouds
            // 
            this.clClouds.HeaderText = "Clouds";
            this.clClouds.MinimumWidth = 6;
            this.clClouds.Name = "clClouds";
            this.clClouds.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Wind in numbers";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Couds in numbers";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Pressure";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(12, 99);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(121, 23);
            this.btnHistory.TabIndex = 12;
            this.btnHistory.Text = "Search history";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 665);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.dgForecast);
            this.Controls.Add(this.lbLat);
            this.Controls.Add(this.lbLon);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.lbClouds);
            this.Controls.Add(this.lbWind);
            this.Controls.Add(this.lbMinT);
            this.Controls.Add(this.lbMaxT);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTown);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgForecast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbMaxT;
        private System.Windows.Forms.Label lbMinT;
        private System.Windows.Forms.Label lbWind;
        private System.Windows.Forms.Label lbClouds;
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.Label lbLon;
        private System.Windows.Forms.Label lbLat;
        private System.Windows.Forms.DataGridView dgForecast;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayOfWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaxT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMinT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWind;
        private System.Windows.Forms.DataGridViewTextBoxColumn clClouds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnHistory;
    }
}

