using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void intButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("-2147483648 до +2147483647");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("от 0 до 4 294 967 295");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("-32768 до +32767");
		}
	}
}
