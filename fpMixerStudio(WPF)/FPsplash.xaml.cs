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
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Threading;
using System.Windows.Controls.Primitives;
namespace fpMixerStudio_WPF_
{
    /// <summary>
    /// Interaction logic for FPsplash.xaml
    /// </summary>
    public partial class FPsplash : Window
    {
       
        public FPsplash()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
             timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
                 }
  
        private void move_object(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void showMain(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow IndexForm = new MainWindow();
            IndexForm.Show();
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {

        }
         private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

                     
        
        }

       
       
    }
}
