namespace Datenerfassung.DataModel
{
	public abstract class DataBase
	{
		public int Id { get; set; } = 0;
		public bool IsNewRecord
		{
			get { return Id == 0; }
		}
	}
}
