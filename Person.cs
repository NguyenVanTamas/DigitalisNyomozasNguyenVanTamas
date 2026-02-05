using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozasNguyenVanTamas
{
	internal class Person
	{
		private string name;
		private int age;
		private string addendum;

		public Person(string name, int age, string addendum)
		{
			this.name = name;
			this.age = age;
			this.addendum = addendum;
		}

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }
		public string Addendum { get => addendum; set => addendum = value; }
	}
}
