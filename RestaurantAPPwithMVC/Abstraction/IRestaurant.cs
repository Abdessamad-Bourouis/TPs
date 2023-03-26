using RestaurantAPPwithMVC.Models;

namespace RestaurantAPPwithMVC.Abstraction;

public interface IRestaurant
{
    bool AddRestaurant(Restaurant _restaurant);
    List<Restaurant> GetListRestaurant();
    Restaurant GetRestaurant(Guid Id);
    bool UpdateRestaurant(Restaurant restaurant);
    bool DeleteRestaurant(Guid Id);
}