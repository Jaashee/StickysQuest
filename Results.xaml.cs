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
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Page
    {
        Player Player1 = new Player();
        Enemy Final_Enemy = new Enemy();
        bool results;
        public Results(Player CurrentPlayer, Enemy FinalEnemy, bool Won)
        {

            InitializeComponent();
            Player1 = CurrentPlayer;
            Final_Enemy = FinalEnemy;
            results = Won;
            RefreshScreen();
    }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TitleScreen());

        }
        public void RefreshScreen()
        {
            if (results)
            {
                lblResult.Content = "Victory!";
                lblResult.Foreground = Brushes.Green;
            }
            else
            {
                lblResult.Content = "Defeat!";
                lblResult.Foreground = Brushes.Red;
            }
            ImageBrush PlayerImage = new ImageBrush();
            PlayerImage.ImageSource = Player1.PlayerImage;
            PlayerRect.Fill = PlayerImage;

            ImageBrush PlayerHat = new ImageBrush();
            PlayerHat.ImageSource = Player1.PlayerHat;
            RectPlayerHat.Fill = PlayerHat;



            ImageBrush EnemyImage = new ImageBrush();
            EnemyImage.ImageSource = Final_Enemy.EnemyImage;
            EnemyRect.Fill = EnemyImage;
        }
    }
}
