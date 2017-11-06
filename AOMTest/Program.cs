using System;

namespace AOMTest
{
	class MainClass
	{
		static TestMapStarter mapStarter = new TestMapStarter();
		static Player[] playersArray = { new Player("MaestroTrolol0", new Nation("Eggy"), new MajorGod("Zeus")) };

		public static void Main(string[] args)
		{
			
			ShowResult();

		}
		static void ShowResult() 
		{
			mapStarter.StartMap(playersArray);

			Console.ReadLine();
			ShowResult();


		}
	}
}
