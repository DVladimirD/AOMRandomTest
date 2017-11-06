using System;
namespace AOMTest
{
	public class Nation
	{
		public Nation(string name)
		{
			nationName = name;
		}
		public string nationName;

		public MajorGod[] MajorGods = {//array of all available major gods for nation
			new MajorGod("Zeus"),
			new MajorGod("Nades"),
			new MajorGod("Poseidon"),
			new MajorGod("Ra"),
			new MajorGod("Isis"),
			new MajorGod("Set"),
			new MajorGod("Thor"),
			new MajorGod("Odin"),
			new MajorGod("Loki"),
			new MajorGod("Kronos"),
			new MajorGod("Oranos"),
			new MajorGod("Gaia")
		};//for example, here are all possible gods

		//this is all minor gods for nation separated by their standard level
		public MinorGod[] FirstMinorGods = {
			new MinorGod("Athena"),
			new MinorGod("Hermes"),
			new MinorGod("Ares"),
			new MinorGod("Bast"),
			new MinorGod("Ptah"),
			new MinorGod("Anubis"),
			new MinorGod("Forseti"),
			new MinorGod("Freya"),
			new MinorGod("Heimdall"),
			new MinorGod("Promotheus"),
			new MinorGod("Leto"),
			new MinorGod("Oceanus"),
		};
		public MinorGod[] SecondMinorGods = {
			new MinorGod("Apollo"),
			new MinorGod("Dyonysus"),
			new MinorGod("Aphrodite"),
			new MinorGod("Hator"),
			new MinorGod("Sekhmet"),
			new MinorGod("Nephtys"),
			new MinorGod("Bragi"),
			new MinorGod("Skadi"),
			new MinorGod("Njord"),
			new MinorGod("Hyperion"),
			new MinorGod("Rheya"),
			new MinorGod("Theia"),
		};
		public MinorGod[] ThirdMinorGods = {
			new MinorGod("Hephaestus"),
			new MinorGod("Hera"),
			new MinorGod("Artemis"),
			new MinorGod("Horus"),
			new MinorGod("Osiris"),
			new MinorGod("Thoth"),
			new MinorGod("Baldr"),
			new MinorGod("Hel"),
			new MinorGod("Tyr"),
			new MinorGod("Helios"),
			new MinorGod("Atlas"),
			new MinorGod("Hekate"),
		};
	}
}

