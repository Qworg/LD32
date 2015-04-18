using System.Collections;
using NUnit.Framework;

namespace Model
{
	[TestFixture]
	public class HouseModelTests {

		[Test]
		public void TestEnrollStudents()
		{
			var testObj = new Model.House( "Blueindore");
			testObj.EnrollStudent( new Model.Student( "Harried Podder"));
			Assert.That( testObj.TotalMembers(), Is.EqualTo(1));
		}
	}
}
