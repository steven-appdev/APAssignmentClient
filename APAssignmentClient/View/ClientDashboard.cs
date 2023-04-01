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

    public partial class ClientDashboard : Form, IClientDashboardView
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

        public void register(ClientDashboardPresenter _presenter)
        {
            presenter = _presenter;
        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            presenter.ChangeClientName();
        }
    }
}
