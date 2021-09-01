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
using System.Windows.Threading;

namespace IntellectWorkout
{
    /// <summary>
    /// Interaction logic for spatialQuestions.xaml
    /// </summary>
    public partial class spatialQuestions : Window
    {
        public static int fsM = 0;

        public spatialQuestions()
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

        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Back_Button_ClickM(object sender, RoutedEventArgs e)
        {
            spatialWindow sw = new();
            sw.Show();
            Close();
        }

        // TO HELP DRAG MOVE THE APP
        private void spatialQuestions_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void FullscreenButton_Click(object sender, RoutedEventArgs e)
        {
            if (fsM == 0)
            {
                this.WindowState = WindowState.Maximized;
                fsText.Text = "Minimize";
                fsM = 1;
            }
            else if (fsM == 1)
            {
                this.WindowState = WindowState.Normal;
                fsText.Text = "Fullscreen";
                fsM = 0;
            }
        }
    }
}
