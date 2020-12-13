using HeadСhef.DAL.Interfaces;
using System;

namespace HeadСhef.DAL.Abstract
{
    public abstract class Foodstuff : IFoodstuff
    {
        public Foodstuff(double weight)
        {
            Weight = weight;
        }
        
        public abstract string Name { get; }
        public abstract string Category { get; }
        public abstract double CaloricPer100Grams { get; }
        public abstract double FatsPer100Grams { get; }
        public abstract double ProteinsPer100Grams { get; }
        public abstract double CarbohydratesPer100Grams { get; }
        public double Weight { get; private set; }

    }
}
