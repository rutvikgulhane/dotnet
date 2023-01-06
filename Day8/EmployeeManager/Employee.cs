namespace HRManager;
public class Employee{

    public int Id{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string Email{get;set;}
    public string ContactNumber{get;set;}

    public Employee(){}
    public Employee(string fname, string email) {
        
        this.FirstName = fname;
        this.Email = email;
       
    }

    public override string ToString()
    {
        return  "ID-> " +Id +"Name->" + FirstName+ " " + LastName + " \nEmail->" + Email;
    }

}