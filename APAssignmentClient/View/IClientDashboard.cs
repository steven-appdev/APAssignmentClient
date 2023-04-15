using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClient
{
    public interface IClientDashboard
    {
        String username { get; set; }
        DataGridView enrolledCourses { get; }
        DataGridView BookedSession { get; }
        Object GetSelectedValue { get; }
        Object GetSelectedBookingID { get; }
        bool ViewCourse { get; set; }
        bool dropCourse { get; set; }
        void Register(ClientDashboardPresenter presenter);
    }
}
