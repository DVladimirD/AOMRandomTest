using System;
using System.Security.Cryptography;

namespace AOMTest
{
	public class TestMapStarter
	{
		public TestMapStarter()
		{
		}

		public void StartMap(Player[] players) 
		{
			Array.ForEach(players, player => SetRandomMinorGods(player));
		}

		void SetRandomMinorGods(Player player) 
		{

			Nation takedNation = Array.Find(Nations.nations, nation => nation.nationName == player.nation.nationName);

			MinorGod lastMinorGod = null;

			for (int i = 0; i <= 1; i++)
			{
				lastMinorGod = GetUniqGod(takedNation.FirstMinorGods, lastMinorGod);
				player.majorGod.firstMinorGods[i] = lastMinorGod;

				Console.WriteLine("First god = " + lastMinorGod.godName);
			}

			for (int i = 0; i <= 1; i++)
			{
				lastMinorGod = GetUniqGod(takedNation.SecondMinorGods, lastMinorGod);
				player.majorGod.secondMinorGods[i] = lastMinorGod;

				Console.WriteLine("Second god = " + lastMinorGod.godName);
			}

			for (int i = 0; i <= 1; i++)
			{
				lastMinorGod = GetUniqGod(takedNation.ThirdMinorGods, lastMinorGod);
				player.majorGod.secondMinorGods[i] = lastMinorGod;

				Console.WriteLine("Third god = " + lastMinorGod.godName);
			}
		}

		MinorGod GetUniqGod(MinorGod[] minorGods, MinorGod lastGod) 
		{
			MinorGod newGod = minorGods[new Random((int)DateTime.Now.Ticks).Next(0, minorGods.Length - 1)];

			if (newGod == lastGod)
			{
				newGod = GetUniqGod(minorGods, lastGod);
			}

			return newGod;
		}
	}
}

