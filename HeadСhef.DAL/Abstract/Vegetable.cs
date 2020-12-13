using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Abstract
{
    public abstract class Vegetable : Foodstuff
    {
        public Vegetable(double weight) : base(weight)
        {
        }

        public override string Category => "Овощи";
        public override string Name => "Капуста";
        public override double CaloricPer100Grams => 27.0;
        public override double FatsPer100Grams => 0.1;
        public override double ProteinsPer100Grams => 1.8;
        public override double CarbohydratesPer100Grams => 4.7;

    }
}
