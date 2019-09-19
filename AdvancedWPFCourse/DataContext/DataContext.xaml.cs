using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WpfTrainingApp.DataContext
{
    /// <summary>
    /// Interaction logic for DataContext.xaml
    /// </summary>
    public partial class DataContext : Window, INotifyPropertyChanged
    {
        SampleData sampleData = new SampleData();

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private bool _isButtonVisible;
        public bool IsButtonVisible
        {
            get => _isButtonVisible;
            set
            {
                _isButtonVisible = value;
                OnPropertyChanged();
            }
        }


        public DataContext()
        {
            InitializeComponent();
            //  this.DataContext = this;
        }

        public ObservableCollection<Employee> Employees => sampleData.Employees;
        public ObservableCollection<EmployeeEx> EmployeesEx => sampleData.EmployeesEx;

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            sampleData.Employees.First().FirstName = "code changed";
            sampleData.Employees.First().LastName = "code changed";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IsButtonVisible = !IsButtonVisible;
        }
    }
}
