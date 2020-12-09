using HeadСhef.DAL.Abstract;
using HeadСhef.DAL.Entities.KindOfFood;
using HeadСhef.DAL.Interfaces;
using System.Linq;

namespace HeadСhef.DAL.Entities.Dishes
{
    public class CaesarSalad : Foodstuff, IDish
    {
        private const double GRAMS_OF_SALAD_PER_100_GRAMS_OF_SALAD = 43.1;
        private const double GRAMS_OF_PARMESAN_PER_100_GRAMS_OF_SALAD = 10.8;
        private const double GRAMS_OF_BREAD_PER_100_GRAMS_OF_SALAD = 21.6;
        private const double GRAMS_OF_GARLIC_PER_100_GRAMS_OF_SALAD = 0.4;
        private const double GRAMS_OF_OLIVE_OIL_PER_100_GRAMS_OF_SALAD = 3.9;
        private const double GRAMS_OF_SALT_PER_100_GRAMS_OF_SALAD = 0.4;
        private const double GRAMS_OF_BLACK_PEPPER_PER_100_GRAMS_OF_SALAD = 0.4;
        private const double GRAMS_OF_CAESAR_SAUCE_PER_100_GRAMS_OF_SALAD = 19.4;

        private readonly IStore _store;
        private readonly DishService _dishService;

        public Vegetable Salad { get; set; }
        public MilkProduct Parmesan { get; set; }
        public Bakery Bread { get; set; }
        public Seasoning Garlic { get; set; }
        public VegetablesOil OliveOil { get; set; }
        public Seasoning Salt { get; set; }
        public Seasoning BlackPepper { get; set; }
        public CaesarSauce CaesarSauce { get; set; }

        public CaesarSalad(IStore store, double defaultGramm = 100.0)
        {
            _store = store;

            _dishService = new DishService();

            Make(defaultGramm);

            CaloricPer100Grams = _dishService.CalculateCaloricPer100GramsOfProduct(this);
        }
        public IFoodstuff Make(double gramm)
        {
            Salad = _store.Vegetables
                .Where(s => s.Name.Equals("Salad"))
                .Select(s => { s.Weight = GRAMS_OF_SALAD_PER_100_GRAMS_OF_SALAD; return s; })
                .FirstOrDefault();

            Parmesan = _store.MilkProducts
                .Where(p => p.Name.Equals("Parmesan"))
                .Select(p => { p.Weight = GRAMS_OF_PARMESAN_PER_100_GRAMS_OF_SALAD; return p; })
                .FirstOrDefault();

            Bread = _store.Bakeries
                .Where(b => b.Name.Equals("Bread"))
                .Select(b => { b.Weight = GRAMS_OF_BREAD_PER_100_GRAMS_OF_SALAD; return b; })
                .FirstOrDefault();

            Garlic = _store.Seasonings
                .Where(g => g.Name.Equals("Garlic"))
                .Select(g => { g.Weight = GRAMS_OF_GARLIC_PER_100_GRAMS_OF_SALAD; return g; })
                .FirstOrDefault();

            OliveOil = _store.VegetablesOils
                .Where(o => o.Name.Equals("Olive oil"))
                .Select(o => { o.Weight = GRAMS_OF_OLIVE_OIL_PER_100_GRAMS_OF_SALAD; return o; })
                .FirstOrDefault();

            Salt = _store.Seasonings
                .Where(s => s.Name.Equals("Salt"))
                .Select(s => { s.Weight = GRAMS_OF_SALT_PER_100_GRAMS_OF_SALAD; return s; })
                .FirstOrDefault();

            BlackPepper = _store.Seasonings
                .Where(s => s.Name.Equals("Black pepper"))
                .Select(s => { s.Weight = GRAMS_OF_BLACK_PEPPER_PER_100_GRAMS_OF_SALAD; return s; })
                .FirstOrDefault();

            CaesarSauce = new CaesarSauce(_store)
                .Make(GRAMS_OF_CAESAR_SAUCE_PER_100_GRAMS_OF_SALAD) as CaesarSauce;

            Weight = gramm;

            return this;
        }
    }
}
