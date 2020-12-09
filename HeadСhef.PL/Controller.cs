using HeadСhef.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeadСhef.PL
{
    public delegate IFoodstuff MakeDishOrderEventHandler(IChef chef, IDish dish, double grams);
    public delegate double CalculateCaloricOrderEventHandler(IFoodstuff dish);
    public delegate IEnumerable<IFoodstuff> SortFoodstuffOrderEventHandler(IFoodstuff dish);
    public delegate IEnumerable<IFoodstuff> FindProductsOfDishOrderEventHandler(double lowerCaloricLimit,
        double upperCaloricLimit, IFoodstuff dish);

    public class Controller
    {
        public event MakeDishOrderEventHandler MakeDishOrder;
        public event CalculateCaloricOrderEventHandler CalculateCaloricValueOrder;
        public event SortFoodstuffOrderEventHandler SortFoodstuffOrder;
        public event FindProductsOfDishOrderEventHandler FindProductsOfDishOrder;


        /// <summary>
        /// Fire the event "MakeDishOrder".
        /// </summary>
        public IFoodstuff OnMakeDishOrder(IChef chef, IDish dish, double grams)
        {
            var preparedDish = MakeDishOrder?.Invoke(chef, dish, grams);

            Console.WriteLine("Готово!");

            return preparedDish;
        }

        /// <summary>
        /// Fire the event "CalculateCaloricValueOrder".
        /// </summary>
        public void OnCalculateCaloricValueOrder(IFoodstuff dish)
        {
            var totalCalories = CalculateCaloricValueOrder?.Invoke(dish);

            Console.WriteLine($"Энергетическая ценность в {dish.Weight} граммах салата - {totalCalories:f1} ккал\n");
        }

        /// <summary>
        /// Fire the event "SortFoodstuffOrder".
        /// </summary>
        public void OnSortFoodstuffOrder(IFoodstuff dish)
        {
            var productsList = SortFoodstuffOrder?.Invoke(dish);

            Console.SetCursorPosition(30, Console.CursorTop);

            Console.WriteLine($"Ккал на 100гр.");

            foreach (var product in productsList)
            {
                Console.Write($"{product.Name}");

                Console.SetCursorPosition(30, Console.CursorTop);
                
                Console.WriteLine($"{product.CaloricPer100Grams:f1}");
            }

            Console.WriteLine($"\n");
        }

        /// <summary>
        /// Fire the event "FindProductsOfDishOrder".
        /// </summary>
        public void OnFindProductsOfDishOrder(double lowerLimit, double upperLimit, 
            IFoodstuff dish)
        {
            var productsList  = FindProductsOfDishOrder?.Invoke(lowerLimit, upperLimit, dish);

            Console.WriteLine(
                $"Ингредиенты в салате, удовлетворяющие диапозону калорийности [{lowerLimit} - {upperLimit}]:");

            if (productsList.Any())
            {
                foreach (var product in productsList)
                {
                    Console.WriteLine(product.Name);
                }

                Console.WriteLine($"\n");
            }

            else
            {
                Console.WriteLine("Продукты не найдены.\n");
            }
        }
    }
}
