namespace GameItems;

public static class Fight{
    public static void Punch(this Player player, Player p1, Player p2) {
        p2.Health-=5;
    }
    public static void Kick(this Player player, Player p1, Player p2) {
        p2.Health-=10;
    }
    public static void Smash(this Player player, Player p1, Player p2) {
        p2.Health-=20;
    }

    

}
