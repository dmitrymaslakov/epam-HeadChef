using HeadСhef.DAL.Entities.KindOfFood;
using System.Collections.Generic;

namespace HeadСhef.DAL.Entities
{
    public interface IStore
    {
        IEnumerable<Bakery> Bakeries { get; set; }
        IEnumerable<Meat> Meats { get; set; }
        IEnumerable<MilkProduct> MilkProducts { get; set; }
        IEnumerable<Seasoning> Seasonings { get; set; }
        IEnumerable<Vegetable> Vegetables { get; set; }
        IEnumerable<VegetablesOil> VegetablesOils { get; set; }
    }
}
