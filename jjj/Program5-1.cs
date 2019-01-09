using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheela_5_chelek1
{
	class Program
	{
		static void Main(string[] args)
		{
			//params is to create arry from number of parametrs that you doesnt know how many paramaters....
			int a = 2;
			int b = 3;
			int c = 4;
			Create(a,b,c);
			

		}

		private static void Create(params int[] arrayofnumbers)
		{
			for (int i = 0; i < arrayofnumbers.Length; i++)
			{
				Console.WriteLine(arrayofnumbers[i]);
			}
		}
	}
}
