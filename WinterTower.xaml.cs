using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
        public static Weapon Dagger = new Weapon("Dagger", "Short, but gets to the point", 15, 10);
        public static Wand MagicWand = new Wand("MagicWand", "The standard magical instrument", 25, 10, 25);
        public static Potion Heal = new Potion();
        public static Enemy_Attack Roar = new(1, "Roar", "The enemy ferociously roars!", 10);
        public static Enemy_Attack Swipe = new(2, "Swipe", "The enemy swipes at you!", 15);
        public static Enemy_Attack Explosion = new(3, "Explosion", "The enemy explodes!", 25);
        public static Enemy_Attack IceMist = new(4, "Ice Mist", "The enemy blows icy mist at you!", 10);
        public static Enemy_Attack Blizzard = new(5, "Blizzard", "The enemy unleashes a blizzard!", 25);


       Player Player1 = new Player();
        Enemy Enemy1 = new Enemy(1, "Yeti", "an evil monster", 50, Roar, Swipe, 1, 15, "Minion");
        Enemy Enemy2 = new Enemy(2, "Bomb", "an evil bomb monster", 50, Explosion, IceMist, 1, 15, "Minion");
        Enemy Enemy3 = new Enemy(3, "SnowJoker", "an evil snow joker monster", 50, IceMist, Blizzard, 1, 15, "Minion");


        List <Enemy> EnemyList = new List<Enemy>();
        List <Weapon> WeaponList = new List<Weapon>();
        List <Wand> WandList = new List<Wand>();
        
        
        public WinterTower(Player CurrentPlayer)
        {
            InitializeComponent();

            FightCanvas.Focus();

            EnemyList.Add(Enemy1);
            EnemyList.Add(Enemy2);
            EnemyList.Add(Enemy3);

            Player1 = CurrentPlayer;

            WeaponList.Add(Dagger);

            WandList.Add(MagicWand);

            RefreshScreen();



        }

        private void btnAttack_Click(object sender, RoutedEventArgs e)
        {
            PlayerAttack();
            if (EnemyList[0].EnemyHealth > 0)
            {
                EnemyAttack();
            }
            else
            {
                //WinterEnemyRect.Visibility = Visibility.Hidden;
                Player1.PlayerScore += Enemy1.EnemyXP;
                lblScore.Content = "Score : " + Player1.PlayerScore.ToString();
/*                btnAttack.IsEnabled = false;
                btnAttackWand.IsEnabled = false;*/
                txtActionDisplay.Text += Player1.PlayerName + " defeated " + EnemyList[0].EnemyName + " earning " + EnemyList[0].EnemyXP.ToString() + " score points!";
                EnemyRespawn();

            }


        }
        private void btnAttackWand_Click(object sender, RoutedEventArgs e)
        {
            PlayerAttackWand();
            if (EnemyList[0].EnemyHealth > 0)
            {
                EnemyAttack();
            }
           else {
                
                Player1.PlayerScore += Enemy1.EnemyXP;
                lblScore.Content = "Score : " + Player1.PlayerScore.ToString();
/*                btnAttack.IsEnabled = false;
                btnAttackWand.IsEnabled = false;*/
                txtActionDisplay.Text += Player1.PlayerName + " defeated " + EnemyList[0].EnemyName + " earning " + EnemyList[0].EnemyXP.ToString() + " score points!";
                EnemyRespawn();


            }


        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TitleScreen());
        }

        public void PlayerAttack()
        {
            txtActionDisplay.Text = Player1.PlayerName + " attacked " + EnemyList[0].EnemyName + " with " + Player1.PlayerWeapon.WeaponName + " dealing " + Player1.PlayerWeapon.WeaponDamage.ToString() + " damage.\n";

            Player1.PlayerStamina -= Player1.PlayerWeapon.SPCost;
            lblPlayerSP.Content = "SP: " + Player1.PlayerStamina.ToString();
            EnemyList[0].EnemyHealth -= Player1.PlayerWeapon.WeaponDamage;
            lblEnemyHP.Content = "HP: " + EnemyList[0].EnemyHealth.ToString();

        }
        public void PlayerAttackWand()
        {

            txtActionDisplay.Text = Player1.PlayerName + " attacked " + EnemyList[0].EnemyName + " with " + Player1.PlayerWand.WandName + " dealing " + Player1.PlayerWand.WandDamage.ToString() + " damage.\n";

            Player1.PlayerStamina -= Player1.PlayerWand.SPCost;
            Player1.PlayerMana -= Player1.PlayerWand.MPCost;

            lblPlayerSP.Content = "SP: " + Player1.PlayerStamina.ToString();
            lblPlayerMP.Content = "MP: " + Player1.PlayerMana.ToString();

            EnemyList[0].EnemyHealth -= Player1.PlayerWand.WandDamage;
            lblEnemyHP.Content = "HP: " + EnemyList[0].EnemyHealth.ToString();

        }
        public void EnemyAttack()
        {
            Random rd = new Random();

            int rand_num = rd.Next(1, 3);

            if (rand_num == 1){
                txtActionDisplay.Text += EnemyList[0].EnemyName + " attacked " + Player1.PlayerName + " with " + EnemyList[0].Attack1.EnemyAttackName + " dealing " + EnemyList[0].Attack1.EnemyAttackDamage.ToString() + " damage.";
                Player1.PlayerHealth -= EnemyList[0].Attack1.EnemyAttackDamage;

            }
            else
            {
                txtActionDisplay.Text += EnemyList[0].EnemyName + " attacked " + Player1.PlayerName + " with " + EnemyList[0].Attack2.EnemyAttackName + " dealing " + EnemyList[0].Attack2.EnemyAttackDamage.ToString() + " damage.";
                Player1.PlayerHealth -= EnemyList[0].Attack2.EnemyAttackDamage;

            }


            lblPlayerHP.Content = "HP: " + Player1.PlayerHealth.ToString();


        }

        public void PlayerDied()
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }

        public void EnemyRespawn()
        {
            EnemyList.RemoveAt(0);
            if(EnemyList.Count == 0)
            {
                //IF YOU KILL AL THE ENEMYIES, THIS HAPPENS
                Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
                Application.Current.Shutdown();
            }
            else
            {
                RefreshScreen();
            }
            
        }
        public void RefreshScreen()
        {
            if (EnemyList.Count > 0) 
            {
                lblPlayerName.Content = Player1.PlayerName;
                lblEnemyRole.Content = EnemyList[0].EnemyType;
                lblEnemyName.Content = EnemyList[0].EnemyName;
                btnAttack.Content = "Attack with " + Player1.PlayerWeapon.WeaponName;
                btnAttackWand.Content = "Attack with " + Player1.PlayerWand.WandName;

                lblPlayerHP.Content = "HP: " + Player1.PlayerHealth.ToString();
                lblPlayerSP.Content = "SP: " + Player1.PlayerStamina.ToString();
                lblPlayerMP.Content = "MP: " + Player1.PlayerMana.ToString();
                lblEnemyHP.Content = "HP: " + EnemyList[0].ToString();




                ImageBrush PlayerImage = new ImageBrush();
                PlayerImage.ImageSource = Player1.PlayerImage;
                PlayerRect.Fill = PlayerImage;

                ImageBrush PlayerHat = new ImageBrush();
                PlayerHat.ImageSource = Player1.PlayerHat;
                Hat.Fill = PlayerHat;

                ImageBrush WeaponImage1 = new ImageBrush();
                WeaponImage1.ImageSource = Player1.PlayerWeapon.WeaponImage;
                Weapon.Fill = WeaponImage1;

                ImageBrush WandImage = new ImageBrush();
                WandImage.ImageSource = Player1.PlayerWand.WandImage;
                Wand.Fill = WandImage;

                ImageBrush WitnerEnemyImage = new ImageBrush();
                WitnerEnemyImage.ImageSource = EnemyList[0].EnemyImage;
                WinterEnemyRect.Fill = WitnerEnemyImage;
            }
            


        }

    }
}
