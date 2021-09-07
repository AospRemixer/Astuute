using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using System.Text.RegularExpressions;

namespace IntellectWorkout
{
    /// <summary>
    /// Interaction logic for vocabQuestions.xaml
    /// </summary>
    public partial class vocabQuestions : Window
    {
        // Random
        public static Random r = new();
        //Path to the model file
        private static string[] MODEL = { "mug.obj", "tooth.obj", "sword.obj", "pug.obj" };
        public string MODEL_PATH(int i)
        {
            string a = MODEL[i];
            return GlobalVars.PathToAppFolder + "3d/" + $"{a}";
        }
        // Question Num
        public int i = r.Next(0, 4);
        // Num Of Questions Done
        public int CURRENT_LVL = 0;

        public vocabQuestions()
        {
            InitializeComponent();
            lvl.Content = CURRENT_LVL.ToString();
            SetupQ(MODEL_PATH(i));
        }

        // TO HELP DRAG MOVE THE APP
        private void vocabQuestions_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Back_Button_ClickV(object sender, RoutedEventArgs e)
        {
            volcabWindow vw = new();
            vw.Show();
            Close();
        }

        // Setup Next Q
        public void SetupQ(string ModelS)
        {
            AwnsTxt.Text = "Awnser Here";
            // SET 3d Model
            ModelVisual3D device3D = new ModelVisual3D();
            viewPort3d.Children.Clear();
            viewPort3d.Children.Add(new DefaultLights());
            viewPort3d.ZoomExtents();
            device3D.Content = Display3d(ModelS);
            
            // Add to view port
            viewPort3d.Children.Add(device3D);

            // Set Text
            switch (i)
            {
                case 0:
                    // Correct Awnser: 1
                    modelName.Text = "Mug";
                    guideTxt.Content = "1. Ceramic\n2. Paten\n3. Superannuated\n4. Supple\n5. Gelatinous";
                    break;
                    // Correct Awnser: 3
                case 1:
                    modelName.Text = "Shark Tooth";
                    guideTxt.Content = "1. Taxonomy\n2. Mtdna\n3. Cenozoic\n4. Kaolin\n5. Fluorine";
                    break;
                // Correct Awnser: 2
                case 2:
                    modelName.Text = "Sword";
                    guideTxt.Content = "1. Fencing\n2. Horned\n3. Cenozoic\n4. Machete\n5. Bronze";
                    break;
                // Correct Awnser: 1
                case 3:
                    modelName.Text = "Pug";
                    guideTxt.Content = "1. Ironclad\n2. Unwavering\n3. Substantial\n4. Consequential\n5. Bulwarked";
                    break;
            }
        }
        
        // Display The 3d Model
        private Model3D Display3d(string model)
        {
            Model3D device = null;
            try
            {
                //Adding a gesture here
                viewPort3d.RotateGesture = new MouseGesture(MouseAction.LeftClick);

                //Import 3D model file
                ModelImporter import = new ModelImporter();

                //Load the 3D model file
                device = import.Load(model);
            }
            catch (Exception e)
            {
                // Handle exception in case can not file 3D model
                MessageBox.Show("Exception Error : " + e.StackTrace);
            }
            return device;
        }

        private void txtInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-5]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void NextButton_click(object sender, RoutedEventArgs e)
        {
            int m = Convert.ToInt32(AwnsTxt.Text);
            switch(i)
            {
                case 0:
                    if (m == 1)
                    {
                        i = r.Next(0, 4);
                        string path = MODEL_PATH(i);
                        SetupQ(path);
                        CURRENT_LVL++;
                        lvl.Content = CURRENT_LVL.ToString();
                    }
                    else
                    {
                        youLost yl = new();
                        yl.Show();
                        Close();
                    }
                    break;
                case 1:
                    if (m == 3)
                    {
                        i = r.Next(0, 4);
                        string path = MODEL_PATH(i);
                        SetupQ(path);
                        CURRENT_LVL++;
                        lvl.Content = CURRENT_LVL.ToString();
                    }
                    else
                    {
                        youLost yl = new();
                        yl.Show();
                        Close();
                    }
                    break;
                case 2:
                    if (m == 2)
                    {
                        i = r.Next(0, 4);
                        string path = MODEL_PATH(i);
                        SetupQ(path);
                        CURRENT_LVL++;
                        lvl.Content = CURRENT_LVL.ToString();
                    }
                    else
                    {
                        youLost yl = new();
                        yl.Show();
                        Close();
                    }
                    break;
                case 3:
                    if (m == 1)
                    {
                        i = r.Next(0, 4);
                        string path = MODEL_PATH(i);
                        SetupQ(path);
                        CURRENT_LVL++;
                        lvl.Content = CURRENT_LVL.ToString();
                    }
                    else
                    {
                        youLost yl = new();
                        yl.Show();
                        Close();
                    }
                    break;
            }
        }
    }
}
