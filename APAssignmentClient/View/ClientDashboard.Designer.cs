namespace APAssignmentClient
{
    partial class ClientDashboard
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
            this.lsbEnrolledCourses = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnrolNew = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            // 
            // lsbEnrolledCourses
            // 
            this.lsbEnrolledCourses.FormattingEnabled = true;
            this.lsbEnrolledCourses.Location = new System.Drawing.Point(12, 105);
            this.lsbEnrolledCourses.Name = "lsbEnrolledCourses";
            this.lsbEnrolledCourses.Size = new System.Drawing.Size(776, 316);
            this.lsbEnrolledCourses.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enrolled Courses";
            // 
            // btnEnrolNew
            // 
            this.btnEnrolNew.Location = new System.Drawing.Point(656, 66);
            this.btnEnrolNew.Name = "btnEnrolNew";
            this.btnEnrolNew.Size = new System.Drawing.Size(132, 33);
            this.btnEnrolNew.TabIndex = 3;
            this.btnEnrolNew.Text = "+ Enrol New Course";
            this.btnEnrolNew.UseVisualStyleBackColor = true;
            this.btnEnrolNew.Click += new System.EventHandler(this.btnEnrolNew_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(169, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(198, 45);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "(username)";
            // 
            // ClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnEnrolNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbEnrolledCourses);
            this.Controls.Add(this.label1);
            this.Name = "ClientDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Activated += new System.EventHandler(this.ClientDashboard_Activated);
            this.Load += new System.EventHandler(this.ClientDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbEnrolledCourses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnrolNew;
        private System.Windows.Forms.Label lblUsername;
    }
}

