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
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolledCourses)).BeginInit();
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
            this.btnEnrolNew.Location = new System.Drawing.Point(595, 66);
            this.btnEnrolNew.Name = "btnEnrolNew";
            this.btnEnrolNew.Size = new System.Drawing.Size(193, 33);
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
            this.status});
            this.dgvEnrolledCourses.Location = new System.Drawing.Point(14, 105);
            this.dgvEnrolledCourses.Name = "dgvEnrolledCourses";
            this.dgvEnrolledCourses.ReadOnly = true;
            this.dgvEnrolledCourses.RowHeadersVisible = false;
            this.dgvEnrolledCourses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEnrolledCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnrolledCourses.Size = new System.Drawing.Size(774, 336);
            this.dgvEnrolledCourses.TabIndex = 5;
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
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 200;
            // 
            // ClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnrolNew;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DataGridView dgvEnrolledCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}

