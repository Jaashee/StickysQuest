﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;


namespace TheGame
{


    public class Player 
    {


        public string PlayerName { get; set; }
        public BitmapImage PlayerImage { get; set; }
        public BitmapImage PlayerHat { get; set; }

        public double PlayerHealth { get; set; }
        public double PlayerCurrentHealth { get; set; }
        public double PlayerStamina { get; set; }
        public double PlayerCurrentStamina { get; set; }
        public double PlayerMana { get; set; }
        public double PlayerCurrentMana { get; set; }
        public double PlayerLevel { get; set; }
        public double PlayerScore { get; set; }
        public Weapon PlayerWeapon { get; set; }
        public Wand PlayerWand { get; set; }
        public Potion PlayerPotion { get; set; }



        public Player()
        {

        }
        public Player(string PlayerName, string PlayerColour, string PlayerHat, double PlayerHealth, double PlayerStamina, double PlayerMana, double PlayerLevel, 
            double PlayerScore, Weapon PlayerWeapon, Wand PlayerWand, Potion PlayerPotion)
        {
            this.PlayerName = PlayerName;
            this.PlayerImage = new BitmapImage(new Uri("Images/" + PlayerColour + ".png", UriKind.Relative));
            this.PlayerHat = new BitmapImage(new Uri("Images/" + PlayerHat + ".png", UriKind.Relative));
            this.PlayerHealth = PlayerHealth;
            this.PlayerCurrentHealth = PlayerHealth;
            this.PlayerStamina = PlayerStamina;
            this.PlayerCurrentStamina = PlayerStamina;
            this.PlayerMana = PlayerMana;
            this.PlayerCurrentMana = PlayerMana;
            this.PlayerLevel = PlayerLevel;
            this.PlayerScore = PlayerScore;
            this.PlayerWeapon = PlayerWeapon;
            this.PlayerWand = PlayerWand;
            this.PlayerPotion = PlayerPotion;

        }
        public double[] AttackMelee(Enemy CurrentEnemy)
        {
            int i = 0;
            double[] damage = { 1.0, 1.0 };
            foreach (string CurrentDamageType in CurrentEnemy.EnemyWeakness)
            {
                
            if (CurrentDamageType == this.PlayerWeapon.WeaponPDamageType)
                {
                    damage[0] = damage[0] * CurrentEnemy.EnemyWeaknessEffect[i];
                }

                if (CurrentDamageType == this.PlayerWeapon.WeaponSDamageType)
                {
                    damage[1] = damage[1] * CurrentEnemy.EnemyWeaknessEffect[i];
                }

                i++;
            }

            return damage;
        }

        public double AttackWand(Enemy CurrentEnemy)
        {
            double damage =1.0;
            int i = 0;

            foreach (string CurrentDamageType in CurrentEnemy.EnemyWeakness)
            {
                if (CurrentDamageType == this.PlayerWand.WandDamageType)
                {
                    damage *= CurrentEnemy.EnemyWeaknessEffect[i];
                }

                i++;
            }

            return damage;
        }
        public void ChangeColour( string Colour)
        {
            this.PlayerImage = new BitmapImage(new Uri("Images/" + Colour + ".png", UriKind.Relative));
        }
        public void ChangeHat(string Hat)
        {
            this.PlayerHat = new BitmapImage(new Uri("Images/" + Hat + ".png", UriKind.Relative));
        }

        public string UsePotion()
        {
            char[] PotionEffects = this.PlayerPotion.PotionEffect.ToCharArray();//100500
            char health = PotionEffects[0];
            char stamina = PotionEffects[1];
            char mana = PotionEffects[2];
            double amount = int.Parse(PotionEffects[3].ToString() + PotionEffects[4].ToString());
            char percent = PotionEffects[5];
            string flavourText = this.PlayerName + "'s " +this.PlayerPotion.PotionName + " restored " + amount;

            if (health.ToString() == "1")
            {
                this.PlayerCurrentHealth = this.PlayerCurrentHealth + amount;
                if (this.PlayerCurrentHealth > this.PlayerHealth){
                    this.PlayerCurrentHealth = this.PlayerHealth;
                }
                flavourText += " health";
            }
            if (stamina.ToString() == "1")
            {
                this.PlayerCurrentStamina = this.PlayerCurrentStamina + amount;
                if (this.PlayerCurrentStamina > this.PlayerStamina)
                {
                    this.PlayerCurrentStamina = this.PlayerStamina;
                }
                flavourText += " stamina";

            }
            if (mana.ToString() == "1")
            {
                this.PlayerCurrentMana = this.PlayerCurrentMana + amount;
                if (this.PlayerCurrentMana > this.PlayerMana)
                {
                    this.PlayerCurrentMana = this.PlayerMana;
                }
                flavourText += " of mana";

            }
            flavourText += "\n";

            return (flavourText);
        }
        public void ValidateName(string Name)
        {
            string Error = "";
            if (string.IsNullOrEmpty(Name))
            {
                Error = "Name cannot be empty";
            }
            else if (Name.Length > 20)
            {
                Error = "Name Cannot longer than 20 characters";

            }

            if (string.IsNullOrEmpty(Error))
            {
                this.PlayerName = Name;

            }
            else
            {
                MessageBox.Show(Error);
                return;
            }
        }
        /*        public Player(string PlayerName, string PlayerImage, double PlayerHealth, double PlayerStamina, double PlayerMana, double PlayerLevel, double PlayerScore)
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

