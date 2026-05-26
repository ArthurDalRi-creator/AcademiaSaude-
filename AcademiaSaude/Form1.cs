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
	public partial class Form1 : Form
	{
		public Form1()		{
			InitializeComponent();
		}

		private void toolStripComboBox1_Click(object sender, EventArgs e)
		{

					}

		private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmLogin tela = new FrmLogin();
			tela.Show();
			this.Hide();
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			FrmCadastro tela = new FrmCadastro();
			tela.Show();
			this.Hide();
		}

		private void cADASTROToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmCadastro tela = new FrmCadastro();
			tela.Show();
			this.Hide();
		}

		private void mENSALIDADEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmMensalidade tela = new FrmMensalidade();
			tela .Show();
			this.Hide();
		}

		private void pERFILToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmPerfil tela = new FrmPerfil();
			tela.Show();
			this.Hide();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void sOBREToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmSobre tela = new FrmSobre();
			tela .Show();
			this.Hide();
		}
	}
}
