using System;
namespace RandomGarbLuke
{
	public class Classroom : IGetClassHeight
	{
        private readonly IGetHeight _personInjector;

        public int[] _studentsHeight = { };

        public int _height;

        public Classroom(IGetHeight person)
        {
            _personInjector = person;

            _height = _personInjector.GetHeightinCM()
            
            _studentsHeight.Append(_personInjector.GetHeightinCM());
        }

        public Classroom(Person person)
		{
			int x = person.GetHeightinCM();
			_studentsHeight?.Append(person.GetHeightinCM());
		}

        public Classroom(Boy person)
        {
            int x = person.GetHeightinCM();
            _studentsHeight?.Append(person.GetHeightinCM());
        }

        public Classroom(Girl person)
        {
            int x = person.GetHeightinCM();
            _studentsHeight?.Append(person.GetHeightinCM());
        }

        public int[] GetClassHeight()
		{
			return _studentsHeight;
		}
	}
}

