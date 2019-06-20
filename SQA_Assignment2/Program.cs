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
            new Program().GO();
            Console.ReadKey();
        }

        private void GO()
        {
            int option = 0;
            string optionStr = string.Empty;
            do
            {
                Console.Write("\n\t1.Enter triangle dimensions\n\t2.Exit\n\nChoose Option: ");
                optionStr = Console.ReadLine();
                if (int.TryParse(optionStr, out option))
                    switch(option)
                    {
                        case 1:
                        TriangleSolver.SetSide1(TriangleSolver.Getvalue("1"));
                        TriangleSolver.SetSide2(TriangleSolver.Getvalue("2"));
                        TriangleSolver.SetSide3(TriangleSolver.Getvalue("3"));
                        bool canForm = TriangleSolver.IsTriangle(TriangleSolver.GetSide1(), TriangleSolver.GetSide2(), TriangleSolver.GetSide3());
                        if (canForm)
                        {
                            string type = TriangleSolver.Analyze(TriangleSolver.GetSide1(), TriangleSolver.GetSide2(), TriangleSolver.GetSide3());
                            Console.WriteLine("\n\tIt is " + type + " Triangle");
                        }
                        else
                            Console.WriteLine("\n\tValues Can't form Triangle");
                            break;
                        case 2:
                            Console.WriteLine("\n\tThank you\n\tGood Bye");
                            break;
                        default:
                            Console.WriteLine("\n\tInvalid Option\n\tplease enter again");
                            break;
                    }   
                else
                    Console.WriteLine("\n\tCharacters are not allowed\n\tplease enter again");
            } while (option!=2);
        }
    }
}
