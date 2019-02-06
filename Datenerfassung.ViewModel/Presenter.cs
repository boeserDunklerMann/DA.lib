using Datenerfassung.DataModel;
using IO.Declarations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Datenerfassung.ViewModel
{
    public class Presenter : DA.lib.MVVM.Framework.ObservableObject
    {
		public List<Person> MeineFreunde { get; private set; } = new List<Person>();
		public Person SelectedFreund { get; set; } = new Person();
		private IStorage storage = Commons.ContractBinder.GetObject<IStorage>();
		private ISerializer serializer = Commons.ContractBinder.GetObject<ISerializer>();

		public Presenter() : base()
		{
			LoadFreunde();
			SelectedFreund = MeineFreunde.FirstOrDefault();
		}

		private void LoadFreunde()
		{
			try
			{
				string loadedData = storage.LoadPersons();
				MeineFreunde = serializer.DeserializePersons(loadedData);
				RaisePropertyChangedEvent(nameof(MeineFreunde));
			}
			catch
			{

			}
		}

		private void SaveFreunde()
		{
			int currId = 0;
			MeineFreunde.ForEach(f => f.Id = ++currId);
			object data2Save = serializer.SerializePersons(MeineFreunde);
			storage.WritePersons(data2Save.ToString());
			RaisePropertyChangedEvent(nameof(MeineFreunde));
		}

		public ICommand DoReloadData
		{
			get
			{
				return
					new DA.lib.MVVM.Framework.DelegateCommand(LoadFreunde);
			}
		}
		public ICommand DoSaveData
		{
			get { return new DA.lib.MVVM.Framework.DelegateCommand(SaveFreunde); }
		}
    }
}
