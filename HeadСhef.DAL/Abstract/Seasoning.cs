using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Abstract
{
    public abstract class Seasoning : Foodstuff
    {
        public Seasoning(double weight) : base(weight)
        {
        }

        public override sealed string Category => "Приправы";
        public override string Name => "Соль";
        public override double CaloricPer100Grams => 0.0;
        public override double FatsPer100Grams => 0.0;
        public override double ProteinsPer100Grams => 0.0;
        public override double CarbohydratesPer100Grams => 0.0;

    }
}
