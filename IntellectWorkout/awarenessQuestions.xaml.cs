using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IntellectWorkout
{
    /// <summary>
    /// Interaction logic for awarenessQuestions.xaml
    /// </summary>
    public partial class awarenessQuestions : Window
    {
        // Global Variables!
        public static int waitMode = 0;
        public Stopwatch sw = new Stopwatch();

        // Setup This Window!
        public awarenessQuestions()
        {
            InitializeComponent();
        }

        // To close this app!
        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // To go back a window!
        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            awarnessWindow aw = new();
            aw.Show();
            Close();
        }

        // To drag move the app!
        private void awarenessQ_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        // This Fucntion Sets the main Button Color, and text and also starts the timer!
        private async void mainFunc()
        {
            var converter = new BrushConverter();
            spatialQuestions sq = new();
            Random r = new();
            int t = r.Next(1500, 8500);
            Txt.Text = "Wait...";
            waitMode = 1;
            StartButton.Background = (Brush)converter.ConvertFromString("#933861");
            await Task.Delay(t);
            waitMode = 2;
            Txt.Text = "Click!";
            sw.Reset();
            sw.Start();
            StartButton.Background = (Brush)converter.ConvertFromString("#2bd654");

        }

        // This start button is the main button's onClick trigger code. It does a certain task depending on the state of the activity! 
        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            if (sw.IsRunning)
            {
                sw.Stop();
                long time_elapsed = sw.ElapsedMilliseconds;
                TimeTxt.Text = time_elapsed.ToString() + "ms";
            }
            if (waitMode == 0)
            {
                mainFunc();
            }
            else if (waitMode == 1)
            {
                // Do Nothing.
            }
            else if (waitMode == 2)
            {
                Txt.Text = "Restart";
                waitMode = 0;
            }
        }
    }
}
