namespace RestaurantAPPwithMVC.Models;

public class Data
{
    public static List<Restaurant> restaurant = new List<Restaurant>() {
         new Restaurant{Id= Guid.NewGuid(),Name="AB",Description="AB 1"},
         new Restaurant{Id= Guid.NewGuid(),Name="AC",Description="AC 2"},
         new Restaurant{Id= Guid.NewGuid(),Name="AD",Description="AD 3"},
         new Restaurant{Id= Guid.NewGuid(),Name="AE",Description="AE 4"},
    };
}
