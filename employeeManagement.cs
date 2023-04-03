//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace TestingConsoleApp
//{
//	public class Employee
//	{
//		public string FirstName { get; set; }
//		public string LastName { get; set; }
//		public string Company { get; set; }
//		public int Age { get; set; }
//		public Employee()
//		{
//			//this.Notes = new Dictionary<string, List<string>>();
//		}
//		public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
//		{
//			Dictionary<string, int> result = new Dictionary<string, int>();
//			var companyEmplyees = employees.Select(x => x.Company).Distinct().ToList();
//			foreach (var company in companyEmplyees)
//			{
//				int average = (int)(from emp in employees where emp.Company == company select emp.Age).Average();
//				result.Add(company, average);
//			}
//			return result;
//		}
//		public static Dictionary<string, int> CountOfEmplyeeForEachCompany(List<Employee> employees)
//		{
//			Dictionary<string, int> result = new Dictionary<string, int>();
//			var companyEmplyees = employees.Select(x => x.Company).Distinct().ToList();
//			foreach (var company in companyEmplyees)
//			{
//				int average = (int)(from emp in employees where emp.Company == company select emp.Age).Count();
//				result.Add(company, average);
//			}
//			return result;
//		}
//		public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
//		{
//			Dictionary<string, Employee> result = new Dictionary<string, Employee>();
//			var companyEmplyees = employees.Select(x => x.Company).Distinct().OrderBy(x => x).ToList();
//			foreach (var company in companyEmplyees)
//			{
//				//Employee average = (from emp in employees where emp.Company == company select emp).Max();
//				//result.Add(company, average);

//				var emy = employees.OrderByDescending(x => x.Age).FirstOrDefault();
//				result.Add(company, emy);
//			}
//			return result;
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
//				return this.Notes[state];
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
