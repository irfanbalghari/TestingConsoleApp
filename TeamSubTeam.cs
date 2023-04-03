//using System;

//namespace TestingConsoleApp
//{
//	public class Team
//	{
//		public string teamName { get; set; }
//		public int noOfPlayers { get; set; }
//		public Team(string teamName = null, int noOfPlayers = 0)
//		{
//			this.teamName = teamName;
//			this.noOfPlayers = noOfPlayers;
//		}

//		public void AddPlayer(int count)
//		{
//			this.noOfPlayers += count;
//		}
//		public bool RemovePlayer(int count)
//		{
//			if (this.noOfPlayers - count > 0)
//			{
//				this.noOfPlayers -= count;
//				return true;
//			}
//			else
//			{
//				return false;
//			}
//		}
//	}
//	public class SubTeam : Team
//	{
//		public SubTeam(string teamName, int noOfPlayers) : base(teamName, noOfPlayers)
//		{

//		}
//		public void ChangeTeamName(string name)
//		{
//			teamName = name;
//		}
//	}
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			if (!typeof(SubTeam).IsSubclassOf(typeof(Team)))
//			{
//				throw new Exception("Subteam class should inherit from team class");
//			}

//			String str = Console.ReadLine();
//			String[] strArr = str.Split();
//			string initialName = strArr[0];
//			int count = Convert.ToInt32(strArr[1]);
//			SubTeam teamObj = new SubTeam(initialName, count);
//			Console.WriteLine("Team " + teamObj.teamName + " created");

//			str = Console.ReadLine();
//			count = Convert.ToInt32(str);
//			Console.WriteLine("Current no of players in the team " + teamObj.teamName + "is" + teamObj.noOfPlayers);
//			teamObj.AddPlayer(count);
//			Console.WriteLine("New of players in the team " + teamObj.teamName + " is " + teamObj.noOfPlayers);

//			str = Console.ReadLine();
//			count = Convert.ToInt32(str);
//			Console.WriteLine("Current no of players in the team " + teamObj.teamName + " is " + teamObj.noOfPlayers);


//			var res = teamObj.RemovePlayer(count);
//			if (res)
//			{
//				Console.WriteLine("New of players in the team " + teamObj.teamName + " is " + teamObj.noOfPlayers);

//			}
//			else
//			{
//				Console.WriteLine("Number of players in the team " + teamObj.teamName + " remains same");

//			}

//			str = Console.ReadLine();
//			teamObj.ChangeTeamName(str);
//			Console.WriteLine("Team name of the team " + initialName + " change to " + teamObj.teamName);


//			Console.Read();

//		}

//	}

//}
