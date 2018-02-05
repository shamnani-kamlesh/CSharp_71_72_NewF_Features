using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace _1.Inferred_Tupel_element_names
{
    class Program
    {
        static void Main(string[] args)
        {
            //Retrive fruites (from any data source)
            var fruits = Fruit.GetFruits();

            //Old (Specify names to the Tupel elements)
            var tupelExampleQuery = from fruit in fruits
                                    select (Id: fruit.Id, Name: fruit.Name);

            var firstElementOld = tupelExampleQuery.First(); //(int Id, String Name)
            string firstFruitOld = $"First fruit is : Id {firstElementOld.Id.ToString()} is Name {firstElementOld.Name}";

            //New (Inferred Tupel element names)
            var inferredTupelExampleQuery = from fruit in fruits
                                            select (fruit.Id, fruit.Name); // Same as above but Id and Name names will be inferred

            var firstElementNew = inferredTupelExampleQuery.First(); //(int Id, String Name)
            string firstFruitNew = $"First fruit is : Id {firstElementNew.Id.ToString()} is Name {firstElementNew.Name}";

            Console.WriteLine("Press any key to exit - Debug code to understand :)");
            Console.ReadKey();
        }
    }
}
