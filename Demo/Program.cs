
using Demo.Abstraction;
using Demo.Casting_Overloading_Operator;
using Demo.Overloading_Operator;
using System.Drawing;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Complex C1 = new Complex() { Real = 3, Imag = 5 };
            Complex C2 = new Complex() { Real = 3, Imag = 5 };

            #region Binary Operator

            //Complex C3 = default;

            //C3 = C1 + C2;

            //Console.WriteLine($"C1 = {C1}");
            //Console.WriteLine($"C2 = {C2}");
            //Console.WriteLine("----------");

            //Console.WriteLine($"C3 = {C3}");

            #endregion

            #region Unary Operator

            //Complex C3 = new Complex();

            //Console.WriteLine(C1);

            //C3 = ++C1; Console.WriteLine("After  C3 = ++C1; ");

            //Console.WriteLine(C1);

            #endregion

            #region Relational Operator[Comparison Operator]

            //if (C1 > C2)
            //    Console.WriteLine("C1 Is Greater Than C2 ");
            //else if (C1 < C2)
            //    Console.WriteLine("C1 Is Less Than C2 ");
            //else
            //    Console.WriteLine("C1 Equals C2");

            #endregion

            #region Casting Operator 

            #region Example 01 [Explicitly]
            //object O1 = 5;

            //int X = (int)O1;
            //int Y = (int)C1; // explicit casting 

            //Console.Writeline($"Y = {Y}");
            #endregion

            #region Example 02 [Implicitly]
            //object O1 = "Hany";

            //string X = (string)O1;
            //string Y = (string)C1;// Implicit Casting 

            //Console.WriteLine($"Y = {Y}");

            #endregion


            #endregion

            #region Casting Operator Overloading - Business Need [Maping]


            //User user = new User()
            //{
            //    Id = 123,
            //    FullName = "Hany Bakry",
            //    Email = "Hany@Email.com",
            //    Password = "p@ssword!",
            //    SecurityStmp = Guid.NewGuid(),
            //};

            //UserViewModel model = (UserViewModel) user;

            //Console.WriteLine(model.Id);
            //Console.WriteLine(model.FName);
            //Console.WriteLine(model.LName);
            //Console.WriteLine(model.Email);
            //Console.WriteLine(model.Password);


            #endregion

            #region Abstraction [Class , Method , Property ] 

            ///Rect rect = new Rect() { Dim01 = 10 , Dim02 = 20 };
            ///decimal rectArea = rect.CalcArea();
            ///decimal rectPeri = rect.Perimeter;
            ///
            ///Console.WriteLine($"Rect Peri : {rectPeri}");
            ///Console.WriteLine($"Rectangle Area : {rectArea}");
            ///Console.WriteLine("#########");

            ///Square square = new Square(20);
            ///
            ///decimal squareArea = square.CalcArea();
            ///decimal squarePeri = square.Perimeter;
            ///
            ///Console.WriteLine($"Square Peri : {squarePeri}");
            ///Console.WriteLine($"Square Area : {squareArea}");

            ///Circle circle = new Circle(20);
            ///
            ///decimal circlArea = circle.CalcArea();
            ///decimal circlePeri = circle.Perimeter;
            ///
            ///Console.WriteLine($"circlArea : {circlArea}");
            ///Console.WriteLine($"circlePeri : {circlePeri}");








            #endregion



        }
    }
}
