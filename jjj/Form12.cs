using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shseela_6_chelek_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int[] a;
			a = new int[10];
			IntializeArray(a);
			printArray(a);
		
		}

		private void printArray(int [] a)
		{
			for (int i = 0; i < a.Length; i++)
			{
				Console.WriteLine(a[i]);
			}
		}

		private void IntializeArray(int [] a)
		{
			Random r = new Random();
			a = new int[10];
			for (int i = 0; i < 10; i++)
			{
				a[i] = r.Next(101);
			}
		}
	}
}
