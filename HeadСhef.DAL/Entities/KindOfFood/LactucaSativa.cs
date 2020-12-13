using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Entities.KindOfFood
{
    public class LactucaSativa : Vegetable
    {
        public LactucaSativa(double weight) : base(weight)
        {
        }

        public override string Name => "Салат Айсберг";
        public override double CaloricPer100Grams => 14.0;
        public override double FatsPer100Grams => 0.1;
        public override double ProteinsPer100Grams => 0.9;
        public override double CarbohydratesPer100Grams => 1.8;
    }
}
