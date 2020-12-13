using HeadСhef.DAL.Entities.KindOfFood;
using System.Collections.Generic;

namespace HeadСhef.DAL.Abstract
{
    public interface IStore
    {
        /*IEnumerable<Bakery> Bakeries { get; set; }
        IEnumerable<Meat> Meats { get; set; }
        IEnumerable<MilkProduct> MilkProducts { get; set; }
        IEnumerable<Seasoning> Seasonings { get; set; }
        IEnumerable<Vegetable> Vegetables { get; set; }
        IEnumerable<VegetableOil> VegetablesOils { get; set; }*/

        BlackPepper GetBlackPepper(double weight);
    }
}
