using System.Windows;

namespace AdvancedWPFCourse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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
            CustomStackPanel.IsBackgroundBrown = chkBkgColor.IsChecked.Value;
        }

        private void ChkBkgColor_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
