using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Abstract
{
    public abstract class VegetableOil : Foodstuff
    {
        public VegetableOil(double weight) : base(weight)
        {
        }

        public override sealed string Category => "Масло растительное";
        public override double CaloricPer100Grams => 900.0;
        public override double FatsPer100Grams => 99.9;
        public override double ProteinsPer100Grams => 0.0;
        public override double CarbohydratesPer100Grams => 0.0;
    }
}
