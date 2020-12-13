using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Abstract
{
    public abstract class Bakery : Foodstuff
    {
        public Bakery(double weight) : base(weight)
        {
        }

        public override string Category => "Хлебобулочные изделия";
        public override string Name => "Хлеб";
        public override double CaloricPer100Grams => 250.0;
        public override double FatsPer100Grams => 4.0;
        public override double ProteinsPer100Grams => 8.0;
        public override double CarbohydratesPer100Grams => 50.0;
    }
}
