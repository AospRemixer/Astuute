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
    /// Interaction logic for mathWindow.xaml
    /// </summary>
    public partial class mathWindow : Window
    {
        public mathWindow()
        {
            InitializeComponent();
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

        // EXIT BUTTON ON MATH WINDOW
        private void Exit_Button_Math(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        // START BUTTON
        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            mathQuestions mq = new mathQuestions();
            mq.Show();
            Close();
        }


        // BACK BUTTON
        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }

        // TO HELP DRAG MOVE THE APP
        private void mathWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}
