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
	public partial class FrmMensalidade : Form
	{
		public FrmMensalidade()
		{
			InitializeComponent();
		}

		private void btnVolt3_Click(object sender, EventArgs e)
		{
			Form1 menu = new Form1();
			menu.Show();
			this.Close();
		}

		private void FrmMensalidade_Load(object sender, EventArgs e)
		{

		}
	}
}
