namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly-Typed Local Variable
            #region Var
            // var: is a C# keyword
            // var is TypeSafe


            /// Compiler acn detect the type of variable based on its intial value
            //var Name = "Samer";
            //Console.WriteLine(Name);
            //var numInt = 7;
            //Console.WriteLine(numInt);
            //var numDouble = 3.14;
            //Console.WriteLine(numDouble);
            //var numLong = 1000000000000;
            //Console.WriteLine(numLong);
            //var numChar = 'S';
            //Console.WriteLine(numChar);


            // Value must be intialized
            //var x;


            /// Value cna't be itialized with null
            ///var Names = null; --> Invalid 
            //var Names = "Samer";
            //Console.WriteLine(Names);
            //Names = null;     ///--> Valid


            /// var in C# totally different from var in JS
            /// in JS you can change varible datatype after 
            /// intialization:-
            //var x = 7;
            //x = "Samer"; Valid In Java Script

            ///In C#, After intailization you can't change variable datatype:-
            //var x = 7;
            //x = "Samer"; Invalid in C#

            #endregion

            #region Dynamic
            // dynamic is a C# keyword
            // Only one case we will use dynamic keyword,
            // when we nedd to declare a variable with diffirence
            // datatype but dynamic is not TypeSafe


            /// We don't need to intialize the value
            /// because compiler will skip the checking at 
            /// compilation time so it can be intialized or not
            //dynamic num = 10;
            //dynamic x = "Samer";


            /// Can be intialized with null
            //dynamic y = null;


            /// have th same work of var in JavaScript
            //x = 10;
            //x = 10.5;
            //x = true;
            //x = 'S';


            #endregion

            //We will use var keyword always because var is TypeSafe
            #endregion
        }
    }
}
