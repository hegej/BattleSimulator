using System;

namespace BattleSimulator
{
    class Program
    {

        static Random random = new Random();

        static void Main(string[] args)
        {
            var enemy = new Enemy(100, 10);
            var player = new Player(100, 11);

            for (int i = 0; i <= 20; i++)
            {
                var x = random.Next(0, 100);
                Console.WriteLine("This is random: " + x);
                if(x <= 50)
                {
                    player.Attack(enemy, player.weaponDamage);
                    Console.WriteLine("Player attacks enemy, Enemy lose " + player.weaponDamage + " life. Enemy life is: " + enemy.life);
                }
                else
                {
                    enemy.Attack(player, enemy.weaponDamage);
                    Console.WriteLine("Enemy attacks player, player lose " + enemy.weaponDamage + " life. Player life is: " + player.life);
                }

                if(enemy.life <=0)
                {
                    Console.WriteLine("Enemy is dead, Player has won!");
                    break;
                }
                if (player.life <= 0)
                {
                    Console.WriteLine("Player is dead, Enemy has won!");
                    break;
                }

            }


        }
    }


    public class Player
    {
        public int life;
        public int weaponDamage;

        public Player(int life, int weaponDamage)
        {
            this.life = life;
            this.weaponDamage = weaponDamage;
        }
        public void Attack(Enemy enemy, int weaponDamage)
        {
              enemy.life = enemy.life - weaponDamage;
        }

    }

    public class Enemy
    {
        public int life;
        public int weaponDamage;

        public Enemy(int life, int weaponDamage)
        {
            this.life = life;
            this.weaponDamage = weaponDamage;
        }
        public void Attack(Player player, int weaponDamage)
        {
            player.life = player.life - weaponDamage;
        }
    }

}
