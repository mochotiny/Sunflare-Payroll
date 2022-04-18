using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_APP.View.Modules.Attendance;
using WFA_APP.Models;

namespace WFA_APP.Presenter
{
    public class AttendancePresenter
    {
        private AttendanceModel attendanceModel;
        private AttendanceForm attendanceForm;
        public AttendancePresenter(AttendanceModel attendanceModel, AttendanceForm attendanceForm)
        {
            this.attendanceModel = attendanceModel;
            this.attendanceForm = attendanceForm;

            attendanceForm.Presenter = this;
        }
    }

}
