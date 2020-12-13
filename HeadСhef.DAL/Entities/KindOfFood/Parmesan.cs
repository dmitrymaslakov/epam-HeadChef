using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Entities.KindOfFood
{
    public class Parmesan : MilkProduct
    {
        public Parmesan(double weight) : base(weight)
        {
        }

        public override string Name => "Пармезан";

        public override double CaloricPer100Grams => 392.0;

        public override double FatsPer100Grams => 28.0;

        public override double ProteinsPer100Grams => 33.0;

        public override double CarbohydratesPer100Grams => 0.0;
    }
}
