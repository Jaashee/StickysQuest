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
    /// Interaction logic for CreateCharacter.xaml
    /// </summary>
    public partial class CreateCharacter : Page
    {
        public static Weapon Dagger = new Weapon("Dagger", "Short, but gets to the point", "Weapon-Dagger","Sprite-Dagger", "Stab", 15, "", 0, 10);
        public static Wand MagicWand = new Wand("MagicWand", "The standard magical instrument", "Weapon-MagicWand", "Sprite-MagicWand", "Holy", 25, 10, 25);
        public static Potion RedPotion = new Potion("Red Potion", "Heals 50 hp","Sprite-RedPotion" ,"100500");
        Player Player1 = new Player("Player", "Player-Black", "Hat-None", 100, 100, 100, 1, 0, Dagger, MagicWand, RedPotion);


        public CreateCharacter()
        {
            InitializeComponent();




            RefreshScreen();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string PlayernName = "";
            PlayernName = txtPlayerName.Text;
            Player1.ValidateName(PlayernName);

            if (Player1.PlayerName == PlayernName)
            {
                this.NavigationService.Navigate(new WinterTower(Player1));

            }
        }

        private void cmboColour_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmboColour.SelectedIndex == 0) {
                Player1.ChangeColour("Player-Black");
            }else if (cmboColour.SelectedIndex == 1)
            {
                Player1.ChangeColour("Player-Red");
            }
            else if (cmboColour.SelectedIndex == 2)
            {
                Player1.ChangeColour("Player-Pink");
            }
            else if (cmboColour.SelectedIndex == 3)
            {
                Player1.ChangeColour("Player-Green");
            }
            else if (cmboColour.SelectedIndex == 4)
            {
                Player1.ChangeColour("Player-Blue");
            }

            RefreshScreen();
        }

        private void cmboHat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmboHat.SelectedIndex == 0)
            {
                Player1.ChangeHat("Hat-None");
            }
            else if (cmboHat.SelectedIndex == 1)
            {
                Player1.ChangeHat("Hat-Tophat");
            }
            else if (cmboHat.SelectedIndex == 2)
            {
                Player1.ChangeHat("Hat-CatEars");
            }
            else if (cmboHat.SelectedIndex == 3)
            {
                Player1.ChangeHat("Hat-Space");
            }
            RefreshScreen();
        }
    

        public void RefreshScreen()
        {


                ImageBrush PlayerImage = new ImageBrush();
                PlayerImage.ImageSource = Player1.PlayerImage;
                PlayerRect.Fill = PlayerImage;

                ImageBrush PlayerHat = new ImageBrush();
                PlayerHat.ImageSource = Player1.PlayerHat;
                Hat.Fill = PlayerHat;

            



        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TitleScreen());
        }
    }
}
