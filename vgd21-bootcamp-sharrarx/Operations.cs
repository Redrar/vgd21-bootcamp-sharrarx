using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_sharrarx
{
    public  static class Operations
    {

        public static void Arithmetic()
        {
            int a = 9;
            int b = 6;
            int c;

            a++;
            b--;

            c = a + b;
            c = a - b;
            c = a * b;
            c = a / b;

            c = a % b;
            c = b % a;
            c = 13 % 2;
            c = 14 % 2;
            c = 15 % 2;


            a += b;
            a -= 7;
            a *= b;
            a /= 7;
        }

        public static void Comparison()
        {
            int a = 10;
            int b = 45;
            int c = 10;
            Console.WriteLine(a == b);
            Console.WriteLine(a == c);
            Console.WriteLine(a != b);
            Console.WriteLine(a > c);
            Console.WriteLine(a >= c);
            Console.WriteLine(a < c);
            Console.WriteLine(a <= c);
        }

        public static void Logic()
        {
            int playerXP = 80;
            int playerHealth = 15;
            bool hasWeapon = true;
            bool hasMagic = true;

            bool canUnlockLevel99 = false;

            canUnlockLevel99 = (playerXP > 70 && playerHealth >= 10 && hasMagic);
            Console.WriteLine("Can enter level 99? " + canUnlockLevel99);


            bool canPickupSword = false;
            canPickupSword = (hasMagic || !hasWeapon);
            Console.WriteLine("Can pick up sword? " + canPickupSword);

        }

        public static void Ternary()
        {
            int a, b, c;
            a = 16;
            b = 19;
            c = (a == b) ? a : b;

            Console.WriteLine(c);

            if (a == b)
            {
                c = a;
            }
            else
            {
                c = b;
            }

        }




    }
}
