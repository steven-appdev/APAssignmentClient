using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public interface IBookingModel
    {
        List<Management> RetrieveAllManagement();
        int ManagementID { set; get; }
        String RetrieveSupportSession();
    }
}
