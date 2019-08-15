using System.Windows;
namespace WpfTrainingApp.WPFTriggers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DependecyPropertyTriggers : Window
    {
        public DependecyPropertyTriggers()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Execute_Clicked(object sender, RoutedEventArgs e)
        {
            var employee = new Employee();
            employee.Execute();

        }

        private void ChkBkgColor_OnClick(object sender, RoutedEventArgs e)
        {
            //CustomStackPanel.IsBackgroundBrown = chkBkgColor.IsChecked.Value;

            if (chkBkgColor.IsChecked.Value == true)
            {
                customStackPanel.IsBackgroundBrown = true;
            }
            else
            {
                customStackPanel.IsBackgroundBrown = false;
            }

        }

    }
}
