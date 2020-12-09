using HeadСhef.DAL.Interfaces;
using System;

namespace HeadСhef.DAL.Abstract
{
    public abstract class Foodstuff : IFoodstuff
    {
        public string Name { get; set; }
        public double CaloricPer100Grams { get; set; }
        public double FatsPer100Grams { get; set; }
        public double ProteinsPer100Grams { get; set; }
        public double CarbohydratesPer100Grams { get; set; }
        public double Weight { get; set; }
    }
}
