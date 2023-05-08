using APAssignmentClient.Presenter;
using APAssignmentClient.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClientUnitTest.Mocs.Screen_Mocs
{
    public class NewBookingMoc : INewBooking
    {
        public String GetDuration { get; }
        public DateTime DateTime { get; }
        public String SupportSession { get; set; }
        public ComboBox ManagementName { get; }
        public ComboBox Duration { get; }
        public String Message { get; set; }
        public String MessageTitle { get; set; }
        public String ErrorMsg { get; set; }
        public String ErrorTitle { get; set; }
        public DataTable ManagementNameData { get; set; }
        public bool FormClosed { get; set; }

        public void Register(NewBookingPresenter _presenter) { }
        public bool DisplayConfirmationMessage(String msg, String title)
        {
            Message = msg;
            MessageTitle = title;
            return true;
        }

        public void DisplayErrorMessage(String msg, String title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void SetManagementNameData(String value, String display, DataTable dt)
        {
            ManagementNameData = dt;
        }

        public void CloseForm()
        {
            FormClosed = true;
        }
    }
}
