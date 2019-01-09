using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheela_3_chelek1
{
	class Program
	{
		static void Main(string[] args)
		{
			//it didnt change because I created a new array in the function. (meatchel)
			int[] a = { 5, 4, -5 };
			Update(a);
			Console.WriteLine(a[0]);
		}

		private static void Update(int[] a)
		{
			a = new int[3];
			a[0] = 1;
		}
	}
}
