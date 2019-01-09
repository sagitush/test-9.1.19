using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheela_2
{
	class Program
	{
		static void Main(string[] args)
		{
			//it was changed because its the same array that I was sending to the function.
			int[] a = { 5, 4, -5 };
			update(a);
			Console.WriteLine(a[0]);

		}

		private static void update(int [] a)
		{
			a[0] = 1;
		}
	}
}
