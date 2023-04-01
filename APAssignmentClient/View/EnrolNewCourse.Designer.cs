namespace APAssignmentClient
{
    partial class EnrolNewCourse
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
            this.lsbAvailableCourses = new System.Windows.Forms.ListBox();
            this.btnEnrol = new System.Windows.Forms.Button();
            this.btnViewCourseDescription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbAvailableCourses
            // 
            this.lsbAvailableCourses.FormattingEnabled = true;
            this.lsbAvailableCourses.Location = new System.Drawing.Point(12, 12);
            this.lsbAvailableCourses.Name = "lsbAvailableCourses";
            this.lsbAvailableCourses.Size = new System.Drawing.Size(507, 251);
            this.lsbAvailableCourses.TabIndex = 0;
            // 
            // btnEnrol
            // 
            this.btnEnrol.Location = new System.Drawing.Point(378, 269);
            this.btnEnrol.Name = "btnEnrol";
            this.btnEnrol.Size = new System.Drawing.Size(141, 34);
            this.btnEnrol.TabIndex = 1;
            this.btnEnrol.Text = "Enrol Course";
            this.btnEnrol.UseVisualStyleBackColor = true;
            this.btnEnrol.Click += new System.EventHandler(this.btnEnrol_Click);
            // 
            // btnViewCourseDescription
            // 
            this.btnViewCourseDescription.Location = new System.Drawing.Point(231, 269);
            this.btnViewCourseDescription.Name = "btnViewCourseDescription";
            this.btnViewCourseDescription.Size = new System.Drawing.Size(141, 34);
            this.btnViewCourseDescription.TabIndex = 2;
            this.btnViewCourseDescription.Text = "View Course Description";
            this.btnViewCourseDescription.UseVisualStyleBackColor = true;
            // 
            // EnrolNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 315);
            this.Controls.Add(this.btnViewCourseDescription);
            this.Controls.Add(this.btnEnrol);
            this.Controls.Add(this.lsbAvailableCourses);
            this.Name = "EnrolNewCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrol New Courses";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbAvailableCourses;
        private System.Windows.Forms.Button btnEnrol;
        private System.Windows.Forms.Button btnViewCourseDescription;
    }
}