using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Fruit
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static List<Fruit> GetFruits()
        {
            return new List<Fruit>
            {
                new Fruit { Id= 1, Name= "Apples" },
                new Fruit { Id= 2, Name= "Apricots" },
                new Fruit { Id= 3, Name= "Avocados" },
                new Fruit { Id= 4, Name= "Bananas" },
                new Fruit { Id= 5, Name= "Boysenberries" },
                new Fruit { Id= 6, Name= "Blueberries" },
                new Fruit { Id= 7, Name= "Bing Cherry" },
                new Fruit { Id= 8, Name= "Cherries" },
                new Fruit { Id= 9, Name= "Cantaloupe" },
                new Fruit { Id= 10, Name= "Crab apples" },
                new Fruit { Id= 11, Name= "Clementine" },
                new Fruit { Id= 12, Name= "Cucumbers" }
            };
        }

        ///*Old (before C#7.1) - Default literal expressions*/
        //public static async Task<List<Fruit>> GetFruitsAsync(CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return await Task<List<Fruit>>.Factory.StartNew(() =>
        //    {
        //        return GetFruits();
        //    });
        //}

        /*New (C#7.1) - Default literal expressions (type in the default is inferred)*/
        public static async Task<List<Fruit>> GetFruitsAsync(CancellationToken cancellationToken = default)
        {
            return await Task<List<Fruit>>.Factory.StartNew(() =>
            {
                return GetFruits();
            });
        }
    }
}