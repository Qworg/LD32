using System.Collections;
using NUnit.Framework;

[TestFixture]
public class HouseModelTests {

	[Test]
	public void TestEnrollStudents()
	{
		var testObj = new HouseModel( "Blueindore");
		testObj.EnrollStudent( new StudentModel( "Harried Podder"));
		Assert.That( testObj.TotalMembers(), Is.EqualTo(1));
	}
}
