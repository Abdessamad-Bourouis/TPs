using System.Xml.Linq;

namespace Formation.Models
{
    public class Data
    {
         public static List<Restaurant> restaurant=new List<Restaurant>() { 
             new Restaurant{Id= 1,Name="AB",Description="AB 1"},
             new Restaurant{Id= 2,Name="AC",Description="AC 2"},
             new Restaurant{Id= 3,Name="AD",Description="AD 3"},
             new Restaurant{Id= 4,Name="AE",Description="AE 4"},
        };
    }
}

