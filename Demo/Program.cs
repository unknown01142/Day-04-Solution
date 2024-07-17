
using Demo.Overloading_Operator;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Complex C1 = new Complex() { Real = 3, Imag = 5 };
            Complex C2 = new Complex() { Real = 3, Imag = 5 };

            #region Binary Operator

            Complex C3 = default;

            C3 = C1 + C2;

            Console.WriteLine($"C1 = {C1}");
            Console.WriteLine($"C2 = {C2}");
            Console.WriteLine("----------");

            Console.WriteLine($"C3 = {C3}");

            #endregion




        }
    }
}
