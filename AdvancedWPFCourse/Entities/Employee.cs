//**************************************************
//* © 2019 Litera Corp. All Rights Reserved.
//**************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTrainingApp
{
    public class Employee:INotifyPropertyChanged
    {
        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (value != _firstName)
                {
                    _firstName = value;
                    OnPropertyChanged(nameof(FirstName));
                }
            }
        }
        private string _lastName;

        public string LastName
        {
            get => _lastName;
            set
            {
                if (value != _lastName)
                {
                    _lastName = value;
                    OnPropertyChanged(nameof(LastName));
                }
            }
        }

        public string FullName => $"{FirstName} {LastName}";


        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public Employee()
        {
        }

        public void Execute()
        {
            System.Windows.MessageBox.Show("Execute in Employee");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
