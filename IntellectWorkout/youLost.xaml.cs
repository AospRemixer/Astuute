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
    /// Interaction logic for youLost.xaml
    /// </summary>
    public partial class youLost : Window
    {
        public youLost()
        {
            InitializeComponent();
        }

        // TO HELP DRAG MOVE THE APP
        private void youlost_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void exitYouLost_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void returnToHome_click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new();
            mw.Show();
            Close();
            mathQuestions mq = new();
            mq.DataContext = null;
            mq.removeQ();
        }
    }
}