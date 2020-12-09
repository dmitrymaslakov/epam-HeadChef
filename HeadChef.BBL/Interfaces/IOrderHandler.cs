using HeadСhef.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeadChef.BBL.Services
{
    public interface IOrderHandler
    {
        /// <summary>
        /// Handler the user's order.
        /// </summary>
        IFoodstuff MakeDishBy(IChef chef, IDish dish, double grams);

        /// <summary>
        /// Calculates the calorie content of the dish.
        /// </summary>
        double CalculateCaloricValue(IFoodstuff dish);

        /// <summary>
        /// Sorts the foodstuff by descending caloric value.
        /// </summary>
        IEnumerable<IFoodstuff> SortFoodstuffsBy(IFoodstuff dish);

        /// <summary>
        /// Search for products corresponding to a given caloric value range.
        /// </summary>
        IEnumerable<IFoodstuff> FindProductsOfDishBy(double lowerCaloricLimit, double upperCaloricLimit, IFoodstuff dish);
    }
}
