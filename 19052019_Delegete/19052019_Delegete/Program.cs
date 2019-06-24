using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19052019_Delegete
{
    class Program
    {
        public delegate int CalculatoreGetintReturnInt(int x, int y);

        static CalculatoreGetintReturnInt method;

        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }
        static int Div (int x, int y)
        {
            return x / y;
        }
        static int Sub(int x, int y)
        {
            return x - y;
        }
       static int Calculator(CalculatoreGetintReturnInt func, int x, int y)
       {
            int result = func.Invoke(x, y);

            return result;
       }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator(Add, 3,3));
            Console.WriteLine(Calculator(Multiply, 3, 5));
            Console.WriteLine(Calculator(Div, 10,2));
            Console.WriteLine(Calculator(Sub,10,5));
            
          
        }
    }
}
