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
        // RANDOM
        public static Random r = new();
        // LIST OF ALL URI's [IMAGE]                                                  0.  (1)6 is correct option                                                                                                1.  (B)27000 is correct option                                                                   2.   (3)10 is correct option                                                                                3.   (2)72 is correct option                                                                              4.    (1)24 is correct option                                                                                       5.   (1)7 is correct option                                                                       6.    (3)48 is correct option                                                                                         7. (C)8 is correct option                                                                                      8. (C)38 is correct option                                                                                9. (2)43 is correct
        public static string[] uris = { @"C:\Users\skulw\Downloads\VisualStudio\IntellectWorkout\IntellectWorkout\TimathonAssets\reasoningQ\1.png", @"C:\Users\skulw\Downloads\VisualStudio\IntellectWorkout\IntellectWorkout\TimathonAssets\reasoningQ\2.png", @"C:\Users\skulw\Downloads\VisualStudio\IntellectWorkout\IntellectWorkout\TimathonAssets\reasoningQ\3.png", @"C:\Users\skulw\Downloads\VisualStudio\IntellectWorkout\IntellectWorkout\TimathonAssets\reasoningQ\4.png", @"C:\Users\skulw\Downloads\VisualStudio\IntellectWorkout\IntellectWorkout\TimathonAssets\reasoningQ\5.png", @"C:\Users\skulw\Downloads\VisualStudio\IntellectWorkout\IntellectWorkout\TimathonAssets\reasoningQ\6.png", @"C:\Users\skulw\Downloads\VisualStudio\IntellectWorkout\IntellectWorkout\TimathonAssets\reasoningQ\7.png", @"C:\Users\skulw\Downloads\VisualStudio\IntellectWorkout\IntellectWorkout\TimathonAssets\reasoningQ\8.png", @"C:\Users\skulw\Downloads\VisualStudio\IntellectWorkout\IntellectWorkout\TimathonAssets\reasoningQ\9.png", @"C:\Users\skulw\Downloads\VisualStudio\IntellectWorkout\IntellectWorkout\TimathonAssets\reasoningQ\10.png" };
        // CURRENT STATE.. [MAIN VARIABLE]
        public static int i = r.Next(0, 10);

        public reasoningQuestions()
        {
            InitializeComponent();
            mainImage.Source = new BitmapImage(new Uri(uris[i]));
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
            resetAll();
        }

        private void first_click(object sender, RoutedEventArgs e)
        {
            if (i == 9)
            {
                i = 0;
                mainImage.Source = new BitmapImage(new Uri(uris[i]));
            }
            else
            {
                i++;
                mainImage.Source = new BitmapImage(new Uri(uris[i]));
            }

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

        public void resetAll()
        {
            i = r.Next(0, 10);
        }
    }
}
