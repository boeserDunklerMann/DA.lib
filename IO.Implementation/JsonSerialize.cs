using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datenerfassung.DataModel;
using IO.Declarations;
using Newtonsoft.Json;

namespace IO.Implementation
{
	public class JsonSerialize : Declarations.ISerializer
	{
		public object SerializePersons(List<Person> people)
			=> JsonConvert.SerializeObject(people);

		public List<Person> DeserializePersons(object data)
			=> JsonConvert.DeserializeObject<List<Person>>(data.ToString());
	}
}
