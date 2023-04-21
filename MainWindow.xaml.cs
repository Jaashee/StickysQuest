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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Define the MediaPlayer as a public static property
        public static MediaPlayer BackgroundMs { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            BackgroundMs = new MediaPlayer();
            BackgroundMs.Open(new Uri("Sounds/Background.wav", UriKind.Relative));
            BackgroundMs.Play();
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.Loaded += MainWindow_Loaded;
            frmMasterFrame.NavigationService.Navigate(new TitleScreen());
        }
    }
}