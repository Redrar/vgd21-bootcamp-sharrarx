using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_sharrarx
{
    public static class MadLibs
    {
        public static void Execute()
        {
            Console.Write("Please write an adjective: >");
            string adj1 = Console.ReadLine();
            Console.Write("Please write a person's name: >");
            string name1 = Console.ReadLine();
            Console.Write("Please write a noun: >");
            string noun1 = Console.ReadLine();
            Console.Write("Please write an adjective: >");
            string adj2 = Console.ReadLine();
            Console.Write("Please write an animal: >");
            string animal1 = Console.ReadLine();





            Console.WriteLine("-------------------------\n\n");
            Console.WriteLine("Once upon a time there was a {0} knight named {1}, who was destined to slay the {2} .",adj1, name1, noun1);
            Console.WriteLine("On {0}'s journey, they came across a {1} {2}.", name1, adj2, animal1);
            Console.WriteLine("Together, {0} and their {1} continued {0}'s adventure, and slayed the {2}.", name1, animal1, noun1);
        }
    }
}
