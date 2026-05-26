using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaSaude
{
	public partial class FrmSobre : Form
	{
		public FrmSobre()
		{
			InitializeComponent();
		}

		private void btnVolt5_Click(object sender, EventArgs e)
		{
			Form1 menu = new Form1();
			menu.Show();
			this.Close();
		}
	}
}
