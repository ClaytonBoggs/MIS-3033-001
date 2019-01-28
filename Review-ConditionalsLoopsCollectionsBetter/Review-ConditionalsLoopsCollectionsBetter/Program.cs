using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_ConditionalsLoopsCollectionsBetter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Conditionals
            int age = 0;
            string messageForUser = "Please enter your age >>";

            Console.WriteLine(messageForUser); // Ask the user to input their age
            age = Convert.ToInt32(Console.ReadLine()); // use comments to explain methods that aren't working in order to gain some credit during exams

            if (age == 18)
            {
                Console.WriteLine("Congratz, you are 18");
            }
            else if(age ==16)
            {
                Console.WriteLine("vroom vroom, you can drive")
            }
            else
            {
                Console.WriteLine("I don't know your age");
            }

            Console.WriteLine("Your age is " + age.ToString("N0")); //concatenate a string with the value of our variable 'age' formated as a number*/

            /*LOOP

            for(int i=100; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine("Blast Off");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }*/

            /*int i = 100;
            do
            {
                Console.WriteLine(i);
                i--;
            } while (i >= 0);

            while (i >= 0)
            {
                Console.WriteLine(i);
                i--; //placement of this matters because we could start the loop with 99 instead of 100
            }*/

            //Arrays

            /*string[] firstNames = new string[15];
            string[] lastNames = new string[15];
            firstNames[0] = "Adam";
            lastNames[0] = "Ackerman";
            firstNames[1] = "Steve";
            lastNames[1] = "Jobs";

            for (int i = 0; i < firstNames.Length; i++)
            {
                if(firstNames[i] == null && lastNames[i] == null)
                {
                }
                else
                {
                    Console.WriteLine($"{lastNames[i]}, {firstNames[i]}");
                }
                //OR We can use this conditional
                if (firstNames[i] != null && lastNames[i] != null)
                {
                    Console.WriteLine($"{lastNames[i]}, {firstNames[i]}");
                }*/


            //LISTS

            /*List<double> examScores = new List<double>();
            examScores.Add(75.5);
            examScores.Add(50);
            examScores.Add(25.5);
            examScores.Add(7);
            examScores.Add(100);
            double average = 0;
            foreach(var item in examScores)
            {
                average += item;
                Console.WriteLine(item);
            }

            Console.WriteLine($"Your average exam score is {(average/examScores.Count).ToString("N2")}");

            */

            /*DICTIONARY

            Dictionary<int, double> studentGrades = new Dictionary<int, double>();
            studentGrades.Add(1, 0.97);
            studentGrades.Add(2, 0.47);
            studentGrades.Add(0, .5);

            Console.WriteLine(studentGrades[1].ToString("P2"));
            if (studentGrades.ContainsKey(0)==true) //==true is not necessary
            {
                Console.WriteLine(studentGrades[0].ToString("P2"));
            }
            else
            {
                studentGrades.Add(0, 1.0);
                Console.WriteLine(studentGrades[0].ToString("P2"));
            }
            */


            Console.ReadKey();

        }
    }
}
