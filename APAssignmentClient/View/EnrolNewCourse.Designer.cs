namespace APAssignmentClient.View
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
            this.btnEnrol = new System.Windows.Forms.Button();
            this.btnViewCourseDescription = new System.Windows.Forms.Button();
            this.dgvAvailableCourses = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnrol
            // 
            this.btnEnrol.Location = new System.Drawing.Point(580, 269);
            this.btnEnrol.Name = "btnEnrol";
            this.btnEnrol.Size = new System.Drawing.Size(141, 34);
            this.btnEnrol.TabIndex = 1;
            this.btnEnrol.Text = "Enrol Course";
            this.btnEnrol.UseVisualStyleBackColor = true;
            this.btnEnrol.Click += new System.EventHandler(this.btnEnrol_Click);
            // 
            // btnViewCourseDescription
            // 
            this.btnViewCourseDescription.Location = new System.Drawing.Point(433, 269);
            this.btnViewCourseDescription.Name = "btnViewCourseDescription";
            this.btnViewCourseDescription.Size = new System.Drawing.Size(141, 34);
            this.btnViewCourseDescription.TabIndex = 2;
            this.btnViewCourseDescription.Text = "View Course Description";
            this.btnViewCourseDescription.UseVisualStyleBackColor = true;
            this.btnViewCourseDescription.Click += new System.EventHandler(this.btnViewCourseDescription_Click);
            // 
            // dgvAvailableCourses
            // 
            this.dgvAvailableCourses.AllowUserToAddRows = false;
            this.dgvAvailableCourses.AllowUserToDeleteRows = false;
            this.dgvAvailableCourses.AllowUserToResizeColumns = false;
            this.dgvAvailableCourses.AllowUserToResizeRows = false;
            this.dgvAvailableCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmName,
            this.clmType,
            this.clmDuration,
            this.clmPrice});
            this.dgvAvailableCourses.Location = new System.Drawing.Point(11, 12);
            this.dgvAvailableCourses.MultiSelect = false;
            this.dgvAvailableCourses.Name = "dgvAvailableCourses";
            this.dgvAvailableCourses.ReadOnly = true;
            this.dgvAvailableCourses.RowHeadersVisible = false;
            this.dgvAvailableCourses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAvailableCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableCourses.Size = new System.Drawing.Size(710, 251);
            this.dgvAvailableCourses.TabIndex = 3;
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "id";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Width = 50;
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmName.DataPropertyName = "name";
            this.clmName.HeaderText = "Course Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmType
            // 
            this.clmType.DataPropertyName = "type";
            this.clmType.HeaderText = "Course Type";
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            this.clmType.Width = 150;
            // 
            // clmDuration
            // 
            this.clmDuration.DataPropertyName = "duration";
            this.clmDuration.HeaderText = "Duration";
            this.clmDuration.Name = "clmDuration";
            this.clmDuration.ReadOnly = true;
            this.clmDuration.Width = 70;
            // 
            // clmPrice
            // 
            this.clmPrice.DataPropertyName = "price";
            this.clmPrice.HeaderText = "Price";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            // 
            // EnrolNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 315);
            this.Controls.Add(this.dgvAvailableCourses);
            this.Controls.Add(this.btnViewCourseDescription);
            this.Controls.Add(this.btnEnrol);
            this.Name = "EnrolNewCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrol New Courses";
            this.Load += new System.EventHandler(this.EnrolNewCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEnrol;
        private System.Windows.Forms.Button btnViewCourseDescription;
        private System.Windows.Forms.DataGridView dgvAvailableCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
    }
}