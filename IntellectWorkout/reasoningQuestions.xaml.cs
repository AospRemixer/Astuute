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
        // Global Variables....
        // RANDOM
        public static Random r = new();

        // All Images:
        public static string[] uris = { @"1.png", @"2.png", @"3.png", @"4.png", @"5.png", @"6.png", @"7.png", @"8.png", @"9.png", @"10.png" };
        
        // CURRENT QUESTION.. [MAIN VARIABLE]
        public static int i = r.Next(0, 10);

        // NUM OF CORRECT
        public static int numOfC = -1;

        // Starts this window up!
        public reasoningQuestions()
        {
            InitializeComponent();
            setupQ();
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

        // The main function! Setups the question! [All in one function!]
        public void setupQ()
        {
            numOfC++;
            numOfcorrect.Content = numOfC.ToString();
            if (i == 9)
            {
                i = 0;
                mainImage.Source = new BitmapImage(new Uri(GlobalVars.PathToAppFolder + "rQ/" + uris[i], UriKind.RelativeOrAbsolute));
            }
            else
            {
                i++;
                mainImage.Source = new BitmapImage(new Uri(GlobalVars.PathToAppFolder + "rQ/" + uris[i], UriKind.RelativeOrAbsolute));
            }
            // THIS SETUPS THE TEXT ON THE BUTTON ACCORDING TO THE QUESTION, WHICH IS BASICALLY THE VARIABLE "i".
            switch (i)
            {
                case 0:
                    firstButtonText.Text = 6.ToString();
                    secondButtonText.Text = 7.ToString();
                    thirdButtonText.Text = 5.ToString();
                    forthButtonText.Text = 4.ToString();
                    break;
                case 1:
                    firstButtonText.Text = 72000.ToString();
                    secondButtonText.Text = 27000.ToString();
                    thirdButtonText.Text = 72900.ToString();
                    forthButtonText.Text = 27900.ToString();
                    break;
                case 2:
                    firstButtonText.Text = 1.ToString();
                    secondButtonText.Text = 2.ToString();
                    thirdButtonText.Text = 10.ToString();
                    forthButtonText.Text = 6.ToString();
                    break;
                case 3:
                    firstButtonText.Text = 27.ToString();
                    secondButtonText.Text = 98.ToString();
                    thirdButtonText.Text = 72.ToString();
                    forthButtonText.Text = 89.ToString();
                    break;
                case 4:
                    firstButtonText.Text = 24.ToString();
                    secondButtonText.Text = 39.ToString();
                    thirdButtonText.Text = 54.ToString();
                    forthButtonText.Text = 108.ToString();
                    break;
                case 5:
                    firstButtonText.Text = 7.ToString();
                    secondButtonText.Text = 16.ToString();
                    thirdButtonText.Text = 12.ToString();
                    forthButtonText.Text = 14.ToString();
                    break;
                case 6:
                    firstButtonText.Text = 60.ToString();
                    secondButtonText.Text = 50.ToString();
                    thirdButtonText.Text = 48.ToString();
                    forthButtonText.Text = 58.ToString();
                    break;
                case 7:
                    firstButtonText.Text = 25.ToString();
                    secondButtonText.Text = 49.ToString();
                    thirdButtonText.Text = 8.ToString();
                    forthButtonText.Text = 2.ToString();
                    break;
                case 8:
                    firstButtonText.Text = 30.ToString();
                    secondButtonText.Text = 36.ToString();
                    thirdButtonText.Text = 38.ToString();
                    forthButtonText.Text = 48.ToString();
                    break;
                case 9:
                    firstButtonText.Text = 41.ToString();
                    secondButtonText.Text = 43.ToString();
                    thirdButtonText.Text = 49.ToString();
                    forthButtonText.Text = 50.ToString();
                    break;
            }
        }

        // This is to close the app!
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

        // To Go Back a Window!
        private void Back_Button_ClickR(object sender, RoutedEventArgs e)
        {
            reasoningWindow rw = new();
            rw.Show();
            Close();
            resetAll();
        }

        // First Button!
        private void first_click(object sender, RoutedEventArgs e)
        {
            switch (i)
            {
                case 0:
                    setupQ();
                    break;

                case 4:
                    setupQ();
                    break;
                case 5:
                    setupQ();
                    break;
                default:
                    youLost yl = new();
                    yl.Show();
                    Close();
                    break;
            }
        }

        // Second Button!
        private void second_click(object sender, RoutedEventArgs e)
        {
            switch (i)
            {
                case 1:
                    setupQ();
                    break;
                case 3:
                    setupQ();
                    break;
                case 9:
                    setupQ();
                    break;
                default:
                    youLost yl = new();
                    yl.Show();
                    Close();
                    break;
            }
        }

        // Third Button!
        private void third_click(object sender, RoutedEventArgs e)
        {
            switch (i)
            {
                case 2:
                    setupQ();
                    break;
                case 6:
                    setupQ();
                    break;
                case 7:
                    setupQ();
                    break;
                case 8:
                    setupQ();
                    break;
                default:
                    youLost yl = new();
                    yl.Show();
                    Close();
                    break;
            }
        }

        // Forth Button!
        private void forth_click(object sender, RoutedEventArgs e)
        {
            // So basically 4th button is never correct :(((
            youLost yl = new();
            yl.Show();
            Close();
        }

        // To Reset the points and etc!
        public void resetAll()
        {
            i = r.Next(0, 10);
            numOfC = -1;
        }
    }
}