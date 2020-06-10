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
using System.IO;
using Microsoft.Win32;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;
namespace fpMixerStudio_WPF_
{
    /// <summary>
    /// Interaction logic for videoSource.xaml
    /// </summary>
    public partial class videoSource : Window
    {
        private bool mediaPlayerIsPlaying = false;
        OpenFileDialog openFileDialog = new OpenFileDialog();
       public Uri vSource;
       public videoSource()



       {

           InitializeComponent();
       }

        private void play_brows_video()
        {
          

            mediaPlayerIsPlaying = true;
        }

        private void Open_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }


       

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
          
        }

        private void Play_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            MainWindow mainWindow = Owner as MainWindow;
       //     e.CanExecute = (mainWindow.video1 != null) && (mainWindow.video1.Source != null);
        }

        private void Play_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MainWindow mainWindow = Owner as MainWindow;
         //   mainWindow.video1.Play();
            mediaPlayerIsPlaying = true;
        }


        private void browsVideo(object sender, RoutedEventArgs e)
        {

            MainWindow mainWindow = Owner as MainWindow;

            openFileDialog.Filter = "Media files (*.mp4;*.mpg;*.mpeg)|*.mp4;*.mpg;*.mpeg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {

                VideoFileName.Text = new Uri(openFileDialog.FileName).ToString();
                vSource = new Uri(openFileDialog.FileName);

            }
          
        }

        private void close(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Hide();
        }

        private void ok(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow mainWindow = Owner as MainWindow;
        
            switch (mainWindow.changeVideoChannel.Content.ToString())
            {
                case "video1":
                     mainWindow.video1.Source = vSource;
                    mainWindow.video1.Play();
                    mainWindow.video_1_PlayBtn.Visibility = Visibility.Collapsed ;
                    mainWindow.video_1_PauseBtn.Visibility = Visibility.Visible;
                    break;

                case "video2":
                    mainWindow.video2.Source = vSource;
                    mainWindow.video2.Play();
                    mainWindow.video_1_PlayBtn2.Visibility = Visibility.Collapsed;
                    mainWindow.video_1_PauseBtn2 .Visibility = Visibility.Visible ;

                    break;

                case "video3":
                    mainWindow.video3.Source = vSource;
                    mainWindow.video3.Play();
                    mainWindow.video_1_PlayBtn3.Visibility = Visibility.Collapsed;
                    mainWindow.video_1_PauseBtn3 .Visibility = Visibility.Visible ;


                    break;

                case "video4":
                    mainWindow.video4.Source = vSource;
                    mainWindow.video4.Play();
                    mainWindow.video_1_PlayBtn4.Visibility = Visibility.Collapsed;
                    mainWindow.video_1_PauseBtn4 .Visibility = Visibility.Visible ;
                    break;

                case "video5":
                    mainWindow.video5.Source = vSource;
                    mainWindow.video5.Play();
                    mainWindow.video_1_PlayBtn5.Visibility = Visibility.Collapsed;
                    mainWindow.video_1_PauseBtn5 .Visibility = Visibility.Visible ;

                    break;

                case "video6":
                    mainWindow.video6.Source = vSource;
                    mainWindow.video6.Play();
                    mainWindow.video_1_PlayBtn6.Visibility = Visibility.Collapsed;
                    mainWindow.video_1_PauseBtn6 .Visibility = Visibility.Visible ;

                    break;

                case "video7":
                    mainWindow.video7.Source = vSource;
                    mainWindow.video7.Play();
                    mainWindow.video_1_PlayBtn7.Visibility = Visibility.Collapsed;
                    mainWindow.video_1_PauseBtn7 .Visibility = Visibility.Visible ;

                    break;

                case "video8":
                    mainWindow.video8.Source = vSource;
                    mainWindow.video8.Play();
                    mainWindow.video_1_PlayBtn8.Visibility = Visibility.Collapsed;
                    mainWindow.video_1_PauseBtn8 .Visibility = Visibility.Visible ;

                    break;

            }


          
            this.Hide();
        }

        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
    }
}
