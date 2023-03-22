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
using static TheGame.Player;

namespace TheGame
{
    /// <summary>
    /// Interaction logic for WinterTower.xaml
    /// </summary>
    public partial class WinterTower : Page
    {
        int counter = 0;
        List<Enemy> WinterEnemyList = new List<Enemy>();
        List<Enemy> WinterEnemyImageList = new List<Enemy>();
        
        public WinterTower()
        {
            InitializeComponent();

            FightCanvas.Focus();

            ImageBrush PlayerImage = new ImageBrush();
            PlayerImage.ImageSource = new BitmapImage(new Uri("Images/Fighter.png", UriKind.Relative));
            Player.Fill = PlayerImage;

            ImageBrush WitnerEnemy1Image = new ImageBrush();
            WitnerEnemy1Image.ImageSource = new BitmapImage(new Uri("Images/WinterEnemy1.png", UriKind.Relative));
            WinterEnemy1.Fill = WitnerEnemy1Image;

            WinterEnemyList.Add(new Enemy(100));
            WinterEnemyList.Add(new Enemy(100));
            WinterEnemyList.Add(new Enemy(100));
            WinterEnemyList.Add(new Enemy(100));
            WinterEnemyList.Add(new Enemy(150));


        }

        private void btnAttack_Click(object sender, RoutedEventArgs e)
        {
            PlayerAttack();
            foreach (var i in WinterEnemyList)
            {
                if(i.EnemyHealth < 0)
                {
                    WinterEnemy1.Visibility = Visibility.Hidden;
                    counter += 1;
                }
            }
            lblScore.Content = "Score =" + counter.ToString();
            counter = 0;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TitleScreen());
        }

        public void PlayerAttack()
        {
            WinterEnemyList[0].EnemyHealth -= 20;
        }


    }
}
