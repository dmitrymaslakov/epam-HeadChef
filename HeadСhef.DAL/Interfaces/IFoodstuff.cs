using System;
using System.Collections.Generic;
using System.Text;

namespace HeadСhef.DAL.Interfaces
{
    public interface IFoodstuff
    {
        string Name { get; set; }
        double CaloricPer100Grams { get; set; }
        double FatsPer100Grams { get; set; }
        double ProteinsPer100Grams { get; set; }
        double CarbohydratesPer100Grams { get; set; }
        double Weight { get; set; }
    }
}
