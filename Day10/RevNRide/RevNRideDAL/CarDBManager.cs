namespace RevNRideDAL;
using System;
using System.Text.Json;
using RevNRideBOL;

public class CarDBManager
{
    public static List<Car> ReadCarsFromFile() {

        string carString = File.ReadAllText
        (@"/media/runner/DATA/IACSD AKURDI/DOT_NET/DN_Assignments/Day10/RevNRide/MOCK_DATA.json");
        return JsonSerializer.Deserialize<List<Car>>(carString);
    }

    public static void AddCarsIntoFile(List<Car> carList, string fileName = @"/media/runner/DATA/IACSD AKURDI/DOT_NET/DN_Assignments/Day10/RevNRide/MOCK_DATA.json") {

        File.WriteAllText(fileName, JsonSerializer.Serialize(carList));
    }

    public static bool AddCarIntoFile(Car car) {
        
        List<Car> cars = ReadCarsFromFile();
        cars.Add(car);
        AddCarsIntoFile(cars);
        return true;
    }

    public static Car GetCarFromFile(string id) {

        List<Car> cars = ReadCarsFromFile();
        Car car = cars.FirstOrDefault(car => car.Id == id);

        System.Console.WriteLine(car); 
        int indexOfThatCar = cars.IndexOf(car);
        if (car == null)
        {
            return null;
        }
        return car;
    }

    
}
