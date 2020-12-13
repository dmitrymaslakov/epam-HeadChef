using HeadСhef.DAL.Abstract;
using HeadСhef.DAL.Entities.KindOfFood;
using HeadСhef.DAL.Helper;
using HeadСhef.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HeadСhef.DAL.Entities.Dishes
{
    public class CaesarSalad : Foodstuff, IDish
    {
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

        public CaesarSalad(double weight, IEnumerable<IFoodstuff> ingredients, IFoodstuff dishDressing) : base(weight)
        {
            MakeSalad(ingredients);

            CaesarSauce = dishDressing as CaesarSauce;

            CaloricPer100Grams = CalculateCaloricPer100GramsOfSalad();

            FatsPer100Grams = CalculateFatsPer100GramsOfSalad();

            ProteinsPer100Grams = CalculateProteinsPer100GramsOfSalad();

            CarbohydratesPer100Grams = CalculateCarbohydratesPer100GramsOfSalad();
        }

        private double CalculateCaloricPer100GramsOfSalad()
        {
            var saladCaloric = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_SALAD_PER_100_GRAMS_OF_SALAD, Salad.CaloricPer100Grams);

            var parmesanCaloric = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_PARMESAN_PER_100_GRAMS_OF_SALAD, Parmesan.CaloricPer100Grams);

            var breadCaloric = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_BREAD_PER_100_GRAMS_OF_SALAD, Bread.CaloricPer100Grams);

            var garlicCaloric = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_GARLIC_PER_100_GRAMS_OF_SALAD, Garlic.CaloricPer100Grams);

            var oliveOilCaloric = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_OLIVE_OIL_PER_100_GRAMS_OF_SALAD, OliveOil.CaloricPer100Grams);

            var saltCaloric = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_SALT_PER_100_GRAMS_OF_SALAD, Salt.CaloricPer100Grams);

            var blackPepperCaloric = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_BLACK_PEPPER_PER_100_GRAMS_OF_SALAD, BlackPepper.CaloricPer100Grams);

            var caesarSauceCaloric = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_CAESAR_SAUCE_PER_100_GRAMS_OF_SALAD, CaesarSauce.CaloricPer100Grams);

            return saladCaloric + parmesanCaloric + breadCaloric + garlicCaloric + oliveOilCaloric +
                saltCaloric + blackPepperCaloric + caesarSauceCaloric;
        }

        private double CalculateFatsPer100GramsOfSalad()
        {
            var saladFats = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_SALAD_PER_100_GRAMS_OF_SALAD, Salad.FatsPer100Grams);

            var parmesanFats = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_PARMESAN_PER_100_GRAMS_OF_SALAD, Parmesan.FatsPer100Grams);

            var breadFats = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_BREAD_PER_100_GRAMS_OF_SALAD, Bread.FatsPer100Grams);

            var garlicFats = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_GARLIC_PER_100_GRAMS_OF_SALAD, Garlic.FatsPer100Grams);

            var oliveOilFats = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_OLIVE_OIL_PER_100_GRAMS_OF_SALAD, OliveOil.FatsPer100Grams);

            var saltFats = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_SALT_PER_100_GRAMS_OF_SALAD, Salt.FatsPer100Grams);

            var blackPepperFats = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_BLACK_PEPPER_PER_100_GRAMS_OF_SALAD, BlackPepper.FatsPer100Grams);

            var caesarSauceFats = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_CAESAR_SAUCE_PER_100_GRAMS_OF_SALAD, CaesarSauce.FatsPer100Grams);

            return saladFats + parmesanFats + breadFats + garlicFats + oliveOilFats +
                saltFats + blackPepperFats + caesarSauceFats;
        }
        
        private double CalculateProteinsPer100GramsOfSalad()
        {
            var saladProteins = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_SALAD_PER_100_GRAMS_OF_SALAD, Salad.ProteinsPer100Grams);

            var parmesanProteins = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_PARMESAN_PER_100_GRAMS_OF_SALAD, Parmesan.ProteinsPer100Grams);

            var breadProteins = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_BREAD_PER_100_GRAMS_OF_SALAD, Bread.ProteinsPer100Grams);

            var garlicProteins = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_GARLIC_PER_100_GRAMS_OF_SALAD, Garlic.ProteinsPer100Grams);

            var oliveOilProteins = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_OLIVE_OIL_PER_100_GRAMS_OF_SALAD, OliveOil.ProteinsPer100Grams);

            var saltProteins = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_SALT_PER_100_GRAMS_OF_SALAD, Salt.ProteinsPer100Grams);

            var blackPepperProteins = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_BLACK_PEPPER_PER_100_GRAMS_OF_SALAD, BlackPepper.ProteinsPer100Grams);

            var caesarSauceProteins = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_CAESAR_SAUCE_PER_100_GRAMS_OF_SALAD, CaesarSauce.ProteinsPer100Grams);

            return saladProteins + parmesanProteins + breadProteins + garlicProteins + oliveOilProteins +
                saltProteins + blackPepperProteins + caesarSauceProteins;
        }
        
        private double CalculateCarbohydratesPer100GramsOfSalad()
        {
            var saladCarbohydrates = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_SALAD_PER_100_GRAMS_OF_SALAD, Salad.CarbohydratesPer100Grams);

            var parmesanCarbohydrates = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_PARMESAN_PER_100_GRAMS_OF_SALAD, Parmesan.CarbohydratesPer100Grams);

            var breadCarbohydrates = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_BREAD_PER_100_GRAMS_OF_SALAD, Bread.CarbohydratesPer100Grams);

            var garlicCarbohydrates = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_GARLIC_PER_100_GRAMS_OF_SALAD, Garlic.CarbohydratesPer100Grams);

            var oliveOilCarbohydrates = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_OLIVE_OIL_PER_100_GRAMS_OF_SALAD, OliveOil.CarbohydratesPer100Grams);

            var saltCarbohydrates = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_SALT_PER_100_GRAMS_OF_SALAD, Salt.CarbohydratesPer100Grams);

            var blackPepperCarbohydrates = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_BLACK_PEPPER_PER_100_GRAMS_OF_SALAD, BlackPepper.CarbohydratesPer100Grams);

            var caesarSauceCarbohydrates = ProductCalculator.CalculateWeightOfProductInDish(
                SaladData.GRAMS_OF_CAESAR_SAUCE_PER_100_GRAMS_OF_SALAD, CaesarSauce.CarbohydratesPer100Grams);

            return saladCarbohydrates + parmesanCarbohydrates + breadCarbohydrates + garlicCarbohydrates + oliveOilCarbohydrates +
                saltCarbohydrates + blackPepperCarbohydrates + caesarSauceCarbohydrates;
        }

        private void MakeSalad(IEnumerable<IFoodstuff> ingredients)
        {
            Salad = ingredients
                .Where(f => f is LactucaSativa)
                .FirstOrDefault() as LactucaSativa;

            Parmesan = ingredients
                .Where(f => f is Parmesan)
                .FirstOrDefault() as Parmesan;

            Bread = ingredients
                .Where(f => f is CiabattaBread)
                .FirstOrDefault() as CiabattaBread;

            Garlic = ingredients
                .Where(f => f is Garlic)
                .FirstOrDefault() as Garlic;

            OliveOil = ingredients
                .Where(f => f is OliveOil)
                .FirstOrDefault() as OliveOil;

            Salt = ingredients
                .Where(f => f is SeaSalt)
                .FirstOrDefault() as SeaSalt;

            BlackPepper = ingredients
                .Where(f => f is BlackPepper)
                .FirstOrDefault() as BlackPepper;
        }

        public IFoodstuff GetCookedDish()
        {
            return this;
        }
    }
}
