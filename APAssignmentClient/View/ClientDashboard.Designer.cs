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
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnrolNew = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.dgvEnrolledCourses = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDropCourse = new System.Windows.Forms.Button();
            this.btnClientInformation = new System.Windows.Forms.Button();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMngmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDropBooking = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolledCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enrolled Courses";
            // 
            // btnEnrolNew
            // 
            this.btnEnrolNew.Location = new System.Drawing.Point(623, 268);
            this.btnEnrolNew.Name = "btnEnrolNew";
            this.btnEnrolNew.Size = new System.Drawing.Size(165, 33);
            this.btnEnrolNew.TabIndex = 3;
            this.btnEnrolNew.Text = "+ Enrol New Course";
            this.btnEnrolNew.UseVisualStyleBackColor = true;
            this.btnEnrolNew.Click += new System.EventHandler(this.btnEnrolNew_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(170, 5);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(198, 45);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "(username)";
            // 
            // dgvEnrolledCourses
            // 
            this.dgvEnrolledCourses.AllowUserToAddRows = false;
            this.dgvEnrolledCourses.AllowUserToDeleteRows = false;
            this.dgvEnrolledCourses.AllowUserToResizeColumns = false;
            this.dgvEnrolledCourses.AllowUserToResizeRows = false;
            this.dgvEnrolledCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrolledCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.title,
            this.courseType,
            this.status});
            this.dgvEnrolledCourses.Location = new System.Drawing.Point(14, 89);
            this.dgvEnrolledCourses.Name = "dgvEnrolledCourses";
            this.dgvEnrolledCourses.ReadOnly = true;
            this.dgvEnrolledCourses.RowHeadersVisible = false;
            this.dgvEnrolledCourses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEnrolledCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnrolledCourses.Size = new System.Drawing.Size(774, 173);
            this.dgvEnrolledCourses.TabIndex = 5;
            this.dgvEnrolledCourses.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvEnrolledCourses_RowsAdded);
            this.dgvEnrolledCourses.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvEnrolledCourses_RowsRemoved);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.HeaderText = "Course Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // courseType
            // 
            this.courseType.HeaderText = "Course Type";
            this.courseType.Name = "courseType";
            this.courseType.ReadOnly = true;
            this.courseType.Width = 200;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 200;
            // 
            // btnDropCourse
            // 
            this.btnDropCourse.Enabled = false;
            this.btnDropCourse.Location = new System.Drawing.Point(452, 268);
            this.btnDropCourse.Name = "btnDropCourse";
            this.btnDropCourse.Size = new System.Drawing.Size(165, 33);
            this.btnDropCourse.TabIndex = 6;
            this.btnDropCourse.Text = "Drop Course";
            this.btnDropCourse.UseVisualStyleBackColor = true;
            this.btnDropCourse.Click += new System.EventHandler(this.btnDropCourse_Click);
            // 
            // btnClientInformation
            // 
            this.btnClientInformation.Location = new System.Drawing.Point(565, 12);
            this.btnClientInformation.Name = "btnClientInformation";
            this.btnClientInformation.Size = new System.Drawing.Size(223, 33);
            this.btnClientInformation.TabIndex = 7;
            this.btnClientInformation.Text = "My Information";
            this.btnClientInformation.UseVisualStyleBackColor = true;
            this.btnClientInformation.Click += new System.EventHandler(this.btnClientInformation_Click);
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.Location = new System.Drawing.Point(623, 536);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(165, 33);
            this.btnNewBooking.TabIndex = 8;
            this.btnNewBooking.Text = "+ Book New Booking";
            this.btnNewBooking.UseVisualStyleBackColor = true;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.AllowUserToResizeColumns = false;
            this.dgvBooking.AllowUserToResizeRows = false;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmMngmName,
            this.clmDate,
            this.clmDuration});
            this.dgvBooking.Location = new System.Drawing.Point(14, 357);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.RowHeadersVisible = false;
            this.dgvBooking.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooking.Size = new System.Drawing.Size(774, 173);
            this.dgvBooking.TabIndex = 9;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Width = 50;
            // 
            // clmMngmName
            // 
            this.clmMngmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMngmName.HeaderText = "Management Name";
            this.clmMngmName.Name = "clmMngmName";
            this.clmMngmName.ReadOnly = true;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Date";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            this.clmDate.Width = 200;
            // 
            // clmDuration
            // 
            this.clmDuration.HeaderText = "Duration";
            this.clmDuration.Name = "clmDuration";
            this.clmDuration.ReadOnly = true;
            this.clmDuration.Width = 75;
            // 
            // btnDropBooking
            // 
            this.btnDropBooking.Location = new System.Drawing.Point(452, 536);
            this.btnDropBooking.Name = "btnDropBooking";
            this.btnDropBooking.Size = new System.Drawing.Size(165, 33);
            this.btnDropBooking.TabIndex = 10;
            this.btnDropBooking.Text = "Drop Booking";
            this.btnDropBooking.UseVisualStyleBackColor = true;
            this.btnDropBooking.Click += new System.EventHandler(this.btnDropBooking_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Booked Session";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(281, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Drop Course";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDropBooking);
            this.Controls.Add(this.dgvBooking);
            this.Controls.Add(this.btnNewBooking);
            this.Controls.Add(this.btnClientInformation);
            this.Controls.Add(this.btnDropCourse);
            this.Controls.Add(this.dgvEnrolledCourses);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnEnrolNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Activated += new System.EventHandler(this.ClientDashboard_Activated);
            this.Load += new System.EventHandler(this.ClientDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolledCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnrolNew;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DataGridView dgvEnrolledCourses;
        private System.Windows.Forms.Button btnDropCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button btnClientInformation;
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Button btnDropBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMngmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

