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
	public partial class frmCompraGadoItem : MetroFramework.Forms.MetroForm
	{
		public int compraGadoId;

		public frmCompraGadoItem(int gadoId)
		{
			InitializeComponent();
			compraGadoId = gadoId;
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmCompraGadoItem_Load(object sender, EventArgs e)
		{
			GetAllAnimal();
		}

		private void GetAllAnimal()
		{
			try
			{
				WebServiceMarfrigSoapClient webpec = new WebServiceMarfrigSoapClient();
				animalBindingSource.DataSource = webpec.GetAllAnimalCompraGadoItem(compraGadoId);

				Animal oanimal = animalBindingSource.Current as Animal;
			}
			catch (Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			if (txtQuantidade.Text == null)
			{
				MetroFramework.MetroMessageBox.Show(this, "Digite a quantidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtQuantidade.Focus();
				return;
			}

			try
			{
				Convert.ToInt32(txtQuantidade.Text);
			}
			catch (Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, "Por favor, digite uma quantidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtQuantidade.Focus();
				return;
			}

			if (txtAnimal.Text == "")
			{
				MetroFramework.MetroMessageBox.Show(this, "Por favor, selecione um animal.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
				
			WebServiceMarfrigSoapClient wbClient = null;
			CompraGadoItem classcompragadoitem = null;

			try
			{
				wbClient = new WebServiceMarfrigSoapClient();
				classcompragadoitem = new WebServiceMarfrig.CompraGadoItem();

				classcompragadoitem.Id = 1;
				classcompragadoitem.Quantidade = Convert.ToInt32(txtQuantidade.Text);
				classcompragadoitem.AnimalId = Convert.ToInt32(metroGrid1.CurrentRow.Cells[0].Value.ToString());
				classcompragadoitem.CompraGadoId = compraGadoId;

				wbClient.InserirCompraGadoItem(classcompragadoitem);
			}
			catch (Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			this.Close();
		}

		private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				txtAnimal.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
			}
			catch (Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
