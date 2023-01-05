namespace bankmgr;

public delegate void MonitorBalance(double amount);

public class BankManager
{
    
    public void CloseAccount(double amount) {
        System.Console.WriteLine("Freezing Accont");
    }

    public void SendSMS(double amount) {
        System.Console.WriteLine("Sending SMS.....");
    }

    public void SendEmail(double amount) {
        System.Console.WriteLine("Sending Email.....");
    }
}