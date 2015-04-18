using System.Collections;

namespace Model
{
	public class Student 
	{
		private string _name;

		public string GetName()
		{
			return _name;
		}

		public Student( string name)
		{
			_name = name;
		}
	}
}