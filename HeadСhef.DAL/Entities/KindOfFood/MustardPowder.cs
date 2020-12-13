using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Entities.KindOfFood
{
    public class MustardPowder : Seasoning
    {
        public MustardPowder(double weight) : base(weight)
        {
        }

        public override string Name => "Горчица";
        public override double CaloricPer100Grams => 378;
        public override double FatsPer100Grams => 11.1;
        public override double ProteinsPer100Grams => 37.1;
        public override double CarbohydratesPer100Grams => 32.6;
    }
}
