using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace SlapsUI
{
    /// <summary>
    /// Interaction logic for Slider.xaml
    /// </summary>
    public partial class UI_Slider4 : MetroWindow
    {
        public UI_Slider4()
        {
            EnsureApplicationResources();
            InitializeComponent();
        }

        public static void EnsureApplicationResources()
        {
            if (Application.Current == null)
            {
                new MyApp() { ShutdownMode = ShutdownMode.OnExplicitShutdown };
            }
        }
        private void Ok_Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
