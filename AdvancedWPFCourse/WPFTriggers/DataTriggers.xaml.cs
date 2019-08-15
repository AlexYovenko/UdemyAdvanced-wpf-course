using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfTrainingApp.WPFTriggers
{
    /// <summary>
    /// Interaction logic for DataTriggers.xaml
    /// </summary>
    public partial class DataTriggers : Window
    {
        public DataTriggers()
        {
            InitializeComponent();
        }

        SampleData sampleData = new SampleData();

    

        public ObservableCollection<Employee> Employees
        {
            get { return sampleData.Employees; }

        }
    }
}
