namespace PAS_BOL;

public class Department{

  public int Id{get;set;}
  public string Department_Name{get;set;}

  public override string ToString()
  {
    return Id + " " + Department_Name;
  }
}