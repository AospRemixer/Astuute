using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace IntellectWorkout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            // THIS IS THE TIMER PART
            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();

            // FUNCTION FOR THE TIMER
            void timer_Tick(object sender, EventArgs e)
            {
                LiveTimeLabel.Content = DateTime.Now.ToString("HH:mm");
            }
        }

        // MATH BUTTON
        private void Math_Button_Click(object sender, RoutedEventArgs e)
        {
            // OPEN THE MATH WINDOW
            mathWindow maWindow = new mathWindow();
            maWindow.Show();
            this.Close();
        }

        // MEMORY BUTTON
        private void Memory_Button_Click(object sender, RoutedEventArgs e)
        {
            memoryWindow mw = new();
            mw.Show();
            Hide();
        }

        // REASONING BUTTON
        private void Reasoning_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        // SPATIAL BUTTON
        private void Spatial_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        // LINGUISTIC BUTTON
        private void Linguistic_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        // KINESTHETIC BUTTON
        private void Kinesthetic_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        // SETTINGS BUTTON
        private void Settings_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        // SECRET BUTTON
        private void Secret_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        // TO HELP DRAG THE APP
        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        // TO MAKE MY OWN EXIT BUTTON
        private void Exit_Button_Home(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
