using HeadСhef.DAL.Abstract;
using HeadСhef.DAL.Entities.KindOfFood;
using HeadСhef.DAL.Helper;
using HeadСhef.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HeadСhef.DAL.Entities.Dishes
{
    public class CaesarSauce : Foodstuff, IDish
    {
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

            CaloricPer100Grams = CalculateCaloricPer100GramsOfSauce();

            FatsPer100Grams = CalculateFatsPer100GramsOfSauce();

            ProteinsPer100Grams = CalculateProteinsPer100GramsOfSauce();

            CarbohydratesPer100Grams = CalculateCarbohydratesPer100GramsOfSauce();
        }

        private double CalculateCaloricPer100GramsOfSauce()
        {
            var eggCaloric = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_EGG_YOLK_PER_100_GRAMS_OF_SAUCE, EggYolk.CaloricPer100Grams);

            var powderCaloric = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_MUSTARD_POWDER_PER_100_GRAMS_OF_SAUCE, MustardPowder.CaloricPer100Grams);

            var kefirCaloric = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_KEFIR_PER_100_GRAMS_OF_SAUCE, Kefir.CaloricPer100Grams);

            var oliveOilCaloric = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_OLIVE_OIL_PER_100_GRAMS_OF_SAUCE, OliveOil.CaloricPer100Grams);

            var saltCaloric = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_SALT_PER_100_GRAMS_OF_SAUCE, Salt.CaloricPer100Grams);

            var oreganoCaloric = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_OREGANO_PER_100_GRAMS_OF_SAUCE, Oregano.CaloricPer100Grams);

            return eggCaloric + powderCaloric + kefirCaloric + oliveOilCaloric + saltCaloric + oreganoCaloric;
        }

        private double CalculateFatsPer100GramsOfSauce()
        {
            var eggFats = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_EGG_YOLK_PER_100_GRAMS_OF_SAUCE, EggYolk.FatsPer100Grams);

            var powderFats = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_MUSTARD_POWDER_PER_100_GRAMS_OF_SAUCE, MustardPowder.FatsPer100Grams);

            var kefirFats = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_KEFIR_PER_100_GRAMS_OF_SAUCE, Kefir.FatsPer100Grams);

            var oliveOilFats = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_OLIVE_OIL_PER_100_GRAMS_OF_SAUCE, OliveOil.FatsPer100Grams);

            var saltFats = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_SALT_PER_100_GRAMS_OF_SAUCE, Salt.FatsPer100Grams);

            var oreganoFats = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_OREGANO_PER_100_GRAMS_OF_SAUCE, Oregano.FatsPer100Grams);

            return eggFats + powderFats + kefirFats + oliveOilFats + saltFats + oreganoFats;
        }

        private double CalculateProteinsPer100GramsOfSauce()
        {
            var eggProteins = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_EGG_YOLK_PER_100_GRAMS_OF_SAUCE, EggYolk.ProteinsPer100Grams);

            var powderProteins = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_MUSTARD_POWDER_PER_100_GRAMS_OF_SAUCE, MustardPowder.ProteinsPer100Grams);

            var kefirProteins = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_KEFIR_PER_100_GRAMS_OF_SAUCE, Kefir.ProteinsPer100Grams);

            var oliveOilProteins = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_OLIVE_OIL_PER_100_GRAMS_OF_SAUCE, OliveOil.ProteinsPer100Grams);

            var saltProteins = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_SALT_PER_100_GRAMS_OF_SAUCE, Salt.ProteinsPer100Grams);

            var oreganoProteins = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_OREGANO_PER_100_GRAMS_OF_SAUCE, Oregano.ProteinsPer100Grams);

            return eggProteins + powderProteins + kefirProteins + oliveOilProteins + saltProteins + oreganoProteins;
        }

        private double CalculateCarbohydratesPer100GramsOfSauce()
        {
            var eggCarbohydrates = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_EGG_YOLK_PER_100_GRAMS_OF_SAUCE, EggYolk.CarbohydratesPer100Grams);

            var powderCarbohydrates = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_MUSTARD_POWDER_PER_100_GRAMS_OF_SAUCE, MustardPowder.CarbohydratesPer100Grams);

            var kefirCarbohydrates = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_KEFIR_PER_100_GRAMS_OF_SAUCE, Kefir.CarbohydratesPer100Grams);

            var oliveOilCarbohydrates = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_OLIVE_OIL_PER_100_GRAMS_OF_SAUCE, OliveOil.CarbohydratesPer100Grams);

            var saltCarbohydrates = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_SALT_PER_100_GRAMS_OF_SAUCE, Salt.CarbohydratesPer100Grams);

            var oreganoCarbohydrates = ProductCalculator.CalculateWeightOfProductInDish(
                    SauceData.GRAMS_OF_OREGANO_PER_100_GRAMS_OF_SAUCE, Oregano.CarbohydratesPer100Grams);

            return eggCarbohydrates + powderCarbohydrates + kefirCarbohydrates + oliveOilCarbohydrates + saltCarbohydrates + oreganoCarbohydrates;
        }

        private void MakeSauce(IEnumerable<IFoodstuff> ingredients)
        {

            EggYolk = ingredients
                .Where(f => f is EggYolk)
                .FirstOrDefault() as EggYolk;

            MustardPowder = ingredients
                .Where(f => f is MustardPowder)
                .FirstOrDefault() as MustardPowder;

            Kefir = ingredients
                .Where(f => f is Kefir)
                .FirstOrDefault() as Kefir;

            OliveOil = ingredients
                .Where(f => f is OliveOil)
                .FirstOrDefault() as OliveOil;

            Salt = ingredients
                .Where(f => f is SeaSalt)
                .FirstOrDefault() as SeaSalt;

            Oregano = ingredients
                .Where(f => f is Oregano)
                .FirstOrDefault() as Oregano;
        }

        public IFoodstuff GetCookedDish()
        {
            return this;
        }
    }
}
