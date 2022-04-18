using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace WFA_APP.Models
{
    
    public class EmployeeModel
    {
        public int BiometricID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeContact { get; set; }
        public string EmployeeAddress { get; set; }
        public int DepartmentID { get; set; }
        public int JobID { get; set; }
        public decimal DailyRate { get; set; }
    }

    //business logic
   
}
