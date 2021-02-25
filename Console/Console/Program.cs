using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Calculations
            var x = System.Math.Floor(14.56);
            var y = System.Math.Sqrt(100);
            #endregion


            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);

            Console.ReadKey(true);
        }
    }
}
