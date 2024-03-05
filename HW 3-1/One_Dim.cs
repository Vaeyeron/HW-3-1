﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class One_Dim
    {
        // UpperCamelCase
        // lowerCamelCase
        // _lowerCamelCase
        // UPPER_
        private int[] _array;
        private int[] _Min_Numbers;

        public One_Dim(int length, bool user_Input = false)
        {
            Initialize(length, user_Input);
        }
        public void Initialize(int length, bool user_Input = false)
        {
            _array = new int[length];
            if (user_Input)
            {
                Fill_Array_With_User_Values();
            }
            else
            {
                Fill_Array_With_Random_Values();
            }
        }

        public void Fill_Array_With_User_Values()
        {
            Console.WriteLine("Enter values for the array:");
            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write($"Enter value for index {i}: ");
                if (!int.TryParse(Console.ReadLine(), out _array[i]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer value.");
                    i--;
                }
            }
        }

        public void Fill_Array_With_Random_Values()
        {
            Random random = new Random();
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = random.Next(-200, 201);
            }
        }
        public void Print_Array()
        {
            Console.WriteLine("Array elements:");
            foreach (var element in _array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        public double Calculate_Average()
        {
            double sum = 0;
            foreach (var element in _array)
            {
                sum += element;
            }
            return sum / _array.Length;
        }
        public void Remove_Elements_More_Than_Abs_100()
        {
            Console.WriteLine("Array after removing elements with abs more than 100");
            int length_Min = 1;
            int[] _Min_Numbers = new int[length_Min];
            int Min_Numbers_Index = 0;
            foreach (int i in _array)
            {
                if (i < 100 & i > -100)
                {
                    _Min_Numbers[Min_Numbers_Index] = _array[i];
                    Min_Numbers_Index++;
                    length_Min++;
                }
            }
            _array = new int[Min_Numbers_Index];
            for (int i = 0; i < Min_Numbers_Index; i++)
            {
                _array[i] = _Min_Numbers[i];
            }
            Print_Array();
        }
        public void Remove_Duplicate_Elements()
        {
            Console.WriteLine("Array after removing duplicated elements");
            _array = _array.Distinct().ToArray();
            Print_Array();
        }
    }
}
