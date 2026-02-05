using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozasNguyenVanTamas
{
	internal class Evidence
	{
		private int id;
		private string type;
		private string description;
		private string credibility;

		public Evidence(int id, string type, string description, string credibility)
		{
			this.id = id;
			this.type = type;
			this.description = description;
			this.credibility = credibility;
		}

		public int Id { get => id; set => id = value; }
		public string Type { get => type; set => type = value; }
		public string Description { get => description; set => description = value; }
		public string Credibility { get => credibility; set => credibility = value; }
	}
}
