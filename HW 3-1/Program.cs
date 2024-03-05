using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a type for the array(1, 2 or 3)");
            int type = int.Parse(Console.ReadLine());
            Console.WriteLine("What type? (if user input(true) or if random(false))");
            bool user_Input = bool.Parse(Console.ReadLine()); 
            if (type == 1)
            {
                Console.WriteLine("Enter length for the array");
                int length = int.Parse(Console.ReadLine());
                One_Dim one_Dim = new One_Dim(length, user_Input);
                one_Dim.Print_Array();
                one_Dim.Remove_Elements_More_Than_Abs_100(length);
                one_Dim.Remove_Duplicate_Elements();
                Console.WriteLine("Average: " + one_Dim.Calculate_Average());
                Console.ReadKey();
            }
            if (type == 2)
            {
                Console.WriteLine("How many rows?");
                int rows = int.Parse(Console.ReadLine());
                Console.WriteLine("How many columns?");
                int columns = int.Parse(Console.ReadLine());
                Multi_Dim multi_Dim = new Multi_Dim(rows, columns, user_Input);
                multi_Dim.Print();
                multi_Dim.Reverse_Even_Rows();
                Console.WriteLine("Average: " + multi_Dim.Calculate_Average());
                Console.ReadKey();
            }
            if (type == 3)
            {
                Console.WriteLine("Enter the number of massives");
                int length = int.Parse(Console.ReadLine());
                Jagged_Dim jagged_Dim = new Jagged_Dim(length, user_Input);
                jagged_Dim.Print();
                jagged_Dim.Calculate_Nested_Averages();
                jagged_Dim.Modify_Even_Elements();
                Console.WriteLine("Average: " + jagged_Dim.Calculate_Average());
                Console.ReadKey();
            }
        }
    }
}