using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace TheGame
{
    /// <summary>
    /// Interaction logic for TitleScreen.xaml
    /// </summary>
    public partial class TitleScreen : Page
    {
        public TitleScreen()
        {
            InitializeComponent();
        }

        // This event is triggered when the page is loaded
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // Show the background image when the TitleScreen page is loaded
            if (this.IsLoaded) // Check if the page is loaded
            {
                MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
                if (mainWindow != null)
                {
                    // Find the Image control with the name "imgBackground"
                    Image imgBackground = mainWindow.FindName("imgTitle") as Image;
                    if (imgBackground != null)
                    {
                        // Set the visibility of the image to Visible
                        imgBackground.Visibility = Visibility.Visible;
                    }
                }
            }
        }

        // This event is triggered when the page is unloaded
        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            // Hide the background image when the TitleScreen page is unloaded
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                // Find the Image control with the name "imgBackground"
                Image imgBackground = mainWindow.FindName("imgTitle") as Image;
                if (imgBackground != null)
                {
                    // Set the visibility of the image to Collapsed
                    imgBackground.Visibility = Visibility.Collapsed;
                }
            }
        }

        // This event handler is called when the btnStart button is clicked
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the next page
            SoundPlayer BackgroundMs = new SoundPlayer("Sounds/Background.wav");
            BackgroundMs.Load();
            BackgroundMs.Play();
            this.NavigationService.Navigate(new CreateCharacter());
        }

        // This event handler is called when the btnQuit button is clicked
        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            // Quit the application
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();

        }

        // This event handler is called when the btnOptions button is clicked
        private void btnOptions_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the options page
            this.NavigationService.Navigate(new OptionsPage());
        }
    }
}
