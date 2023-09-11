using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //declarartion of a string, an integer, a boolean and a decimal

            string name = "John";
            int age = 18;
            bool isTall = true;
            double weight = 80.2;
            char initial = 'J';

            //print to console
            Console.WriteLine("His name is " + name + " he is " + age + " it is " + isTall + " that he is tall");
            Console.WriteLine("He weighs " + weight + " his initial is " + initial);

            name = "Tim";
            age = 10;
            isTall = false;
            weight = 30.5;
            initial = 'T';

            Console.WriteLine("His name is " + name + " he is " + age + " it is " + isTall + " that he is tall");
            Console.WriteLine("He weighs " + weight + " his initial is " + initial);

            //freeze console
            Console.ReadLine();



        }
    }
}
