using Formation.Abstraction;
using Formation.Models;

namespace Formation.Repository
{
    public class restaurantRepository : IRestaurant
    {
        public bool AddRestaurant(Restaurant _restaurant)
        {
            try
            {
                Data.restaurant.Add(_restaurant); 
                return true;
            }catch (Exception)
            {
                return false;
            }
        }

        public List<Restaurant> GetListRestaurant()
        {
            return Data.restaurant.ToList();
        }

        public Restaurant GetRestaurant(int Id)
        {
            var restaurant= Data.restaurant.Where(x => x.Id == Id).FirstOrDefault();
            if(restaurant==null)
                return new Restaurant();
            return restaurant;
        }
    }
}
