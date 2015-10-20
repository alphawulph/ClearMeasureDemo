using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
	[TestFixture]
	public class ListBuilderTests
	{
		public Dictionary<int, string> StringsList => new Dictionary<int, string>(2) { { 5, "Buzz" }, { 3, "Fizz" }, {6, "Never"} };

		[Test]
		public void BuildList_15()
		{
			var result = ListBuilder.BuildList(15, StringsList).ToArray();

			Assert.AreEqual("Buzz", result[14]);
			Assert.AreEqual("Buzz", result[4]);
			Assert.AreEqual("Fizz", result[2]);
			Assert.AreEqual("Fizz", result[5]);
			Assert.AreEqual("7", result[6]);
		}

		[Test]
		public void BuildList_Priority()
		{
			var result = ListBuilder.BuildList(15, StringsList).ToArray();

			Assert.IsFalse(result.Any(x => x == "Never"));
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void BuildList_InvalidUbound()
		{
			var subject = ListBuilder.BuildList(0, StringsList);

			var result = subject.FirstOrDefault();
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void BuildList_InvalidStringlist()
		{
			var subject = ListBuilder.BuildList(15, null);

			var result = subject.FirstOrDefault();
		}

	}
}
