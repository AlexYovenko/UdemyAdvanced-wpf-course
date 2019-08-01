//**************************************************
//* © 2019 Litera Corp. All Rights Reserved.
//**************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedWPFCourse
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format($"{FirstName} {LastName}");
        }

        public Employee()
        {
        }

        public void Execute()
        {
            System.Windows.MessageBox.Show("Execute in Employee");
        }
    }
}
