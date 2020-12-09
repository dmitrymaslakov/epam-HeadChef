using HeadСhef.DAL.Entities;
using HeadСhef.DAL.Entities.Dishes;
using HeadСhef.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeadChef.BBL.Services
{
    public class OrderHandler : IOrderHandler
    {
        public IFoodstuff MakeDishBy(IChef chef, IDish dish, double grams)
        {
            try
            {
                return chef.MakeDish(dish, grams);
            }
            catch
            {
                throw;
            }

        }

        public double CalculateCaloricValue(IFoodstuff dish)
        {
            try
            {
                return dish.Weight * dish.CaloricPer100Grams / 100;
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<IFoodstuff> SortFoodstuffsBy(IFoodstuff dish)
        {
            try
            {
                var type = dish.GetType();

                var propertyInfo = type.GetProperties();

                Comparison<IFoodstuff> sort;

                sort = (x, y) =>
                {
                    if (x.CaloricPer100Grams > y.CaloricPer100Grams)
                        return -1;

                    else if (x.CaloricPer100Grams < y.CaloricPer100Grams)
                        return 1;

                    return 0;
                };

                var productsOfDish = propertyInfo
                    .Select(prop => prop.GetValue(dish) as IFoodstuff)
                    .Where(productOfDish => productOfDish != null)
                    .ToList();

                productsOfDish.Sort(sort);

                return productsOfDish;
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<IFoodstuff> FindProductsOfDishBy(double lowerCaloricLimit, double upperCaloricLimit, IFoodstuff dish)
        {
            try
            {
                var type = dish.GetType();

                var propertyInfo = type.GetProperties();

                return propertyInfo
                    .Select(prop => prop.GetValue(dish) as IFoodstuff)
                    .Where(productOfDish => productOfDish != null)
                    .Where(productOfDish => productOfDish.CaloricPer100Grams >= lowerCaloricLimit
                        && productOfDish.CaloricPer100Grams <= upperCaloricLimit);
            }
            catch
            {
                throw;
            }
        }
    }
}
