namespace RevNRideBLL;
using RevNRideDAL;
using RevNRideBOL;
public class CarManager
{

    public static List<Car> GetCars() {
        return CarDBManager.ReadCarsFromFile();
    }

    public static Car GetCar(string id) {
        return CarDBManager.GetCarFromFile(id);
    }
}
