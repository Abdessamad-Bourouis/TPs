using Formation.Models;

namespace Formation.Abstraction
{
    public interface IRestaurant
    {
        bool AddRestaurant(Restaurant _restaurant);
        List<Restaurant> GetListRestaurant();
        Restaurant GetRestaurant(int Id);
    }
}
