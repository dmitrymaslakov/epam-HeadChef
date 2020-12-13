using HeadСhef.DAL.Entities.Dishes;

namespace HeadСhef.DAL.Interfaces
{
    public interface IChef
    {
        string Name { get; set; }

        IFoodstuff MakeDish(DishesIndex dish, double weight, IFoodstuff dishDressing = null);
    }
}
