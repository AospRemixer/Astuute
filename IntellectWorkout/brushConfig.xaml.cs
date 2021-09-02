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
    /// Interaction logic for brushConfig.xaml
    /// </summary>
    public partial class brushConfig : Window
    {
        public brushConfig()
        {
            InitializeComponent();
        }

        // TO HELP DRAG MOVE THE APP
        private void mouseDownC(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            spatialQuestions sq = new();
            sq.saveS(GlobalVars.brushClr);
            Close();
        }

        private void cp_SelectedColorChanged_1(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            if (cp.SelectedColor.HasValue)
            {
                GlobalVars.brushClr = cp.SelectedColor.Value.ToString();
            }

        }
    }
}
