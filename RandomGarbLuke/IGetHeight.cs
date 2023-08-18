using System;
namespace RandomGarbLuke
{
	public interface IGetHeight
	{
		/// <summary>
		///	This interface allows you to pass in an animal, and it will retrieve it's height (int)
		/// 
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		int GetHeightinCM();

		public void ReturnHeightAsInt()
		{
			Console.WriteLine("The height is");
		}
	}
}

