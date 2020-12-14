using HeadСhef.DAL.Abstract;
using HeadСhef.DAL.Entities.KindOfFood;
using HeadСhef.DAL.Helper;
using HeadСhef.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HeadСhef.DAL.Entities.Dishes
{
    public class CaesarSauce : Foodstuff
    {
        private readonly Dictionary<IFoodstuff, double> _proportions;

        public EggYolk EggYolk { get; private set; }
        public MustardPowder MustardPowder { get; private set; }
        public Kefir Kefir { get; private set; }
        public OliveOil OliveOil { get; private set; }
        public SeaSalt Salt { get; private set; }
        public Oregano Oregano { get; private set; }
        public override string Name => "Соус Цезарь";
        public override string Category => "Заправка";
        public override double CaloricPer100Grams { get; }
        public override double FatsPer100Grams { get; }
        public override double ProteinsPer100Grams { get; }
        public override double CarbohydratesPer100Grams { get; }

        public CaesarSauce(double weight, IEnumerable<IFoodstuff> ingredients) : base(weight)
        {
            MakeSauce(ingredients);

            _proportions = new Dictionary<IFoodstuff, double> {
                { EggYolk, SauceData.GRAMS_OF_EGG_YOLK_PER_100_GRAMS_OF_SAUCE },
                { MustardPowder, SauceData.GRAMS_OF_MUSTARD_POWDER_PER_100_GRAMS_OF_SAUCE },
                { Kefir, SauceData.GRAMS_OF_KEFIR_PER_100_GRAMS_OF_SAUCE },
                { OliveOil, SauceData.GRAMS_OF_OLIVE_OIL_PER_100_GRAMS_OF_SAUCE },
                { Salt, SauceData.GRAMS_OF_SALT_PER_100_GRAMS_OF_SAUCE },
                { Oregano, SauceData.GRAMS_OF_OREGANO_PER_100_GRAMS_OF_SAUCE }
            };

            CaloricPer100Grams = CalculateCaloricPer100GramsOfSauce();

            FatsPer100Grams = CalculateFatsPer100GramsOfSauce();

            ProteinsPer100Grams = CalculateProteinsPer100GramsOfSauce();

            CarbohydratesPer100Grams = CalculateCarbohydratesPer100GramsOfSauce();
        }

        private double CalculateCaloricPer100GramsOfSauce()
        {
            return _proportions
                .Select(proportion => ProductCalculator.CalculateWeightOfProductInDish(
                    proportion.Value, proportion.Key.CaloricPer100Grams))
                .Sum();
        }

        private double CalculateFatsPer100GramsOfSauce()
        {
            return _proportions
                .Select(proportion => ProductCalculator.CalculateWeightOfProductInDish(
                    proportion.Value, proportion.Key.FatsPer100Grams))
                .Sum();
        }

        private double CalculateProteinsPer100GramsOfSauce()
        {
            return _proportions
                .Select(proportion => ProductCalculator.CalculateWeightOfProductInDish(
                    proportion.Value, proportion.Key.ProteinsPer100Grams))
                .Sum();
        }

        private double CalculateCarbohydratesPer100GramsOfSauce()
        {
            return _proportions
                .Select(proportion => ProductCalculator.CalculateWeightOfProductInDish(
                    proportion.Value, proportion.Key.CarbohydratesPer100Grams))
                .Sum();
        }

        private void MakeSauce(IEnumerable<IFoodstuff> ingredients)
        {
            EggYolk = ingredients
                .FirstOrDefault(foodstuff => foodstuff.Name.Equals("Куриный желток")) as EggYolk;

            MustardPowder = ingredients
                .FirstOrDefault(foodstuff => foodstuff.Name.Equals("Горчица")) as MustardPowder;

            Kefir = ingredients
                .FirstOrDefault(foodstuff => foodstuff.Name.Equals("Кефир")) as Kefir;

            OliveOil = ingredients
                .FirstOrDefault(foodstuff => foodstuff.Name.Equals("Масло оливковое")) as OliveOil;

            Salt = ingredients
                .FirstOrDefault(foodstuff => foodstuff.Name.Equals("Соль морская")) as SeaSalt;

            Oregano = ingredients
                .FirstOrDefault(foodstuff => foodstuff.Name.Equals("Орегано")) as Oregano;

        }
    }
}
