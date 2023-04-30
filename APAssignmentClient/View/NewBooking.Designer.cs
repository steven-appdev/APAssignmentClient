namespace APAssignmentClient.View
{
    partial class NewBooking
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
            this.cmbManagementName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSessionDuration = new System.Windows.Forms.ComboBox();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtSessionDate = new System.Windows.Forms.DateTimePicker();
            this.txtbSupportSession = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Management Name";
            // 
            // cmbManagementName
            // 
            this.cmbManagementName.FormattingEnabled = true;
            this.cmbManagementName.Location = new System.Drawing.Point(131, 17);
            this.cmbManagementName.Name = "cmbManagementName";
            this.cmbManagementName.Size = new System.Drawing.Size(227, 21);
            this.cmbManagementName.TabIndex = 1;
            this.cmbManagementName.SelectedIndexChanged += new System.EventHandler(this.cmbManagementName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duration (minutes)";
            // 
            // cmbSessionDuration
            // 
            this.cmbSessionDuration.FormattingEnabled = true;
            this.cmbSessionDuration.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60"});
            this.cmbSessionDuration.Location = new System.Drawing.Point(131, 70);
            this.cmbSessionDuration.Name = "cmbSessionDuration";
            this.cmbSessionDuration.Size = new System.Drawing.Size(227, 21);
            this.cmbSessionDuration.TabIndex = 3;
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Location = new System.Drawing.Point(28, 137);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(330, 33);
            this.btnConfirmBooking.TabIndex = 4;
            this.btnConfirmBooking.Text = "Confirm Booking";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Session Date";
            // 
            // dtSessionDate
            // 
            this.dtSessionDate.CustomFormat = "MM/dd/yyyy";
            this.dtSessionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSessionDate.Location = new System.Drawing.Point(131, 97);
            this.dtSessionDate.Name = "dtSessionDate";
            this.dtSessionDate.Size = new System.Drawing.Size(227, 20);
            this.dtSessionDate.TabIndex = 6;
            // 
            // txtbSupportSession
            // 
            this.txtbSupportSession.Enabled = false;
            this.txtbSupportSession.Location = new System.Drawing.Point(131, 44);
            this.txtbSupportSession.Name = "txtbSupportSession";
            this.txtbSupportSession.Size = new System.Drawing.Size(227, 20);
            this.txtbSupportSession.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Support Session";
            // 
            // NewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 184);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbSupportSession);
            this.Controls.Add(this.dtSessionDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.cmbSessionDuration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbManagementName);
            this.Controls.Add(this.label1);
            this.Name = "NewBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Booking";
            this.Load += new System.EventHandler(this.NewBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbManagementName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSessionDuration;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtSessionDate;
        private System.Windows.Forms.TextBox txtbSupportSession;
        private System.Windows.Forms.Label label4;
    }
}