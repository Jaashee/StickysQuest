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

            // Set the initial volume percentage
            volumePercentage.Text = $"{(int)(volumeSlider.Value * 100)}%";
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
            if (MainWindow.BackgroundMs != null)
            {
                MainWindow.BackgroundMs.Volume = e.NewValue;
            }

            if (volumePercentage != null)
            {
                int percentage = (int)(e.NewValue * 100);
                volumePercentage.Text = $"{percentage}%";
            }
        }


        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HelpScreen());
        }
    }
}