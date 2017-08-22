using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age.");
            int age = int.Parse(Console.ReadLine());
            if (age < 0 || age > 100)
            {
                Console.WriteLine("This program is for humans.");
            }
            else if (age >= 0 && age <= 2)
            {
                Console.WriteLine("Still in Mama's Arms");
            }
            else if (age >= 3 && age <= 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (age >= 5 && age <= 11)
            {
                Console.WriteLine("Elementary School");
            }
            else if (age >= 12 && age <= 14)
            {
                Console.WriteLine("Middle School");
            }
            else if (age >= 15 && age <= 18)
            {
                Console.WriteLine("High School");
            }
            else if (age >= 19 && age <= 22)
            {
                Console.WriteLine("College");
            }
            else if (age >= 23 && age <= 65)
            {
                Console.WriteLine("Working for the Man");
            }
            else if (age >= 66 && age <= 100)
            {
                Console.WriteLine("The Golden Years, enjoy!");
            }
        }
    }
}
