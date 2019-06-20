using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_Assignment2
{
    public static class TriangleSolver
    {
        static int side1;
        static int side2;
        static int side3;
        static TriangleSolver()
        {
            side1 = side2 = side3 = 0;
        }
        public static int Getvalue(string param)
        {
            string value;
            int val;
            while(true)
            {
                Console.Write("\nEnter side "+param+": ");
                value = Console.ReadLine();
                if (int.TryParse(value, out val))
                    if (val <= 0)
                        Console.WriteLine("\n\tNegative value or Zero is not allowed\n\tplease enter again");
                    else
                        return val;
                else
                    Console.WriteLine("\n\tCharacters are not allowed\n\tplease enter again");
            }
        }
        public static int GetSide1()
        {
            return side1;
        }
        public static int SetSide1(int val)
        {
            side1 = val;
            return side1;
        }
        public static int GetSide2()
        {
            return side2;
        }
        public static int SetSide2(int val)
        {
            side2 = val;
            return side2;
        }
        public static int GetSide3()
        {
            return side3;
        }
        public static int SetSide3(int val)
        {
            side3 = val;
            return side3;
        }
        public static string Analyze(int side1, int side2, int side3)
        {
            if (side1 == side2 && side2 == side3)
                return "Equilateral";
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                return "Isosceles";
            else
                return "Scalene";
        }
        public static bool IsEquilateral(int side1, int side2, int side3)
        {
            if (side1 == side2 && side2 == side3)
                return true;
            else
                return false;
        }
        public static bool IsIsosceles(int side1, int side2, int side3)
        {
            if (side1 == side2 || side1 == side3 || side2 == side3)
                return true;
            else
                return false;
        }
        public static bool IsScalene(int side1, int side2, int side3)
        {
            if (side1 != side2 && side2 != side3 && side3 != side1)
                return true;
            else
                return false;
        }
        public static bool IsTriangle(int side1, int side2, int side3)
        {
            // check condition 
            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
                return false;
            else
                return true;
        }
    }
}