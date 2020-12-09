using System;
using System.Collections.Generic;
using System.Text;

namespace HeadСhef.DAL.Interfaces
{
    public interface IChef
    {
        string Name { get; set; }

        IFoodstuff MakeDish(IDish dish, double grams);
    }
}
