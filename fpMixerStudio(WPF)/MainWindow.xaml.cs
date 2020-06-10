using System.Windows.Media.Animation;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.IO;
using Microsoft.Win32;
using System.Windows.Threading;
using System.Windows.Controls.Primitives;


namespace fpMixerStudio_WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //private void OpenAnotherWindow_Click(object sender, RoutedEventArgs e)
        //{

        //}

        private bool mediaPlayerIsPlaying = false;
        private bool userIsDraggingSlider = false;
        public Uri video1Source;
        public bool liveVideoVar1;
        public bool liveVideoVar2; 
        //WINDOWS POP UPS DEFINATION
        OpenFileDialog openFile = new OpenFileDialog();
        videoSource videoS = new videoSource();
     
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if ((video1.Source != null) && (video1.NaturalDuration.HasTimeSpan))
            {
                video_1_progressbar.Minimum = 0;
                video_1_progressbar.Maximum = video1.NaturalDuration.TimeSpan.TotalSeconds;
                video_1_progressbar.Value = video1.Position.TotalSeconds;

                video_1_slider.Minimum = 0;
                video_1_slider.Maximum = video1.NaturalDuration.TimeSpan.TotalSeconds;
                video_1_slider.Value = video1.Position.TotalSeconds;

            }



            if ((video2.Source != null) && (video2.NaturalDuration.HasTimeSpan))
            {
                video_1_progressbar2.Minimum = 0;
                video_1_progressbar2.Maximum = video2.NaturalDuration.TimeSpan.TotalSeconds;
                video_1_progressbar2.Value = video2.Position.TotalSeconds;

                video_1_slider2.Minimum = 0;
                video_1_slider2.Maximum = video2.NaturalDuration.TimeSpan.TotalSeconds;
                video_1_slider2.Value = video2.Position.TotalSeconds;

            }


            if ((video3.Source != null) && (video3.NaturalDuration.HasTimeSpan))
            {
                video_1_progressbar3.Minimum = 0;
                video_1_progressbar3.Maximum = video3.NaturalDuration.TimeSpan.TotalSeconds;
                video_1_progressbar3.Value = video3.Position.TotalSeconds;

                video_1_slider3.Minimum = 0;
                video_1_slider3.Maximum = video3.NaturalDuration.TimeSpan.TotalSeconds;
                video_1_slider3.Value = video3.Position.TotalSeconds;

            }


            if ((video4.Source != null) && (video4.NaturalDuration.HasTimeSpan))
            {
                video_1_progressbar4.Minimum = 0;
                video_1_progressbar4.Maximum = video4.NaturalDuration.TimeSpan.TotalSeconds;
                video_1_progressbar4.Value = video4.Position.TotalSeconds;

                video_1_slider4.Minimum = 0;
                video_1_slider4.Maximum = video4.NaturalDuration.TimeSpan.TotalSeconds;
                video_1_slider4.Value = video4.Position.TotalSeconds;

            }


            if ((video5.Source != null) && (video5.NaturalDuration.HasTimeSpan))
            {
                video_1_progressbar5.Minimum = 0;
                video_1_progressbar5.Maximum = video5.NaturalDuration.TimeSpan.TotalSeconds;
                video_1_progressbar5.Value = video5.Position.TotalSeconds;

                video_1_slider5.Minimum = 0;
                video_1_slider5.Maximum = video5.NaturalDuration.TimeSpan.TotalSeconds;
                video_1_slider5.Value = video5.Position.TotalSeconds;

            }


            if ((video6.Source != null) && (video6.NaturalDuration.HasTimeSpan))
            {
                video_1_progressbar6.Minimum = 0;
                video_1_progressbar6.Maximum = video6.NaturalDuration.TimeSpan.TotalSeconds;
                video_1_progressbar6.Value = video6.Position.TotalSeconds;

                video_1_slider6.Minimum = 0;
                video_1_slider6.Maximum = video6.NaturalDuration.TimeSpan.TotalSeconds;
                video_1_slider6.Value = video6.Position.TotalSeconds;

            }


            if ((video7.Source != null) && (video7.NaturalDuration.HasTimeSpan))
            {
                video_1_progressbar7.Minimum = 0;
                video_1_progressbar7.Maximum = video7.NaturalDuration.TimeSpan.TotalSeconds;
                video_1_progressbar7.Value = video7.Position.TotalSeconds;

                video_1_slider7.Minimum = 0;
                video_1_slider7.Maximum = video7.NaturalDuration.TimeSpan.TotalSeconds;
                video_1_slider7.Value = video7.Position.TotalSeconds;

            }


            if ((video8.Source != null) && (video8.NaturalDuration.HasTimeSpan))
            {
                video_1_progressbar8.Minimum = 0;
                video_1_progressbar8.Maximum = video8.NaturalDuration.TimeSpan.TotalSeconds;
                video_1_progressbar8.Value = video8.Position.TotalSeconds;

                video_1_slider8.Minimum = 0;
                video_1_slider8.Maximum = video8.NaturalDuration.TimeSpan.TotalSeconds;
                video_1_slider8.Value = video8.Position.TotalSeconds;

            }
        }


      
       



        //<!--0000000000000000000000000000000000000    START OF TOP VIDEO CHANNEL   0000000000000000000000000000000000000000-->

        //<!--START  MEDIA CHANEL 1 (ALL COMAND AND FUNCTIONS)-->
        private void video_1_Play(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (video1.Source != null)
            {
           
                video1.Play();
                video_1_PlayBtn.Visibility = Visibility.Collapsed;
                video_1_PauseBtn.Visibility = Visibility.Visible;
            }
            // Initialize the MediaElement property values.
            InitializePropertyValues();
        }

        // Pause the media.
        private void video_1_Pause(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            video1.Pause();
            video_1_PauseBtn.Visibility = Visibility.Collapsed;
            video_1_PlayBtn.Visibility = Visibility.Visible;

        }
        // Stop the media.
        private void video_1_Stop(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            video1.Stop();
            video_1_PauseBtn.Visibility = Visibility.Collapsed;
            video_1_PlayBtn.Visibility = Visibility.Visible;

        }


        //Change Volume
        private void video_1_Volume(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            video1.Volume = (double)volumeSlider.Value;
        }

        //video Progress codes start
        private void video_1_Open(object sender, RoutedEventArgs e)
        {


        }

        private void video_1_Ended(object sender, RoutedEventArgs e)
        {
            video1.Stop();
            video_1_PauseBtn.Visibility = Visibility.Collapsed;
            video_1_PlayBtn.Visibility = Visibility.Visible;
        }


        private void video_1_slider_DragStarted(object sender, DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
        }

        private void video_1_slider_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            video1.Position = TimeSpan.FromSeconds(video_1_slider.Value);
        }


        private void video_1_Progrss(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           
            txt.Text = TimeSpan.FromSeconds(video_1_progressbar.Value).ToString(@"hh\:mm\:ss") + "/" + video1.NaturalDuration.TimeSpan.Hours.ToString() + ":" + video1.NaturalDuration.TimeSpan.Minutes.ToString() + ":" + video1.NaturalDuration.TimeSpan.Seconds.ToString();


        }
         //Video progress codes ends
        //<!--END  MEDIA CHANEL 1 (ALL COMAND AND FUNCTIONS)-->


        //<!--START  MEDIA CHANEL 2 (ALL COMAND AND FUNCTIONS)-->
        private void video_1_Play2(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (video2.Source != null)
            {
                video2.Play();
                video_1_PlayBtn2.Visibility = Visibility.Collapsed;
                video_1_PauseBtn2.Visibility = Visibility.Visible;
            }
            // Initialize the MediaElement property values.
            InitializePropertyValues();
        }

        // Pause the media.
        private void video_1_Pause2(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            video2.Pause();
            video_1_PauseBtn2.Visibility = Visibility.Collapsed;
            video_1_PlayBtn2.Visibility = Visibility.Visible;

        }
        // Stop the media.
        private void video_1_Stop2(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            video2.Stop();
            video_1_PauseBtn2.Visibility = Visibility.Collapsed;
            video_1_PlayBtn2.Visibility = Visibility.Visible;

        }


        //Change Volume
        private void video_1_Volume2(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            video2.Volume = (double)volumeSlider2.Value;
        }

        //video Progress codes start
    

        private void video_1_Ended2(object sender, RoutedEventArgs e)
        {
            video2.Stop();
            video_1_PauseBtn2.Visibility = Visibility.Collapsed;
            video_1_PlayBtn2.Visibility = Visibility.Visible;
        }


        private void video_1_slider_DragStarted2(object sender, DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
        }

        private void video_1_slider_DragCompleted2(object sender, DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            video2.Position = TimeSpan.FromSeconds(video_1_slider2.Value);
        }


        private void video_1_Progrss2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //video1.Position = TimeSpan.FromSeconds(video_1_slider.Value);

            txt2.Text = TimeSpan.FromSeconds(video_1_progressbar2.Value).ToString(@"hh\:mm\:ss") + "/" + video2.NaturalDuration.TimeSpan.Hours.ToString() + ":" + video2.NaturalDuration.TimeSpan.Minutes.ToString() + ":" + video2.NaturalDuration.TimeSpan.Seconds.ToString();


        }



        //Video progress codes ends

        //<!--END  MEDIA CHANEL 2 (ALL COMAND AND FUNCTIONS)-->

        //<!--END  MEDIA CHANEL 2-->



        //<!--START  MEDIA CHANEL 3 (ALL COMAND AND FUNCTIONS)-->
        private void video_1_Play3(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (video3.Source != null)
            {
                video3.Play();
                video_1_PlayBtn3.Visibility = Visibility.Collapsed;
                video_1_PauseBtn3.Visibility = Visibility.Visible;
            }
            // Initialize the MediaElement property values.
            InitializePropertyValues();
        }

        // Pause the media.
        private void video_1_Pause3(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            video3.Pause();
            video_1_PauseBtn3.Visibility = Visibility.Collapsed;
            video_1_PlayBtn3.Visibility = Visibility.Visible;

        }
        // Stop the media.
        private void video_1_Stop3(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            video3.Stop();
            video_1_PauseBtn3.Visibility = Visibility.Collapsed;
            video_1_PlayBtn3.Visibility = Visibility.Visible;

        }


        //Change Volume
        private void video_1_Volume3(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            video3.Volume = (double)volumeSlider2.Value;
        }

        //video Progress codes start


        private void video_1_Ended3(object sender, RoutedEventArgs e)
        {
            video3.Stop();
            video_1_PauseBtn3.Visibility = Visibility.Collapsed;
            video_1_PlayBtn3.Visibility = Visibility.Visible;
        }


        private void video_1_slider_DragStarted3(object sender, DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
        }

        private void video_1_slider_DragCompleted3(object sender, DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            video3.Position = TimeSpan.FromSeconds(video_1_slider3.Value);
        }


        private void video_1_Progrss3(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //video1.Position = TimeSpan.FromSeconds(video_1_slider.Value);

            txt3.Text = TimeSpan.FromSeconds(video_1_progressbar3.Value).ToString(@"hh\:mm\:ss") + "/" + video3.NaturalDuration.TimeSpan.Hours.ToString() + ":" + video3.NaturalDuration.TimeSpan.Minutes.ToString() + ":" + video3.NaturalDuration.TimeSpan.Seconds.ToString();


        }



        //Video progress codes ends

        //<!--END  MEDIA CHANEL 3 (ALL COMAND AND FUNCTIONS)-->

        //<!--END  MEDIA CHANEL 3-->

        //<!--START  MEDIA CHANEL 4 (ALL COMAND AND FUNCTIONS)-->
        private void video_1_Play4(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (video4.Source != null)
            {
                video4.Play();
                video_1_PlayBtn4.Visibility = Visibility.Collapsed;
                video_1_PauseBtn4.Visibility = Visibility.Visible;
            }
            // Initialize the MediaElement property values.
            InitializePropertyValues();
        }

        // Pause the media.
        private void video_1_Pause4(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            video4.Pause();
            video_1_PauseBtn4.Visibility = Visibility.Collapsed;
            video_1_PlayBtn4.Visibility = Visibility.Visible;

        }
        // Stop the media.
        private void video_1_Stop4(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            video4.Stop();
            video_1_PauseBtn4.Visibility = Visibility.Collapsed;
            video_1_PlayBtn4.Visibility = Visibility.Visible;

        }


        //Change Volume
        private void video_1_Volume4(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            video4.Volume = (double)volumeSlider4.Value;
        }

        //video Progress codes start


        private void video_1_Ended4(object sender, RoutedEventArgs e)
        {
            video4.Stop();
            video_1_PauseBtn4.Visibility = Visibility.Collapsed;
            video_1_PlayBtn4.Visibility = Visibility.Visible;
        }


        private void video_1_slider_DragStarted4(object sender, DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
        }

        private void video_1_slider_DragCompleted4(object sender, DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            video4.Position = TimeSpan.FromSeconds(video_1_slider4.Value);
        }


        private void video_1_Progrss4(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //video1.Position = TimeSpan.FromSeconds(video_1_slider.Value);

            txt4.Text = TimeSpan.FromSeconds(video_1_progressbar4.Value).ToString(@"hh\:mm\:ss") + "/" + video4.NaturalDuration.TimeSpan.Hours.ToString() + ":" + video4.NaturalDuration.TimeSpan.Minutes.ToString() + ":" + video4.NaturalDuration.TimeSpan.Seconds.ToString();


        }



        //Video progress codes ends

        //<!--END  MEDIA CHANEL 4 (ALL COMAND AND FUNCTIONS)-->

        //<!--END  MEDIA CHANEL 4-->



        //<!--0000000000000000000000000000000000000    END OF TOP VIDEO CHANNEL   0000000000000000000000000000000000000000-->

        
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
       
        //<!--0000000000000000000000000000000000000    START OF BUTTOM VIDEO CHANNEL   0000000000000000000000000000000000000000-->
        //<!--START  MEDIA CHANEL 5 (ALL COMAND AND FUNCTIONS)-->
        private void video_1_Play5(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (video5.Source != null)
            {

                video5.Play();
                video_1_PlayBtn5.Visibility = Visibility.Collapsed;
                video_1_PauseBtn5.Visibility = Visibility.Visible;
            }
            // Initialize the MediaElement property values.
            InitializePropertyValues();
        }

        // Pause the media.
        private void video_1_Pause5(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            video5.Pause();
            video_1_PauseBtn5.Visibility = Visibility.Collapsed;
            video_1_PlayBtn5.Visibility = Visibility.Visible;

        }
        // Stop the media.
        private void video_1_Stop5(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            video5.Stop();
            video_1_PauseBtn5.Visibility = Visibility.Collapsed;
            video_1_PlayBtn5.Visibility = Visibility.Visible;

        }


        //Change Volume
        private void video_1_Volume5(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            video5.Volume = (double)volumeSlider5.Value;
        }

  
        private void video_1_Ended5(object sender, RoutedEventArgs e)
        {
            video5.Stop();
            video_1_PauseBtn5.Visibility = Visibility.Collapsed;
            video_1_PlayBtn5.Visibility = Visibility.Visible;
        }


        private void video_1_slider_DragStarted5(object sender, DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
        }

        private void video_1_slider_DragCompleted5(object sender, DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            video5.Position = TimeSpan.FromSeconds(video_1_slider5.Value);
        }


        private void video_1_Progrss5(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            txt5.Text = TimeSpan.FromSeconds(video_1_progressbar5.Value).ToString(@"hh\:mm\:ss") + "/" + video5.NaturalDuration.TimeSpan.Hours.ToString() + ":" + video5.NaturalDuration.TimeSpan.Minutes.ToString() + ":" + video5.NaturalDuration.TimeSpan.Seconds.ToString();


        }
        //Video progress codes ends
        //<!--END  MEDIA CHANEL 5 (ALL COMAND AND FUNCTIONS)-->


        //<!--START  MEDIA CHANEL 6 (ALL COMAND AND FUNCTIONS)-->
        private void video_1_Play6(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (video6.Source != null)
            {
                video6.Play();
                video_1_PlayBtn6.Visibility = Visibility.Collapsed;
                video_1_PauseBtn6.Visibility = Visibility.Visible;
            }
            // Initialize the MediaElement property values.
            InitializePropertyValues();
        }

        // Pause the media.
        private void video_1_Pause6(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            video6.Pause();
            video_1_PauseBtn6.Visibility = Visibility.Collapsed;
            video_1_PlayBtn6.Visibility = Visibility.Visible;

        }
        // Stop the media.
        private void video_1_Stop6(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            video6.Stop();
            video_1_PauseBtn6.Visibility = Visibility.Collapsed;
            video_1_PlayBtn6.Visibility = Visibility.Visible;

        }


        //Change Volume
        private void video_1_Volume6(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            video6.Volume = (double)volumeSlider6.Value;
        }

        //video Progress codes start


        private void video_1_Ended6(object sender, RoutedEventArgs e)
        {
            video6.Stop();
            video_1_PauseBtn6.Visibility = Visibility.Collapsed;
            video_1_PlayBtn6.Visibility = Visibility.Visible;
        }


        private void video_1_slider_DragStarted6(object sender, DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
        }

        private void video_1_slider_DragCompleted6(object sender, DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            video6.Position = TimeSpan.FromSeconds(video_1_slider6.Value);
        }


        private void video_1_Progrss6(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //video1.Position = TimeSpan.FromSeconds(video_1_slider.Value);

            txt6.Text = TimeSpan.FromSeconds(video_1_progressbar6.Value).ToString(@"hh\:mm\:ss") + "/" + video6.NaturalDuration.TimeSpan.Hours.ToString() + ":" + video6.NaturalDuration.TimeSpan.Minutes.ToString() + ":" + video6.NaturalDuration.TimeSpan.Seconds.ToString();


        }



        //Video progress codes ends

        //<!--END  MEDIA CHANEL 6 (ALL COMAND AND FUNCTIONS)-->

        //<!--END  MEDIA CHANEL 6-->



        //<!--START  MEDIA CHANEL 7 (ALL COMAND AND FUNCTIONS)-->
        private void video_1_Play7(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (video7.Source != null)
            {
                video7.Play();
                video_1_PlayBtn7.Visibility = Visibility.Collapsed;
                video_1_PauseBtn7.Visibility = Visibility.Visible;
            }
            // Initialize the MediaElement property values.
            InitializePropertyValues();
        }

        // Pause the media.
        private void video_1_Pause7(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            video7.Pause();
            video_1_PauseBtn7.Visibility = Visibility.Collapsed;
            video_1_PlayBtn7.Visibility = Visibility.Visible;

        }
        // Stop the media.
        private void video_1_Stop7(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            video7.Stop();
            video_1_PauseBtn7.Visibility = Visibility.Collapsed;
            video_1_PlayBtn7.Visibility = Visibility.Visible;

        }


        //Change Volume
        private void video_1_Volume7(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            video7.Volume = (double)volumeSlider7.Value;
        }

        //video Progress codes start


        private void video_1_Ended7(object sender, RoutedEventArgs e)
        {
            video3.Stop();
            video_1_PauseBtn7.Visibility = Visibility.Collapsed;
            video_1_PlayBtn7.Visibility = Visibility.Visible;
        }


        private void video_1_slider_DragStarted7(object sender, DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
        }

        private void video_1_slider_DragCompleted7(object sender, DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            video7.Position = TimeSpan.FromSeconds(video_1_slider7.Value);
        }


        private void video_1_Progrss7(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //video1.Position = TimeSpan.FromSeconds(video_1_slider.Value);

            txt7.Text = TimeSpan.FromSeconds(video_1_progressbar7.Value).ToString(@"hh\:mm\:ss") + "/" + video7.NaturalDuration.TimeSpan.Hours.ToString() + ":" + video7.NaturalDuration.TimeSpan.Minutes.ToString() + ":" + video7.NaturalDuration.TimeSpan.Seconds.ToString();


        }



        //Video progress codes ends

        //<!--END  MEDIA CHANEL 7 (ALL COMAND AND FUNCTIONS)-->

        //<!--END  MEDIA CHANEL 7-->

        //<!--START  MEDIA CHANEL 8 (ALL COMAND AND FUNCTIONS)-->
        private void video_1_Play8(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (video8.Source != null)
            {
                video8.Play();
                video_1_PlayBtn8.Visibility = Visibility.Collapsed;
                video_1_PauseBtn8.Visibility = Visibility.Visible;
            }
            // Initialize the MediaElement property values.
            InitializePropertyValues();
        }

        // Pause the media.
        private void video_1_Pause8(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            video8.Pause();
            video_1_PauseBtn8.Visibility = Visibility.Collapsed;
            video_1_PlayBtn8.Visibility = Visibility.Visible;

        }
        // Stop the media.
        private void video_1_Stop8(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            video8.Stop();
            video_1_PauseBtn8.Visibility = Visibility.Collapsed;
            video_1_PlayBtn8.Visibility = Visibility.Visible;

        }


        //Change Volume
        private void video_1_Volume8(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            video8.Volume = (double)volumeSlider8.Value;
        }

        //video Progress codes start


        private void video_1_Ended8(object sender, RoutedEventArgs e)
        {
            video8.Stop();
            video_1_PauseBtn8.Visibility = Visibility.Collapsed;
            video_1_PlayBtn8.Visibility = Visibility.Visible;
        }


        private void video_1_slider_DragStarted8(object sender, DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
        }

        private void video_1_slider_DragCompleted8(object sender, DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            video8.Position = TimeSpan.FromSeconds(video_1_slider8.Value);
        }


        private void video_1_Progrss8(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //video1.Position = TimeSpan.FromSeconds(video_1_slider.Value);

            txt8.Text = TimeSpan.FromSeconds(video_1_progressbar8.Value).ToString(@"hh\:mm\:ss") + "/" + video8.NaturalDuration.TimeSpan.Hours.ToString() + ":" + video8.NaturalDuration.TimeSpan.Minutes.ToString() + ":" + video8.NaturalDuration.TimeSpan.Seconds.ToString();


        }



        //Video progress codes ends

        //<!--END  MEDIA CHANEL 4 (ALL COMAND AND FUNCTIONS)-->

        //<!--END  MEDIA CHANEL 4-->
        //<!--0000000000000000000000000000000000000    END OF BUTTOM VIDEO CHANNEL   0000000000000000000000000000000000000000-->



        void InitializePropertyValues()
        {

        }


        //START OF TOP=================SELECT VIDEO SOURCE 

        private void selectVideo1(object sender, RoutedEventArgs e)
        {
            changeVideoChannel.Content = "video1";
            videoSource videoSource = new videoSource();
            videoSource.Owner = this;
            
            videoSource.ShowDialog();
            

        }

    

        private void selectVideo2(object sender, RoutedEventArgs e)
        {
            changeVideoChannel.Content = "video2";
            videoSource videoSource = new videoSource();
            videoSource.Owner = this;
            videoSource.ShowDialog();
        }

        private void selectVideo3(object sender, RoutedEventArgs e)
        {
            changeVideoChannel.Content = "video3";
            videoSource videoSource = new videoSource();
            videoSource.Owner = this;
            videoSource.ShowDialog();
        }

        private void selectVideo4(object sender, RoutedEventArgs e)
        {
            changeVideoChannel.Content = "video4";
            videoSource videoSource = new videoSource();
            videoSource.Owner = this;
            videoSource.ShowDialog();
        }



        //END OF TOP=================SELECT VIDEO SOURCE 

        //START OF BUTTOM=================SELECT VIDEO SOURCE 

        private void selectVideo5(object sender, RoutedEventArgs e)
        {
            changeVideoChannel.Content = "video5";
            videoSource videoSource = new videoSource();
            videoSource.Owner = this;
            videoSource.ShowDialog();

        }



        private void selectVideo6(object sender, RoutedEventArgs e)
        {
            changeVideoChannel.Content = "video6";
            videoSource videoSource = new videoSource();
            videoSource.Owner = this;
            videoSource.ShowDialog();
        }

        private void selectVideo7(object sender, RoutedEventArgs e)
        {
            changeVideoChannel.Content = "video7";
            videoSource videoSource = new videoSource();
            videoSource.Owner = this;
            videoSource.ShowDialog();
        }

        private void selectVideo8(object sender, RoutedEventArgs e)
        {
            changeVideoChannel.Content = "video8";
            videoSource videoSource = new videoSource();
            videoSource.Owner = this;
            videoSource.ShowDialog();
        }

        //END OF BUTTOM=================SELECT VIDEO SOURCE 



        private void showVideoControl(object sender, MouseEventArgs e)
        {
            if (video1Source == null)
            {
                if (VideoMixControl1.IsMouseOver == true)
                {
                    VideoMixControl1.Opacity = 0;
                }
            }

        }

        private void sendVideo_1_Live(object sender, RoutedEventArgs e)
        {
            if (LiveVideo.Source == null)
            {
                LiveVideo2.Opacity = 0;
                LiveVideo.Opacity = 100;
                LiveVideo.Source = video1.Source;
               
            }
            else
            {
                LiveVideo.Opacity = 0;
                LiveVideo2.Opacity = 100;
                LiveVideo2.Source = video1.Source;
               
            }
          

        }

        private void sendVideo_2_Live(object sender, RoutedEventArgs e)
        {
            if (LiveVideo.Source == null)
            {
                LiveVideo2.Opacity = 0;
                LIVE.Opacity = 0;
                LiveVideo.Opacity = 100;
                LiveVideo.Source = video2.Source;
                LiveVideo2.Source = null;

            }
            else
            {
                LiveVideo.Opacity = 0;
                LiveVideo2.Opacity = 100;
                LiveVideo2.Source = video2.Source;
                LiveVideo.Source = null;

            }
        }

        private void sendVideo_3_Live(object sender, RoutedEventArgs e)
        {
            LiveVideo.Source = video3.Source;
        }

        private void sendVideo_4_Live(object sender, RoutedEventArgs e)
        {
            LiveVideo.Source = video4.Source;
        }

        private void sendVideo_5_Live(object sender, RoutedEventArgs e)
        {
            LiveVideo.Source = video5.Source;
        }

        private void sendVideo_6_Live(object sender, RoutedEventArgs e)
        {
            LiveVideo.Source = video6.Source;
        }

        private void sendVideo_7_Live(object sender, RoutedEventArgs e)
        {
            LiveVideo.Source = video7.Source;
        }

        private void sendVideo_8_Live(object sender, RoutedEventArgs e)
        {
            LiveVideo.Source = video8.Source;
        }

        

    }
}


