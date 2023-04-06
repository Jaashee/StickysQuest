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
    
        public static Weapon Dagger = new Weapon("Dagger", "Short, but gets to the point", "Weapon-Dagger", "Sprite-Dagger", "Stab", 15, "", 0, 10);
        public static Wand MagicWand = new Wand("MagicWand", "The standard magical instrument", "Weapon-MagicWand", "Sprite-MagicWand", "Holy", 25, 10, 25);
        public static Potion RedPotion = new Potion("Red Potion", "Heals 50 hp", "Sprite-RedPotion", "100500");
        public static Enemy_Attack Bounce = new(1, "Bounce", "The enemy bounces high and lands on you!", 10);
        public static Enemy_Attack Tackle = new(2, "Tackle", "The enemy tackles you!", 15);
        public static Enemy_Attack WaterTrap = new(3, "WaterTrap", "The enemy lures you to the water and drags you under!", 25);
        public static Enemy_Attack SnowBall = new(4, "Snow Ball", "The enemy throws a snow ball at you!", 10);
        public static Enemy_Attack SlimeSlam = new(5, "Slime Slam", "The enemy slime bounces incredibly high and lands with thunderous impact!", 30);
        public static Enemy_Attack LavaBurst = new(6, "Lava Burst", "The enemy bursts a lava bubble!", 20);


        public static string[] SlimeWeak = { "Slash","Stab" };
        public static double[] SlimeWeakEffect = { 2.0, 0.5 };
        public static string[] LavaSlimeWeak = { "Slash", "Stab" ,"Water"};
        public static double[] LavaSlimeWeakEffect = { 2.0, 0.5 ,2.0}; 
        public static string[] SnowSlimeWeak = { "Slash", "Stab","Smash","Water" };
        public static double[] SnowSlimeWeakEffect = { 2.0, 0.5, 2.0, 2.0 }; 
        public static string[] LilySlimeWeak = { "Slash", "Stab" , "Water" ,"Lightning"};
        public static double[] LilySlimeWeakEffect = { 2.0, 0.5, 0.5, 2.0 }; 
        public static string[] KingSlimeWeak = { "Slash", "Stab" , "Holy"};
        public static double[] KingSlimeWeakEffect = { 2.0, 0.5, 0.5};





        Player Player1 = new Player();
       public static  Enemy Slime = new Enemy(1, "Slime", "A very weak monster.  Very bouncy too.", "Enemy-Slime",25, Bounce, Tackle, 1, 15, "Minion", SlimeWeak, SlimeWeakEffect);
        public static Enemy LavaSlime = new Enemy(1, "Lava Slime", "A slime made of lava.  Do not try to bounce off them.","Enemy-LavaSlime", 33, Bounce, LavaBurst, 2, 25, "Minion", LavaSlimeWeak, LavaSlimeWeakEffect);
        public static Enemy SnowSlime = new Enemy(1, "Snow Slime", "A slime made of snow and ice.  It's insides are said to be colder than the arctic.","Enemy-SnowSlime", 29, Bounce, SnowBall, 2, 25, "Minion", SnowSlimeWeak, SnowSlimeWeakEffect);
        public static Enemy LilySlime = new Enemy(1, "Lily Slime", "A strange slime that lives under the water.","Enemy-LilySlime", 15, Bounce, WaterTrap, 3, 35, "Minion", LilySlimeWeak, LilySlimeWeakEffect);
        public static Enemy KingSlime = new Enemy(1, "The King of Slimes", "The King of Slimes is said to be the forefather of all other slimes", "Enemy-KingSlime",100, SlimeSlam, Bounce, 5, 55, "Boss", KingSlimeWeak, KingSlimeWeakEffect);
        Tower SlimeTower = new("The Slime Tower", "This tower seems to be covered in green slime.  Expect a gooey fight.", Slime, LavaSlime, SnowSlime, LilySlime, KingSlime);


        List<Enemy> EnemyList = new List<Enemy>();
        List <Weapon> WeaponList = new List<Weapon>();
        List <Wand> WandList = new List<Wand>();
        
        
        public WinterTower(Player CurrentPlayer)
        {
            InitializeComponent();

            FightCanvas.Focus();

            EnemyList.Add(SlimeTower.FirstEnemy);
            EnemyList.Add(SlimeTower.SecondEnemy);
            EnemyList.Add(SlimeTower.ThirdEnemy);
            EnemyList.Add(SlimeTower.FourthEnemy);
            EnemyList.Add(SlimeTower.Boss);

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
                EnemyAttack(1);
            }
            else
            {
                Player1.PlayerScore += EnemyList[0].EnemyXP;
                lblScore.Content = "Score : " + Player1.PlayerScore.ToString();

                txtActionDisplay.Text += Player1.PlayerName + " defeated " + EnemyList[0].EnemyName + " earning " + EnemyList[0].EnemyXP.ToString() + " score points!";
                EnemyRespawn();

            }


        }
        private void btnAttackWand_Click(object sender, RoutedEventArgs e)
        {
            PlayerAttackWand();
            if (EnemyList[0].EnemyHealth > 0)
            {
                EnemyAttack(1);
            }
           else {
                
                Player1.PlayerScore += EnemyList[0].EnemyXP;
                lblScore.Content = "Score : " + Player1.PlayerScore.ToString();

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
            double[] attackMultiplier = Player1.AttackMelee(EnemyList[0]);
            double playerDamageP = Player1.PlayerWeapon.WeaponPDamage * attackMultiplier[0];
            double playerDamageS = Player1.PlayerWeapon.WeaponSDamage * attackMultiplier[1];

            if (Player1.PlayerWeapon.WeaponSDamageType == "")
            {
                txtActionDisplay.Text = Player1.PlayerName + " attacked " + EnemyList[0].EnemyName + " with " + Player1.PlayerWeapon.WeaponName + " dealing " + playerDamageP.ToString() + " " + Player1.PlayerWeapon.WeaponPDamageType +" damage.\n";
                Player1.PlayerCurrentStamina -= Player1.PlayerWeapon.SPCost;
                lblPlayerSP.Content = "SP: " + Player1.PlayerCurrentStamina.ToString();
                EnemyList[0].EnemyHealth -= playerDamageP;
                lblEnemyHP.Content = "HP: " + EnemyList[0].EnemyHealth.ToString();
            }
            else
            {
                txtActionDisplay.Text = Player1.PlayerName + " attacked " + EnemyList[0].EnemyName + " with " + Player1.PlayerWeapon.WeaponName + " dealing " + playerDamageP.ToString() + " " + Player1.PlayerWeapon.WeaponPDamageType + " damage.\n" +
                    "and " + playerDamageS.ToString() + " " + Player1.PlayerWeapon.WeaponSDamageType + " damage.\n";
                Player1.PlayerCurrentStamina -= Player1.PlayerWeapon.SPCost;
                lblPlayerSP.Content = "SP: " + Player1.PlayerCurrentStamina.ToString();
                EnemyList[0].EnemyHealth -= playerDamageP;
                lblEnemyHP.Content = "HP: " + EnemyList[0].EnemyHealth.ToString();
            }


        }
        public void PlayerAttackWand()
        {
            double attackMultiplier = Player1.AttackWand(EnemyList[0]);
            double playerDamage = Player1.PlayerWand.WandDamage * attackMultiplier;


            txtActionDisplay.Text = Player1.PlayerName + " attacked " + EnemyList[0].EnemyName + " with " + Player1.PlayerWand.WandName + " dealing " + playerDamage.ToString() +" " + Player1.PlayerWand.WandDamageType+ " damage.\n";

            Player1.PlayerCurrentStamina -= Player1.PlayerWand.SPCost;
            Player1.PlayerCurrentMana -= Player1.PlayerWand.MPCost;

            lblPlayerSP.Content = "SP: " + Player1.PlayerCurrentStamina.ToString();
            lblPlayerMP.Content = "MP: " + Player1.PlayerCurrentMana.ToString();

            EnemyList[0].EnemyHealth -= playerDamage;
            lblEnemyHP.Content = "HP: " + EnemyList[0].EnemyHealth.ToString();

        }
        private void btnPotion_Click(object sender, RoutedEventArgs e)
        {
            txtActionDisplay.Text = Player1.UsePotion();
            EnemyAttack(1);
        }

        public void EnemyAttack(double powerMuliply)
        {
            Random rd = new Random();

            double rand_num = rd.Next(1, 3);

            if (rand_num == 1){
                txtActionDisplay.Text += EnemyList[0].EnemyName + " attacked " + Player1.PlayerName + " with " + EnemyList[0].Attack1.EnemyAttackName + " dealing " + (EnemyList[0].Attack1.EnemyAttackDamage * powerMuliply).ToString() + " damage.";
                Player1.PlayerCurrentHealth -= EnemyList[0].Attack1.EnemyAttackDamage * powerMuliply;

            }
            else
            {
                txtActionDisplay.Text += EnemyList[0].EnemyName + " attacked " + Player1.PlayerName + " with " + EnemyList[0].Attack2.EnemyAttackName + " dealing " + (EnemyList[0].Attack2.EnemyAttackDamage* powerMuliply).ToString() + " damage.";
                Player1.PlayerCurrentHealth -= EnemyList[0].Attack2.EnemyAttackDamage * powerMuliply;

            }


            lblPlayerHP.Content = "HP: " + Player1.PlayerCurrentHealth.ToString();
            RefreshScreen();


        }

        public void PlayerDied()
        {

            this.NavigationService.Navigate(new Results(Player1, EnemyList[0],false));

        }

        public void EnemyRespawn()
        {
            if(EnemyList.Count == 1)
            {
                //IF YOU KILL AL THE ENEMYIES, THIS HAPPENS
                this.NavigationService.Navigate(new Results(Player1, EnemyList[0], true));

            }
            else
            {
                EnemyList.RemoveAt(0);
                RefreshScreen();
            }
            
        }
        public void RefreshScreen()
        {
            if ((Player1.PlayerCurrentStamina <= 0) || (Player1.PlayerCurrentMana <= 0))
            {
                btnRest.IsEnabled = true;
                btnAttack.IsEnabled = false;
                btnPotion.IsEnabled = false;
                btnAttackWand.IsEnabled = false;

            }
            else
            {
                btnRest.IsEnabled = false;
                btnAttack.IsEnabled = true;
                btnPotion.IsEnabled = true;
                btnAttackWand.IsEnabled = true;

            }
            if (Player1.PlayerCurrentHealth <= 0)
            {
                PlayerDied();
            }
            if (EnemyList.Count > 0) 
            {
                lblPlayerName.Content = Player1.PlayerName;
                lblEnemyRole.Content = EnemyList[0].EnemyType;
                lblEnemyName.Content = EnemyList[0].EnemyName;

                ImageBrush WeaponSprite = new ImageBrush();
                WeaponSprite.ImageSource = Player1.PlayerWeapon.WeaponSprite;
                btnAttack.Background = WeaponSprite;

                ImageBrush WandSprite = new ImageBrush();
                WandSprite.ImageSource = Player1.PlayerWand.WandSprite;
                btnAttackWand.Background = WandSprite;

                ImageBrush PotionSprite = new ImageBrush();
                PotionSprite.ImageSource = Player1.PlayerPotion.PotionImage;
                btnPotion.Background = PotionSprite;

                lblPlayerHP.Content = "HP: " + Player1.PlayerCurrentHealth.ToString();
                lblPlayerSP.Content = "SP: " + Player1.PlayerCurrentStamina.ToString();
                lblPlayerMP.Content = "MP: " + Player1.PlayerCurrentMana.ToString();
                lblEnemyHP.Content = "HP: " + EnemyList[0].EnemyHealth.ToString();




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

        private void btnRest_Click(object sender, RoutedEventArgs e)
        {
            Player1.PlayerCurrentStamina += (Player1.PlayerStamina/1.5);
            Player1.PlayerCurrentMana += (Player1.PlayerMana/1.5);
            txtActionDisplay.Text += Player1.PlayerName + " took a rest to recover their stamina and mana, leaving themselves open to attack! \n";

            EnemyAttack(1.5);
            RefreshScreen();
        }
    }
}
