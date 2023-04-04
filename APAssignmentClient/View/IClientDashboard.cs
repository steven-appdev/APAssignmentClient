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
        Object GetSelectedValue { get; }
        bool dropCourse { get; set; }
        void Register(ClientDashboardPresenter presenter);
    }
}
