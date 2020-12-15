using HeadСhef.DAL.Abstract;
using HeadСhef.DAL.Entities.KindOfFood;
using HeadСhef.DAL.Helper;
using HeadСhef.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HeadСhef.DAL.Entities.Dishes
{
    public class CaesarSauce : Dish
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

            CaloricPer100Grams = CalculateNutritionInformation(_proportions)["caloric"];

            FatsPer100Grams = CalculateNutritionInformation(_proportions)["fats"];

            ProteinsPer100Grams = CalculateNutritionInformation(_proportions)["proteins"];

            CarbohydratesPer100Grams = CalculateNutritionInformation(_proportions)["carbohydrates"];
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
