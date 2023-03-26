using RestaurantAPPwithMVC.Abstraction;
using RestaurantAPPwithMVC.Models;

namespace RestaurantAPPwithMVC.Repository
{
    public class RestaurantRepository:IRestaurant
    {
        public bool AddRestaurant(Restaurant _restaurant)
        {
            try
            {
                
                Data.restaurant.Add(_restaurant);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteRestaurant(Guid Id)
        {
            var restaurant = GetRestaurant(Id);
            if (restaurant != null)
            {
                Data.restaurant.Remove(restaurant);
                return true;
            }

            return false;
        }

        public List<Restaurant> GetListRestaurant()
        {
            return Data.restaurant.ToList();
        }

        public Restaurant GetRestaurant(Guid Id)
        {
            var restaurant = Data.restaurant.Where(x => x.Id == Id).FirstOrDefault();
            if (restaurant == null)
                return new Restaurant();
            return restaurant;
        }

        public bool UpdateRestaurant(Restaurant restaurant)
        {
            var res=GetRestaurant(restaurant.Id);
            if(res == null)
                return false;

            res.Name = restaurant.Name;
            res.Description= restaurant.Description;
            Data.restaurant.Add(res);

            return true;
        }
    }
}
