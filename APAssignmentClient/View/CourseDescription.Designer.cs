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
            this.txtbCourseID.Location = new System.Drawing.Point(92, 15);
            this.txtbCourseID.Name = "txtbCourseID";
            this.txtbCourseID.ReadOnly = true;
            this.txtbCourseID.Size = new System.Drawing.Size(293, 20);
            this.txtbCourseID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Title";
            // 
            // txtbCourseTitle
            // 
            this.txtbCourseTitle.Enabled = false;
            this.txtbCourseTitle.Location = new System.Drawing.Point(92, 46);
            this.txtbCourseTitle.Name = "txtbCourseTitle";
            this.txtbCourseTitle.ReadOnly = true;
            this.txtbCourseTitle.Size = new System.Drawing.Size(293, 20);
            this.txtbCourseTitle.TabIndex = 3;
            // 
            // rtxtbDescription
            // 
            this.rtxtbDescription.Enabled = false;
            this.rtxtbDescription.Location = new System.Drawing.Point(92, 81);
            this.rtxtbDescription.Name = "rtxtbDescription";
            this.rtxtbDescription.ReadOnly = true;
            this.rtxtbDescription.Size = new System.Drawing.Size(293, 132);
            this.rtxtbDescription.TabIndex = 4;
            this.rtxtbDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // CourseDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 237);
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
    }
}