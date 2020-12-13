using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Entities.KindOfFood
{
    public class CiabattaBread : Bakery
    {
        public CiabattaBread(double weight) : base(weight)
        {
        }

        public override string Name => "Хлеб Чиабатта";
        public override double CaloricPer100Grams => 262.0;
        public override double FatsPer100Grams => 3.8;
        public override double ProteinsPer100Grams => 7.7;
        public override double CarbohydratesPer100Grams => 47.8;
    }
}
