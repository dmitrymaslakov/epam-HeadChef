using HeadСhef.DAL.Entities.KindOfFood;
using System.Collections.Generic;

namespace HeadСhef.DAL.Entities
{
    public class Store : IStore
    {
        public IEnumerable<Bakery> Bakeries { get; set; }
        public IEnumerable<Meat> Meats { get; set; }
        public IEnumerable<MilkProduct> MilkProducts { get; set; }
        public IEnumerable<Seasoning> Seasonings { get; set; }
        public IEnumerable<Vegetable> Vegetables { get; set; }
        public IEnumerable<VegetablesOil> VegetablesOils { get; set; }
    }
}
