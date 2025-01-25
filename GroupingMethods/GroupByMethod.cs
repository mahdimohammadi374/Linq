namespace Linq.GroupingMethods;

public class GroupByMethod
{
    public void Use_GroupBy()
    {
        List<City> cities = City.GetCities();
        //.GroupBy() is a Deferred Exetion Method
        var result = cities.GroupBy(x => x.Country);

        foreach (var country in result)
        {
            //here we have access to countries
            Console.WriteLine("Country: {0}", country.Key);

            foreach (var city in country)
            {
                //in nested loop we have access to elements of each group, in this case cities
                Console.WriteLine("City: {0}", city.Name);
                
            }

            Console.WriteLine("------------------------------------------");

        }
    }
}

public class ToLookUpMethod
{
    public void Use_ToLookUp()
    {
        List<City> cities = City.GetCities();
        //.ToLookup() is an Immediate Exetion Method
        var result = cities.ToLookup(x => x.Country);

        foreach (var country in result)
        {
            //here we have access to countries
            Console.WriteLine("Country: {0}", country.Key);

            foreach (var city in country)
            {
                //in nested loop we have access to elements of each group, in this case cities
                Console.WriteLine("City: {0}", city.Name);

            }

            Console.WriteLine("------------------------------------------");

        }
    }
}
