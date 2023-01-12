namespace RevNRide.Models;
public class BikeOperations
{
    public static bool AddABikeInListAndFile(string brand, string name, string model, string fileName="data.json") {
        List<Bike> bikeList = BikeUtils.ReadBikesFromFile();
        bikeList.Add(new Bike() {Brand=brand, Name=name, Model=model});
        BikeUtils.WriteBikesIntoFile(bikeList);
        // File.WriteAllText("data.json", JsonSerializer.Serialize<List<Bike>>(bikeList));
        return true;
    }

    public static bool ValidateBikeDetails(string brand, string name, string model) {
        if (brand!=null && name != null && model != null)
        {
            // AddABikeInListAndFile(brand, name, model);
            return true;
        }
        return false;
    }
}