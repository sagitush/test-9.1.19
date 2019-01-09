using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1._19
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("enter");
			int x = Convert.ToInt32(Console.ReadLine());
			power2(ref x);
			Console.WriteLine($"power 2 of your number is {x}");
		}

		private static void power2( ref int i)
		{
			i = i * 2;
		}
	}
}
