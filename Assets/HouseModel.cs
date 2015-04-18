using System.Collections;
using System.Collections.Generic;

public class HouseModel
{
	private List<StudentModel> _students;
	private string _name;

	public HouseModel( string name)
	{
		_students = new List<StudentModel>();
		_name = name;
	}

	public void EnrollStudent( StudentModel student )
	{
		_students.Add(student);
	}

	public void ExpellStudent( StudentModel student )
	{
		_students.Remove(student);
	}

	public int TotalMembers()
	{
		return _students.Count;
	}
}
