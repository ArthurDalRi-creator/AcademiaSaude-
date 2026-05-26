using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademiaSaude;

namespace AcademiaSaude
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void FrmLogin_Load(object sender, EventArgs e)
		{
			
		}

		private void txtBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnVolt2_Click(object sender, EventArgs e)
		{

			Form1 menu = new Form1();
			menu.Show();
			this.Close();
		}

		private void btnLog_Click(object sender, EventArgs e)
		{
			Sessao.Logado = true;

			MessageBox.Show("Login Realizado");
		}
	}
}

