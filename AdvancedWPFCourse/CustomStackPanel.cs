//**************************************************
//* © 2019 Litera Corp. All Rights Reserved.
//**************************************************

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfTrainingApp
{
    class CustomStackPanel : StackPanel
    {
        public static DependencyProperty IsBrownColorProperty = DependencyProperty.Register("IsBackgroundBrown", typeof(bool), typeof(CustomStackPanel), new PropertyMetadata(false,OnIsBackgroundBrown));

        private static void OnIsBackgroundBrown(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var customStackPanel = d as CustomStackPanel;
            if (customStackPanel.IsBackgroundBrown)
            {
                customStackPanel.Background = Brushes.BurlyWood;
            }
            else
            {
                customStackPanel.Background = Brushes.Brown;
            }
        }

        public bool IsBackgroundBrown
        {
            get
            {
                return (bool)GetValue(IsBrownColorProperty);
            }

            set { SetValue(IsBrownColorProperty, value); }
        }
    }
}
