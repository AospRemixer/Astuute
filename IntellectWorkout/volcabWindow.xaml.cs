using System;
using System.Windows;
using System.Windows.Threading;

namespace IntellectWorkout
{
    /// <summary>
    /// Interaction logic for volcabWindow.xaml
    /// </summary>
    public partial class volcabWindow : Window
    {
        public volcabWindow()
        {
            InitializeComponent();
            // THIS IS THE TIMER PART
            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();
            // FUNCTION FOR THE TIMER
            void timer_Tick(object sender, EventArgs e)
            {
                LiveTimeLabel.Content = DateTime.Now.ToString("HH:mm");
            }
        }


        // To Close The App!
        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // To Return To Home Screen!
        private void Back_Button_ClickV(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new();
            mw.Show();
            Close();
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
