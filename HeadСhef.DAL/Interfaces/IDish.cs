using System;
using System.Collections.Generic;
using System.Text;

namespace HeadСhef.DAL.Interfaces
{
    public interface IDish
    {
        /// <summary>
        /// Prepare a dish
        /// </summary>
        IFoodstuff Make(double gramm);
    }
}
