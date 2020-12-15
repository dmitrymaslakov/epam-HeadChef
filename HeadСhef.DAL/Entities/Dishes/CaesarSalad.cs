using HeadСhef.DAL.Abstract;
using HeadСhef.DAL.Entities.KindOfFood;
using HeadСhef.DAL.Helper;
using HeadСhef.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HeadСhef.DAL.Entities.Dishes
{
    public class CaesarSalad : Dish
    {
        private readonly Dictionary<IFoodstuff, double> _proportions;

        public LactucaSativa Salad { get; private set; }
        public Parmesan Parmesan { get; private set; }
        public CiabattaBread Bread { get; private set; }
        public Garlic Garlic { get; private set; }
        public OliveOil OliveOil { get; private set; }
        public SeaSalt Salt { get; private set; }
        public BlackPepper BlackPepper { get; private set; }
        public CaesarSauce CaesarSauce { get; private set; }
        public override string Name => "Салат Цезарь";
        public override string Category => "Холодная закуска";
        public override double CaloricPer100Grams { get; }
        public override double FatsPer100Grams { get; }
        public override double ProteinsPer100Grams { get; }
        public override double CarbohydratesPer100Grams { get; }

        public CaesarSalad(double weight, IEnumerable<IFoodstuff> ingredients, CaesarSauce dishDressing) : base(weight)
        {
            MakeSalad(ingredients);

            CaesarSauce = dishDressing;

            _proportions = new Dictionary<IFoodstuff, double> {
                { Salad, SaladData.GRAMS_OF_SALAD_PER_100_GRAMS_OF_SALAD },
                { Parmesan, SaladData.GRAMS_OF_PARMESAN_PER_100_GRAMS_OF_SALAD },
                { Bread, SaladData.GRAMS_OF_BREAD_PER_100_GRAMS_OF_SALAD },
                { Garlic, SaladData.GRAMS_OF_GARLIC_PER_100_GRAMS_OF_SALAD},
                { OliveOil, SaladData.GRAMS_OF_OLIVE_OIL_PER_100_GRAMS_OF_SALAD },
                { Salt, SaladData.GRAMS_OF_SALT_PER_100_GRAMS_OF_SALAD },
                { BlackPepper, SaladData.GRAMS_OF_BLACK_PEPPER_PER_100_GRAMS_OF_SALAD },
                { CaesarSauce, SaladData.GRAMS_OF_CAESAR_SAUCE_PER_100_GRAMS_OF_SALAD }
            };

            CaloricPer100Grams = CalculateNutritionInformation(_proportions)["caloric"];

            FatsPer100Grams = CalculateNutritionInformation(_proportions)["fats"];

            ProteinsPer100Grams = CalculateNutritionInformation(_proportions)["proteins"];

            CarbohydratesPer100Grams = CalculateNutritionInformation(_proportions)["carbohydrates"];
        }

        private void MakeSalad(IEnumerable<IFoodstuff> ingredients)
        {
            Salad = ingredients
                .FirstOrDefault(foodstuff => foodstuff.Name.Equals("Салат Айсберг")) as LactucaSativa;

            Parmesan = ingredients
                .FirstOrDefault(foodstuff => foodstuff.Name.Equals("Пармезан")) as Parmesan;

            Bread = ingredients
                 .FirstOrDefault(foodstuff => foodstuff.Name.Equals("Хлеб Чиабатта")) as CiabattaBread;

            Garlic = ingredients
                .FirstOrDefault(foodstuff => foodstuff.Name.Equals("Чеснок")) as Garlic;

            OliveOil = ingredients
                .FirstOrDefault(foodstuff => foodstuff.Name.Equals("Масло оливковое")) as OliveOil;

            Salt = ingredients
                .FirstOrDefault(foodstuff => foodstuff.Name.Equals("Соль морская")) as SeaSalt;

            BlackPepper = ingredients
                .FirstOrDefault(foodstuff => foodstuff.Name.Equals("Черный перец")) as BlackPepper;
        }
    }
}
