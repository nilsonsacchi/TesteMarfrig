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
	public partial class frmAnimal : MetroFramework.Forms.MetroForm
	{
		public frmAnimal()
		{
			InitializeComponent();
		}

		private void GetAllAnimal()
		{
			try
			{
				WebServiceMarfrigSoapClient webpec = new WebServiceMarfrigSoapClient();
				animalBindingSource.DataSource = webpec.GetAllAnimal();

				Animal oAnimal = animalBindingSource.Current as Animal;
			}
			catch (Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnInserir_Click(object sender, EventArgs e)
		{
			txtId.Text = "NOVO";
			txtDescricao.Text = null;
			txtPreco.Text = "0";

			txtDescricao.Focus();
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
				txtDescricao.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
				txtPreco.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();

			}
			catch (Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			if (txtDescricao.Text.Length <= 0)
			{
				MetroFramework.MetroMessageBox.Show(this, "O nome do animal não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			else
			{
				if (MetroFramework.MetroMessageBox.Show(this, "Deseja salvar as informações ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				{
					if (txtId.Text != "NOVO")
					{
						txtId.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
						txtDescricao.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
						txtPreco.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
					}
					return;
				}

				WebServiceMarfrigSoapClient wbClinet = null;
				Animal classAnimal = null;

				try
				{
					wbClinet = new WebServiceMarfrigSoapClient();
					classAnimal = new WebServiceMarfrig.Animal();

					if (txtId.Text != "NOVO")
						classAnimal.Id = Convert.ToInt32(txtId.Text);
					else classAnimal.Id = 1;

					classAnimal.Descricao = txtDescricao.Text;
					classAnimal.Preco = double.Parse(txtPreco.Text);

					if (txtId.Text != "NOVO")
						wbClinet.UpdateAnimal(classAnimal);
					else
					{
						wbClinet.InserirAnimal(classAnimal);

						txtId.Text = "";
						txtDescricao.Text = "";
						txtPreco.Text = "0";
					}

					GetAllAnimal();
				}
				catch (Exception ex)
				{
					MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			if (txtId.Text == "NOVO")
				return;

			if (MetroFramework.MetroMessageBox.Show(this, "Tem certeza que deseja excluir o registro", "Excluir ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;

			WebServiceMarfrigSoapClient wbClinet = null;

			try
			{
				wbClinet = new WebServiceMarfrigSoapClient();
				wbClinet.DeleteAnimal(Convert.ToInt32(txtId.Text));

				txtId.Text = "";
				txtDescricao.Text = "";
				txtPreco.Text = "0";

				GetAllAnimal();
			}
			catch (Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtPreco_TextChanged(object sender, EventArgs e)
		{
			Preco(ref txtPreco);
		}

		private void Preco(ref MetroFramework.Controls.MetroTextBox txt)
		{
			string n = string.Empty;
			double v = 0;

			try
			{
				n = txt.Text.Replace(",", "").Replace(".", "");
				if (n.Equals(""))
					n = "";

				n = n.PadLeft(3, '0');
				if (n.Length > 3 & n.Substring(0, 1) == "0")
					n = n.Substring(1, n.Length - 1);
				v = Convert.ToDouble(n) / 100;
				txt.Text = string.Format("{0:N}", v);
				txt.SelectionStart = txt.Text.Length;

			}
			catch (Exception ex)
			{
				//MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsNumber(e.KeyChar) == false)
				txtPreco.Text = "";
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			if (txtId.Text != "NOVO")
			{
				if (MetroFramework.MetroMessageBox.Show(this, "Deseja cancelar a alteração ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					txtId.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
					txtDescricao.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
					txtPreco.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
				}
			}
			else
			{
				if (txtId.Text == "NOVO")
					if (MetroFramework.MetroMessageBox.Show(this, "Deseja cancelar o novo registro ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						txtId.Text = "";
						txtDescricao.Text = "";
						txtPreco.Text = "";
						GetAllAnimal();
					}
			}
		}

		private void frmAnimal_Load(object sender, EventArgs e)
		{
			GetAllAnimal();
		}
	}
}
