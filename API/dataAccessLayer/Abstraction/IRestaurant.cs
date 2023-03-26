using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLayer.Abstraction
{
    public interface IRestaurant
    {
        bool AddRestaurant(Restaurant _restaurant);
        List<Restaurant> GetListRestaurant();
        Restaurant GetRestaurant(Guid Id);
        bool UpdateRestaurant(Restaurant restaurant);
        bool DeleteRestaurant(Guid Id);
    }
}
