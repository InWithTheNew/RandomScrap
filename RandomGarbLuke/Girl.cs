using System;
namespace RandomGarbLuke
{
	public class Girl : Person
	{
		private string _gender = "Girl";

        internal override int _height { get; }

        public Girl()
		{
		}
        public Girl(int Height)
        {
            _height = Height;
        }
    }
}

