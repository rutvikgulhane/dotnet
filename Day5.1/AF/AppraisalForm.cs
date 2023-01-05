namespace Apprform;
using System.ComponentModel.DataAnnotations;


[Serializable]
public class AppraisalForm {
    [Required]
    public int Id{get;set;}
    public string Name{get;set;}

    public AppraisalForm(int id, string name) {
        this.Id = id;
        this.Name = name;
    }

    public AppraisalForm() {
        this.Id = 1000;
        this.Name = "Def";  
    }

    public override string ToString()
    {
        return Id + " " + Name;
    }



}