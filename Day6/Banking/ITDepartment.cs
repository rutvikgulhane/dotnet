namespace IncomeTax;

public delegate void ChargeIT(double amount);

public class ITDepartment{

    

    public void DeductIncomeTax(double amount) {
        System.Console.WriteLine("15% Tax Applied");
    }
}