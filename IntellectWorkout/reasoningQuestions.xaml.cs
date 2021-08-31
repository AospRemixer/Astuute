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
    /// Interaction logic for reasoningQuestions.xaml
    /// </summary>
    public partial class reasoningQuestions : Window
    {
        public reasoningQuestions()
        {
            InitializeComponent();
            mainImage.Source = new BitmapImage(new Uri(@"C:\Users\skulw\Downloads\VisualStudio\IntellectWorkout\IntellectWorkout\TimathonAssets\colors.png"));
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

        private void Exit_Button_Memory(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // TO HELP DRAG MOVE THE APP
        private void reasoningQuestions_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Back_Button_ClickR(object sender, RoutedEventArgs e)
        {
            reasoningWindow rw = new();
            rw.Show();
            Close();
        }

        private void first_click(object sender, RoutedEventArgs e)
        {

        }

        private void second_click(object sender, RoutedEventArgs e)
        {

        }

        private void third_click(object sender, RoutedEventArgs e)
        {

        }

        private void forth_click(object sender, RoutedEventArgs e)
        {

        }
    }
}
