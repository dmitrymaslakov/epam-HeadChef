using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Abstract
{
    public abstract class MilkProduct : Foodstuff
    {
        public MilkProduct(double weight) : base(weight)
        {
        }

        public override string Category => "Кисло-молочные продукты";
        public override string Name => "Молоко";
        public override double CaloricPer100Grams => 64.0;
        public override double FatsPer100Grams => 3.6;
        public override double ProteinsPer100Grams => 3.2;
        public override double CarbohydratesPer100Grams => 4.8;

    }
}
