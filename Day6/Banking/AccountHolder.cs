namespace acchldr;
using bankmgr;
using IncomeTax;

public class AccountHolder
{

    public event MonitorBalance underBalance;
    public event MonitorBalance withdrawLimitExceed;
    public event ChargeIT overBalance;
    int Id { get; set; }
    string Name { get; set; }
    double Balance { get; set; }
    bool IsActive { get; set; }


    public AccountHolder(int id, string name, double balance)
    {
        this.Id = id;
        this.Name = name;
        this.Balance = balance;
        this.IsActive = true;
    }

    public void DepositAmount(double amount)
    {
        if (IsActive)
        {
            this.Balance += amount;
            if (this.Balance > 250000)
            {
                overBalance(amount);
            }
        }
    }

    public void WithdrawAmount(double amount)
    {
        if (IsActive)
        {
            if (amount > 100000)
            {
                withdrawLimitExceed(amount);

            }
            else if (this.Balance - amount >= 0)
            {
                this.Balance -= amount;
            }
            else
            {
                IsActive = false;
                underBalance(amount);
            }
        }
    }
}