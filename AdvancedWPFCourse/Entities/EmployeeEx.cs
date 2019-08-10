
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
    public class EmployeeEx
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public EmployeeEx()
        {
        }

        public void Execute()
        {
            System.Windows.MessageBox.Show("Execute in Employee");
        }
    }
}
