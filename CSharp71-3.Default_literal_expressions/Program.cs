using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace CSharp71_3.Default_literal_expressions
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var fruits = await Fruit.GetFruitsAsync();

            //Do Some work
        }
    }
}
