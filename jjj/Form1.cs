using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sheela_1_chelek_3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Random r = new Random();
			label1.Text = r.Next(100).ToString();
			
			label2.Text = r.Next(100).ToString();
			
			label3.Text = r.Next(100).ToString();
			
			label4.Text = r.Next(100).ToString();
			
			label5.Text = r.Next(100).ToString();
			

		}

		private void button1_Click(object sender, EventArgs e)
		{
			label1.ForeColor = label1.BackColor;
			label2.ForeColor = label2.BackColor;
			label3.ForeColor = label3.BackColor;
			label4.ForeColor = label4.BackColor;
			label5.ForeColor = label5.BackColor;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			int sum = 0;
			if(label1.Text == textBox1.Text)
			{
				sum = sum + 1;
			}
			if (label2.Text == textBox2.Text)
			{
				sum = sum + 1;
			}
			if (label3.Text == textBox3.Text)
			{
				sum = sum + 1;
			}
			if (label4.Text == textBox4.Text)
			{
				sum = sum + 1;
			}
			if (label5.Text == textBox5.Text)
			{
				sum = sum + 1;
			}
			if (sum==5)
			{
				MessageBox.Show("you won!!!", "won", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				MessageBox.Show("you are wrong!", "too bad", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			listBox1.Items.Add(sum);
		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{

			label1.ForeColor = Color.Black;
			label2.ForeColor = Color.Black;
			label3.ForeColor = Color.Black;
			label4.ForeColor = Color.Black;
			label5.ForeColor = Color.Black;
			textBox1.Text =" ";
			textBox2.Text = " ";
			textBox3.Text = " ";
			textBox4.Text = " ";
			textBox5.Text = " ";
			Random r = new Random();
			label1.Text = $"{r.Next(100)}";

			label2.Text = r.Next(100).ToString();

			label3.Text = r.Next(100).ToString();

			label4.Text = r.Next(100).ToString();

			label5.Text = r.Next(100).ToString();


		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Are you sure you want to exit?","exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}//2
//winform have writeline debug to check things because we dont have the wall to see like the console

//4
//1,3

