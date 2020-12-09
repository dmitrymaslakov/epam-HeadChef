using HeadСhef.DAL.Abstract;
using HeadСhef.DAL.Interfaces;
using System.Linq;

namespace HeadСhef.DAL.Entities.Dishes
{
    public class DishService
    {
        public double CalculateGrammOfProductPartFor(double necessaryGrammOfProduct, double grammOfProductPartPer100GramsOfProduct)
        {
            try
            {
                double defaultGrammOfProduct = 100.0;

                return necessaryGrammOfProduct * grammOfProductPartPer100GramsOfProduct / defaultGrammOfProduct;
            }
            catch
            {
                throw;
            }
        }

        public double CalculateCaloricPer100GramsOfProduct(IDish dish)
        {
            try
            {
                var type = dish.GetType();

                var propertyInfo = type.GetProperties();

                return propertyInfo
                    .Select(prop => prop.GetValue(dish) as Foodstuff)
                    .Where(productOfDish => productOfDish != null)
                    .Select(productOfDish => CalculateGrammOfProductPartFor(productOfDish.Weight, productOfDish.CaloricPer100Grams))
                    .Sum();
            }
            catch
            {
                throw;
            }
        }
    }
}
