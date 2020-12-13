using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Entities.KindOfFood
{
    public class Kefir : MilkProduct
    {
        public Kefir(double weight) : base(weight)
        {
        }

        public override string Name => "Кефир";
        public override double CaloricPer100Grams => 40.0;
        public override double FatsPer100Grams => 1.0;
        public override double ProteinsPer100Grams => 2.8;
        public override double CarbohydratesPer100Grams => 4.0;
    }
}
