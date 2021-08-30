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
using System.Windows.Shapes;

namespace IntellectWorkout
{
    /// <summary>
    /// Interaction logic for reasoningWindow.xaml
    /// </summary>
    public partial class reasoningWindow : Window
    {
        public reasoningWindow()
        {
            InitializeComponent();
        }

        private void Exit_Button_Reasoning(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Back_Button_ClickR(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new();
            mw.Show();
            Hide();
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            reasoningQuestions rq = new();
            rq.Show();
            Hide();
        }

        private void reasoningWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}