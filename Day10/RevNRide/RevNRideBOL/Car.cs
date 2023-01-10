namespace RevNRideBOL;
using System.ComponentModel.DataAnnotations;
[Serializable]
public class Car
{
    public string? Id { get; set; }
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int? ModelYear { get; set; }

    public Car() { }

    public Car(string id)
    {
        Id = id;
    }

    // override object.Equals
    public override bool Equals(object obj)
    {
        //
        // See the full list of guidelines at
        //   http://go.microsoft.com/fwlink/?LinkID=85237
        // and also the guidance for operator== at
        //   http://go.microsoft.com/fwlink/?LinkId=85238
        //

        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        // TODO: write your implementation of Equals() here

        return this.Id.Equals((obj as Car).Id);
    }

    // override object.GetHashCode
    public override int GetHashCode()
    {
        // TODO: write your implementation of GetHashCode() here
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return "Id->" + Id + " Make->" + Make + " Model->" + Model + " Model Year->" + ModelYear;
    }
}
