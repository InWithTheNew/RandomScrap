namespace Entities
{
	public class Girl : Person
	{
        public Girl(
            string firstname,
            string surname,
            DateTime dob,
            int height,
            int weight)
            : base(firstname, surname, dob, "female", height, weight)
        {
        }
    }
}

