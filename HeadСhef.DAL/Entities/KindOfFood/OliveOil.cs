using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Entities.KindOfFood
{
    public class OliveOil : VegetableOil
    {
        public OliveOil(double weight) : base(weight)
        {
        }
        public override string Name => "Масло оливковое";
        public override double CaloricPer100Grams => 898.0;
        public override double FatsPer100Grams => 99.8;
    }
}
