namespace Linq;

public class City
{
    public string Name { get; set; }
    public string Country { get; set; }

    public static List<City> GetCities()
    {
        return new List<City>()
        {
            new City(){Name = "Berlin", Country = "Germany"},
            new City(){Name = "Vancouver", Country = "Canada"},
            new City(){Name = "New York City", Country = "USA"},
            new City(){Name = "Munich", Country = "Germany"},
            new City(){Name = "Toronto", Country = "Canada"},
            new City(){Name = "Los Angeles", Country = "USA"},
            new City(){Name = "Hamburg", Country = "Germany"},
            new City(){Name = "Chicago", Country = "USA"},
            new City(){Name = "Montreal", Country = "Canada"},
            new City(){Name = "San Francisco", Country = "USA"},
        };
    }
}
