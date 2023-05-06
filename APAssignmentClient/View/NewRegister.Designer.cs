namespace APAssignmentClient.View
{
    partial class NewRegister
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbContact = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(38, 28);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // txtbUsername
            // 
            this.txtbUsername.Location = new System.Drawing.Point(128, 25);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(320, 20);
            this.txtbUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(38, 54);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(128, 51);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(320, 20);
            this.txtbPassword.TabIndex = 3;
            this.txtbPassword.UseSystemPasswordChar = true;
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(128, 94);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(320, 20);
            this.txtbName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full Name";
            // 
            // txtbAddress
            // 
            this.txtbAddress.Location = new System.Drawing.Point(128, 120);
            this.txtbAddress.Name = "txtbAddress";
            this.txtbAddress.Size = new System.Drawing.Size(320, 20);
            this.txtbAddress.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(128, 146);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(320, 20);
            this.txtbEmail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contact Number";
            // 
            // txtbContact
            // 
            this.txtbContact.Location = new System.Drawing.Point(128, 172);
            this.txtbContact.Name = "txtbContact";
            this.txtbContact.Size = new System.Drawing.Size(320, 20);
            this.txtbContact.TabIndex = 10;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(41, 209);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(407, 34);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register Account";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // NewRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 260);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbAddress);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtbUsername);
            this.Controls.Add(this.lblUsername);
            this.Name = "NewRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbContact;
        private System.Windows.Forms.Button btnRegister;
    }
}