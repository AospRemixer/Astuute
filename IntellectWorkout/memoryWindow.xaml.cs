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
    /// Interaction logic for memoryWindow.xaml
    /// </summary>
    public partial class memoryWindow : Window
    {
        public memoryWindow()
        {
            InitializeComponent();
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            memoryQuestions mq = new();
            mq.Show();
            Hide();
        }

        private void Exit_Button_Memory(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Back_Button_ClickM(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new();
            mw.Show();
            Hide();
        }

        private void memoryWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

    }
}