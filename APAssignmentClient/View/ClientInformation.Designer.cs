namespace APAssignmentClient.View
{
    partial class ClientInformation
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
            this.txtbID = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbAddress = new System.Windows.Forms.TextBox();
            this.txtbEmailAddress = new System.Windows.Forms.TextBox();
            this.txtbContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbBill = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txtbID
            // 
            this.txtbID.Enabled = false;
            this.txtbID.Location = new System.Drawing.Point(118, 16);
            this.txtbID.Name = "txtbID";
            this.txtbID.ReadOnly = true;
            this.txtbID.Size = new System.Drawing.Size(232, 20);
            this.txtbID.TabIndex = 2;
            // 
            // txtbName
            // 
            this.txtbName.Enabled = false;
            this.txtbName.Location = new System.Drawing.Point(118, 42);
            this.txtbName.Name = "txtbName";
            this.txtbName.ReadOnly = true;
            this.txtbName.Size = new System.Drawing.Size(232, 20);
            this.txtbName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // txtbAddress
            // 
            this.txtbAddress.Enabled = false;
            this.txtbAddress.Location = new System.Drawing.Point(118, 68);
            this.txtbAddress.Name = "txtbAddress";
            this.txtbAddress.ReadOnly = true;
            this.txtbAddress.Size = new System.Drawing.Size(232, 20);
            this.txtbAddress.TabIndex = 5;
            // 
            // txtbEmailAddress
            // 
            this.txtbEmailAddress.Enabled = false;
            this.txtbEmailAddress.Location = new System.Drawing.Point(118, 94);
            this.txtbEmailAddress.Name = "txtbEmailAddress";
            this.txtbEmailAddress.ReadOnly = true;
            this.txtbEmailAddress.Size = new System.Drawing.Size(232, 20);
            this.txtbEmailAddress.TabIndex = 6;
            // 
            // txtbContact
            // 
            this.txtbContact.Enabled = false;
            this.txtbContact.Location = new System.Drawing.Point(118, 120);
            this.txtbContact.Name = "txtbContact";
            this.txtbContact.ReadOnly = true;
            this.txtbContact.Size = new System.Drawing.Size(232, 20);
            this.txtbContact.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contact Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Outstanding Bill";
            // 
            // txtbBill
            // 
            this.txtbBill.Enabled = false;
            this.txtbBill.Location = new System.Drawing.Point(118, 146);
            this.txtbBill.Name = "txtbBill";
            this.txtbBill.ReadOnly = true;
            this.txtbBill.Size = new System.Drawing.Size(232, 20);
            this.txtbBill.TabIndex = 11;
            // 
            // ClientInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 187);
            this.Controls.Add(this.txtbBill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbContact);
            this.Controls.Add(this.txtbEmailAddress);
            this.Controls.Add(this.txtbAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.txtbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbAddress;
        private System.Windows.Forms.TextBox txtbEmailAddress;
        private System.Windows.Forms.TextBox txtbContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbBill;
    }
}