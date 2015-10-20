using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
	public class ListBuilder
	{
		public static IEnumerable<string> BuildList(int uBound, Dictionary<int, string> stringsList)
		{
			if(uBound < 1)
				throw new ArgumentException("uBound must be greater than 1");

			if (stringsList == null)
				throw new ArgumentException("Strings List cannot be null");

			for (int i = 1; i <= uBound; i++)
			{
				bool matched = false;

				foreach (var key in stringsList.Keys)
					if (i%key == 0)
					{
						yield return stringsList[key];
						matched = true;
						break;
					}

				if(!matched)
					yield return i.ToString();
			}
		}
	}
}
