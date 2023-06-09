﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APAssignmentClient.Presenter;

namespace APAssignmentClient.View
{
    public partial class ClientInformation : Form, IClientInformation
    {
        private ClientInformationPresenter presenter;
        public ClientInformation()
        {
            InitializeComponent();
        }

        public void Register(ClientInformationPresenter _presenter)
        {
            presenter = _presenter;
        }

        public String ClientID
        {
            set { txtbID.Text = value; }
            get { return txtbID.Text; }
        }

        public String ClientName
        {
            set { txtbName.Text = value; }
            get { return txtbName.Text; }
        }

        public String ClientAddress
        {
            set { txtbAddress.Text = value; }
            get { return txtbAddress.Text; }
        }

        public String ClientEmailAddress
        {
            set { txtbEmailAddress.Text = value; }
            get { return txtbEmailAddress.Text; }
        }

        public String ClientContactNumber
        {
            set { txtbContact.Text = value; }
            get { return txtbContact.Text; }
        }

        public String ClientBill
        {
            set { txtbBill.Text = value; }
            get { return txtbBill.Text; }
        }

        public void DisplayErrorMessage(String msg, String title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void CloseForm()
        {
            this.Close();
        }
    }
}
