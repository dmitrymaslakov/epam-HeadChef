using System;
using System.Collections.Generic;
using System.Text;

namespace HeadСhef.DAL.Interfaces
{
    public interface IDish
    {
        /// <summary>
        /// Cooked dish
        /// </summary>
        IFoodstuff GetCookedDish();
    }
}
