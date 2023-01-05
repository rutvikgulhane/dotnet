using acchldr;
using IncomeTax;
using bankmgr;

AccountHolder ah1 = new AccountHolder(1, "Rutvik", 5000);
BankManager bm1 = new BankManager();
ITDepartment id1 = new ITDepartment();



MonitorBalance sendEmail = new MonitorBalance(bm1.SendEmail);
MonitorBalance sendSMS = new MonitorBalance(bm1.SendSMS);
MonitorBalance closeAccunt = new MonitorBalance(bm1.CloseAccount);

ChargeIT deductIT = new ChargeIT(id1.DeductIncomeTax);


ah1.underBalance += sendEmail;
ah1.underBalance += sendSMS;


ah1.overBalance += deductIT;
ah1.withdrawLimitExceed += closeAccunt;

System.Console.WriteLine("Enter deposit amount");
ah1.DepositAmount(Convert.ToDouble(Console.ReadLine()));

System.Console.WriteLine("ENter Amount to Withdraw");
ah1.WithdrawAmount(Convert.ToDouble(Console.ReadLine()));


