using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClient
{
    public interface INewBooking
    {
        String GetDuration { get; }
        DateTime DateTime { get; }
        String SupportSession { get; set; }
        ComboBox ManagementName { get; }
        ComboBox Duration { get; }
        void Register(NewBookingPresenter _presenter);
        void AddName(String name);
    }
}
