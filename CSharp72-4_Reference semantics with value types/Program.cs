using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp72_4_Reference_semantics_with_value_types
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            a = 1;
            Console.WriteLine($"Inside Main-Method_Passbyval {a} before");
            Method_Passbyval(a);
            Console.WriteLine($"Inside Main-Method_Passbyval {a} after");

            Console.WriteLine(Environment.NewLine);

            a = 10;
            Console.WriteLine($"Inside Main-Method_Passbyref {a} before");
            Method_Passbyref(ref a);
            Console.WriteLine($"Inside Main-Method_Passbyref {a} after");

            Console.WriteLine(Environment.NewLine);

            a = 20;
            Console.WriteLine($"Inside Main-Method_out_parameter {a} before");
            Method_out_parameter(out a);
            Console.WriteLine($"Inside Main-Method_out_parameter {a} after");

            Console.WriteLine(Environment.NewLine);

            a = 30;
            Console.WriteLine($"Inside Main-Method_in_parameter {a} before");
            Method_in_parameter(in a);
            Console.WriteLine($"Inside Main-Method_in_parameter {a} after");

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        ///value will be changed in this method but caller will not get updated value for parameter(a)
        /// </summary>
        /// <param name="a"></param>
        private static void Method_Passbyval(int a)
        {
            a++;
            Console.WriteLine($"Inside Method_Passbyval (a++) {a}");
        }

        /// <summary>
        /// value will be changed in this method but called will get updated value for parameter(a)
        /// </summary>
        /// <param name="a"></param>
        private static void Method_Passbyref(ref int a)
        {
            a++;
            Console.WriteLine($"Inside Method_Passbyref (a++) {a}");
        }

        /// <summary>
        /// pass by ref + method it self need to initialize parameter(a)
        /// </summary>
        /// <param name="a"></param>
        private static void Method_out_parameter(out int a)
        {
            a = 100; // need to initialize before use
            a++;
            Console.WriteLine($"Inside Method_out_parameter (a=100 & a++) {a}");
        }

        /// <summary>
        /// pass by ref + method cannot change parameter(a)
        /// </summary>
        /// <param name="a"></param>
        private static void Method_in_parameter(in int a)
        {
            //a++; // modification not allowed
            Console.WriteLine($"Inside Method_in_parameter (no change in a) {a}");
        }
    }
}
