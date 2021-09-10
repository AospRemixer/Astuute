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
        // All My Global Variables...

        // MAKE "RANDOM" VARIABLE
        Random r = new Random();
        // THE QUESTION NUMBER
        public static Int32 MAIN_NUM;
        // NUMBER OF QUESTIONS FINISHED
        public static Int32 NUM_OF_Q = -1;
        // FOR THE STATE TEXT BOX
        public static Int32 CURRENT_LVL = -1;
        // YOU LOST.XAML
        public static youLost yL = new();
        
        // To Startup This Window!
        public mathQuestions()
        {
            InitializeComponent();
            // THIS IS THE TIMER PART
            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();
            MAIN_NUM = r.Next(0, 17);
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
            this.Hide();
            removeQ();
        }

        // To close the app!
        private void exitMathQuestions_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Sets up the next question.. [All In One Function!]
        public void createQ(int dummyNum)
        {
            if (CURRENT_LVL == 9)
            {

            } else
            {
            MAIN_NUM = r.Next(0, 17);
            //                                                                                                                                          0. [And]                                          1. [E]                                                                    2. [Eat, Tea]                                                                3. [M]                                                                                                           4. [3, Three]                                                                                                                  5. [CABDE]                                                                                                                                                                                    6. [Yes]                                                                                                                                                                                                                                                    7. [40]                                                                                  8. [Friday]                                                                                     9. [Five minutes]                                                                                              10. [R]                                                                          11. [Breath]                                               12. [Postage Stamp]                                                                                    13. [Silence]          14. [12]              15. [23]                  16. [49]                                                             
            // DECIDES THE QUESTION "createQ(uestion)"
            string[] questions = { "What is the one thing that all wise men, regardless of their religion or politics, agree is between heaven and earth? What is it?", "What letter comes next: O T T F F S S ?", "What common English verb becomes its own past tence by rearranging its letters?", "It occurs once in a minute, twice in a moment, but never in an hour.", "There are two ducks in front of a duck, two ducks behind a duck and a duck in the middle. How many ducks are there?", "Five people were eating apples, A finished before B, but behind C. D finished before E, but behind B. What was the finishing order?", "Jack is looking at Anne. Anne is looking at George. Jack is married, George is not, and we don’t know if Anne is married. Is a married person looking at an unmarried person?", "A man has 53 socks in his drawer: 21 identical blue, 15 identical black and 17 identical red. The lights are out and he is completely in the dark. How many socks must he take out to make 100 percent certain he has at least one pair of black socks?", "The day before two days after the day before tomorrow is Saturday. What day is it today?", "If five cats can catch five mice in five minutes, how long will it take one cat to catch one mouse?", "You can find me in Mercury, Earth, Mars, Jupiter, and Saturn, but not Venus or Neptune. What am I?", "You can hold me close to your heart without using your hands or your arms. What am I?", "I travel the world, yet never leave the corner. What am I?", "They say that I’m golden, but that if you so much as whisper my name, I disappear. What am I?", "3 + 3 x 3 -3 + 3", "4, 7, 12, 15, 20, ?", "4, 9, 16, 25, 36, ?, 64" };
            string finalQuesiton = questions[MAIN_NUM];
            AwnserTextBox.Text = "Awnser Here";
            Question1math.Text = finalQuesiton;
            NUM_OF_Q++;
//            string a = MAIN_NUM.ToString();
//            string b = NUM_OF_Q.ToString();
            CURRENT_LVL++;
//            MessageBox.Show($"Question Num: {a}\nQ Num: {b}");
            numOfQText.Content = CURRENT_LVL.ToString() + "/10";
            }
        }

        // This is to reset the points and etc!
        public void removeQ()
        {
            NUM_OF_Q = -1;
            CURRENT_LVL = -1;
        }

        // Submit Button.. Checks if the awnser is correct or not!
        public void SubmitButton_click(object sender, RoutedEventArgs e)
        {
            if(CURRENT_LVL == 9)
            {
                youWin yw = new();
                yw.Show();
                Hide();
            }

            switch (MAIN_NUM)
            {
                case 0:
                    if (AwnserTextBox.Text == "And") 
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "and")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
                case 1:
                    if (AwnserTextBox.Text == "E")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "e")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
                case 2:
                    if (AwnserTextBox.Text == "Eat")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "eat")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "Tea")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "tea")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
                case 3:
                    if (AwnserTextBox.Text == "M")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "m")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
                case 4:
                    if (AwnserTextBox.Text == "3")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "three")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "Three")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
                case 5:
                    if (AwnserTextBox.Text == "CABDE")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "CABDE")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
                case 6:
                    if (AwnserTextBox.Text == "Yes")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "yes")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
                case 7:
                    if (AwnserTextBox.Text == "40")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "Forty")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "forty")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
                case 8:
                    if (AwnserTextBox.Text == "Friday")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "friday")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
                case 9:
                    if (AwnserTextBox.Text == "5")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "5 mins")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "5 min")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "5 minutes")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "5 Minutes")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
                case 10:
                    if (AwnserTextBox.Text == "R")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "r")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
                case 11:
                    if (AwnserTextBox.Text == "breath")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "Breath")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
                case 12:
                    if (AwnserTextBox.Text == "Postage Stamp")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "Postage stamp")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "postage stamp")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "postage Stamp")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
                case 13:
                    if (AwnserTextBox.Text == "Silence")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "silence")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
                case 14:
                    if (AwnserTextBox.Text == "12")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "twelve")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "Twelve")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
                case 15:
                    if (AwnserTextBox.Text == "23")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "twenty three")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "Twenty Three")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "twenty Three")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "Twenty three")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
                case 16:
                    if (AwnserTextBox.Text == "49")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "forty nine")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "Forty Nine")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "forty Nine")
                    {
                        
                        createQ(0);
                    }
                    else if (AwnserTextBox.Text == "Forty nine")
                    {
                        
                        createQ(0);
                    }
                    else
                    {
                        yL.Show();
                        Hide();
                    }
                    break;
            }
        }



    }

}
