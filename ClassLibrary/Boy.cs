using System;
namespace RandomGarbLuke
{

	public class Boy : Person
	{

		private string _gender = "Boy";
		private string? _firstName;
		private string? _lastName;

        internal override int _height { get; }

        public Boy()
		{
		}

        public Boy(int height)
        {
			_height = height;
        }

        public Boy(string FirstName, string LastName)
		{
			_firstName = FirstName;
			_lastName = LastName;
		}


	}
}

