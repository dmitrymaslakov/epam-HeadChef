namespace HeadСhef.DAL.Helper
{
    public class ProductCalculator
    {
        public static double CalculateWeightOfProductInDish(double necessaryWeightOfDish, double specificWeightOfProductPer100GramsOfDish)
        {
            try
            {
                double defaultGrammOfDish = 100.0;

                return necessaryWeightOfDish * specificWeightOfProductPer100GramsOfDish / defaultGrammOfDish;
            }
            catch
            {
                throw;
            }
        }

    }
}
