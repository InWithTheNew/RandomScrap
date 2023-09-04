using System;
using System.Collections.Generic;
using System.Linq;
namespace RandomGarbLuke

{
	public class Classroom : IGetClassHeight
	{
        private readonly IGetHeight _personInjector;

        List<int> AllMembersHeights = new();

        public Classroom(IGetHeight person)
        {
            _personInjector = person;
            
            AllMembersHeights.Add(_personInjector.GetHeightinCM());
        }

        public Classroom(Person person)
		{
			int x = person.GetHeightinCM();
            AllMembersHeights.Add(_personInjector.GetHeightinCM());
        }

        public Classroom(Boy person)
        {
            int x = person.GetHeightinCM();
            AllMembersHeights.Add(_personInjector.GetHeightinCM());
        }

        public Classroom(Girl person)
        {
            int x = person.GetHeightinCM();
            AllMembersHeights.Add(_personInjector.GetHeightinCM());
        }

        public List<int> GetClassHeight()
		{
			return AllMembersHeights;
		}

        public int GetClassHeightAverage()
        {
            var x = (int)AllMembersHeights.Average();
            return x;
        }
	}
}

