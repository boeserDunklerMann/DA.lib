using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.Implementation
{
	public class FileStorage : Declarations.IStorage
	{
		private const string filename = "C:\\temp\\storage.json";

		public string LoadPersons()
		{
			return System.IO.File.ReadAllText(filename);
		}

		public void WritePersons(string people)
		{
			System.IO.File.WriteAllText(filename, people);
		}
	}
}
