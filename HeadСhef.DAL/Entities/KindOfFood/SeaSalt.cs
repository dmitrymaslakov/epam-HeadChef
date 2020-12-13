using HeadСhef.DAL.Abstract;

namespace HeadСhef.DAL.Entities.KindOfFood
{
    public class SeaSalt : Seasoning
    {
        public SeaSalt(double weight) : base(weight)
        {
        }

        public override string Name => "Соль морская";
    }
}
