using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AcademiaSaude.Usuario;

namespace AcademiaSaude
{
	public partial class FrmPerfil : Form
	{
		public FrmPerfil()
		{

			InitializeComponent();

			this.Load += FrmPerfil_Load;
		}
		private void Avaliar(int nota)
		{
			lblEstr1.ForeColor = nota >= 1 ? Color.Gold : Color.Gray;
			lblEstr2.ForeColor = nota >= 2 ? Color.Gold : Color.Gray;
			lblEstr3.ForeColor = nota >= 3 ? Color.Gold : Color.Gray;
			lblEstr4.ForeColor = nota >= 4 ? Color.Gold : Color.Gray;
			lblEstr5.ForeColor = nota >= 5 ? Color.Gold : Color.Gray;
		}

		private void lblEstr1_Click(object sender, EventArgs e)
		{
			Avaliar(1);
		}

		private void lblEstr2_Click(object sender, EventArgs e)
		{
			Avaliar(2);
		}

		private void lblEstr3_Click(object sender, EventArgs e)
		{
			Avaliar(3);
		}

		private void lblEstr4_Click(object sender, EventArgs e)
		{
			Avaliar(4);
		}

		private void lblEstr5_Click(object sender, EventArgs e)
		{
			Avaliar(5);
		}


		private void FrmPerfil_Load(object sender, EventArgs e)
		{
			txtNome.Text = User.nome;
			txtSobr.Text = User.sobrenome;
			txtIdd.Text = User.idade;
			txtEml.Text = User.email;
			txtSen.Text = User.senha;

			GraphicsPath path = new GraphicsPath();
			path.AddEllipse(0, 0, picturePerf.Width, picturePerf.Height);

			picturePerf.Region = new Region(path);
		}
		
		

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void llbEstr1_Click(object sender, EventArgs e)
		{
			Avaliar(1);
		}

		private void txtNome_TextChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{

		}

		private void btnMostrar_Click(object sender, EventArgs e)
		{
			txtSen.UseSystemPasswordChar =
				!txtSen.UseSystemPasswordChar;
		}
	}
}
