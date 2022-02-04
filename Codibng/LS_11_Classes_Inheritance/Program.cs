#region ""



using System;

namespace LS_11_Classes_Inheritance
{
    class Program
    {
        #endregion


        static void Main(string[] args)
        {
      

            Entity MyEntity = new Entity();

            Player MyPlayer = new Player();

            Enemy MyEnemy = new Enemy();

            FighterPlayer MyFighter = new FighterPlayer();

            MyPlayer.playerWrite();

            
        }     



        class Entity
        {
            public string name;
            public int health;
            public int attack;

            public float attackDamage;

            public void Damage()
            {
                health -= attack;
                Console.WriteLine("New health is: " + health);
            }

            
        }

        class Player : Entity
        {
            public int defence;
            public int speed;

           public void playerWrite()
            {
                int[] attack_array = { 25, 32, 54, 36, 12};

                Random att = new Random();
                
                name = "Amateur";
                health = 299;
                attack = 15;
                defence = 16;
                speed = 20;
                Console.WriteLine(name + ("'s stats are: \nhealth: ") + health + (" \nattack: ") + attack + (" \ndefence: ") + defence + (" \nspeed: ") + speed);
            }

        public void grabEnemyStats(ref Enemy)
            {

            }
        }

        class FighterPlayer : Player
        {
           public FighterPlayer()
            {
                name = "";
                health = 1;
            }
        }

        class Enemy : Entity
        {
            public Enemy()
            {
                name = "Johnathon Paul";
                health = 350;
                attack = 3;
            }
        }

        #region ""
    }
}
#endregion