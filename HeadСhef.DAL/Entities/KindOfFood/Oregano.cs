using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Entities.KindOfFood
{
    public class Oregano : Seasoning
    {
        public Oregano(double weight) : base(weight)
        {
        }

        public override string Name => "Орегано";

        public override double CaloricPer100Grams => 306.0;

        public override double FatsPer100Grams => 10.3;

        public override double ProteinsPer100Grams => 11.0;

        public override double CarbohydratesPer100Grams => 21.6;
    }
}
