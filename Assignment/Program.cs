﻿using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        #region Q1 Methods
        static void PassByValue(int x)
        {
            x += 10;
        }
        static void PassByRef(ref int x)
        {
            x += 10;
        }
        #endregion

        #region Q2 Methods
        static void PassByValueReferenceType(int [] arr)
        {
            arr[0] = 23;
        }
        static void PassByRefReferenceType(ref int[] arr)
        {
            arr[0] = 23;
        }
        #endregion

        #region Q3 Method
        static void SumSub(int num1 , int num2 , out int sum , out int sub)
        {
            sum = num1 + num2;
            sub = num1 - num2;
        }

        #endregion

        #region Q4 Method
        static int SumOfDigits(int num)
        {
            int sum =0 ;
            while (num > 0) {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
        #endregion

        #region Q5 Method
        static bool IsPrime(int number)
        {
            if (number <= 1)
                 return false; 
            

            for (int i = 2; i <= Math.Sqrt(number); i++)
                   if (number % i == 0)
                        return false;
                
            

            return true; 
        }
        #endregion

        #region Q6 Methods

        static void MinMaxArray(int [] array,ref int min,ref int max) {
            max = array.Max(); 
            min = array.Min();
        }

        #endregion

        #region Q7 Method 
        static int Fact(int n)
        {
            int Factorial = 1;
            if (n == 0)
                return Factorial;

            for (int i = 1; i <= n; i++)
            {
                Factorial *= i;
            }

            return Factorial;
        }
        #endregion

        #region Q8 Method
        static string ChangeChar(string s,int position , char letter)
        {
            if (position >= s.Length)
                return "Invalid Position input";
            char[] chars = s.ToCharArray();

            chars[position]= letter;


            return string.Join("", chars);
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            /* 1-	Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
             * Passing by value: When you send an arguments value type to a function by value, you are just sending a copy of those values 
                                 Any changes to it did not affect the original values
              
             * Passing by Reference: When you send an arguments value type to a function by Reference, you are sending the value with it's original address 
                                 So any changes to it inside the fuction will affect at the original values
             */
            //int number = 5;
            //Console.WriteLine($"Number before Passing by Value : {number}");
            //PassByValue(number);
            //Console.WriteLine($"Number after Passing by Value : {number}");
            //Console.WriteLine("\t\t\t**************************");
            //Console.WriteLine($"Number before Passing by Reference : {number}");
            //PassByRef(ref number);
            //Console.WriteLine($"Number after Passing by Reference : {number}");

            #endregion

            #region Q2
            /*2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
             * Passing by value: When you send an arguments Reference type to a function by value, you are creating a variable in stack
             *                   and store the same address of the original object so any changes to it will affect at the original object
              
             * Passing by Reference: When you send an arguments Reference type to a function by Reference, just rename the value in the stack with it's original address 
                                     So any changes to it inside the fuction will affect at the original object
             */

            //int [] num = {1,2,3};
            //Console.WriteLine($"Element 1 in array before Passing by Value : {num[0]}");
            //PassByValueReferenceType(num);
            //Console.WriteLine($"Element 1 in array after Passing by Value : {num[0]}");

            //Console.WriteLine("\t\t\t********************************");

            //int [] number = { 1, 2, 3 };

            //Console.WriteLine($"Element 1 in array before Passing by Reference : {number[0]}");
            //PassByRefReferenceType(ref number);
            //Console.WriteLine($"Element 1 in array after Passing by Reference : {number[0]}");

            #endregion

            #region Q3
            //3 - Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int FirstNumber = 0;
            //int SecondNumber = 0;
            //int sum;
            //int sub;
            //Console.Write("Enter the 1st Number : ");

            //int.TryParse(Console.ReadLine(), out FirstNumber);
            //Console.Write("Enter the 2nd Number : ");
            //int.TryParse(Console.ReadLine(), out SecondNumber);

            //SumSub(FirstNumber, SecondNumber, out sum , out sub);
            //Console.WriteLine($"Sum of {FirstNumber} + {SecondNumber} = {sum} \nSub of {FirstNumber} - {SecondNumber} = {sub} ");

            #endregion

            #region Q4
            //4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            //Console.Write("Enter the Number : ");
            //int.TryParse(Console.ReadLine(), out int Number);

            //Console.WriteLine($"The Sum of the digits of the number {Number} = {SumOfDigits(Number)}");

            #endregion

            #region Q5
            //5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.Write("Enter the Number : ");
            //int.TryParse(Console.ReadLine(), out int Number);

            //Console.WriteLine(IsPrime(Number));

            #endregion

            #region Q6
            //6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters.
            //int[] Numbers = { 12, 17, 10, 4, 5, 6, 7, 8, 9, 45, 84, 3 };
            //int min = 0, max  = 0;
            //MinMaxArray(Numbers,ref min,ref max);
            //Console.WriteLine($"Minimum Value in the array is  {min}");
            //Console.WriteLine($"Maximum Value in the array is  {max}");


            #endregion

            #region Q7
            //7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //Console.Write("Enter the Number : ");
            //int.TryParse(Console.ReadLine(), out int Number);
            //if (Number >= 0)
            // Console.WriteLine($"The Factorial of {Number} is {Fact(Number)}");
            //else
            //    Console.WriteLine("invalid input you have to enter Positive Number");


            #endregion

            #region Q8
            //8-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //Console.Write("Enter the String : ");
            //string text = Console.ReadLine()??" ";

            //Console.Write("Enter the position : ");
            //int position = 0;
            //int.TryParse(Console.ReadLine(),out position);

            //Console.Write("Enter the new char : ");
            //char newchar = ' ';
            //char.TryParse(Console.ReadLine(), out newchar);

            //string newtext = ChangeChar(text, position, newchar);

            //Console.WriteLine(newtext);



            #endregion


        }
    }
}
