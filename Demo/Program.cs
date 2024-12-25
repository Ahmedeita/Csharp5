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

            #region Nullable Datatype
            #region Value Type
            ////int X = null; // int Number only 
            ////int? X = null; // int Number and Null
            ////Nullable<int> Number;

            ////Console.WriteLine(X);

            ////int X = 10;
            ////int? Y = (int?)X; 

            //int? X = 10;
            //int Y;

            //if (X != null)
            //{
            //    Y = (int)X;
            //}
            //else { Y = 0; }

            //if (X.HasValue) { Y = X.Value; }
            //else { Y = 0; }

            //Y = X.HasValue ? X.Value : 0;   
            //Console.WriteLine(Y); 
            #endregion

            #region Reference Type
            //string? Name = null!;
            //Console.WriteLine(Name);

            #endregion
            #endregion

            #region Null Propagation Operator
            //int[] Numbers = null;

            //if(Numbers != null)
            //{
            //    for (int i = 0; i < Numbers.Length; i++)
            //    {
            //        Console.WriteLine(Numbers[i]);
            //    }
            //}

            // i < Numbers?.Length
            // Numbers => Object [Length]
            // Numbers => Null [Null]

            //int Lenght  = Numbers?.Length ?? 0;
            //Console.WriteLine(Lenght);

            //Employee Emp = new Employee();
            //Emp.Department = new Department();

            //if(Emp != null)
            //{
            //    if(Emp.Department != null)
            //    {
            //        Console.WriteLine(Emp.Department.Name);
            //    }
            //}

            //Console.WriteLine(Emp?.Department?.Name ?? "Not Found");

            #endregion
        }
    }
}
