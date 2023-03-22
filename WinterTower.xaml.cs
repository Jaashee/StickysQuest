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
        List <Shape> WinterEnemyImageList = new List<Shape>();
        
        public WinterTower()
        {
            InitializeComponent();

            FightCanvas.Focus();

            ImageBrush PlayerImage = new ImageBrush();
            PlayerImage.ImageSource = new BitmapImage(new Uri("Images/Fighter.png", UriKind.Relative));
            Player.Fill = PlayerImage;

            ImageBrush WitnerEnemy1Image = new ImageBrush();
            WitnerEnemy1Image.ImageSource = new BitmapImage(new Uri("Images/WinterEnemy1.png", UriKind.Relative));

            ImageBrush WitnerEnemy2Image = new ImageBrush();
            WitnerEnemy2Image.ImageSource = new BitmapImage(new Uri("Images/WinterTowerEnemy2.jpg", UriKind.Relative));


            ImageBrush WitnerEnemy3Image = new ImageBrush();
            WitnerEnemy3Image.ImageSource = new BitmapImage(new Uri("Images/WinterTowerEnemy3.jpg", UriKind.Relative));



            WinterEnemy1.Fill = WitnerEnemy1Image;
            WinterEnemy1.Visibility = Visibility.Hidden;
            WinterEnemy2.Fill = WitnerEnemy2Image;
            WinterEnemy2.Visibility = Visibility.Hidden;
            WinterEnemy3.Fill = WitnerEnemy3Image;
            WinterEnemy3.Visibility = Visibility.Hidden;

            WinterEnemyList.Add(new Enemy(100));
            WinterEnemyList.Add(new Enemy(100));
            WinterEnemyList.Add(new Enemy(100));
            WinterEnemyList.Add(new Enemy(100));
            WinterEnemyList.Add(new Enemy(150));

            WinterEnemyImageList.Add(WinterEnemy1);
            WinterEnemyImageList.Add(WinterEnemy2);
            WinterEnemyImageList.Add(WinterEnemy3);


        }

        private void btnAttack_Click(object sender, RoutedEventArgs e)
        {
            PlayerAttack();
            foreach (var i in WinterEnemyList)
            {
                if(i.EnemyHealth < 0)
                {
                    
                    foreach (var shape in WinterEnemyImageList)
                    {
                        shape.Visibility = Visibility.Visible;
                        shape.Visibility = Visibility.Hidden;
                        //shape.Visibility = Visibility.Visible;
                        counter += 1;
                    }
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
