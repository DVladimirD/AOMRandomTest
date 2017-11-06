using System;
namespace AOMTest
{
	public class MajorGod
	{
		public MajorGod(string name)
		{
			godName = name;
		}
		public string godName;
		//this minor gods what you see now it games constantly you take major god when you select it when creating a map 
		public MinorGod[] firstMinorGods = new MinorGod[2];
		public MinorGod[] secondMinorGods = new MinorGod[2];
		public MinorGod[] thirdMinorGods = new MinorGod[2];
	}
}

