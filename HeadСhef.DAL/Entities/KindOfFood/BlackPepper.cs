using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Entities.KindOfFood
{
    public class BlackPepper : Seasoning
    {
        public BlackPepper(double weight) : base(weight)
        {
        }

        public override string Name => "Черный перец";
        public override double CaloricPer100Grams => 251.0;
        public override double FatsPer100Grams => 3.3;
        public override double ProteinsPer100Grams => 10.4;
        public override double CarbohydratesPer100Grams => 38.7;
    }
}
