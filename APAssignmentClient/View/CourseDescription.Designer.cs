namespace APAssignmentClient
{
    partial class CourseDescription
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
            this.txtbCourseID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbCourseTitle = new System.Windows.Forms.TextBox();
            this.rtxtbDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbCourseType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPlaceBackToWaiting = new System.Windows.Forms.Button();
            this.lblCourseStatus = new System.Windows.Forms.Label();
            this.txtbCourseStatus = new System.Windows.Forms.TextBox();
            this.lblCourseDate = new System.Windows.Forms.Label();
            this.txtbCourseDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID";
            // 
            // txtbCourseID
            // 
            this.txtbCourseID.Enabled = false;
            this.txtbCourseID.Location = new System.Drawing.Point(108, 15);
            this.txtbCourseID.Name = "txtbCourseID";
            this.txtbCourseID.ReadOnly = true;
            this.txtbCourseID.Size = new System.Drawing.Size(357, 20);
            this.txtbCourseID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Title";
            // 
            // txtbCourseTitle
            // 
            this.txtbCourseTitle.Enabled = false;
            this.txtbCourseTitle.Location = new System.Drawing.Point(108, 41);
            this.txtbCourseTitle.Name = "txtbCourseTitle";
            this.txtbCourseTitle.ReadOnly = true;
            this.txtbCourseTitle.Size = new System.Drawing.Size(357, 20);
            this.txtbCourseTitle.TabIndex = 3;
            // 
            // rtxtbDescription
            // 
            this.rtxtbDescription.Enabled = false;
            this.rtxtbDescription.Location = new System.Drawing.Point(108, 93);
            this.rtxtbDescription.Name = "rtxtbDescription";
            this.rtxtbDescription.ReadOnly = true;
            this.rtxtbDescription.Size = new System.Drawing.Size(357, 132);
            this.rtxtbDescription.TabIndex = 4;
            this.rtxtbDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // txtbCourseType
            // 
            this.txtbCourseType.Enabled = false;
            this.txtbCourseType.Location = new System.Drawing.Point(108, 67);
            this.txtbCourseType.Name = "txtbCourseType";
            this.txtbCourseType.ReadOnly = true;
            this.txtbCourseType.Size = new System.Drawing.Size(357, 20);
            this.txtbCourseType.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Course Type";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(347, 290);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 31);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPlaceBackToWaiting
            // 
            this.btnPlaceBackToWaiting.Location = new System.Drawing.Point(188, 290);
            this.btnPlaceBackToWaiting.Name = "btnPlaceBackToWaiting";
            this.btnPlaceBackToWaiting.Size = new System.Drawing.Size(153, 31);
            this.btnPlaceBackToWaiting.TabIndex = 9;
            this.btnPlaceBackToWaiting.Text = "Place back to Waiting List";
            this.btnPlaceBackToWaiting.UseVisualStyleBackColor = true;
            this.btnPlaceBackToWaiting.Visible = false;
            this.btnPlaceBackToWaiting.Click += new System.EventHandler(this.btnPlaceBackToWaiting_Click);
            // 
            // lblCourseStatus
            // 
            this.lblCourseStatus.AutoSize = true;
            this.lblCourseStatus.Location = new System.Drawing.Point(23, 234);
            this.lblCourseStatus.Name = "lblCourseStatus";
            this.lblCourseStatus.Size = new System.Drawing.Size(73, 13);
            this.lblCourseStatus.TabIndex = 11;
            this.lblCourseStatus.Text = "Course Status";
            this.lblCourseStatus.Visible = false;
            // 
            // txtbCourseStatus
            // 
            this.txtbCourseStatus.Enabled = false;
            this.txtbCourseStatus.Location = new System.Drawing.Point(108, 231);
            this.txtbCourseStatus.Name = "txtbCourseStatus";
            this.txtbCourseStatus.ReadOnly = true;
            this.txtbCourseStatus.Size = new System.Drawing.Size(357, 20);
            this.txtbCourseStatus.TabIndex = 10;
            this.txtbCourseStatus.Visible = false;
            // 
            // lblCourseDate
            // 
            this.lblCourseDate.AutoSize = true;
            this.lblCourseDate.Location = new System.Drawing.Point(23, 260);
            this.lblCourseDate.Name = "lblCourseDate";
            this.lblCourseDate.Size = new System.Drawing.Size(66, 13);
            this.lblCourseDate.TabIndex = 13;
            this.lblCourseDate.Text = "Course Date";
            this.lblCourseDate.Visible = false;
            // 
            // txtbCourseDate
            // 
            this.txtbCourseDate.Enabled = false;
            this.txtbCourseDate.Location = new System.Drawing.Point(108, 257);
            this.txtbCourseDate.Name = "txtbCourseDate";
            this.txtbCourseDate.ReadOnly = true;
            this.txtbCourseDate.Size = new System.Drawing.Size(357, 20);
            this.txtbCourseDate.TabIndex = 12;
            this.txtbCourseDate.Visible = false;
            // 
            // CourseDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 333);
            this.Controls.Add(this.lblCourseDate);
            this.Controls.Add(this.txtbCourseDate);
            this.Controls.Add(this.lblCourseStatus);
            this.Controls.Add(this.txtbCourseStatus);
            this.Controls.Add(this.btnPlaceBackToWaiting);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbCourseType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxtbDescription);
            this.Controls.Add(this.txtbCourseTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbCourseID);
            this.Controls.Add(this.label1);
            this.Name = "CourseDescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Description";
            this.Load += new System.EventHandler(this.CourseDescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbCourseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbCourseTitle;
        private System.Windows.Forms.RichTextBox rtxtbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbCourseType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPlaceBackToWaiting;
        private System.Windows.Forms.Label lblCourseStatus;
        private System.Windows.Forms.TextBox txtbCourseStatus;
        private System.Windows.Forms.Label lblCourseDate;
        private System.Windows.Forms.TextBox txtbCourseDate;
    }
}