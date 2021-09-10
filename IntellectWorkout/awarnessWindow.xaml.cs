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

namespace IntellectWorkout
{
    /// <summary>
    /// Interaction logic for awarnessWindow.xaml
    /// </summary>
    public partial class awarnessWindow : Window
    {
        // This Starts this Window!
        public awarnessWindow()
        {
            InitializeComponent();
        }

        // This Allows the App to be draged!
        private void awarnessWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        // This is to exit the app!
        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // This is to go back a window!
        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new();
            mw.Show();
            Close();
        }

        // This is to load the next window!
        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            awarenessQuestions aq = new();
            aq.Show();
            Close();
        }
    }
}
