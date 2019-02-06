using Datenerfassung.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.Declarations
{
	public interface IStorage
	{
		void WritePersons(string people);
		string LoadPersons();
	}
}
