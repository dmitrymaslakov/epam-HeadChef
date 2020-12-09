using HeadChef.BBL.Services;
using HeadСhef.DAL.Entities;
using HeadСhef.DAL.Entities.Dishes;
using HeadСhef.DAL.Interfaces;
using Newtonsoft.Json;
using System;
using System.IO;

namespace HeadСhef.PL
{
    partial class Program
    {
        static private readonly OrderHandler _orderHandler = new OrderHandler();

        static void Main(string[] args)
        {
            try
            {
                string path = "../../../Db.json";

                Store store = null;

                using (var r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();

                    store = JsonConvert.DeserializeObject<Store>(json);
                }

                var controller = new Controller();

                controller.MakeDishOrder += _orderHandler.MakeDishBy;

                controller.CalculateCaloricValueOrder += _orderHandler.CalculateCaloricValue;

                controller.SortFoodstuffOrder += _orderHandler.SortFoodstuffsBy;

                controller.FindProductsOfDishOrder += _orderHandler.FindProductsOfDishBy;

                Console.WriteLine("********** Приложение по изготовлению классического салата 'Цезарь' ***********");

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Выберите действие: сделать салат - \"m\"; выйти из програмы - \"e\"");

                        var key = Console.ReadKey(true).Key.ToString().ToLower();

                        switch (key)
                        {
                            case "m":
                                var preparedDish = CookSalad(controller, store);

                                UserActions(controller, preparedDish);

                                continue;

                            case "e":
                                break;

                            default:
                                Console.WriteLine("Вы ввели не допустимый символ. Повторите ввод (\"m\", \"e\") ");

                                continue;
                        }

                        break;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Вы ввели не допустимый символ. Повторите ввод: ");

                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        private static void UserActions(Controller controller, IFoodstuff preparedDish)
        {
            try
            {
                Console.WriteLine("Узнайте состав салата, нажав \"i\"; калорийность - \"c\"; найдите продукт в салате по заданному диапозону калорийности - \"p\"; или любую клавишу, чтобы продолжить");

                string key = Console.ReadKey(true).Key.ToString().ToLower();

                switch (key)
                {
                    case "i":
                        Console.WriteLine(new string('*', 50));

                        controller.OnSortFoodstuffOrder(preparedDish);

                        UserActions(controller, preparedDish);

                        break;

                    case "c":
                        Console.WriteLine(new string('*', 50));

                        controller.OnCalculateCaloricValueOrder(preparedDish);

                        UserActions(controller, preparedDish);

                        break;

                    case "p":
                        Console.WriteLine(new string('*', 50));

                        Console.WriteLine("Введите два числа ");

                        while (true)
                        {
                            try
                            {
                                Console.Write("Нижняя граница калорийности: ");

                                int a = Math.Abs(int.Parse(Console.ReadLine()));

                                Console.Write("Верхняя граница калорийности: ");

                                int b = Math.Abs(int.Parse(Console.ReadLine()));

                                controller.OnFindProductsOfDishOrder(a, b, preparedDish);

                                break;
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Вы ввели не допустимый символ. Повторите ввод: ");

                                continue;
                            }
                        }

                        UserActions(controller, preparedDish);

                        break;

                    default:
                        break;
                }
            }
            catch
            {
                throw;
            }

        }

        private static IFoodstuff CookSalad(Controller controller, Store store)
        {
            try
            {
                Console.Write("Колличество порций салата: ");

                var portion = Math.Abs(int.Parse(Console.ReadLine()));

                var grams = PortionToGramm(portion);

                var chefJamie = new Chef("Jamie");

                var preparedDish = controller.OnMakeDishOrder(chefJamie, new CaesarSalad(store), grams);

                return preparedDish;
            }
            catch
            {
                throw;
            }
        }
        private static double PortionToGramm(int portions)
        {
            double onePortion = 150.0;

            return portions * onePortion;
        }
    }
}
