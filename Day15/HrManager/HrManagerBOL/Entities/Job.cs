namespace HrManagerBOL.Entities;

public class Job{

  public int Id{get;set;}
  public string Jobs {get;set;}

  public override string ToString()
  {
    return Id + " " + Jobs; 
  }
  
}