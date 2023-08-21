using System;

namespace RandomGarbLuke;

abstract public class Person : IGetHeight, IWriteHeight
{
	private int _legs = 2;
	private int _arms = 2;
	private int _heads = 1;
	private string _shoes = "Adidas";
	abstract internal int _height { get; }

	public Person()
	{
		_legs = 4;
	}

	public Person(int legs, int arms)
	{
		_legs = legs;
		_arms = arms;
		Console.WriteLine(String.Format("You have {0} legs and {1} arms!", _legs, _arms));
	}

    public string GetShoes()
    {
		return _shoes;
    }

	public int GetHeightinCM()
	{
		return _height;
	}

}

