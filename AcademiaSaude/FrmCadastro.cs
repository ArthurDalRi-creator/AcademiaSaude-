using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AcademiaSaude.Usuario;

namespace AcademiaSaude
{
	public partial class FrmCadastro : Form
	{
		public FrmCadastro()
		{
			InitializeComponent();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void btnEnt_Click(object sender, EventArgs e)
		{
			FrmLogin tela = new FrmLogin();
			tela.Show();
			this.Hide();
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void btnVolt_Click(object sender, EventArgs e)
		{
			Form1 menu  = new Form1();
			menu.Show();
			this.Close();
		}

		private void btnVolt_Click_1(object sender, EventArgs e)
		{
			Form1 menu = new Form1();
			menu.Show();
			this.Close();
		}

		private void btnCad_Click(object sender, EventArgs e)
		{
			User.nome = txtNome.Text;
			User.sobrenome = txtSobrenome.Text;
			User.idade = txtIdade.Text;
			User.email = txtEmail.Text;
			User.senha = txtSenha.Text;

			MessageBox.Show("Cadastro Realizado!");
			
			FrmPerfil tela = new FrmPerfil();
			tela.Show(); this.Hide();
		}

		private void btnMostrar2_Click(object sender, EventArgs e)
		{
			txtSenha.UseSystemPasswordChar =
		!txtSenha.UseSystemPasswordChar;
		}
	}
}
