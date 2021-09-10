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
    /// Interaction logic for reasoningWindow.xaml
    /// </summary>
    public partial class reasoningWindow : Window
    {
        // Starts this window!
        public reasoningWindow()
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

        // To close this app!
        private void Exit_Button_Reasoning(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // To go back a window!
        private void Back_Button_ClickR(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new();
            mw.Show();
            Hide();
        }

        // To go to the next window!
        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            reasoningQuestions rq = new();
            rq.Show();
            Hide();
        }

        // To Drag Move the app!
        private void reasoningWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}