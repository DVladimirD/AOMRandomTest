using System;
namespace AOMTest
{
	public class Player
	{
		public Player(string name, Nation playerNation, MajorGod playerMajorGod)
		{
			playerName = name;
			nation = playerNation;
			majorGod = playerMajorGod;
		}
		public string playerName;
		public Nation nation;//slot for taked nation
		public MajorGod majorGod;//slot for taked major god
	}
}

