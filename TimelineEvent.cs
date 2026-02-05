using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozasNguyenVanTamas
{
	internal class TimelineEvent
	{
		private DateTime date;
		private string description;

		public TimelineEvent(DateTime date, string description)
		{
			this.date = date;
			this.description = description;
		}

		public DateTime Date { get => date; set => date = value; }
		public string Description { get => description; set => description = value; }
	}
}
