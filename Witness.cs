using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozasNguyenVanTamas
{
	internal class Witness
	{
		private Person person;
		private string testimony;
		private DateTime testimony_date;

		public Witness(Person person, string testimony, DateTime testimony_date)
		{
			this.person = person;
			this.testimony = testimony;
			this.testimony_date = testimony_date;
		}

		public string Testimony { get => testimony; set => testimony = value; }
		public DateTime Testimony_date { get => testimony_date; set => testimony_date = value; }
		internal Person Person { get => person; set => person = value; }
	}
}
