using System;
using System.Windows;
using System.Windows.Input;
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
        public static Int32 NUM_OF_Q;

        public mathQuestions()
        {
            InitializeComponent();
            // THIS IS THE TIMER PART
            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();
            MAIN_NUM = r.Next(0, 18);
            MAIN_NUM2 = r.Next(0, 18);
            MAIN_NUM3 = r.Next(0, 18);
            MAIN_NUM4 = r.Next(0, 18);
            MAIN_NUM5 = r.Next(0, 18);
            MAIN_NUM6 = r.Next(0, 18);
            MAIN_NUM7 = r.Next(0, 18);
            MAIN_NUM8 = r.Next(0, 18);
            MAIN_NUM9 = r.Next(0, 18);
            MAIN_NUM10 = r.Next(0, 18);
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
            //                                                                                                                                          0. [And]                                          1. [E]                                                                    2. [Eat, Tea]                                                                3. [M]                                                                                                           4. [3, Three]                                                                                                                  5. [CABDE]                                                                                                                                                                                    6. [Yes]                                                                                                                                                                                                                                                    7. [40]                                                                                  8. [Friday]                                                                                     9. [Five minutes]                                                                                              10. [R]                                                                          11. [Breath]                                               12. [Postage Stamp]                                                                                    13. [Silence]          14. [12]              15. [23]                  16. [49]                                                             
            // DECIDES THE QUESTION "createQ(uestion)"
            string[] questions = { "What is the one thing that all wise men, regardless of their religion or politics, agree is between heaven and earth? What is it?", "What letter comes next: O T T F F S S ?", "What common English verb becomes its own past tence by rearranging its letters?", "It occurs once in a minute, twice in a moment, but never in an hour.", "There are two ducks in front of a duck, two ducks behind a duck and a duck in the middle. How many ducks are there?", " Five people were eating apples, A finished before B, but behind C. D finished before E, but behind B. What was the finishing order?", "Jack is looking at Anne. Anne is looking at George. Jack is married, George is not, and we don’t know if Anne is married. Is a married person looking at an unmarried person?", "A man has 53 socks in his drawer: 21 identical blue, 15 identical black and 17 identical red. The lights are out and he is completely in the dark. How many socks must he take out to make 100 percent certain he has at least one pair of black socks?", "The day before two days after the day before tomorrow is Saturday. What day is it today?", "If five cats can catch five mice in five minutes, how long will it take one cat to catch one mouse?", "You can find me in Mercury, Earth, Mars, Jupiter, and Saturn, but not Venus or Neptune. What am I?", "You can hold me close to your heart without using your hands or your arms. What am I?", "I travel the world, yet never leave the corner. What am I?", "They say that I’m golden, but that if you so much as whisper my name, I disappear. What am I?", "3 + 3 x 3 -3 + 3", "4, 7, 12, 15, 20, ?", "4, 9, 16, 25, 36, ?, 64" };
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
            if (NUM_OF_Q == 0)
            {
            switch (MAIN_NUM)
            {
                case 0:
                    if (AwnserTextBox.Text == "And")
                    {
                        MessageBox.Show("correct!");
                        createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                    }
                    else if (AwnserTextBox.Text == "and")
                    {
                        MessageBox.Show("correct!");
                        createQ(MAIN_NUM2);
                            NUM_OF_Q++;
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
                            NUM_OF_Q++;
                    } else if (AwnserTextBox.Text == "e")
                    {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
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
                            NUM_OF_Q++;
                    } else if (AwnserTextBox.Text == "eat")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
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
                            NUM_OF_Q++;
                    } else if (AwnserTextBox.Text == "m")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                    else
                    {
                        AwnserTextBox.Text = "Incorrect!";
                    }
                    break;
                case 4:
                        if (AwnserTextBox.Text == "3")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "three")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        } else if (AwnserTextBox.Text == "Three")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else 
                        {
                            AwnserTextBox.Text = "Incorrect!";
                        }
                        break;
                    case 5:
                        if (AwnserTextBox.Text == "CABDE")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "cabde")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else
                        {
                            AwnserTextBox.Text = "Incorrect!";
                        }
                        break;
                    case 6:
                        if (AwnserTextBox.Text == "yes")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "Yes")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "Ye")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "Yeah")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "YES")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else
                        {
                            AwnserTextBox.Text = "Incorrect!";
                        }
                        break;
                    case 7:
                        if (AwnserTextBox.Text == "40")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "forty")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "Forty")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else
                        {
                            AwnserTextBox.Text = "Incorrect!";
                        }
                        break;
                    case 8:
                        if (AwnserTextBox.Text == "friday")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "Friday")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else
                        {
                            AwnserTextBox.Text = "Incorrect!";
                        }
                        break;
                    case 9:
                        if (AwnserTextBox.Text == "5 minutes")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "5")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "5 Minutes")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else
                        {
                            AwnserTextBox.Text = "Incorrect!";
                        }
                        break;
                    case 10:
                        if (AwnserTextBox.Text == "r")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "R")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else
                        {
                            AwnserTextBox.Text = "Incorrect!";
                        }
                        break;
                    case 11:
                        if (AwnserTextBox.Text == "breath")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "Breath")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else
                        {
                            AwnserTextBox.Text = "Incorrect!";
                        }
                        break;
                    case 12:
                        if (AwnserTextBox.Text == "postage stamp")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "Postage Stamp")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "Postage stamp")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else
                        {
                            AwnserTextBox.Text = "Incorrect!";
                        }
                        break;
                    case 13:
                        if (AwnserTextBox.Text == "silence")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "Silence")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else
                        {
                            AwnserTextBox.Text = "Incorrect!";
                        }
                        break;
                    case 14:
                        if (AwnserTextBox.Text == "12")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "twelve")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "Twelve")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else
                        {
                            AwnserTextBox.Text = "Incorrect!";
                        }
                        break;
                    case 15:
                        if (AwnserTextBox.Text == "23")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "twenty three")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "Twenty Three")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else
                        {
                            AwnserTextBox.Text = "Incorrect!";
                        }
                        break;
                    case 16:
                        if (AwnserTextBox.Text == "49")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "forty nine")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
                        }
                        else if (AwnserTextBox.Text == "Forty Nine")
                        {
                            MessageBox.Show("correct!");
                            createQ(MAIN_NUM2);
                            NUM_OF_Q++;
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
            }

            if (NUM_OF_Q == 1) 
            {
            switch (MAIN_NUM2)
            {
                case 0:
                    if (AwnserTextBox.Text == "And")
                    {
                        MessageBox.Show("correct!");
                        createQ(MAIN_NUM3);
                            NUM_OF_Q++;
                    }
                    else if (AwnserTextBox.Text == "and")
                    {
                        MessageBox.Show("correct!");
                        createQ(MAIN_NUM3);
                            NUM_OF_Q++;
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
                        createQ(MAIN_NUM3);
                        NUM_OF_Q++;
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
                        createQ(MAIN_NUM3);
                        NUM_OF_Q++;
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
                        createQ(MAIN_NUM3);
                        NUM_OF_Q++;
                    }
                    else
                    {
                        AwnserTextBox.Text = "Incorrect!";
                    }
                    break;
            }
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
