using System.ComponentModel;
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




        }
    }
}
