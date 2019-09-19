using System;
using System.Collections.Generic;
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

namespace WpfTrainingApp
{
    /// <summary>
    /// Interaction logic for JustTests.xaml
    /// </summary>
    public partial class JustTests : Window
    {
        public JustTests()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string SecondColumnTitle { get; set; } = "This is second";
        public string ThirdColumnTitle { get; set; } = "This is third";
    }
}
