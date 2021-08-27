using System.Windows;
using System.Windows.Input;

namespace IntellectWorkout
{
    /// <summary>
    /// Interaction logic for youWin.xaml
    /// </summary>
    public partial class youWin : Window
    {
        public youWin()
        {
            InitializeComponent();
        }

        private void exitYouWin_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void YouWin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void returnToHome_click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new();
            mw.Show();
            Hide();
            memoryQuestions mq = new();
            mq.ResetAll();
        }
    }
}