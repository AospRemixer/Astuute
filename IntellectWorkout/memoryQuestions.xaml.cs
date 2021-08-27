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

        public memoryQuestions()
        {
            InitializeComponent();
            int firstRand = r.Next(0, 51);
            string main = firstRand.ToString();
            memoryFunc(main);

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

        // My Main Function 
        public void memoryFunc(string newNum)
        {
            mainText.Text = newNum;
            int a = Convert.ToInt32(newNum);
            allNums.Add(a);
        }

        public void numChecker(int numToCheck)
        {
            if (allNums.Contains(numToCheck))
            {
                points++;
                string pointsString = points.ToString();
                numOfRepeated.Content = pointsString;
                int nextRand = r.Next(0, 51);
                string newRand = nextRand.ToString();
                memoryFunc(newRand);

            }
            else
            {
                youLost yl = new();
                yl.Show();
                Hide();
            }
        }

        private void RepeatedButton_click(object sender, RoutedEventArgs e)
        {
              string mainToText = mainText.Text.ToString();
              int a = Convert.ToInt32(mainToText);
              numChecker(a);

        }


        // THE BUG IS THAT IT CLOSES BEFORE THE REPEATED NUMBER IS EVEN SHOWN! 
        // AND CLICKING REPEAT GIVES FREE POINTS!
        private void NextButton_click(object sender, RoutedEventArgs e)
        {
            int nextRand = r.Next(0, 51);
            if (allNums.Contains(nextRand))
            {
                youLost yl = new();
                yl.Show();
                Hide();
            }
            else
            {
                string newRand = nextRand.ToString();
                memoryFunc(newRand);
            }
        }

        public void ResetAll()
        {
            points = 0;
            allNums.Clear();
        }
    }
}
