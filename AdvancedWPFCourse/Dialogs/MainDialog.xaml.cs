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
using Microsoft.Win32;
using System.Diagnostics;

namespace WpfTrainingApp.Dialogs
{
    /// <summary>
    /// Interaction logic for MainDialog.xaml
    /// </summary>
    public partial class MainDialog : Window
    {
        public MainDialog()
        {
            InitializeComponent();
        }

        private void cmbState_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var state = ((ComboBoxItem) cmbState.SelectedItem).Content.ToString();
            if (state.Equals("Alabama"))
            {
                var zipDialog = new GetZipDialog();
                if (zipDialog.ShowDialog() == true)
                {
                    lblZip.Content = zipDialog.ZipCode;
                }
            }
            else
            {
                lblZip.Content = string.Empty;
            }
        }

        private void BtnOpenFileDialog_OnClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Process.Start(openFileDialog.FileName);
            }
        }

       
    }
}
