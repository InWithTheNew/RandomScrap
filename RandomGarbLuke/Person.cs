using System;

namespace RandomGarbLuke;

public class Person : IGetHeight
{
	private int _legs = 2;
	private int _arms = 2;
	private int _heads = 1;
	private string _shoes = "Adidas";
	private int _height = 180;

	public Person()
	{
		_legs = 4;
		Console.WriteLine("I am a person");
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

