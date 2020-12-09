using HeadСhef.DAL.Abstract;
using HeadСhef.DAL.Entities.KindOfFood;
using HeadСhef.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HeadСhef.DAL.Entities.Dishes
{
    public class CaesarSauce : Foodstuff, IDish
    {
        private const double GRAMS_OF_EGG_YOLK_PER_100_GRAMS_OF_SAUCE = 15.1;
        private const double GRAMS_OF_MUSTARD_POWDER_PER_100_GRAMS_OF_SAUCE = 6.1;
        private const double GRAMS_OF_KEFIR_PER_100_GRAMS_OF_SAUCE = 37.9;
        private const double GRAMS_OF_OLIVE_OIL_PER_100_GRAMS_OF_SAUCE = 37.9;
        private const double GRAMS_OF_SALT_PER_100_GRAMS_OF_SAUCE = 1.5;
        private const double GRAMS_OF_OREGANO_PER_100_GRAMS_OF_SAUCE = 1.5;

        private readonly IStore _store;
        private readonly DishService _dishService;

        public Meat EggYolk { get; set; }
        public Seasoning MustardPowder { get; set; }
        public MilkProduct Kefir { get; set; }
        public VegetablesOil OliveOil { get; set; }
        public Seasoning Salt { get; set; }
        public Seasoning Oregano { get; set; }

        public CaesarSauce(IStore store, double defaultGrammOfProduct = 100.0)
        {
            _store = store;

            _dishService = new DishService();

            Name = "Caesar Sauce";

            Make(defaultGrammOfProduct);

            CaloricPer100Grams = _dishService.CalculateCaloricPer100GramsOfProduct(this);
        }

        public IFoodstuff Make(double grammOfProduct)
        {
            Weight = grammOfProduct;

            EggYolk = _store.Meats
                .Where(ey => ey.Name.Equals("Egg yolk"))
                .Select(ey => { ey.Weight = _dishService.CalculateGrammOfProductPartFor(grammOfProduct, GRAMS_OF_EGG_YOLK_PER_100_GRAMS_OF_SAUCE); return ey; })
                .FirstOrDefault();

            MustardPowder = _store.Seasonings
                .Where(mp => mp.Name.Equals("Mustard powder"))
                .Select(mp => { mp.Weight = _dishService.CalculateGrammOfProductPartFor(grammOfProduct, GRAMS_OF_MUSTARD_POWDER_PER_100_GRAMS_OF_SAUCE); return mp; })
                .FirstOrDefault();

            Kefir = _store.MilkProducts
                .Where(k => k.Name.Equals("Kefir"))
                .Select(k => { k.Weight = _dishService.CalculateGrammOfProductPartFor(grammOfProduct, GRAMS_OF_KEFIR_PER_100_GRAMS_OF_SAUCE); return k; })
                .FirstOrDefault();

            OliveOil = _store.VegetablesOils
                .Where(o => o.Name.Equals("Olive oil"))
                .Select(o => { o.Weight = _dishService.CalculateGrammOfProductPartFor(grammOfProduct, GRAMS_OF_OLIVE_OIL_PER_100_GRAMS_OF_SAUCE); return o; })
                .FirstOrDefault();

            Salt = _store.Seasonings
                .Where(s => s.Name.Equals("Salt"))
                .Select(s => { s.Weight = _dishService.CalculateGrammOfProductPartFor(grammOfProduct, GRAMS_OF_SALT_PER_100_GRAMS_OF_SAUCE); return s; })
                .FirstOrDefault();

            Oregano = _store.Seasonings
                .Where(or => or.Name.Equals("Oregano"))
                .Select(or => { or.Weight = _dishService.CalculateGrammOfProductPartFor(grammOfProduct, GRAMS_OF_OREGANO_PER_100_GRAMS_OF_SAUCE); return or; })
                .FirstOrDefault();

            return this;
        }

    }
}
