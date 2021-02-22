using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_sharrarx
{
    public static class Storing
    {

        enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        struct _enemy
        {
            public string name;
            public int health;
            public bool isAlive;
            public float damage;
        }



        //Our first method
        public static void Initialize()
        {
            Console.WriteLine("Hi!");
            Console.WriteLine("C# Bootcamp Initialized");

        }

        //Our second method
        public static void DemoVariables()
        {
            int itemDurability = 524;
            char firstInitial = 'B';
            float stamina = 80.4f;
            bool isAlive = true;
            string playerName = "Billy Bob";
            string heldItem = "Wooden Sword";

            Console.WriteLine("Player Name:\t\t" + playerName);
            Console.WriteLine("Held Item (Durability):\t\t{0} ({1})", heldItem, itemDurability);
            Console.WriteLine("Stamina:\t\t{0}\nAlive:\t\t{1}", stamina, isAlive);
        }

        public static void ReadingInput()
        {
            Console.Write("Choose your name. > ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome, {0}. ", name);
            Console.Write("How old are you, {0}?> ", name);
            int ageinyears = Convert.ToInt16(Console.ReadLine());
            int month = ageinyears * 12;
            float days = ageinyears * 365.25f;
            Console.WriteLine("{0}, you are {1} months old or {2} days old", name, month, days);

        }

        public static void UsingArrays()
        {
            string[] enemyName = new string[5];
            enemyName[0] = "Bob";
            enemyName[1] = "Bill";
            enemyName[2] = "Joe";
            enemyName[3] = "Asmodeus the Demon Lord";
            enemyName[4] = "Henry";
            int[] enemyHealth = new int[5] { 20, 16, 3, 22, 2500 };

            System.Random random = new System.Random();

            while (true)
            {
                int num = random.Next(5);
                Console.WriteLine(num);
                Console.WriteLine("you fight {0}, their health is {1}", enemyName[num], enemyHealth[num]);
            }
        }


        public static void ConstantsEnumsStructs()
        {
            const double pi = 3.1415965353;
            Console.WriteLine(pi);

            var dayOfWeek = Days.Sunday;
            Console.WriteLine("The day is {0}", dayOfWeek);
            if (dayOfWeek == Days.Sunday || dayOfWeek == Days.Sunday)
            {
                Console.WriteLine("It's a weekend!");
            } else
            {
                Console.WriteLine("It's a weekday.");
            }
            _enemy boss;
            boss.name = "Vlad the Destroyer";
            boss.health = 40;
            boss.isAlive = true;
            boss.damage = 10;

            boss.health--;
            Console.WriteLine("{0} has health of {1}", boss.name, boss.health);
        }







    } //public static class Storing
}
