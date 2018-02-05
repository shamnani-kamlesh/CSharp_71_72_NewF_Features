using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp72_3_Leading_underscores_in_numeric_literals
{
    class Program
    {
        static void Main(string[] args)
        {
            //After C#7 (and before C#7.2)
            int i = 123;
            int j = 1_2_3;
            int k = 0x1_2_3;
            int l_binary = 0b101;
            int m_binary = 0b1_0_1;

            //After C#7.2
            /*
             Currently project language is C#7.2 
             - to check it is new feature just change language to any prior language
             */
            byte n_hex = 0x_1_2;
            byte o_hex = 0b_1_0_1;
        }
    }
}
