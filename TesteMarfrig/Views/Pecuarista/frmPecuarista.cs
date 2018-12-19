using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteMarfrig.WebServiceMarfrig;

namespace TesteMarfrig
{
	public partial class frmPecuarista : MetroFramework.Forms.MetroForm
	{
		public frmPecuarista()
		{
			InitializeComponent();
		}

		private void GetAllPecuarista()
		{
			try
			{
				WebServiceMarfrigSoapClient webpec = new WebServiceMarfrigSoapClient();
				pecuaristaBindingSource.DataSource = webpec.GetAllPecuarista();

				Pecuarista oPecurista = pecuaristaBindingSource.Current as Pecuarista;
			}
			catch (Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Pecuarista_Load(object sender, EventArgs e)
		{
			GetAllPecuarista();
		}

		private void btnInserir_Click(object sender, EventArgs e)
		{
			txtId.Text = "NOVO";
			txtNome.Text = null;
			txtNome.Focus();
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				txtId.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
				txtNome.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
			}
			catch(Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			if (txtNome.Text.Trim() == "")
			{
				MetroFramework.MetroMessageBox.Show(this, "O nome do pecuarista não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtNome.Focus();
				return;
			}
			else
			{
				if (MetroFramework.MetroMessageBox.Show(this, "Deseja salvar as informações ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					return;

				WebServiceMarfrigSoapClient wbClinet = null;
				Pecuarista classPecuarista = null;

				try
				{
					wbClinet = new WebServiceMarfrigSoapClient();
					classPecuarista = new WebServiceMarfrig.Pecuarista();

					if (txtId.Text != "NOVO" && txtId.Text != "")
						classPecuarista.Id = Convert.ToInt32(txtId.Text);
					else classPecuarista.Id = 1;

					classPecuarista.Nome = txtNome.Text;

					if (txtId.Text != "NOVO" && txtId.Text != "")
						wbClinet.UpdatePecuarista(classPecuarista);
					else
					{
						wbClinet.InserirPecuarista(classPecuarista);

						txtId.Text = "";
						txtNome.Text = "";
					}

					GetAllPecuarista();
				}
				catch (Exception ex)
				{
					MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			if (MetroFramework.MetroMessageBox.Show(this, "Deseja cancelar a operação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;
			else
			{ 
				txtId.Text = "";
				txtNome.Text = "";
				GetAllPecuarista();
			}
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			if (txtId.Text == "NOVO" || txtId.Text == "")
			{
				MetroFramework.MetroMessageBox.Show(this, "Por favor, selecione um pecuarista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (MetroFramework.MetroMessageBox.Show(this, "Tem certeza que deseja excluir o registro", "Excluir ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;

			WebServiceMarfrigSoapClient wbClinet = null;

			try
			{
				wbClinet = new WebServiceMarfrigSoapClient();
				wbClinet.DeletePecuarista(Convert.ToInt32(txtId.Text));

				txtId.Text = "";
				txtNome.Text = "";

				GetAllPecuarista();
			}
			catch (Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
