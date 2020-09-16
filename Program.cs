using System;
using System.IO;
/* Programmer Brian Robison
 * ISM 4300
 * September 16 2020
 * Program 2b
 */
namespace TechProj2b
{
    class Program
    {
        static void Main(string[] args)
        {
            //INtructions for user
            Console.WriteLine("Enter in expected grade out of 100 for ISM 4300");
            // try block in case user inputs non parseible input.
            try
            {
                //varible assigned for grade input.
                string input = Console.ReadLine();
                // int variable for calulations
                int grade = int.Parse(input);
                //if statement for A grade
                if ((grade <= 100) && (grade >= 93))
                {
                    //displays the correct grade
                    Console.WriteLine("Your letter grade is 'A'");
                }
                //if statement for A- grade
                if ((grade < 93) && (grade >= 90))
                {
                    //displays correct grade
                    Console.WriteLine("Your letter grade is 'A-'");
                }
                //if statement for B+ grade
                if ((grade < 90) && (grade >= 87))
                {
                    //displays correct grade
                    Console.WriteLine("Your letter grade is 'B+'");
                }
                //if statement for B grade
                if ((grade < 87) && (grade >= 83))
                {
                    //displays correct grade
                    Console.WriteLine("Your letter grade is 'B'");
                }
                //if statement for B- grade
                if ((grade < 83) && (grade >= 80))
                {
                    //displays correct grade
                    Console.WriteLine("Your letter grade is 'B-'");
                }
                //if statement for C+ grade
                if ((grade < 80) && (grade >= 77))
                {
                    //displays correct grade
                    Console.WriteLine("Your letter grade is 'C+'");
                }
                //if statement for C grade
                if ((grade < 77) && (grade >= 73))
                {
                    //displays correct grade
                    Console.WriteLine("Your letter grade is 'C'");
                }
                // if statement for c- grade
                if ((grade < 73) && (grade >= 70))
                {
                    //displays correct grade
                    Console.WriteLine("Your letter grade is 'C-'");
                }
                // if statement for D+ grade
                if ((grade < 70) && (grade >= 67))
                {
                    //displays correct grade
                    Console.WriteLine("Your letter grade is 'D+'");
                }
                //if statement for D grade
                if ((grade < 67) && (grade >= 63))
                {
                    //displays correct grade
                    Console.WriteLine("Your letter grade is 'D'");
                }
                //if statement for D- grade
                if ((grade < 63) && (grade >= 60))
                {
                    //displays correct grade
                    Console.WriteLine("Your letter grade is 'D-'");
                }
                //if statement for F grade
                if ((grade < 60) && (grade >=0))       
                {
                    //displays correct grade
                    Console.WriteLine("Your letter grade is 'F'");
                }
                //if statment for an impossible grade
                if ((grade > 100) || (grade < 0))
                {
                    //displayes instructions for providing a poper input
                    Console.WriteLine("Please enter a grade between 0 and 100 and try running the program again...");
                }
            }//end try
            catch
            {
                Console.WriteLine("Please enter a grade between 0 and 100 and try running the program again...");
            }//end of catch
        }//end of main
    }//end of class
}//End of namespace
