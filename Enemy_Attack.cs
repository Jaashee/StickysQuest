using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Enemy_Attack
    {
        public int EnemyAttackID { get; set; }
        public string EnemyAttackName { get; set; }
        public string EnemyAttackDesc { get; set; }
        public int EnemyAttackDamage { get; set; }




        public Enemy_Attack()
        {

            this.EnemyAttackID = 1;
            this.EnemyAttackName = "tackle";
            this.EnemyAttackDesc = "The enemy throws themselves at you!";
            this.EnemyAttackDamage = 10;
        }

        public Enemy_Attack(int EnemyAttackID, string EnemyAttackName, string EnemyAttackDesc, int EnemyAttackDamage)
        {
            this.EnemyAttackID = EnemyAttackID;
            this.EnemyAttackName = EnemyAttackName;
            this.EnemyAttackDesc = EnemyAttackDesc;
            this.EnemyAttackDamage = EnemyAttackDamage;


        }
    }
}