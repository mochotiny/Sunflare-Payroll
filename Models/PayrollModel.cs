using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_APP.Models
{
    public class PayrollModel
    {
        public int PayrollID { get; set; }
        public string EmployeeName { get; set; }
        public int BiometricID { get; set; }
        public decimal DayRate { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public decimal DaysWorked { get; set; }
        public decimal NoOfOT { get; set; }
        public decimal Holiday { get; set; }
        public decimal Adjustments { get; set; }
        public decimal PhilHealth { get; set; }
        public decimal PagIbig { get; set; }
        public decimal SSS { get; set; }
        public decimal LoanOrCA { get; set; }
        public decimal UnderTime { get; set; }
        public decimal Late { get; set; }   
        public decimal Others { get; set; }

    }
}
