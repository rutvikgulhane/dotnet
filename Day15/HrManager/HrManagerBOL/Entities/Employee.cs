namespace HrManagerBOL.Entities;
public class Employee
{
  public int Id{get;set;}
  public string First_name{get;set;}
  public string Last_name{get;set;}
  public string Email{get;set;}
  public string Gender{get;set;}
  public string Password{get;set;}
  public int DeptId{get;set;}
  public int JobId{get;set;}

  public override string ToString()
  {
    return Id + " " +First_name + " " +Last_name +
      " " +Email + " " +Gender + " " +Password +
      " " +DeptId + " " + JobId;
  }

}