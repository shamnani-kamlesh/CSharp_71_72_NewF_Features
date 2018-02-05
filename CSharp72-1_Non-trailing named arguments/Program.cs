using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp72_1_Non_trailing_named_arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodA("arg1_value", 1, "arg3_value");
            MethodA(arg2: 1, arg3: "arg3_value", arg1: "arg1_value");
            MethodA("arg1_value", 1, arg3: "arg3_value");
            MethodA("arg1_value", arg2: 1, arg3: "arg3_value");

            //Before C#7.2 following was not possible
            /*
             Currently project language is C#7.2 
             - to check it is new feature just change language to any prior language
             */
            MethodA(arg1: "arg1_value", 1, arg3: "arg3_value");

        }

        public static void MethodA(string arg1, int arg2, string arg3)
        {

        }

    }
}
