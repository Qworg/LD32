using System.Collections;
using System.Collections.Generic;

namespace Model
{
	public class House
	{
		private List<Student> _students;
		private string _name;

		public House( string name)
		{
			_students = new List<Student>();
			_name = name;
		}

		public void EnrollStudent( Student student )
		{
			_students.Add(student);
		}

		public void ExpellStudent( Student student )
		{
			_students.Remove(student);
		}

		public int TotalMembers()
		{
			return _students.Count;
		}
	}
}