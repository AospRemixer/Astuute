using System.Windows;
using System.Windows.Input;

namespace IntellectWorkout
{
    /// <summary>
    /// Interaction logic for youWin.xaml
    /// </summary>
    public partial class youWin : Window
    {
        // To startup this window!
        public youWin()
        {
            InitializeComponent();
        }

        // To Close this app!
        private void exitYouWin_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // To drag move this app!
        private void YouWin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        // To go back home and clear all activities!
        private void returnToHome_click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new();
            mw.Show();
            Hide();
            memoryQuestions mq = new();
            mq.ResetAll();
            reasoningQuestions rq = new();
            rq.resetAll();
        }
    }
}