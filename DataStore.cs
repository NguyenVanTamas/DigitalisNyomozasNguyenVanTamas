using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozasNguyenVanTamas
{
	internal class DataStore
	{
		private List<User> users;
		private List<Case> cases;
		private List<Person> persons;
		private List<Evidence> evidences;

		public DataStore(List<User> users, List<Case> cases, List<Person> persons, List<Evidence> evidences)
		{
			this.users = users;
			this.cases = cases;
			this.persons = persons;
			this.evidences = evidences;
		}

		internal List<User> Users { get => users; set => users = value; }
		internal List<Case> Cases { get => cases; set => cases = value; }
		internal List<Person> Persons { get => persons; set => persons = value; }
		internal List<Evidence> Evidences { get => evidences; set => evidences = value; }
	}
}
