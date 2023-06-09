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
    public partial class NewBooking : Form, INewBooking
    {
        NewBookingPresenter presenter;
        public NewBooking()
        {
            InitializeComponent();
        }

        public String GetDuration
        {
            get { return cmbSessionDuration.SelectedItem.ToString();  }
        }

        public DateTime DateTime
        {
            get { return dtSessionDate.Value; }
        }

        public DateTimePicker DateTimePicker
        {
            get { return dtSessionDate; }
        }

        public String SupportSession
        {
            get { return txtbSupportSession.Text; }
            set { txtbSupportSession.Text = value; }
        }

        public ComboBox ManagementName
        {
            get { return cmbManagementName; }
        }

        public ComboBox Duration
        {
            get { return cmbSessionDuration; }
        }

        public void Register(NewBookingPresenter _presenter)
        {
            presenter = _presenter;
        }

        private void NewBooking_Load(object sender, EventArgs e)
        {
            presenter.NewBooking_Load();
            cmbSessionDuration.SelectedIndex = 0;
            dtSessionDate.MinDate = DateTime.Now;
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            presenter.btnConfirmBooking_Click();
        }

        private void cmbManagementName_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.cmbManagementName_SelectedIndexChanged();
        }

        public bool DisplayConfirmationMessage(String msg, String title)
        {
            DialogResult result = MessageBox.Show(msg, title, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        public void DisplayErrorMessage(String msg, String title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void SetManagementNameData(String value, String display, DataTable dt)
        {
            cmbManagementName.ValueMember = value;
            cmbManagementName.DisplayMember = display;
            cmbManagementName.DataSource = dt;
        }

        public void CloseForm()
        {
            this.Close();
        }
    }
}
