namespace GameItems;

public class Utilities
{
    public static List<Player> GetAllPlayers(this Player player)
    {
        List<Player> playerList = new List<Player>();

        // int id, string name, int health, int lives
        playerList.Add(new Player(1, "Anvesh", 100, 3));
        playerList.Add(new Player(2, "Rutvik", 100, 3));
        playerList.Add(new Player(3, "Piyush", 100, 3));
        playerList.Add(new Player(4, "Aman", 100, 3));
        playerList.Add(new Player(5, "Tejas", 100, 3));
        playerList.Add(new Player(6, "Nikhil", 100, 3));
        playerList.Add(new Player(7, "Akshay", 100, 3));
        playerList.Add(new Player(8, "Pritish", 100, 3));
        playerList.Add(new Player(9, "Saurabh", 100, 3));
        playerList.Add(new Player(10, "Mayur", 100, 3));

        return playerList;
    }
}