using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_sharrarx
{
    class Statements
    {
        public static void BranchingIf()
        {
            int a = 3;

            if (a < 4)
            {
                Console.WriteLine("Number is less than 4");
                Console.WriteLine("more stuff...");
            }
            else if (a >= 4 && a <= 10)
            {
                Console.WriteLine("Number is between 4 and 10 (inclusive)");
            }
            else
            {
                Console.WriteLine("Number is greater than 10");
            }

            int b = 10;
            if (b > 5)
                Console.WriteLine("b is bigger than 5");

        }

        public static void Switchin()
        {
            int d = 878945;
            string day = "";

            switch (d % 7)
            {
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                default:
                    day = "Weekend!";
                    break;

            }
            Console.WriteLine("Day {0} is {1}", d, day);
        }

        public static void ForLoop()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("The value of i is {0}", i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Outer Loop {0}", i);

                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("\tInner Loop {0}", j);
                }
            }
        }

        public static void WhileLoops()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("The value of i is {0}", i);
                i++;
            }

            int j = 0;
            do
            {
                Console.WriteLine("The value of j is {0}", j);
                j++;
            } while (j < 5);

            do
            {
                Console.WriteLine("Enter command: > ");
            } while (Console.ReadLine() != "q");

        }

        public static void LoopingArrays()
        {
            string[] monster = new string[4];
            monster[0] = "Joe the Strong";
            monster[1] = "Bill the Fearless";
            monster[2] = "Chase the Quick";
            monster[3] = "Vlad the Smart";

            Console.WriteLine("Monster List:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("\t{0}", monster[i]);
            }
        }

        public static void ForEachIterations()
        {
            List<string> weapons = new List<string>();
            weapons.Add("Mace");
            weapons.Add("Sword");
            weapons.Add("Bow");
            weapons.Add("Flail");
            weapons.Add("Staff");
            weapons.Add("Axe");

            Console.WriteLine("List of weapons in our shop:");

            foreach (string p in weapons)
            {
                Console.WriteLine("\t{0}", p);
            }

        }

    }
}
