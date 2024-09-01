using System;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Runtime.Remoting.Channels;

namespace StudentRegistrationApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] course = { "Bachelor of Science in Computer Science (BSCS)\n" + "The Bachelor of Science in Information Technology (BSIT)\n" + "Bachelor of Science in Accountancy (BSA)\n" + "Bachelor of Science in Tourism Management (BSTM)\n" + "Bachelor of Science in Business Administration (BSBA)\n" + " Bachelor of Arts in Communication (BACOMM)\n" + "Bachelor of Science in Hospitality Management (BSHM)\n" + "Bachelor of Multimedia Arts (BMMA)\n" }; //courses xdd
            String[] file =
            {
                "Good Moral Certificate\n" + "form137\n" + "grades\n" + "SHS/ISD Diploma\n" + "PSA\n" + "Medical Certicate\n"
            }; //required file for enrolling
            while (true) //used for loop
            {
                Console.WriteLine("Welcome to Student registration Application!"); //welcoming students
                Console.WriteLine(" "); //spacing
                Console.Write("Would you like to enroll? (yes/no): "); //answerable question
                String answer = Console.ReadLine().ToLower();

                if (answer == "yes" || answer == "y") //if else statement
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Great! now let's answer the fill in the blank questions.");
                    Console.WriteLine(" ");
                    Console.Write("Question 1:\nName: ");
                    String name = Console.ReadLine(); //name input

                    Console.WriteLine(" ");
                    Console.Write("Question 2:\nAge: "); //age input
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(" ");
                    Console.Write("Question 3:\nGender: "); //gender input
                    String gender = Console.ReadLine().ToLower();

                    Console.WriteLine(" ");
                    Console.WriteLine("Great! let's check the requirements! "); //checking
                    Console.WriteLine(" ");
                    Console.WriteLine("Question 4: do you have the requirements provided below?:");

                    foreach (String files in file) //foreach para mapakita yung mga listed na string (based sa naintindihan ko X.X)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("==================================================");
                        Console.WriteLine(files); //enlisted requirements
                        Console.WriteLine("==================================================");

                        Console.Write("answer(y/n): ");
                        String YesOrNo = Console.ReadLine().ToLower();
                        if (YesOrNo == "y" || YesOrNo == "yes") //another if else statement
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Great! we're almost done!");
                            Console.WriteLine(" ");
                            Console.WriteLine("Now let's choose our course, What course do you plan to enter?");
                            Console.WriteLine(" ");

                            while (true)
                            {
                                Console.WriteLine("Instructions: please answer it by its abbreviation "); //instructions!!
                                Console.WriteLine("==================================================");
                                foreach (String courses in course)
                                {
                                    Console.WriteLine(courses); // enlisted course
                                }
                                Console.WriteLine("==================================================");
                                Console.WriteLine(" ");
                                Console.Write("I choose: "); //choosing course
                                String preferredCourse = Console.ReadLine().ToUpper();
                                
                                if (preferredCourse == "BSCS" || preferredCourse == "BSIT" || preferredCourse == "BSTM" || preferredCourse == "BSA" || preferredCourse == "BSBA" || preferredCourse == "BSHM" || preferredCourse == "BMMA" || preferredCourse == "BACOMM")
                                { //course result
                                    Console.WriteLine("==================================================");
                                    Console.WriteLine("you answered " + preferredCourse + "! Here are the information about the course you take");
                                    Console.WriteLine(preferredCourse + " has a 4 year degree program");
                                    Console.WriteLine("The Tuition fee will be: ");
                                    Console.WriteLine("Cash: ₱24,000");
                                    Console.WriteLine("Downpayment: ₱6,000 per quarter");
                                    Console.WriteLine("==================================================");

                                    while (true)
                                    {
                                        Console.WriteLine("What mode of payment would you choose?");
                                        Console.WriteLine(" ");
                                        Console.Write("Answer(CASH/DP): ");
                                        String ModeOfPayment = Console.ReadLine().ToUpper(); //to make the answer capslock 

                                        if (ModeOfPayment == "CASH")
                                        {
                                            //result pag cash
                                            Console.WriteLine("You have chosen: " + ModeOfPayment);
                                            Console.WriteLine("");
                                            Console.WriteLine("results:");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("==================================================");
                                            Console.WriteLine("Student Name: " + name);
                                            Console.WriteLine("Student Age: " + age);
                                            Console.WriteLine("Student Gender: " + gender);
                                            Console.WriteLine("Course: " + preferredCourse);
                                            Console.WriteLine("Mode of payment: " + ModeOfPayment);
                                            Console.WriteLine("==================================================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Thank you for enrolling! Have a nice Day!");
                                            Console.ReadKey();
                                            break;
                                            
                                            
                                        }//result kapag downpayment
                                        else if (ModeOfPayment == "DP" || ModeOfPayment == "DOWN PAYMENT")
                                        {
                                            
                                            Console.WriteLine("You have chosen: " + ModeOfPayment);
                                            Console.WriteLine(" ");
                                            Console.WriteLine("results:");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("==================================================");
                                            Console.WriteLine("Student Name: " + name);
                                            Console.WriteLine("Student Age: " + age);
                                            Console.WriteLine("Student Gender: " + gender);
                                            Console.WriteLine("Course: " + preferredCourse);
                                            Console.WriteLine("Mode of payment: " + ModeOfPayment);
                                            Console.WriteLine("==================================================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Thank you for enrolling! Have a nice Day!");
                                            Console.ReadKey();
                                            break;
                                            

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid Answer, Please try again"); //else statement for random answer
                                        }
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, please answer it by its abbreviation. "); //else statement for wrong answer
                                }
                            }
                            break;
                        }
                        else if (YesOrNo == "n" || YesOrNo == "no") //answer for no
                        {
                            Console.WriteLine("Please submit these requirements before enrolling, Thank you!"); //endpoint for answering no for requirements
                            Console.ReadKey(); //space
                            break;
                        }
                        else
                        {
                            Console.WriteLine("invalid, please try again"); //another else sttement for wrong answer
                            Console.WriteLine(" ");
                        }
                    }
                }
                else if (answer == "n" || answer == "no")
                {
                    Console.WriteLine("Understandable, Thank you for using the Student Registration Application.");
                    Console.ReadKey();//space
                    break;
                
                }
                else
                {
                    Console.WriteLine("sorry I didn't comprehend that. please say it again."); //else statemnt for wrong answ
                    Console.WriteLine(" ");//space
                }
            }
        }
    }
}
