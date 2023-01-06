namespace GameItems;

public class Player
{
    public int PlayerID{get;set;}
    public string Name{get;set;}
    public int Health{get;set;}
    public int Lives{get;set;}
    public bool IsAlive{get;set;}

    public Player(int id){
        this.PlayerID = id;
    }

    public Player(int id, string name, int health, int lives) {
        this.PlayerID = id;
        this.Name = name;
        this.Health = health;
        this.Lives = lives;
        this.IsAlive = true;
    }

    public override string ToString()
    {
        return "ID->" + PlayerID + " Name->" + Name + " Health->" + Health + " IsAlive->" + IsAlive;
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
        
        return this.PlayerID==(obj  as Player).PlayerID;
    }
    
    // override object.GetHashCode
    public override int GetHashCode()
    {
        // TODO: write your implementation of GetHashCode() here
        return base.GetHashCode();
    }    


}