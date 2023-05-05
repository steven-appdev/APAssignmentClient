namespace APAssignmentClient.View
{
    partial class AddNewStaff
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
            this.cmbCourseTaught = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbStaffName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbStaffID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbSupportSession = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCourseTaught
            // 
            this.cmbCourseTaught.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseTaught.FormattingEnabled = true;
            this.cmbCourseTaught.Items.AddRange(new object[] {
            "Video Course",
            "Practical Course"});
            this.cmbCourseTaught.Location = new System.Drawing.Point(111, 74);
            this.cmbCourseTaught.Name = "cmbCourseTaught";
            this.cmbCourseTaught.Size = new System.Drawing.Size(357, 21);
            this.cmbCourseTaught.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Course Taught";
            // 
            // txtbStaffName
            // 
            this.txtbStaffName.Location = new System.Drawing.Point(111, 48);
            this.txtbStaffName.Name = "txtbStaffName";
            this.txtbStaffName.Size = new System.Drawing.Size(357, 20);
            this.txtbStaffName.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Staff Name";
            // 
            // txtbStaffID
            // 
            this.txtbStaffID.Location = new System.Drawing.Point(111, 22);
            this.txtbStaffID.Name = "txtbStaffID";
            this.txtbStaffID.ReadOnly = true;
            this.txtbStaffID.Size = new System.Drawing.Size(357, 20);
            this.txtbStaffID.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Staff ID";
            // 
            // txtbSupportSession
            // 
            this.txtbSupportSession.Location = new System.Drawing.Point(111, 101);
            this.txtbSupportSession.Name = "txtbSupportSession";
            this.txtbSupportSession.Size = new System.Drawing.Size(357, 20);
            this.txtbSupportSession.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Support Session";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(303, 137);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(165, 33);
            this.btnAddStaff.TabIndex = 37;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // AddNewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 181);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.txtbSupportSession);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCourseTaught);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbStaffName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbStaffID);
            this.Controls.Add(this.label1);
            this.Name = "AddNewStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Information";
            this.Load += new System.EventHandler(this.AddNewStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCourseTaught;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbStaffName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbStaffID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbSupportSession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddStaff;
    }
}