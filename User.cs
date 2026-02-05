using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozasNguyenVanTamas
{
	internal class User
	{
		private string name;
		private int id;
		private string role;

		public User(string name, int id, string role)
		{
			this.name = name;
			this.id = id;
			this.role = role;
		}

		public string Name { get => name; set => name = value; }
		public int Id { get => id; set => id = value; }
		public string Role { get => role; set => role = value; }
	}
}
