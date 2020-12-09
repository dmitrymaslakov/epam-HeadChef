using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HeadСhef.DAL.Interfaces
{
    public class Chef : IChef
    {
        public string Name { get; set; }

        public Chef(string name)
        {
            Name = name;
        }

        public IFoodstuff MakeDish(IDish dish, double grams)
        {
            try
            {
                Console.Write("Салат будет готов через секунду: ");

                for (int i = 1; i < 2; i++)
                {
                    Thread.Sleep(1000);

                    Console.Write($"{i} ");
                }

                Console.Write($"\n");

                var preparedDish = dish.Make(grams);

                return preparedDish;
            }
            catch
            {
                throw;
            }
        }
    }
}
