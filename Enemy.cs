using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Enemy
    {
        public int EnemyId { get; set; }
        public string EnemyName { get; set; }
        public string EnemyDesc { get; set; }
        public string EnemyImage { get; set; }
        public int EnemyHealth { get; set; }
        public Enemy_Attack Attack1 { get; set; }
        public Enemy_Attack Attack2 { get; set; }
        public int EnemyLevel { get; set; }
        public int EnemyXP { get; set; }
        public string EnemyType { get; set; }


        public Enemy()
        {
            this.EnemyId = 1;
            this.EnemyName = "Monster";
            this.EnemyDesc = "An evil monster";
            this.EnemyImage = "\"Images/WinterEnemy1.png\"";
            this.EnemyHealth = 50;
            this.Attack1 = new Enemy_Attack();
            this.Attack2 = new Enemy_Attack();
            this.EnemyLevel = 1;
            this.EnemyXP = 15;
            this.EnemyType = "minion";
        }
        public Enemy(int EnemyId, string EnemyName, string EnemyDesc, string EnemyImage, int EnemyHealth, Enemy_Attack Attack1, Enemy_Attack Attack2, int EnemyLevel, int EnemyXP, string EnemyType)
        {
            this.EnemyId = EnemyId;
            this.EnemyName = EnemyName;
            this.EnemyDesc = EnemyDesc;
            this.EnemyImage = EnemyImage;
            this.EnemyHealth = EnemyHealth;
            this.Attack1 = Attack1;
            this.Attack2 = Attack2;
            this.EnemyLevel = EnemyLevel;
            this.EnemyXP = EnemyXP;
            this.EnemyType = EnemyType;


        }

        public Enemy(int EnemyId, string EnemyName, string EnemyDesc, string EnemyImage, int EnemyHealth, int EnemyLevel, int EnemyXP, string EnemyType)
        {
            this.EnemyId = EnemyId;
            this.EnemyName = EnemyName;
            this.EnemyDesc = EnemyDesc;
            this.EnemyImage = EnemyImage;
            this.EnemyHealth = EnemyHealth;
            this.Attack1 = new Enemy_Attack();
            this.Attack2 = new Enemy_Attack();
            this.EnemyLevel = EnemyLevel;
            this.EnemyXP = EnemyXP;
            this.EnemyType = EnemyType;


        }
    }
}
