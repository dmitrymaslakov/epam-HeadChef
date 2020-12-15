using HeadСhef.DAL.Abstract;
using HeadСhef.DAL.Helper;
using HeadСhef.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HeadСhef.DAL.Abstract
{
    public abstract class Dish : Foodstuff
    {
        public Dish(double weight) : base(weight)
        {
        }

        protected virtual Dictionary<string, double> CalculateNutritionInformation(Dictionary<IFoodstuff, double> _proportions)
        {
            var query = _proportions
                .Select(proportion =>
                {
                    var caloric = ProductCalculator.CalculateWeightOfProductInDish(
                        proportion.Value, proportion.Key.CaloricPer100Grams);
                    var fats = ProductCalculator.CalculateWeightOfProductInDish(
                        proportion.Value, proportion.Key.FatsPer100Grams);
                    var proteins = ProductCalculator.CalculateWeightOfProductInDish(
                        proportion.Value, proportion.Key.ProteinsPer100Grams);
                    var carbohydrates = ProductCalculator.CalculateWeightOfProductInDish(
                        proportion.Value, proportion.Key.CarbohydratesPer100Grams);

                    var r = new { caloric, fats, proteins, carbohydrates };

                    return r;
                })
                .Aggregate((f, n) =>
                {
                    return
                    new
                    {
                        caloric = f.caloric + n.caloric,
                        fats = f.fats + n.fats,
                        proteins = f.proteins + n.proteins,
                        carbohydrates = f.carbohydrates + n.carbohydrates
                    };
                })
                ;

            return new Dictionary<string, double>
            {
                { "caloric", query.caloric},
                { "fats", query.fats},
                {"proteins", query.proteins },
                { "carbohydrates", query.carbohydrates }
            };
        }
    }
}
