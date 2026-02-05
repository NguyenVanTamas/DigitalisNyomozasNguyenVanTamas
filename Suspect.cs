using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozasNguyenVanTamas
{
	internal class Suspect
	{
		private Person person;
		private int suspicity;
		private string status;

		public Suspect(Person person, int suspicity, string status)
		{
			this.person = person;
			this.suspicity = suspicity;
			this.status = status;
		}

		public int Suspicity { get => suspicity; set => suspicity = value; }
		public string Status { get => status; set => status = value; }
		internal Person Person { get => person; set => person = value; }
	}
}
