using System.Windows;
using System.Windows.Input;

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
            Hide();
            mathQuestions mq = new();
            mq.removeQ();
            memoryQuestions memoryq = new();
            memoryq.ResetAll();
        }
    }
}