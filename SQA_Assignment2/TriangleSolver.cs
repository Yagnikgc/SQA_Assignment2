using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_Assignment2
{
    public static class TriangleSolver
    {
        // 3 sides of a Triangle
        static int side1;
        static int side2;
        static int side3;
        // Initialize all sides with "0" using Constructor
        static TriangleSolver()
        {
            side1 = side2 = side3 = 0;
        }
        // Method to get value from user and also to validate
        public static int Getvalue(string param)
        {
            string value;
            int val;
            // iterate the loop until user enters the correct value
            while(true)
            {
                Console.Write("\nEnter side "+param+": ");
                // read value as string
                value = Console.ReadLine();
                // verify that is it number or not
                if (int.TryParse(value, out val))
                    // verify that value is not negative
                    if (val <= 0)
                        // if value is negative show error message
                        Console.WriteLine("\n\tNegative value or Zero is not allowed\n\tplease enter again");
                    else
                        // if value is correct return it to parameter
                        return val;
                else
                    // if value is not a number, show error message
                    Console.WriteLine("\n\tCharacters are not allowed\n\tplease enter again");
            }
        }
        public static int GetSide1()
        {
            //return value of side 1
            return side1;
        }
        public static int GetSide2()
        {
            //return value of side 2
            return side2;
        }
        public static int GetSide3()
        {
            //return value of side 3
            return side3;
        }
        public static string Analyze(int s1, int s2, int s3)
        {
            // set value of all 3 sides based on parameters
            side1 = s1;
            side2 = s2;
            side3 = s3;
            // check if all 3 sides are equal
            if (side1 == side2 && side2 == side3)
                // if all 3 sides are equal, say it's Equilateral triangle
                return "Equilateral";
            // check if any 2 sides of a triangle are equal
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                // if any 2 sides of a triangle are equal, say it's Isosceles triangle
                return "Isosceles";
            // check if all 3 sides are not equal
            else if (side1 != side2 && side2 != side3 && side3 != side1)
                // if all 3 sides are not equal, say it's Scalene triangle
                return "Scalene";
            else
                // if values are not matched to any of above 3 type, say "Invalid Inputs"
                return "Invalid inputs";
        }
        // check if all 3 sides are equal
        public static bool IsEquilateral(int side1, int side2, int side3)
        {
            // if all 3 sides are equal, return true
            if (side1 == side2 && side2 == side3)
                return true;
            else
                return false;
        }
        // check if any 2 sides of a triangle are equal
        public static bool IsIsosceles(int side1, int side2, int side3)
        {
            // if any 2 sides of a triangle are equal, return true
            if (side1 == side2 || side1 == side3 || side2 == side3)
                return true;
            else
                return false;
        }
        // check if all 3 sides are not equal
        public static bool IsScalene(int side1, int side2, int side3)
        {
            // if all 3 sides are not equal, return true
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