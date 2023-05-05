namespace APAssignmentClient.View
{
    partial class AdminDashboard
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
            this.dgvAllCourses = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnViewCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAllClients = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnViewClient = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnViewStaff = new System.Windows.Forms.Button();
            this.dgvAllStaffs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddStaff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStaffs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "All Courses";
            // 
            // dgvAllCourses
            // 
            this.dgvAllCourses.AllowUserToAddRows = false;
            this.dgvAllCourses.AllowUserToDeleteRows = false;
            this.dgvAllCourses.AllowUserToResizeColumns = false;
            this.dgvAllCourses.AllowUserToResizeRows = false;
            this.dgvAllCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvAllCourses.Location = new System.Drawing.Point(17, 96);
            this.dgvAllCourses.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAllCourses.MultiSelect = false;
            this.dgvAllCourses.Name = "dgvAllCourses";
            this.dgvAllCourses.ReadOnly = true;
            this.dgvAllCourses.RowHeadersVisible = false;
            this.dgvAllCourses.RowHeadersWidth = 51;
            this.dgvAllCourses.RowTemplate.Height = 24;
            this.dgvAllCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllCourses.Size = new System.Drawing.Size(819, 156);
            this.dgvAllCourses.TabIndex = 4;
            this.dgvAllCourses.DataSourceChanged += new System.EventHandler(this.dgvAllCourses_DataSourceChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Course Title";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "type";
            this.Column3.HeaderText = "Course Type";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCourse.Location = new System.Drawing.Point(158, 257);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(165, 33);
            this.btnAddCourse.TabIndex = 13;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnViewCourse
            // 
            this.btnViewCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewCourse.Enabled = false;
            this.btnViewCourse.Location = new System.Drawing.Point(500, 257);
            this.btnViewCourse.Name = "btnViewCourse";
            this.btnViewCourse.Size = new System.Drawing.Size(165, 33);
            this.btnViewCourse.TabIndex = 14;
            this.btnViewCourse.Text = "View Course";
            this.btnViewCourse.UseVisualStyleBackColor = true;
            this.btnViewCourse.Click += new System.EventHandler(this.btnViewCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCourse.Enabled = false;
            this.btnDeleteCourse.Location = new System.Drawing.Point(671, 257);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(165, 33);
            this.btnDeleteCourse.TabIndex = 15;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCourse.Enabled = false;
            this.btnEditCourse.Location = new System.Drawing.Point(329, 257);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(165, 33);
            this.btnEditCourse.TabIndex = 16;
            this.btnEditCourse.Text = "Edit Course";
            this.btnEditCourse.UseVisualStyleBackColor = true;
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "All Clients";
            // 
            // dgvAllClients
            // 
            this.dgvAllClients.AllowUserToAddRows = false;
            this.dgvAllClients.AllowUserToDeleteRows = false;
            this.dgvAllClients.AllowUserToResizeColumns = false;
            this.dgvAllClients.AllowUserToResizeRows = false;
            this.dgvAllClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column5});
            this.dgvAllClients.Location = new System.Drawing.Point(20, 339);
            this.dgvAllClients.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAllClients.MultiSelect = false;
            this.dgvAllClients.Name = "dgvAllClients";
            this.dgvAllClients.ReadOnly = true;
            this.dgvAllClients.RowHeadersVisible = false;
            this.dgvAllClients.RowHeadersWidth = 51;
            this.dgvAllClients.RowTemplate.Height = 24;
            this.dgvAllClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllClients.Size = new System.Drawing.Size(816, 156);
            this.dgvAllClients.TabIndex = 18;
            this.dgvAllClients.DataSourceChanged += new System.EventHandler(this.dgvAllClients_DataSourceChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Client Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn4.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "contact";
            this.Column5.HeaderText = "Contact Number";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteClient.Enabled = false;
            this.btnDeleteClient.Location = new System.Drawing.Point(671, 499);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(165, 33);
            this.btnDeleteClient.TabIndex = 20;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            // 
            // btnViewClient
            // 
            this.btnViewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewClient.Enabled = false;
            this.btnViewClient.Location = new System.Drawing.Point(500, 499);
            this.btnViewClient.Name = "btnViewClient";
            this.btnViewClient.Size = new System.Drawing.Size(165, 33);
            this.btnViewClient.TabIndex = 19;
            this.btnViewClient.Text = "View Client";
            this.btnViewClient.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteStaff.Enabled = false;
            this.btnDeleteStaff.Location = new System.Drawing.Point(671, 753);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(165, 33);
            this.btnDeleteStaff.TabIndex = 24;
            this.btnDeleteStaff.Text = "Delete Staff";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            // 
            // btnViewStaff
            // 
            this.btnViewStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewStaff.Enabled = false;
            this.btnViewStaff.Location = new System.Drawing.Point(500, 753);
            this.btnViewStaff.Name = "btnViewStaff";
            this.btnViewStaff.Size = new System.Drawing.Size(165, 33);
            this.btnViewStaff.TabIndex = 23;
            this.btnViewStaff.Text = "View Staff";
            this.btnViewStaff.UseVisualStyleBackColor = true;
            // 
            // dgvAllStaffs
            // 
            this.dgvAllStaffs.AllowUserToAddRows = false;
            this.dgvAllStaffs.AllowUserToDeleteRows = false;
            this.dgvAllStaffs.AllowUserToResizeColumns = false;
            this.dgvAllStaffs.AllowUserToResizeRows = false;
            this.dgvAllStaffs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllStaffs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvAllStaffs.Location = new System.Drawing.Point(20, 592);
            this.dgvAllStaffs.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAllStaffs.MultiSelect = false;
            this.dgvAllStaffs.Name = "dgvAllStaffs";
            this.dgvAllStaffs.ReadOnly = true;
            this.dgvAllStaffs.RowHeadersVisible = false;
            this.dgvAllStaffs.RowHeadersWidth = 51;
            this.dgvAllStaffs.RowTemplate.Height = 24;
            this.dgvAllStaffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllStaffs.Size = new System.Drawing.Size(816, 156);
            this.dgvAllStaffs.TabIndex = 22;
            this.dgvAllStaffs.DataSourceChanged += new System.EventHandler(this.dgvAllStaffs_DataSourceChanged);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Staff Name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "course";
            this.dataGridViewTextBoxColumn7.HeaderText = "Courses Taught";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "support";
            this.dataGridViewTextBoxColumn8.HeaderText = "Support Sessions";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 552);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 33);
            this.label4.TabIndex = 21;
            this.label4.Text = "All Staffs";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStaff.Location = new System.Drawing.Point(329, 753);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(165, 33);
            this.btnAddStaff.TabIndex = 25;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.ClientSize = new System.Drawing.Size(856, 810);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnViewStaff);
            this.Controls.Add(this.dgvAllStaffs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnViewClient);
            this.Controls.Add(this.dgvAllClients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditCourse);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnViewCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.dgvAllCourses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(786, 595);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Activated += new System.EventHandler(this.Admin_Dashboard_Activated);
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStaffs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAllCourses;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnViewCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAllClients;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnViewClient;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnViewStaff;
        private System.Windows.Forms.DataGridView dgvAllStaffs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}

