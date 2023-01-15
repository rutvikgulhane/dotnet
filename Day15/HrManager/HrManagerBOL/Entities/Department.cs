namespace HrManagerBOL.Entities;
public class Department {

  public int? Id{get;set;}
  public string? Department_name{get;set;}

  public override string ToString()
  {
    return Id + " " + Department_name;
  }
}