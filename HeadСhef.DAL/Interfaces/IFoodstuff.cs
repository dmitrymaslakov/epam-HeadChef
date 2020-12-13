using System;
using System.Collections.Generic;
using System.Text;

namespace HeadСhef.DAL.Interfaces
{
    public interface IFoodstuff
    {
        string Name { get; }
        string Category { get; }
        double CaloricPer100Grams { get; }
        double FatsPer100Grams { get; }
        double ProteinsPer100Grams { get; }
        double CarbohydratesPer100Grams { get; }
        double Weight { get; }
    }
}
