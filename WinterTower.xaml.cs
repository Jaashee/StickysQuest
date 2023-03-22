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
        Player Player1 = new("Hero", 100, 100, 100, 1, 0);
        Enemy Enemy1 = new(1, "Monster", "an evil monster", "Images/WinterEnemy1.png", 50, 1, 15, "Minion");

        List<Enemy> WinterEnemyList = new List<Enemy>();
        List <Shape> WinterEnemyImageList = new List<Shape>();
        
        public WinterTower()
        {
            InitializeComponent();

            FightCanvas.Focus();

            lblPlayerName.Content = Player1.PlayerName;
            lblEnemyRole.Content = Enemy1.EnemyType;
            lblEnemyName.Content = Enemy1.EnemyName;
            btnAttack.Content = "Attack with " + Player1.PlayerWeapon.WeaponName;
            btnAttackWand.Content = "Attack with " + Player1.PlayerWand.WandName;

            lblPlayerHP.Content = "HP: " + Player1.PlayerHealth.ToString();
            lblPlayerSP.Content = "SP: " + Player1.PlayerStamina.ToString();
            lblPlayerMP.Content = "MP: " + Player1.PlayerMana.ToString();
            lblEnemyHP.Content = "HP: " + Enemy1.EnemyHealth.ToString();


            ImageBrush PlayerImage = new ImageBrush();
            PlayerImage.ImageSource = new BitmapImage(new Uri("Images/Punchy.png", UriKind.Relative));
            Player.Fill = PlayerImage;

            ImageBrush WeaponImage = new ImageBrush();
            WeaponImage.ImageSource = new BitmapImage(new Uri(Player1.PlayerWeapon.WeaponImage, UriKind.Relative));
            Weapon.Fill = WeaponImage;

            ImageBrush WandImage = new ImageBrush();
            WandImage.ImageSource = new BitmapImage(new Uri(Player1.PlayerWand.WandImage, UriKind.Relative));
            Wand.Fill = WandImage;

            ImageBrush WitnerEnemy1Image = new ImageBrush();
            WitnerEnemy1Image.ImageSource = new BitmapImage(new Uri(Enemy1.EnemyImage, UriKind.Relative));
            WinterEnemy1.Fill = WitnerEnemy1Image;


        }

        private void btnAttack_Click(object sender, RoutedEventArgs e)
        {
            PlayerAttack();
            if (Enemy1.EnemyHealth <= 0)
            {
                WinterEnemy1.Visibility = Visibility.Hidden;
                Player1.PlayerScore += Enemy1.EnemyXP;
            }



            lblScore.Content = "Score =" + Player1.PlayerScore.ToString();

        }
        private void btnAttackWand_Click(object sender, RoutedEventArgs e)
        {
            PlayerAttackWand();
            if (Enemy1.EnemyHealth <= 0)
            {
                WinterEnemy1.Visibility = Visibility.Hidden;
                Player1.PlayerScore += Enemy1.EnemyXP;
            }



            lblScore.Content = "Score =" + Player1.PlayerScore.ToString();

        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TitleScreen());
        }

        public void PlayerAttack()
        {
            txtActionDisplay.Text = Player1.PlayerName + " attacked " + Enemy1.EnemyName + " with " + Player1.PlayerWeapon.WeaponName + " dealing " + Player1.PlayerWeapon.WeaponDamage.ToString() + " damage.";

            Player1.PlayerStamina -= Player1.PlayerWeapon.SPCost;
            lblPlayerSP.Content = "SP: " + Player1.PlayerStamina.ToString();
            Enemy1.EnemyHealth -= Player1.PlayerWeapon.WeaponDamage;
            lblEnemyHP.Content = "HP: " + Enemy1.EnemyHealth.ToString();

        }
        public void PlayerAttackWand()
        {

            txtActionDisplay.Text = Player1.PlayerName + " attacked " + Enemy1.EnemyName + " with " + Player1.PlayerWand.WandName + " dealing " + Player1.PlayerWand.WandDamage.ToString() + " damage.";

            Player1.PlayerStamina -= Player1.PlayerWand.SPCost;
            Player1.PlayerMana -= Player1.PlayerWand.MPCost;

            lblPlayerSP.Content = "SP: " + Player1.PlayerStamina.ToString();
            lblPlayerMP.Content = "MP: " + Player1.PlayerMana.ToString();

            Enemy1.EnemyHealth -= Player1.PlayerWand.WandDamage;
            lblEnemyHP.Content = "HP: " + Enemy1.EnemyHealth.ToString();

        }

    }
}
