using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearMeasureDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var stringList = FizzBuzz.ListBuilder.BuildList(100000);

			foreach (var value in stringList)
				Console.WriteLine(value);

			Console.ReadKey();
		}
	}
}
