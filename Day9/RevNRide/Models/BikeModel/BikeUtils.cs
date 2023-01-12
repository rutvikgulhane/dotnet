using System.Text.Json;

namespace RevNRide.Models;
public class BikeUtils {

    public static List<Bike> GetSomeBikes() {

        List<Bike> bikeList = new List<Bike>();
        bikeList.Add(new Bike(){Brand="Honda", Name="CBR", Model="CBR250"});
        bikeList.Add(new Bike(){Brand="Suzuki", Name="Gixxer", Model="Gixxer250"});
        bikeList.Add(new Bike(){Brand="KTM", Name="Duke", Model="Duke390"});
        bikeList.Add(new Bike(){Brand="BMW", Name="GS", Model="GS310"});
        return bikeList;
    }

    public static List<Bike> ReadBikesFromFile() {
        // WriteBikesIntoFile(GetSomeBikes());
        if (true)
        try
        {
        return JsonSerializer.Deserialize<List<Bike>>(File.ReadAllText("data.json"));
            
        }
        catch (Exception e)
        {
            
            System.Console.WriteLine(e.StackTrace);
        }
        return null;
    }
    
    public static void WriteBikesIntoFile(List<Bike> bikeList, string fileName="data.json") {
        
        File.WriteAllText(fileName, JsonSerializer.Serialize<List<Bike>>(bikeList));
    }

    


}