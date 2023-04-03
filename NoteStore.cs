//using System;
//using System.Collections.Generic;

//namespace TestingConsoleApp
//{
//	public class NotesStore
//	{
//		public Dictionary<string, List<string>> Notes;
//		public NotesStore()
//		{
//			this.Notes = new Dictionary<string, List<string>>();
//		}

//		public void AddNotes(string state, string name)
//		{
//			if (string.IsNullOrEmpty(name))
//			{
//				throw new Exception("Name cannot be empty");
//			}
//			else if (state == "completed" || state == "active" || state == "others")
//			{
//				if (this.Notes.ContainsKey(state))
//				{
//					this.Notes[state].Add(name);
//				}
//				else
//				{
//					this.Notes[state] = new List<string>();
//					this.Notes[state].Add(name);
//				}
//			}
//			else
//			{
//				throw new Exception("Invalid state: " + state);

//			}
//		}
//		public List<string> GetNotes(string state)
//		{
//			var notes = new List<string>();
//			if (state == "completed" || state == "active" || state == "others")
//			{
//				var dict = this.Notes.ContainsKey(state);
//				if (dict)
//				{
//					return this.Notes[state];
//				}
//				else
//				{
//					return notes;

//				}
//			}
//			else
//			{
//				throw new Exception("Invalid state: " + state);
//			}
//		}
//	}

//	public class Program
//	{
//		static void Main(string[] args)
//		{

//			var notesStoreObj = new NotesStore();
//			var n = int.Parse(Console.ReadLine());
//			for (var i = 0; i < n; i++)
//			{
//				var operationInfo = Console.ReadLine().Split(' ');
//				try
//				{
//					if (operationInfo[0] == "AddNote")
//					{
//						notesStoreObj.AddNotes(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
//					}
//					else if (operationInfo[0] == "GetNotes")
//					{
//						var result = notesStoreObj.GetNotes(operationInfo[1]);
//						if (result.Count == 0)
//						{
//							Console.WriteLine("No Notes ");
//						}
//						else
//						{
//							Console.WriteLine(string.Join(",", result));
//						}
//					}
//					else
//					{
//						Console.WriteLine("Invalid Parameter ");
//					}
//				}
//				catch (Exception e)
//				{

//					Console.WriteLine("Error: " + e.Message);
//				}
//			}
//			Console.Read();

//		}

//	}

//}
