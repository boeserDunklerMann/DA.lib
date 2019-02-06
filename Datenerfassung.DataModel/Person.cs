using System;
using System.Collections.Generic;

namespace Datenerfassung.DataModel
{
	public class Person : DataBase
    {
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public List<AddressEntry> Addresses { get; set; } = new List<AddressEntry>();
	}
}
