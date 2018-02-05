using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace CSharp71_2.Async_main
{
    class Program
    {
        /*-----OLD way-----(before C#7.1)*/
        //static int Main(string[] args)
        //{
        //    var fruits = Fruit.GetFruitsAsync().GetAwaiter().GetResult();
        //    //Do Some work

        //    //return exit code
        //    return 0;
        //}

        /*-----New way-----*/
        static async Task Main(string[] args)
        {
            var fruits = await Fruit.GetFruitsAsync();

            //Do Some work
        }
    }
}
