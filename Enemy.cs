using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TheGame
{
    public class Enemy
    {
        public double EnemyId { get; set; }
        public string EnemyName { get; set; }
        public string EnemyDesc { get; set; }
        public BitmapImage EnemyImage { get; set; }
        public double EnemyHealth { get; set; }
        public Enemy_Attack Attack1 { get; set; }
        public Enemy_Attack Attack2 { get; set; }
        public double EnemyLevel { get; set; }
        public double EnemyXP { get; set; }
        public string EnemyType { get; set; }
        public string[] EnemyWeakness {get; set;}
        public double[] EnemyWeaknessEffect { get; set; }

        public Enemy()
        {
/*            this.EnemyId = 1;
            this.EnemyName = "Monster";
            this.EnemyDesc = "An evil monster";
            this.EnemyImage = "\"Images/WinterEnemy1.png\"";
            this.EnemyHealth = 50;
            this.Attack1 = new Enemy_Attack();
            this.Attack2 = new Enemy_Attack();
            this.EnemyLevel = 1;
            this.EnemyXP = 15;
            this.EnemyType = "minion";*/
        }
        public Enemy(int EnemyId, string EnemyName, string EnemyDesc, string EnemyImage,int EnemyHealth, Enemy_Attack Attack1, Enemy_Attack Attack2, double EnemyLevel, double EnemyXP, string EnemyType, string[] EnemyWeakness, double[] EnemyWeaknessEffect)
        {
            this.EnemyId = EnemyId;
            this.EnemyName = EnemyName;
            this.EnemyDesc = EnemyDesc;
            this.EnemyImage = new BitmapImage(new Uri("Images/" + EnemyImage + ".png", UriKind.Relative));
            this.EnemyHealth = EnemyHealth;
            this.Attack1 = Attack1;
            this.Attack2 = Attack2;
            this.EnemyLevel = EnemyLevel;
            this.EnemyXP = EnemyXP;
            this.EnemyType = EnemyType;
            this.EnemyWeakness = EnemyWeakness;
            this.EnemyWeaknessEffect = EnemyWeaknessEffect;

        }

        public Enemy(int EnemyId, string EnemyName, string EnemyDesc, string  enemyImage, double EnemyHealth, double EnemyLevel, double EnemyXP, string EnemyType, List<string> EnemyWeakness, List<double> EnemyWeaknessEffect)
        {
            this.EnemyId = EnemyId;
            this.EnemyName = EnemyName;
            this.EnemyDesc = EnemyDesc;
            this.EnemyImage = new BitmapImage(new Uri("Images/" + enemyImage + ".png", UriKind.Relative)); 
            this.EnemyHealth = EnemyHealth;
            this.Attack1 = new Enemy_Attack();
            this.Attack2 = new Enemy_Attack();
            this.EnemyLevel = EnemyLevel;
            this.EnemyXP = EnemyXP;
            this.EnemyType = EnemyType;


        }
    }
}
