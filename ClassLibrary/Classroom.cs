using System;
using System.Collections.Generic;
using System.Linq;


namespace ClassLibrary
{
	public class Classroom 
	{

        List<int> AllMembersHeights = new();

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

