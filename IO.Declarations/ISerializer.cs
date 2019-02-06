using Datenerfassung.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.Declarations
{
	/// <summary>
	/// In the implementation-class here must be the O-R-Mapping from DataModel to serializable data (DataSet or JSon or ...) and vice versa
	/// </summary>
    public interface ISerializer
    {
		object SerializePersons(List<Person> people);
		List<Person> DeserializePersons(object data);
    }
}
