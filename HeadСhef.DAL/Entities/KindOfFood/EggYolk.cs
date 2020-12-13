using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Entities.KindOfFood
{

    public class EggYolk : Meat
    {
        public EggYolk(double weight) : base(weight)
        {
        }

        public override string Name => "Куриный желток";
        public override double CaloricPer100Grams => 352.0;
        public override double FatsPer100Grams => 31.2;
        public override double ProteinsPer100Grams => 16.2;
        public override double CarbohydratesPer100Grams => 1.0;
    }
}


