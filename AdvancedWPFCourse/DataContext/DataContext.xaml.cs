﻿using AdvancedWPFCourse;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace WpfTrainingApp.DataContext
{
    /// <summary>
    /// Interaction logic for DataContext.xaml
    /// </summary>
    public partial class DataContext : Window
    {
        SampleData sampleData = new SampleData();

        public DataContext()
        {
            InitializeComponent();
          //  this.DataContext = this;
        }

        public ObservableCollection<Employee> Employees
        {
            get { return sampleData.Employees; }

        }
        public ObservableCollection<EmployeeEx> EmployeesEx
        {
            get { return sampleData.EmployeesEx; }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            sampleData.Employees.First().FirstName = "code changed";
            sampleData.Employees.First().LastName = "code changed";

        }
    }
}
