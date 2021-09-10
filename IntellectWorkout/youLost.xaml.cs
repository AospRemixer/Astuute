using System.Windows;
using System.Windows.Input;

namespace IntellectWorkout
{
    /// <summary>
    /// Interaction logic for youLost.xaml
    /// </summary>
    public partial class youLost : Window
    {
        // To start up this window!
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

        // To close this app!
        private void exitYouLost_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // To go back to home screen! And clear all activities!
        private void returnToHome_click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new();
            mw.Show();
            Hide();
            mathQuestions mq = new();
            mq.removeQ();
            memoryQuestions memoryq = new();
            memoryq.ResetAll();
            reasoningQuestions rq = new();
            rq.resetAll();
        }
    }
}