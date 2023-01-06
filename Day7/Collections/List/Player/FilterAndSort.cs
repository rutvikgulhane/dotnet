namespace GameItems;

public class FilterAndSort
{
    public static IEnumerable<Player> GetAllNamesAsString(this Player player, List<Player> players)
    {
        var playerNames = from player in players select player.Name;
        return playerNames as IEnumerable<Player>;
    }

    public static IEnumerable<Player> GetAllPlayersWhoseHealthIsBelow30(this Player player, List<Player> players)
    {
        var playerNames = from player in players where player.Health < 30 select player.Name;
        return playerNames as IEnumerable<Player>;
    }
    public static IEnumerable<Player> GetAllPlayersWhoseLifeIs0(this Player player, List<Player> players)
    {
        var playerNames = from player in players where player.Lives == 0 select player.Name;
        return playerNames as IEnumerable<Player>;
    }



}