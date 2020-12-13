using HeadСhef.DAL.Interfaces;
using HeadСhef.DAL.Entities.Dishes;
using System;
using System.Threading;
using System.Collections.Generic;
using HeadСhef.DAL.Helper;

namespace HeadСhef.DAL.Entities
{

    public class Chef : IChef
    {
        public string Name { get; set; }

        public Chef(string name)
        {
            Name = name;
        }

        public IFoodstuff MakeDish(DishesIndex dish, double weight, IFoodstuff dishDressing = null)
        {
            try
            {
                switch (dish)
                {
                    case DishesIndex.CaesarSalad:

                        IEnumerable<IFoodstuff> saladIngredients = GetSaladIngredients(weight, dish);

                        return new CaesarSalad(weight, saladIngredients, dishDressing).GetCookedDish();

                    case DishesIndex.CaesarSauce:

                        IEnumerable<IFoodstuff> sauceIngredients = GetSauceIngredients(weight, dish);

                        return new CaesarSauce(weight, sauceIngredients).GetCookedDish();

                    default:

                        return null;
                }
            }
            catch
            {
                throw;
            }
        }

        private IEnumerable<IFoodstuff> GetSauceIngredients(double weight, DishesIndex dish)
        {
            Console.Write($"{dish} будет готов через секунду: ");

            for (int i = 1; i < 2; i++)
            {
                Thread.Sleep(1000);

                Console.Write($"{i} ");
            }

            Console.Write($"\n");


            var eggYolkWeight =
                ProductCalculator.CalculateWeightOfProductInDish(
                    weight, SauceData.GRAMS_OF_EGG_YOLK_PER_100_GRAMS_OF_SAUCE);

            var powderWeight =
                ProductCalculator.CalculateWeightOfProductInDish(
                    weight, SauceData.GRAMS_OF_MUSTARD_POWDER_PER_100_GRAMS_OF_SAUCE);

            var kefirWeight =
                ProductCalculator.CalculateWeightOfProductInDish(
                    weight, SauceData.GRAMS_OF_KEFIR_PER_100_GRAMS_OF_SAUCE);

            var oliveOilWeight =
                ProductCalculator.CalculateWeightOfProductInDish(
                    weight, SauceData.GRAMS_OF_OLIVE_OIL_PER_100_GRAMS_OF_SAUCE);

            var saltWeight =
                ProductCalculator.CalculateWeightOfProductInDish(
                    weight, SauceData.GRAMS_OF_SALT_PER_100_GRAMS_OF_SAUCE);

            var oreganoWeight =
                ProductCalculator.CalculateWeightOfProductInDish(
                    weight, SauceData.GRAMS_OF_OREGANO_PER_100_GRAMS_OF_SAUCE);

            return new List<IFoodstuff> {
                Store.GetEggYolk(eggYolkWeight),
                Store.GetMustardPowder(powderWeight),
                Store.GetKefir(kefirWeight),
                Store.GetOliveOil(oliveOilWeight),
                Store.GetSeaSalt(saltWeight),
                Store.GetOregano(oreganoWeight)
            };
        }

        private IEnumerable<IFoodstuff> GetSaladIngredients(double weight, DishesIndex dish)
        {
            Console.Write($"{dish} будет готов через секунду: ");

            for (int i = 1; i < 2; i++)
            {
                Thread.Sleep(1000);

                Console.Write($"{i} ");
            }

            Console.Write($"\n");


            var saladWeight =
                ProductCalculator.CalculateWeightOfProductInDish(
                    weight, SaladData.GRAMS_OF_SALAD_PER_100_GRAMS_OF_SALAD);

            var parmesanWeight =
                ProductCalculator.CalculateWeightOfProductInDish(
                    weight, SaladData.GRAMS_OF_PARMESAN_PER_100_GRAMS_OF_SALAD);

            var breadWeight =
                ProductCalculator.CalculateWeightOfProductInDish(
                    weight, SaladData.GRAMS_OF_BREAD_PER_100_GRAMS_OF_SALAD);

            var garlicWeight =
                ProductCalculator.CalculateWeightOfProductInDish(
                    weight, SaladData.GRAMS_OF_GARLIC_PER_100_GRAMS_OF_SALAD);

            var oliveOilWeight =
                ProductCalculator.CalculateWeightOfProductInDish(
                    weight, SaladData.GRAMS_OF_OLIVE_OIL_PER_100_GRAMS_OF_SALAD);

            var saltWeight =
                ProductCalculator.CalculateWeightOfProductInDish(
                    weight, SaladData.GRAMS_OF_SALT_PER_100_GRAMS_OF_SALAD);

            var blackPepperWeight =
                ProductCalculator.CalculateWeightOfProductInDish(
                    weight, SaladData.GRAMS_OF_BLACK_PEPPER_PER_100_GRAMS_OF_SALAD);

            return new List<IFoodstuff> {
                Store.GetLactucaSativa(saladWeight),
                Store.GetParmesan(parmesanWeight),
                Store.GetCiabattaBread(breadWeight),
                Store.GetGarlic(garlicWeight),
                Store.GetOliveOil(oliveOilWeight),
                Store.GetSeaSalt(saltWeight),
                Store.GetBlackPepper(blackPepperWeight)
            };
        }
    }
}
