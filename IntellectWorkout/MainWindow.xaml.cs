﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
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
            

        }

        // MEMORY BUTTON
        private void Memory_Button_Click(object sender, RoutedEventArgs e)
        {

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
            System.Windows.Application.Current.Shutdown();
        }
    }
}