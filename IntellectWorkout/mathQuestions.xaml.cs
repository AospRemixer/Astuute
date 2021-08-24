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
    /// Interaction logic for mathQuestions.xaml
    /// </summary>
    public partial class mathQuestions : Window
    {
        // MAKE "RANDOM" VARIABLES
        
        Random r = new Random();
        public static Int32 MAIN_NUM;
        public static Int32 MAIN_NUM2;
        public static Int32 MAIN_NUM3;
        public static Int32 MAIN_NUM4;
        public static Int32 MAIN_NUM5;
        public static Int32 MAIN_NUM6;
        public static Int32 MAIN_NUM7;
        public static Int32 MAIN_NUM8;
        public static Int32 MAIN_NUM9;
        public static Int32 MAIN_NUM10;

        public mathQuestions()
        {
            InitializeComponent();
            // THIS IS THE TIMER PART
            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();
            MAIN_NUM = r.Next(0, 4);
            MAIN_NUM2 = r.Next(0, 4);
            MAIN_NUM3 = r.Next(0, 4);
            MAIN_NUM4 = r.Next(0, 4);
            MAIN_NUM5 = r.Next(0, 4);
            MAIN_NUM6 = r.Next(0, 4);
            MAIN_NUM7 = r.Next(0, 4);
            MAIN_NUM8 = r.Next(0, 4);
            MAIN_NUM9 = r.Next(0, 4);
            MAIN_NUM10 = r.Next(0, 4);
            createQ(MAIN_NUM);

            // FUNCTION FOR THE TIMER
            void timer_Tick(object sender, EventArgs e)
            {
                LiveTimeLabel.Content = DateTime.Now.ToString("HH:mm");
            }

        }

        // TO HELP DRAG MOVE THE APP
        private void mathWindowQuestions_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        // BACK BUTTON
        private void backMathQuestions_Click(object sender, RoutedEventArgs e)
        {
            // OPEN THE MATH WINDOW AGAIN
            mathWindow maWindow = new mathWindow();
            maWindow.Show();
            this.Close();
        }


        private void exitMathQuestions_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void createQ(int finalNum)
        {
            string[] questions = { "What is the one thing that all wise men, regardless of their religion or politics, agree is between heaven and earth? What is it?", "What letter comes next: O T T F F S S ?", "What common English verb becomes its own past tence by rearranging its letters?", "It occurs once in a minute, twice in a moment, but never in an hour." };
            string finalQuesiton = questions[finalNum];
            Question1math.Text = finalQuesiton;
            MessageBox.Show(finalNum.ToString());
            if (submitButton.IsPressed)
            {
                MessageBox.Show("working!");
            }
        }


        private void first_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void second_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void third_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void forth_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        public void SubmitButton_click(object sender, RoutedEventArgs e)
        {
            switch (MAIN_NUM)
            {
                case 0:
                    if (AwnserTextBox.Text == "And")
                    {
                        MessageBox.Show("correct!");
                        createQ(MAIN_NUM2);
                    }
                    else if (AwnserTextBox.Text == "and")
                    {
                        MessageBox.Show("correct!");
                        createQ(MAIN_NUM2);
                    }
                    else
                    {
                        AwnserTextBox.Text = "Incorrect!";
                    }
                    break;
                case 1:
                    if (AwnserTextBox.Text == "E")
                    {
                        MessageBox.Show("correct!");
                        createQ(MAIN_NUM2);
                    }
                    else
                    {
                        AwnserTextBox.Text = "Incorrect!";
                    }
                    break;
                case 2:
                    if (AwnserTextBox.Text == "Eat")
                    {
                        MessageBox.Show("correct!");
                        createQ(MAIN_NUM2);
                    }
                    else
                    {
                        AwnserTextBox.Text = "Incorrect!";
                    }
                    break;
                case 3:
                    if (AwnserTextBox.Text == "M")
                    {
                        MessageBox.Show("correct!");
                        createQ(MAIN_NUM2);
                    }
                    else
                    {
                        AwnserTextBox.Text = "Incorrect!";
                    }
                    break;
                default:
                    AwnserTextBox.Text = "Incorrect!";
                    break;

            }

            switch (MAIN_NUM2)
            {
                case 0:
                    if (AwnserTextBox.Text == "And")
                    {
                        MessageBox.Show("correct!");
                        createQ(MAIN_NUM2);
                    }
                    else if (AwnserTextBox.Text == "and")
                    {
                        MessageBox.Show("correct!");
                        createQ(MAIN_NUM2);
                    }
                    else
                    {
                        AwnserTextBox.Text = "Incorrect!";
                    }
                    break;
                case 1:
                    if (AwnserTextBox.Text == "E")
                    {
                        MessageBox.Show("correct!");
                        createQ(MAIN_NUM2);
                    }
                    else
                    {
                        AwnserTextBox.Text = "Incorrect!";
                    }
                    break;
                case 2:
                    if (AwnserTextBox.Text == "Eat")
                    {
                        MessageBox.Show("correct!");
                        createQ(MAIN_NUM2);
                    }
                    else
                    {
                        AwnserTextBox.Text = "Incorrect!";
                    }
                    break;
                case 3:
                    if (AwnserTextBox.Text == "M")
                    {
                        MessageBox.Show("correct!");
                        createQ(MAIN_NUM2);
                    }
                    else
                    {
                        AwnserTextBox.Text = "Incorrect!";
                    }
                    break;
            }
        }

        // W.i.P
/*        void newQ()
        {
            int correctAwns = 0;
            int numberOfAwns = 0;


        }
*/

        // W.I.P
/*        public int RandomNum()
        {
            var exclude = new HashSet<int>() { random };
            var range = Enumerable.Range(1, 100).Where(i => !exclude.Contains(i));

            var rand = new System.Random();
            int index = rand.Next(0, 100 - exclude.Count);
            return range.ElementAt(index);
        }
*/
    }
}
