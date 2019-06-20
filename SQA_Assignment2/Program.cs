using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // start execution here
            new Program().GO();
            // wait for user response and show output
            Console.ReadKey();
        }

        private void GO()
        {
            int option = 0;
            string optionStr = string.Empty;
            do
            {
                // display options
                Console.Write("\n\t1.Enter triangle dimensions\n\t2.Exit\n\nChoose Option: ");
                // read value as string
                optionStr = Console.ReadLine();
                // verify that is it number or not
                if (int.TryParse(optionStr, out option))
                    // perform tasks as per user input
                    switch(option)
                    {
                        // if option = 1, perform task on triangle
                        case 1:
                            // read value for 3 sides of a triangle
                            int side1 = TriangleSolver.Getvalue("1");
                            int side2 = TriangleSolver.Getvalue("2");
                            int side3 = TriangleSolver.Getvalue("3");
                            // check that can it form a triangle or not
                            bool canForm = TriangleSolver.IsTriangle(side1, side2, side3);
                            // if traingle if formable, show it's type
                            if (canForm)
                            {
                                // get triangle type
                                string type = TriangleSolver.Analyze(side1, side2, side3);
                                // display triangle type
                                Console.WriteLine("\n\tIt is " + type + " Triangle");
                            }
                            else
                                // show that triangle can't be formed
                                Console.WriteLine("\n\tValues Can't form Triangle");
                            break;
                        // if option = 1, say Good Bye to user
                        case 2:
                            Console.WriteLine("\n\tThank you\n\tGood Bye");
                            break;
                        // if input is none of the option, say invalid option
                        default:
                            Console.WriteLine("\n\tInvalid Option\n\tplease enter again");
                            break;
                    }   
                else
                    // if value is not a number, show error message
                    Console.WriteLine("\n\tCharacters are not allowed\n\tplease enter again");
            // terminate execution on option "2"
            } while (option!=2);
        }
    }
}
