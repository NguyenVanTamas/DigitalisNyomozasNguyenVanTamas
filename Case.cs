using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozasNguyenVanTamas
{
	internal class Case
	{
		private int id;
		private string title;
		private string description;
		private string status;
		private List<Case> persons;
		private List<Case> evidences;

		public Case(int id, string title, string description, string status, List<Case> persons, List<Case> evidences)
		{
			this.id = id;
			this.title = title;
			this.description = description;
			this.status = status;
			this.persons = persons;
			this.evidences = evidences;
		}

		public int Id { get => id; set => id = value; }
		public string Title { get => title; set => title = value; }
		public string Description { get => description; set => description = value; }
		public string Status { get => status; set => status = value; }
		internal List<Case> Persons { get => persons; set => persons = value; }
		internal List<Case> Evidences { get => evidences; set => evidences = value; }

		public void CaseStatus()
		{
			string status = this.Status;
			bool valid = false;
			Console.WriteLine($"Status of selected case: {status}.");
			Console.Write("Change status of selected case to (Open/On-going/Closed): ");
			while (!valid)
			{
				status = Console.ReadLine();
				if (status != "Open" || status != "On-going" || status != "Closed")
				{
					Console.WriteLine("Incorrect status type");
				}
				else
				{
					this.Status = status;
					Console.WriteLine($"Successfully changed status of selected case to: {status}.");
					valid = true;
				}
			}
		}
	}
}
