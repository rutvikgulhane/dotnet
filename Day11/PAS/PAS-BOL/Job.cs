namespace PAS_BOL;

public class Job{

  public int Id{get;set;}
  public string Job{get;set;}

  public override string ToString()
  {
    return Id + " " + Job; 
  }
  
}