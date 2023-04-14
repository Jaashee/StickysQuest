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
    
        public static Weapon Dagger = new Weapon("Dagger", "Short, but gets to the point", "Weapon-Dagger", "Sprite-Dagger", "Stab", 10, "", 0, 5);
        public static Weapon BattleAxe = new Weapon("Battle Axe", "A standard battle axe", "Weapon-BattleAxe", "Sprite-BattleAxe", "Slash", 25, "", 0, 20);
        public static Weapon VolcanoAxe = new Weapon("Volcano Axe", "A legendary battle axe forged in the heart of a volcano", "Weapon-VolcanoAxe", "Sprite-VolcanoAxe", "Slash", 20, "Fire", 10, 25);

        public static Wand MagicWand = new Wand("Magic Wand", "The standard magical instrument", "Weapon-MagicWand", "Sprite-MagicWand", "Holy", 25, 10, 25);
        public static Wand CrystalWand = new Wand("Crystal Wand", "A wand carefully crafted of magic crystal", "Weapon-CrystalWand", "Sprite-CrystalWand", "Magic", 25, 10, 25);
        public static Wand EvilEyeScepter = new Wand("Evil Eye Scepter", "The eye of an evil cyclops has been attached to a scepter", "Weapon-EvilEyeScepter", "Sprite-EvilEyeScepter", "Fire", 25, 10, 25);
        public static Potion RedPotion = new Potion("Red Potion", "Heals 50 hp", "Sprite-RedPotion", "100500");
        public static Enemy_Attack Bounce = new(1, "Bounce", "The enemy bounces high and lands on you!", 10);
        public static Enemy_Attack Tackle = new(2, "Tackle", "The enemy tackles you!", 15);
        public static Enemy_Attack WaterTrap = new(3, "WaterTrap", "The enemy lures you to the water and drags you under!", 25);
        public static Enemy_Attack SnowBall = new(4, "Snow Ball", "The enemy throws a snow ball at you!", 10);
        public static Enemy_Attack SlimeSlam = new(5, "Slime Slam", "The enemy slime bounces incredibly high and lands with thunderous impact!", 30);
        public static Enemy_Attack LavaBurst = new(6, "Lava Burst", "The enemy bursts a lava bubble!", 20);
        public static Enemy_Attack GoneFishing = new(7, "Gone Fishing", "The enemy hooks you with their fishing rod!", 15);
        public static Enemy_Attack PolarStorm = new(7, "Polar Storm", "The enemy summons the cold winds of ancient winter!", 30);
        public static Enemy_Attack WinterDance = new(8, "Winter Dance", "The enemy dances and summons a blizzard!", 25);


        public static string[] SlimeWeak = { "Slash","Stab" };
        public static double[] SlimeWeakEffect = { 2.0, 0.5 };
        public static string[] LavaSlimeWeak = { "Slash", "Stab" ,"Water"};
        public static double[] LavaSlimeWeakEffect = { 2.0, 0.5 ,2.0}; 
        public static string[] SnowSlimeWeak = { "Slash", "Stab","Smash","Fire" };
        public static double[] SnowSlimeWeakEffect = { 2.0, 0.5, 2.0, 2.0 }; 
        public static string[] LilySlimeWeak = { "Slash", "Stab" , "Water" ,"Lightning"};
        public static double[] LilySlimeWeakEffect = { 2.0, 0.5, 0.5, 2.0 };
        public static string[] SantaSlimeWeak = { "Slash", "Stab", "Smash", "Fire", "Holy", "Magic" };
        public static double[] SantaSlimeWeakEffect = { 2.0, 0.5, 2.0, 2.0 , 0.5, 2.0};
        public static string[] KingSlimeWeak = { "Slash", "Stab" , "Magic", "Holy"};
        public static double[] KingSlimeWeakEffect = { 2.0, 0.5, 2.0,  0.5};


        public static string[] IceFishingWeak = { "Water", "Ice", "Fire" };
        public static double[] IceFishingEffect = { 0.5, 0.5, 2.0 };
        public static string[] LavaFishingWeak = { "Water", "Ice", "Fire" };
        public static double[] LavaFishingEffect = { 2.0, 0.5, 0.5 };

        public static string[] IceGolemWeak = { "Stab","Smash", "Water", "Ice", "Fire" };
        public static double[] IceGolemEffect = { 0.5, 2.0, 0.5, 0.5, 2.0 };

        public static string[] SnowflakeWeak = { "Smash", "Water", "Ice", "Fire" };
        public static double[] SnowflakeEffect = { 2.0, 0.5, 0.5, 2.0 };

        public static string[] PolarBeastWeak = { "Stab","Slice", "Water", "Ice", "Fire" };
        public static double[] PolarBeastEffect = { 2.0, 0.5, 0.5, 0.5, 2.0 };

        public static string[] SnowMiserWeak = { "Water", "Ice", "Fire", "Holy", "Magic" };
        public static double[] SnowMiserEffect = { 0.5, 0.5, 2.0, 0.5, 2.0 };

        public static string[] SnowMadManWeak = { "Water", "Ice", "Fire", "Magic", "Holy" };
        public static double[] SnowMadManEffect = { 0.5, 0.5, 2.0, 0.5, 2.0 };

        Player Player1 = new Player();
        public static Enemy IceFishing = new Enemy(1, "Ice Fisher", "A regular guy, he is ice fishing.", "Enemy-IceFishing", 30, SnowBall, GoneFishing, 1, 15, "Minion", IceFishingWeak, IceFishingEffect);
        public static Enemy LavaFishing = new Enemy(1, "Lava Fisher", "A regular guy, for some reason he is fishing in lava.", "Enemy-LavaFishing", 25, LavaBurst, GoneFishing, 1, 25, "Minion", LavaFishingWeak, LavaFishingEffect);
        public static Enemy IceGolem = new Enemy(1, "Ice Golem", "A strange creature made of ice colder than normal", "Enemy-IceGolem", 50, SnowBall, Tackle, 1, 25, "Minion", IceGolemWeak, IceGolemEffect);
        public static Enemy Snowflake = new Enemy(1, "Mishapen Snowflake", "A colossal snowflake that does not look happy", "Enemy-MisshapenSnowflake", 30, SnowBall, PolarStorm, 1, 40, "Minion", SnowflakeWeak, SnowflakeEffect);
        public static Enemy PolarBeast = new Enemy(1, "Polar Beast", "A creature that typically lives high in the northern arctic", "Enemy-PolarBeast", 25, Tackle, SnowBall, 1, 15, "Minion", PolarBeastWeak, PolarBeastEffect);
        public static Enemy SnowMadMan = new Enemy(1, "Snow Mad Man", "The soul of a mad man made form of snow.", "Enemy-SnowMadMan", 35, PolarStorm, SnowBall, 1, 35, "Minion", SnowMadManWeak, SnowMadManEffect);
        public static Enemy SnowMiser = new Enemy(1, "Snow Miser", "The king of winter.", "Enemy-SnowMiser", 45, PolarStorm, WinterDance, 5, 55, "Boss", SnowMiserWeak, SnowMiserEffect);

        public static  Enemy Slime = new Enemy(1, "Slime", "A very weak monster.  Very bouncy too.", "Enemy-Slime",25, Bounce, Tackle, 1, 15, "Minion", SlimeWeak, SlimeWeakEffect);
        public static Enemy LavaSlime = new Enemy(1, "Lava Slime", "A slime made of lava.  Do not try to bounce off them.","Enemy-LavaSlime", 33, Bounce, LavaBurst, 2, 25, "Minion", LavaSlimeWeak, LavaSlimeWeakEffect);
        public static Enemy SnowSlime = new Enemy(1, "Snow Slime", "A slime made of snow and ice.  It's insides are said to be colder than the arctic.","Enemy-SnowSlime", 29, Bounce, SnowBall, 2, 25, "Minion", SnowSlimeWeak, SnowSlimeWeakEffect);
        public static Enemy LilySlime = new Enemy(1, "Lily Slime", "A strange slime that lives under the water.","Enemy-LilySlime", 15, Bounce, WaterTrap, 3, 35, "Minion", LilySlimeWeak, LilySlimeWeakEffect);
        public static Enemy KingSlime = new Enemy(1, "The King of Slimes", "The King of Slimes is said to be the forefather of all other slimes", "Enemy-KingSlime",75, SlimeSlam, Bounce, 5, 55, "Boss", KingSlimeWeak, KingSlimeWeakEffect);
        public static Enemy SantaSlime = new Enemy(1, "Slimeta Clause", "This strange slime delivers presents to all the good slimes every year", "Enemy-SlimeClause", 75, SlimeSlam, SnowBall, 5, 55, "Boss", SantaSlimeWeak, SantaSlimeWeakEffect);


        List<Enemy> TowerList = new List<Enemy>();
        List <Weapon> WeaponList = new List<Weapon>();
        List <Wand> WandList = new List<Wand>();
        

        public WinterTower(Player CurrentPlayer)
        {
            InitializeComponent();
            FightCanvas.Focus();
            List<Enemy> EnemyList = new List<Enemy>()
            {
                IceFishing, LavaFishing, IceGolem, Snowflake, PolarBeast, SnowMadMan, Slime, LavaSlime, SnowSlime, LilySlime
            };
            List<Enemy> BossList = new List<Enemy>() 
            {
            SnowMiser, KingSlime, SantaSlime
            };

            Tower TempTower = new("The Temp Tower", "This tower seems to be covered in green slime.  Expect a gooey fight.", EnemyList, BossList);

            List<Enemy> Temp = new List<Enemy>()
            {
                TempTower.FirstEnemy, TempTower.SecondEnemy, TempTower.ThirdEnemy, TempTower.FourthEnemy, TempTower.Boss
            };
            TowerList = Temp;

            Player1 = CurrentPlayer;

            WeaponList.Add(Dagger);

            WandList.Add(MagicWand);

            RefreshScreen();



        }

        private void btnAttack_Click(object sender, RoutedEventArgs e)
        {
            PlayerAttack();
            if (TowerList[0].EnemyHealth > 0)
            {
                EnemyAttack(1);
            }
            else
            {
                Player1.PlayerScore += TowerList[0].EnemyXP;
                lblScore.Content = "Score : " + Player1.PlayerScore.ToString();

                txtActionDisplay.Text += Player1.PlayerName + " defeated " + TowerList[0].EnemyName + " earning " + TowerList[0].EnemyXP.ToString() + " score points!";
                EnemyRespawn();

            }


        }
        private void btnAttackWand_Click(object sender, RoutedEventArgs e)
        {
            PlayerAttackWand();
            if (TowerList[0].EnemyHealth > 0)
            {
                EnemyAttack(1);
            }
           else {
                
                Player1.PlayerScore += TowerList[0].EnemyXP;
                lblScore.Content = "Score : " + Player1.PlayerScore.ToString();

                txtActionDisplay.Text += Player1.PlayerName + " defeated " + TowerList[0].EnemyName + " earning " + TowerList[0].EnemyXP.ToString() + " score points!";
                EnemyRespawn();


            }


        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TitleScreen());
        }

        public void PlayerAttack()
        {
            double[] attackMultiplier = Player1.AttackMelee(TowerList[0]);
            double playerDamageP = Player1.PlayerWeapon.WeaponPDamage * attackMultiplier[0];
            double playerDamageS = Player1.PlayerWeapon.WeaponSDamage * attackMultiplier[1];

            if (Player1.PlayerWeapon.WeaponSDamageType == "")
            {
                txtActionDisplay.Text = Player1.PlayerName + " attacked " + TowerList[0].EnemyName + " with " + Player1.PlayerWeapon.WeaponName + " dealing " + playerDamageP.ToString() + " " + Player1.PlayerWeapon.WeaponPDamageType +" damage.\n";
                Player1.PlayerCurrentStamina -= Player1.PlayerWeapon.SPCost;
                lblPlayerSP.Content = "SP: " + Player1.PlayerCurrentStamina.ToString();
                TowerList[0].EnemyHealth -= playerDamageP;
                lblEnemyHP.Content = "HP: " + TowerList[0].EnemyHealth.ToString();
            }
            else
            {
                txtActionDisplay.Text = Player1.PlayerName + " attacked " + TowerList[0].EnemyName + " with " + Player1.PlayerWeapon.WeaponName + " dealing " + playerDamageP.ToString() + " " + Player1.PlayerWeapon.WeaponPDamageType + " damage.\n" +
                    "and " + playerDamageS.ToString() + " " + Player1.PlayerWeapon.WeaponSDamageType + " damage.\n";
                Player1.PlayerCurrentStamina -= Player1.PlayerWeapon.SPCost;
                lblPlayerSP.Content = "SP: " + Player1.PlayerCurrentStamina.ToString();
                TowerList[0].EnemyHealth -= playerDamageP;
                lblEnemyHP.Content = "HP: " + TowerList[0].EnemyHealth.ToString();
            }


        }
        public void PlayerAttackWand()
        {
            double attackMultiplier = Player1.AttackWand(TowerList[0]);
            double playerDamage = Player1.PlayerWand.WandDamage * attackMultiplier;


            txtActionDisplay.Text = Player1.PlayerName + " attacked " + TowerList[0].EnemyName + " with " + Player1.PlayerWand.WandName + " dealing " + playerDamage.ToString() +" " + Player1.PlayerWand.WandDamageType+ " damage.\n";

            Player1.PlayerCurrentStamina -= Player1.PlayerWand.SPCost;
            Player1.PlayerCurrentMana -= Player1.PlayerWand.MPCost;

            lblPlayerSP.Content = "SP: " + Player1.PlayerCurrentStamina.ToString();
            lblPlayerMP.Content = "MP: " + Player1.PlayerCurrentMana.ToString();

            TowerList[0].EnemyHealth -= playerDamage;
            lblEnemyHP.Content = "HP: " + TowerList[0].EnemyHealth.ToString();

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
                txtActionDisplay.Text += TowerList[0].EnemyName + " attacked " + Player1.PlayerName + " with " + TowerList[0].Attack1.EnemyAttackName + " dealing " + (TowerList[0].Attack1.EnemyAttackDamage * powerMuliply).ToString() + " damage.";
                Player1.PlayerCurrentHealth -= TowerList[0].Attack1.EnemyAttackDamage * powerMuliply;

            }
            else
            {
                txtActionDisplay.Text += TowerList[0].EnemyName + " attacked " + Player1.PlayerName + " with " + TowerList[0].Attack2.EnemyAttackName + " dealing " + (TowerList[0].Attack2.EnemyAttackDamage* powerMuliply).ToString() + " damage.";
                Player1.PlayerCurrentHealth -= TowerList[0].Attack2.EnemyAttackDamage * powerMuliply;

            }


            lblPlayerHP.Content = "HP: " + Player1.PlayerCurrentHealth.ToString();
            RefreshScreen();


        }

        public void PlayerDied()
        {

            this.NavigationService.Navigate(new Results(Player1, TowerList[0],false));

        }

        public void EnemyRespawn()
        {
            if(TowerList.Count == 1)
            {
                //IF YOU KILL AL THE ENEMYIES, THIS HAPPENS
                this.NavigationService.Navigate(new Results(Player1, TowerList[0], true));

            }
            else
            {
                TowerList.RemoveAt(0);
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
            if (TowerList.Count > 0) 
            {
                lblPlayerName.Content = Player1.PlayerName;
                lblEnemyRole.Content = TowerList[0].EnemyType;
                lblEnemyName.Content = TowerList[0].EnemyName;

                ImageBrush WeaponSprite = new ImageBrush();
                WeaponSprite.ImageSource = Player1.PlayerWeapon.WeaponSprite;
                btnAttack.Background = WeaponSprite;
                btnAttack.ToolTip = Player1.PlayerWeapon.ToString();

                ImageBrush WandSprite = new ImageBrush();
                WandSprite.ImageSource = Player1.PlayerWand.WandSprite;
                btnAttackWand.Background = WandSprite;
                btnAttackWand.ToolTip = Player1.PlayerWand.ToString();

                ImageBrush PotionSprite = new ImageBrush();
                PotionSprite.ImageSource = Player1.PlayerPotion.PotionImage;
                btnPotion.Background = PotionSprite;
                btnPotion.ToolTip = Player1.PlayerPotion.ToString();

                lblPlayerHP.Content = "HP: " + Player1.PlayerCurrentHealth.ToString();
                lblPlayerSP.Content = "SP: " + Player1.PlayerCurrentStamina.ToString();
                lblPlayerMP.Content = "MP: " + Player1.PlayerCurrentMana.ToString();
                lblEnemyHP.Content = "HP: " + TowerList[0].EnemyHealth.ToString();




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
                WitnerEnemyImage.ImageSource = TowerList[0].EnemyImage;
                WinterEnemyRect.Fill = WitnerEnemyImage;
            }
            


        }

        private void btnRest_Click(object sender, RoutedEventArgs e)
        {
            Player1.PlayerCurrentStamina += (Player1.PlayerStamina/1.5);
            Player1.PlayerCurrentMana += (Player1.PlayerMana/1.5);
            txtActionDisplay.Text = Player1.PlayerName + " took a rest to recover their stamina and mana, leaving themselves open to attack! \n";

            EnemyAttack(1.5);
            RefreshScreen();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.IsLoaded) // Check if the page is loaded
            {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                // Find the Image control with the name "imgBackground"
                Image imgBackground = mainWindow.FindName("imgTower") as Image;
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
                Image imgBackground = mainWindow.FindName("imgTower") as Image;
                if (imgBackground != null)
                {
                    // Set the visibility of the image to Collapsed
                    imgBackground.Visibility = Visibility.Collapsed;
                }
            }
        }

    }
}
