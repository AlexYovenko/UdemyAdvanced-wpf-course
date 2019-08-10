//**************************************************
//* © 2019 Litera Corp. All Rights Reserved.
//**************************************************

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedWPFCourse;

namespace WpfTrainingApp
{
    public class SampleData
    {
        public ObservableCollection<Employee> Employees = new ObservableCollection<Employee>()
        {
            new Employee(){FirstName = "Alex",LastName = "Yovenko"},
            new Employee(){FirstName = "Ivan", LastName = "Pikuza"},
            new Employee(){FirstName = "Alexsey", LastName = "Frolov"}
        };


        public ObservableCollection<EmployeeEx> EmployeesEx = new ObservableCollection<EmployeeEx>()
        {
            new EmployeeEx(){FirstName = "AlexEx",LastName = "YovenkoEx"},
            new EmployeeEx(){FirstName = "IvanEx", LastName = "PikuzaEx"},
            new EmployeeEx(){FirstName = "AlexseyEx", LastName = "FrolovEx"}
        };

        public SampleData()
        {
            
        }
    }
}
