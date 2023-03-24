using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheGame
{
    public class Player 
    {


        public string PlayerName { get; set; }
        public string PlayerImage { get; set; }
        public int PlayerHealth { get; set; }
        public int PlayerStamina { get; set; }
        public int PlayerMana { get; set; }
        public int PlayerLevel { get; set; }
        public int PlayerScore { get; set; }
        public Weapon PlayerWeapon { get; set; }
        public Wand PlayerWand { get; set; }
        public Potion PlayerPotion { get; set; }



        public Player()
        {

        }
        public Player(string PlayerName, string PlayerImage, int PlayerHealth, int PlayerStamina, int PlayerMana, int PlayerLevel, 
            int PlayerScore, Weapon PlayerWeapon, Wand PlayerWand, Potion PlayerPotion)
        {
            this.PlayerName = PlayerName;
            this.PlayerImage = PlayerImage;
            this.PlayerHealth = PlayerHealth;
            this.PlayerStamina = PlayerStamina;
            this.PlayerMana = PlayerMana;
            this.PlayerLevel = PlayerLevel;
            this.PlayerScore = PlayerScore;
            this.PlayerWeapon = PlayerWeapon;
            this.PlayerWand = PlayerWand;
            this.PlayerPotion = PlayerPotion;

        }

/*        public Player(string PlayerName, string PlayerImage, int PlayerHealth, int PlayerStamina, int PlayerMana, int PlayerLevel, int PlayerScore)
        {
            this.PlayerName = PlayerName;
            this.PlayerImage = PlayerImage;
            this.PlayerHealth = PlayerHealth;
            this.PlayerStamina = PlayerStamina;
            this.PlayerMana = PlayerMana;
            this.PlayerLevel = PlayerLevel;
            this.PlayerScore = PlayerScore;
            this.PlayerWeapon = new Weapon();
            this.PlayerWand = new Wand();
            this.PlayerPotion = new Potion();

        }*/



    }
}
