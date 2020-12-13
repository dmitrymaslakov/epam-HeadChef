using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Abstract
{
    public abstract class Meat : Foodstuff
    {
        public Meat(double weight) : base(weight)
        {
        }

        public override string Category => "Мясные продукты";
        public override string Name => "Говядина";
        public override double CaloricPer100Grams => 187.0;
        public override double FatsPer100Grams => 12.4;
        public override double ProteinsPer100Grams => 18.9;
        public override double CarbohydratesPer100Grams => 0.0;

    }
}
