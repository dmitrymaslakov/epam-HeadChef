using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Entities.KindOfFood
{
    public class Garlic : Seasoning
    {
        public Garlic(double weight) : base(weight)
        {
        }

        public override string Name => "Чеснок";
        public override double CaloricPer100Grams => 163.0;
        public override double FatsPer100Grams => 0.5;
        public override double ProteinsPer100Grams => 6.5;
        public override double CarbohydratesPer100Grams => 29.9;
    }
}
