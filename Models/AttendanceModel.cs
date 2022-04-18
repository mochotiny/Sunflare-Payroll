using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_APP.Models
{
    public class AttendanceModel
    {
        public int AttendanceId { get; set; }
        public int BiometricID { get; set; }
        public DateTime WorkedDay { get; set; }
        public TimeSpan StartAt { get; set; }
        public TimeSpan EndAt { get; set; }
        public Decimal NoOfOvertime { get; set; }

    }
}
