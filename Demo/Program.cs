using System.Xml.Linq;

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

            #region Anonymous Type
            //var emp = new { Id = 7, Name = "Samer", Salary = 10_000 };
            //Console.WriteLine(emp.GetType().Name);
            //Console.WriteLine(emp);
            //The object that will be created from Anonymous type is an Immutable object [Can't be changed]
            //emp01.Id = 20; Invalid

            //emp = new { Id = 11, emp.Name, emp.Salary };
            //emp = emp with { Id = 20 }; //Syntax Sugar



            //var emp02 = new { Name = "Samir", Id = 10, Salary = 11_000 };
            //The Smae Anonymous Type a long as:
            // 1. the same properties Namig [case Sensitive]
            // 2. The same properties order

            //Console.WriteLine(emp02.GetType().Name);
            //Console.WriteLine(emp02);
            //var product = new { ProductName = "Meat", Price = 20 };
            //Console.WriteLine(product.GetType().Name);
            #endregion

            #region Extension Method
            ///Static Method Calling
            ///int x = 12345;
            ///Console.WriteLine(IntExtension.Reverse(x));

            ///Extension Method Calling
            ///int x = 12345;
            ///int y = x.Reverse();
            ///Console.WriteLine(y);
            #endregion

            #region What is LINQ..?
            // LINQ: stands for Language-Integreted Query
            // In C# we write LINQ not DataBase
            // LINQ is +40 Extension for Built-Interface "IEnumerable", each extension can have one or more overloads
            //      named as "LINQ Operators" existed in class "Enumerable
            //      and divided into 13 category

            // Use "LINQ Operators" against data stored in sequence, regardless data store [File, Database, Provider like SQL]

            //Types of sequence:-
            //1. Local L20       L2XML
            //2. Remote L2E

            List<int> nums = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var Odds = nums.Where((x) => x % 2 != 0).ToList();

            //foreach (var num in Odds)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region LINQ Syntax
            #region 1. Fluent Syntax
            // 1.1 Call "LINQ Operator" as static method through "Enumerabl" class

            //var OddNums = Enumerable.Where<int>(nums, (X) => X % 2 != 0).ToList();


            // 1.2 Call "LINQ Operator" as extension method [Recommended]

            //OddNums = nums.Where((x) => x % 2 != 0).ToList();

            #endregion

            #region 2. Query Syntax [Query Expression]
            //var OddNums = from N in nums 
            //         where N % 2 != 0 
            //         select N;


            #endregion

            //Fluent Syntax Faster than Query Syntax
            //Query Syntax can use in complex queries

            //foreach (int odd in OddNums)
            //{
            //    Console.WriteLine(odd);
            //}

            #endregion
        }
    }
}
