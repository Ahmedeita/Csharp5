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


        }
    }
}
