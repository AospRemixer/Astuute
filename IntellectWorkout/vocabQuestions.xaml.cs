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
        // Global variables...

        // Random
        public static Random r = new();
        //Path to the model file
        private static string[] MODEL = { "mug.obj", "tooth.obj", "sword.obj", "pug.obj", "ship.obj", "cat.obj", "car.obj", "shoe.obj", "leopard.obj", "onigiri.obj", "diamond.obj", "urus.obj", "ball.obj", "fire.obj" };
        public string MODEL_PATH(int i)
        {
            string a = MODEL[i];
            return GlobalVars.PathToAppFolder + "3d/" + $"{a}";
        }
        // Question Num
        public int i = r.Next(0, 14);
        // Num Of Questions Done
        public int CURRENT_LVL = 0;

        // to startup this window!
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

        // To exit the app!
        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // to go back a window!
        private void Back_Button_ClickV(object sender, RoutedEventArgs e)
        {
            volcabWindow vw = new();
            vw.Show();
            Close();
        }

        // Setup Next Question!
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
                // Correct Awnser: 5
                case 4:
                    modelName.Text = "Ship";
                    guideTxt.Content = "1. Marine\n2. Naval\n3. Aquatic\n4. Thalassic\n5. Nautical";
                    break;
                // Correct Awnser: 4
                case 5:
                    modelName.Text = "Lazy Cat";
                    guideTxt.Content = "1. Droopy\n2. Flagging\n3. Languorous\n4. Lackadaisical\n5. Slothful";
                    break;
                // Correct Awnser: 3
                case 6:
                    modelName.Text = "Car";
                    guideTxt.Content = "1. Jalopy\n2. Junker\n3. Automobile\n4. Heap\n5. Sedan";
                    break;
                // Correct Awnser: 1
                case 7:
                    modelName.Text = "Shoe";
                    guideTxt.Content = "1. Lovely\n2. Dainty\n3. Beauteous\n4. Bonny\n5. Cheerful";
                    break;
                // Correct Awnser: 5
                case 8:
                    modelName.Text = "Cheetah";
                    guideTxt.Content = "1. Lion\n2. Fast\n3. Panther\n4. Tom\n5. Civet";
                    break;
                // Correct Awnser: 3
                case 9:
                    modelName.Text = "Onigiri";
                    guideTxt.Content = "1. Euphoric\n2. Beatific\n3. Appetizing\n4. Divine\n5. Scrumptious";
                    break;
                // Correct Awnser: 2
                case 10:
                    modelName.Text = "Diamond";
                    guideTxt.Content = "1. Loner\n2. Singular\n3. Unthinkable\n4. Unwonted\n5. Queer";
                    break;
                // Correct Awnser: 2
                case 11:
                    modelName.Text = "Lambo Urus";
                    guideTxt.Content = "1. Riches\n2. Affluence\n3. Fortune\n4. Charming\n5. Graceful";
                    break;
                // Correct Awnser: 5
                case 12:
                    modelName.Text = "Soccer Ball";
                    guideTxt.Content = "1. Bundle\n2. Mass\n3. Pellet\n4. Globule\n5. Sphere";
                    break;
                // Correct Awnser: 3
                case 13:
                    modelName.Text = "Fire";
                    guideTxt.Content = "1. Sparks\n2. Element\n3. Blaze\n4. Warmth\n5. Hearth";
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

        // Makes sure the text is only a number between 1-5
        private void txtInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-5]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        // Checks if the awnser is correct! "NextButton"
        private void NextButton_click(object sender, RoutedEventArgs e)
        {
            int outputValue;
            bool isNumber = int.TryParse(AwnsTxt.Text, out outputValue);
            if (!isNumber)
            {

            }
            else
            {
                int m = Convert.ToInt32(AwnsTxt.Text);
                switch (i)
                {
                    case 0:
                        if (m == 1)
                        {
                            i = r.Next(0, 14);
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
                            i = r.Next(0, 14);
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
                            i = r.Next(0, 14);
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
                            i = r.Next(0, 14);
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
                    case 4:
                        if (m == 5)
                        {
                            i = r.Next(0, 14);
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
                    case 5:
                        if (m == 4)
                        {
                            i = r.Next(0, 14);
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
                    case 6:
                        if (m == 3)
                        {
                            i = r.Next(0, 14);
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
                    case 7:
                        if (m == 1)
                        {
                            i = r.Next(0, 14);
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
                    case 8:
                        if (m == 5)
                        {
                            i = r.Next(0, 14);
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
                    case 9:
                        if (m == 3)
                        {
                            i = r.Next(0, 14);
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
                    case 10:
                        if (m == 2)
                        {
                            i = r.Next(0, 14);
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
                    case 11:
                        if (m == 2)
                        {
                            i = r.Next(0, 14);
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
                    case 12:
                        if (m == 5)
                        {
                            i = r.Next(0, 14);
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
                    case 13:
                        if (m == 3)
                        {
                            i = r.Next(0, 14);
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
}
