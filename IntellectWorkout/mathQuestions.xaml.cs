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
    /// Interaction logic for mathQuestions.xaml
    /// </summary>
    public partial class mathQuestions : Window
    {
        public mathQuestions()
        {
            InitializeComponent();
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
            // OPEN THE MATH WINDOW
            mathWindow maWindow = new mathWindow();
            maWindow.Show();
            this.Close();
        }


        private void exitMathQuestions_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
