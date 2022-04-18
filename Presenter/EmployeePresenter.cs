using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_APP.Models;
using WFA_APP.View.Modules.Employee;

namespace WFA_APP.Presenter
{
    public class EmployeePresenter
    {
        private EmployeeModel employeeModel;
        private EmployeeForm employeeForm;

        public EmployeePresenter(EmployeeModel employeeModel, EmployeeForm employeeForm)
        {
            this.employeeModel = employeeModel;
            this.employeeForm = employeeForm;

            employeeForm.Presenter = this;
        }
    }
}
