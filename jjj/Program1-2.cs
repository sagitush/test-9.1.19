using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheela_1_chelek_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Random r = new Random();
			int[] a = new int[r.Next(1 , 9)];
			int[] b = new int[r.Next(1 , 9)];
			for (int i = 0; i < a.Length; i++)
			{
				a[i] = r.Next(1,99);

			}
			for (int i = 0; i < b.Length; i++)
			{
				b[i] = r.Next(1 , 99);

			}
			Console.WriteLine("array 1");
			PrintArray(a);
			Console.WriteLine("array 2:");
			PrintArray(b);
			Measure(a, b);
			if (Measure(a,b)==1)
			{
				Console.WriteLine("array1 is bigger");
			}
			if (Measure(a, b) == 0)
			{
				Console.WriteLine("the same");
			}
			if (Measure(a, b) == -1)
			{
				Console.WriteLine("array2 is bigger");
			}

		}

		private static void PrintArray(int[] a)
		{
			for (int i = 0; i < a.Length; i++)
			{
				Console.WriteLine(a[i]);
			}
		}

		private static int Measure(int[] a, int[] b)
		{
			int sum1 = 0;
			int sum2 = 0;

			if(a.Length<=b.Length)
			{
				for (int i = 0; i < a.Length; i++)
				{
					if(a[i]>b[i])
					{
						sum1 = sum1 + 1;
					}
					if(b[i]>a[i])
					{
						sum2 = sum2 + 1;
					}

				}
			}
			else
			{
				for (int i = 0; i < b.Length; i++)
				{
					if (a[i] > b[i])
					{
						sum1 = sum1 + 1;
					}
					if (b[i] > a[i])
					{
						sum2 = sum2 + 1;
					}

				}
			}
			if(sum1>sum2)
			{
				return 1;

			}
			else if( sum1==sum2)
			{
				return 0;
			}
			else
			{
				return -1;
			}
		}
	}
}
