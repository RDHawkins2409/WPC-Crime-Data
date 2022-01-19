namespace WPC_Crime_Data
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MM yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(512, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShowUpDown = true;
            this.dtpDate.Size = new System.Drawing.Size(111, 23);
            this.dtpDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(427, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(79, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Month + Year";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(68, 12);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(140, 23);
            this.txtLatitude.TabIndex = 3;
            this.txtLatitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumber);
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(281, 12);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(140, 23);
            this.txtLongitude.TabIndex = 4;
            this.txtLongitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumber);
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(12, 18);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(50, 15);
            this.lblLatitude.TabIndex = 5;
            this.lblLatitude.Text = "Latitude";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(214, 18);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(61, 15);
            this.lblLongitude.TabIndex = 6;
            this.lblLongitude.Text = "Longitude";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(512, 41);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(111, 23);
            this.btnGet.TabIndex = 7;
            this.btnGet.Text = "Get Crimes";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(12, 70);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(611, 368);
            this.txtResults.TabIndex = 8;
            this.txtResults.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Name = "frmMain";
            this.Text = "Crime Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpDate;
        private Label lblDate;
        private TextBox txtLatitude;
        private TextBox txtLongitude;
        private Label lblLatitude;
        private Label lblLongitude;
        private Button btnGet;
        private RichTextBox txtResults;
    }
}