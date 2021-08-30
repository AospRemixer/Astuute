using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace IntellectWorkout
{
    /// <summary>
    /// Interaction logic for memoryQuestions.xaml
    /// </summary>
    public partial class memoryQuestions : Window
    {
        // NEW RANDOM
        public static Random r = new();
        // OLD USED NUMS STORE HERE
        public static List<int> allNums = new();
        // THESE ARE THE POINTS
        public static int points = 0;
        // PREVIOUS NUMBER
        public static int prevNum;
        // USEFUL INT 
        public static int i = 0;

        public memoryQuestions()
        {
            InitializeComponent();
            int firstRand = r.Next(0, 11);
            string main = firstRand.ToString();
            memoryFunc(main);

        }

        // My Main Function IF NEXT BUTTON IS CLICKED
        public void memoryFunc(string newNum)
        {
            mainText.Text = newNum;
            int a = Convert.ToInt32(newNum);
            if (allNums.Contains(a))
            {
                i++;
            }
            else
            {
                allNums.Add(a);
            }
        }


        // IF REPEATED BUTTON IS CLICKED
        public void numChecker(int numToCheck)
        {
            if (!allNums.Contains(numToCheck))
            {
                MessageBox.Show("False");
            }
            else
            {
                MessageBox.Show("True");
            }
        }

        private void RepeatedButton_click(object sender, RoutedEventArgs e)
        {
            string mainToText = mainText.Text.ToString();
            int a = Convert.ToInt32(mainToText);
            numChecker(a);

        }
        // ++++++++++++++++++++++++++++++++++++++++
        // AND CLICKING REPEATED GIVES FREE POINTS!
        // ++++++++++++++++++++++++++++++++++++++++
        private void NextButton_click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                int nextRand = r.Next(0, 11);
                string newRand = nextRand.ToString();
                memoryFunc(newRand);
            }
            else if (i == 1)
            {
                youLost yl = new();
                yl.Show();
                Hide();
            }

        }

        public void ResetAll()
        {
            points = 0;
            allNums.Clear();
            i = 0;
        }

        private void Exit_Button_MemoryQ(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            allNums.Clear();
            points = 0;
            memoryWindow mw = new();
            mw.Show();
            Hide();
        }

        // TO HELP DRAG MOVE THE APP
        private void memoryWindowQuestions_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}