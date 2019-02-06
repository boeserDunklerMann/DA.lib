using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenerfassung.DataModel
{
	public class AddressEntry : DataBase
	{
		public string Street { get; set; }
		public string HouseNumber { get; set; }
		public string ZipCode { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public AdressEntryType AdressType { get; set; }
	}
}
