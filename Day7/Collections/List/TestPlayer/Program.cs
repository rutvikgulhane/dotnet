using GameItems;
using System.Collections.Generic;

Player mod = new Player(999, "Admin", 100, 100);
List<Player> playerList = mod.GetAllPlayers();


// playerList.ForEach(player => System.Console.WriteLine(player));
System.Console.WriteLine();


// Find and Remove from List
/* Player? temp = new Player(5);
playerList.Remove(temp);
playerList.ForEach(player=>System.Console.WriteLine(player));
System.Console.WriteLine(); */

// Find and Update
/* temp = new Player(1);
temp = playerList.Find(player => player.Equals(temp));
temp.IsAlive = false; */

// Sort by Name
// playerList.Sort((player1, player2) => player1.Name.CompareTo(player2.Name));


// Passing a delegate into ForEach()
// playerList.ForEach(delegate (Player player) { System.Console.WriteLine(player); });

// Language Integrated Query LINQ

// 1. Annonymous Type


// 2. Extension Method
mod.Punch(playerList[0], playerList[1]);

mod.Kick(playerList[0], playerList[2]);

mod.Smash(playerList[0], playerList[3]);

playerList.ForEach(delegate (Player player) { System.Console.WriteLine(player); });
