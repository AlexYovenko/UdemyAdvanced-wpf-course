//**************************************************
//* © 2019 Litera Corp. All Rights Reserved.
//**************************************************

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AdvancedWPFCourse
{
    class CustomStackPanel : StackPanel
    {
        public static DependencyProperty IsBrownColorProperty = DependencyProperty.Register("IsBackgroundBrown", typeof(bool), typeof(CustomStackPanel),
            new PropertyMetadata(false, PropertyChangedCallback, CoerceValueCallback));

        private static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
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

        private static object CoerceValueCallback(DependencyObject d, object basevalue)
        {
            var customStackPanel = d as CustomStackPanel;
            //return !customStackPanel.IsBackgroundBrown ? true : false;
            if (!customStackPanel.IsBackgroundBrown)
            {
                MessageBox.Show("This is true");
                return true;
            }
            else
            {
                MessageBox.Show("This is false");

                return false;
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
