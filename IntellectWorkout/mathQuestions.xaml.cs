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
        // THE QUESTION NUMBER
        public static Int32 MAIN_NUM;
        // NUMBER OF QUESTIONS FINISHED
        public static Int32 NUM_OF_Q = -1;
        // FOR THE STATE TEXT BOX
        public static Int32 CURRENT_LVL = -1;
        // YOU LOST.XAML
        public static youLost yL = new();
        

        public mathQuestions()
        {
            InitializeComponent();
            // THIS IS THE TIMER PART
            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();
            MAIN_NUM = r.Next(0, 4);
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
            removeQ();
        }


        private void exitMathQuestions_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void createQ(int dummyNum)
        {
            MAIN_NUM = r.Next(0, 4);
            //                                                                                                                                          0. [And]                                          1. [E]                                                                    2. [Eat, Tea]                                                                3. [M]                                                                                                           4. [3, Three]                                                                                                                  5. [CABDE]                                                                                                                                                                                    6. [Yes]                                                                                                                                                                                                                                                    7. [40]                                                                                  8. [Friday]                                                                                     9. [Five minutes]                                                                                              10. [R]                                                                          11. [Breath]                                               12. [Postage Stamp]                                                                                    13. [Silence]          14. [12]              15. [23]                  16. [49]                                                             
            // DECIDES THE QUESTION "createQ(uestion)"
            string[] questions = { "What is the one thing that all wise men, regardless of their religion or politics, agree is between heaven and earth? What is it?", "What letter comes next: O T T F F S S ?", "What common English verb becomes its own past tence by rearranging its letters?", "It occurs once in a minute, twice in a moment, but never in an hour.", "There are two ducks in front of a duck, two ducks behind a duck and a duck in the middle. How many ducks are there?", "Five people were eating apples, A finished before B, but behind C. D finished before E, but behind B. What was the finishing order?", "Jack is looking at Anne. Anne is looking at George. Jack is married, George is not, and we don’t know if Anne is married. Is a married person looking at an unmarried person?", "A man has 53 socks in his drawer: 21 identical blue, 15 identical black and 17 identical red. The lights are out and he is completely in the dark. How many socks must he take out to make 100 percent certain he has at least one pair of black socks?", "The day before two days after the day before tomorrow is Saturday. What day is it today?", "If five cats can catch five mice in five minutes, how long will it take one cat to catch one mouse?", "You can find me in Mercury, Earth, Mars, Jupiter, and Saturn, but not Venus or Neptune. What am I?", "You can hold me close to your heart without using your hands or your arms. What am I?", "I travel the world, yet never leave the corner. What am I?", "They say that I’m golden, but that if you so much as whisper my name, I disappear. What am I?", "3 + 3 x 3 -3 + 3", "4, 7, 12, 15, 20, ?", "4, 9, 16, 25, 36, ?, 64" };
            string finalQuesiton = questions[MAIN_NUM];
            AwnserTextBox.Text = "Awnser Here";
            Question1math.Text = finalQuesiton;
            NUM_OF_Q++;
            string a = MAIN_NUM.ToString();
            string b = NUM_OF_Q.ToString();
            CURRENT_LVL++;
            MessageBox.Show($"Question Num: {a}\nQ Num: {b}");
            numOfQText.Content = CURRENT_LVL.ToString() + "/10";
        }

        public void removeQ()
        {
            NUM_OF_Q = -1;
            CURRENT_LVL = -1;
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
                        MessageBox.Show("Correct!");
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "and")
                    {
                        MessageBox.Show("Correct!");
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Close();
                    }
                    break;
                case 1:
                    if (AwnserTextBox.Text == "E")
                    {
                        MessageBox.Show("Correct!");
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "e")
                    {
                        MessageBox.Show("Correct!");
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Close();
                    }
                    break;
                case 2:
                    if (AwnserTextBox.Text == "Eat")
                    {
                        MessageBox.Show("Correct!");
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "eat")
                    {
                        MessageBox.Show("Correct!");
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "Tea")
                    {
                        MessageBox.Show("Correct!");
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "tea")
                    {
                        MessageBox.Show("Correct!");
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Close();
                    }
                    break;
                case 3:
                    if (AwnserTextBox.Text == "M")
                    {
                        MessageBox.Show("Correct!");
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "m")
                    {
                        MessageBox.Show("Correct!");
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Close();
                    }
                    break;
            }
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
