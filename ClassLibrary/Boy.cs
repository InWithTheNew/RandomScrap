namespace Entities
{
	public class Boy : Person
	{	
		public Boy(
			string firstname,
			string surname,
			DateTime dob,
			int height,
			int weight)
			: base(firstname, surname, dob, "male", height, weight)
		{
		}
	}
}

