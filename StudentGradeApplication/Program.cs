﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StudentGradeApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Student Grade Application!");
            Console.WriteLine("                                     ");

            Console.WriteLine("would you like to compute your grade?");
            Console.Write("Answer (yes/no): ");
            String answer = Console.ReadLine().ToLower();
            

            if (answer == "yes" || answer == "Yes" || answer == "YES")
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Please answer the provided question");
                Console.WriteLine("                                     ");
                Console.Write("Name: ");

                String Name = Console.ReadLine().ToUpper();


                Console.WriteLine("                                     ");
                Console.Write("Please insert your course: ");
                String course = Console.ReadLine().ToUpper();


                Console.WriteLine("                                     ");
                Console.WriteLine("Please enter your grades of the subject: ");

                Console.Write("English: ");
                double Sub1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Math: ");
                double Sub2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Science: ");
                double Sub3 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Filipino: ");
                double Sub4 = Convert.ToDouble(Console.ReadLine());

                Console.Write("History: ");
                double Sub5 = Convert.ToDouble(Console.ReadLine());

                double subs = Sub1 + Sub2 + Sub3 + Sub4 + Sub5;
                double totalScore = subs / 5;

                if (totalScore > 75.00)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("============================================ ");
                    Console.WriteLine("here are the results!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Student name: " + Name);
                    Console.WriteLine("Student course:  " + course);
                    Console.WriteLine(" ");
                    Console.WriteLine("The Student " + Name + " passed the required grade! ");
                    Console.WriteLine(" ");
                    Console.WriteLine("The general average of " + Name + " is " + totalScore + ".");
                    Console.WriteLine(" ");
                    Console.WriteLine("============================================ ");
                    Console.ReadKey();
                }

                else if (totalScore < 75.00)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("============================================ ");
                    Console.WriteLine("here are the results!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Student name: "+ Name);
                    Console.WriteLine("Student course:  "+ course);
                    Console.WriteLine("The Student " + Name + " failed the required grade! ");
                    Console.WriteLine(" ");
                    Console.WriteLine("The general average of " + Name + " is " + totalScore + ".");
                    Console.ReadKey();


                }

            }
            else if ( answer == "no" )
            {
                Console.WriteLine("Understandable, Thank you for visiting Student Grade Application!");
                Console.WriteLine("Have a nice day!");
                Console.ReadLine();
            }
        }

    }
}
        





                




        
    

