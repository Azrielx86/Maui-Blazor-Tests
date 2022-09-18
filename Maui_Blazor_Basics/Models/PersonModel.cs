using SQLite;

namespace Maui_Blazor_Basics.Models
{
	[Table("students")]
	public class PersonModel
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[MaxLength(250), Unique]
		public string Name { get; set; }
	}
}
