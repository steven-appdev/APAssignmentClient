using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClient
{
    //Client Dashboard (View)

    public partial class ClientDashboard : Form, IClientDashboard
    {
        ClientDashboardPresenter presenter;

        public ClientDashboard()
        {
            InitializeComponent();
        }

        public String username
        {
            set { lblUsername.Text = value; }
            get { return lblUsername.Text; }
        }

        public ListBox enrolledCourses
        {
            get { return lsbEnrolledCourses;}
        }

        public void Register(ClientDashboardPresenter _presenter)
        {
            presenter = _presenter;
        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            presenter.ChangeClientName();
        }

        private void btnEnrolNew_Click(object sender, EventArgs e)
        {
            presenter.btnEnrolNew_Click();
        }

        private void ClientDashboard_Activated(object sender, EventArgs e)
        {
            presenter.ClientDashboard_Activated();
        }
    }
}
