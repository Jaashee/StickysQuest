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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TheGame
{
    /// <summary>
    /// Interaction logic for OptionsPage.xaml
    /// </summary>
    public partial class OptionsPage : Page
    {
        private MediaPlayer BackgroundMs; // Declare BackgroundMs as a class-level variable

        public OptionsPage()
        {
            InitializeComponent();
            BackgroundMs = new MediaPlayer(); // Initialize the BackgroundMs object
            BackgroundMs.Open(new Uri("Sounds/Background.wav", UriKind.Relative));
            BackgroundMs.Play();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TitleScreen());
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }

        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (BackgroundMs != null) // Check if BackgroundMs is not null before setting its volume
            {
                BackgroundMs.Volume = e.NewValue;
            }
        }

    }
}