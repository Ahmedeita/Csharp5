namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Casting [Boxing - Unboxing]

            // Reference Type Casting => Convert from Reference to To Reference Type
            // Boxing Casting => Convert from Value Type to Reference Type
            // UnBoxing Casting => Convert from Reference Type to Value Type

            //object obj = new object(); 
            //obj = "Mostafa"; // Reference Type Casting

            //obj = 2; // Boxing [Casting from Value Type [int] to Reference Type [Object]

            #region Boxing [Safe Code]
            //int X = 10; 
            //object obj01 = new object(); 
            //obj01 = X; 
            //Console.WriteLine(obj01); 
            // Parent = Child

            #endregion
            #region Unboxing [Un Safe Code]
            //object obj02 = new object();
            //obj02 = 10;
            //int X = (int)obj02;
            //Child = Parent
            #endregion

            #endregion
        }
    }
}
