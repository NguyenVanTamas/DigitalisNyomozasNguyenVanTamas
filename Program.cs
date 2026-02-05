using System.Security.Policy;

namespace DigitalisNyomozasNguyenVanTamas
{
	internal class Program
	{

		static void EvidenceManager()
		{
			string choice = string.Empty;
			bool valid = false;
			Console.Write("Select a course of action (Create/Delete/Enumerate): ");
			while (!valid)
			{
				choice = Console.ReadLine();
				if (choice != "Create" || choice != "Delete" || choice != "Enumerate")
				{
					Console.WriteLine("Incorrect course of action");
				}
				else
				{
					valid = true;
				}
			}
			switch (choice)
			{
				case "Create":
					Console.Write("Id: ");
					int id = int.Parse(Console.ReadLine());
					Console.Write("Type: ");
					string type = Console.ReadLine();
					Console.Write("Description: ");
					string description = Console.ReadLine();
					Console.Write("Credibility: ");
					string credibility = Console.ReadLine();
					Evidence newEvidence = new Evidence(id, type, description, credibility);
					break;

				case "Delete":
					break;
			}
		}
		static void CaseManager()
		{

		}
		static void Main(string[] args)
		{

		}
	}
}
