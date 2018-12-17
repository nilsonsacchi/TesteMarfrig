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
	public partial class frmCompraGado :  MetroFramework.Forms.MetroForm
	{
		Pecuarista oPecuarista = new Pecuarista();
		CompraGadoItem oCompraGadoItem = new CompraGadoItem();

		EntityState oEntity = new EntityState();
		string compraGadoId = null;
		DateTime? gdataentrega = null;
		string gpecuarista = null;

		private void getAllCompraGadoItem(int compraGadoId)
		{
			try
			{
				WebServiceMarfrigSoapClient webpec = new WebServiceMarfrigSoapClient();
				compraGadoItemSelectBindingSource.DataSource = webpec.GetCompraGadoItemPorCompraGado(compraGadoId);

				oCompraGadoItem = compraGadoItemSelectBindingSource.Current as CompraGadoItem;
			}
			catch (Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void GetAllPecuarista()
		{
			try
			{
				WebServiceMarfrigSoapClient webclient = new WebServiceMarfrigSoapClient();
				pecuaristaBindingSource.DataSource = webclient.GetAllPecuarista();

				Pecuarista opecuarista = pecuaristaBindingSource.Current as Pecuarista;
			}
			catch (Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public frmCompraGado(EntityState entity, string id, DateTime? dataentrega, string pecuarista)
		{
			InitializeComponent();

			oEntity = entity;
			compraGadoId = id;
			gdataentrega = dataentrega;
			gpecuarista = pecuarista;
		}

		private void btnInserir_Click(object sender, EventArgs e)
		{
			WebServiceMarfrigSoapClient wbClient = null;
			CompraGado classCompragado = null;

			try
			{
				wbClient = new WebServiceMarfrigSoapClient();
				classCompragado = new WebServiceMarfrig.CompraGado();

				if (txtId.Text == "NOVO")
					classCompragado.Id = 1;
				else classCompragado.Id = Convert.ToInt32(txtId.Text);

				if (txtDataEntrega.Checked)
					classCompragado.DataEntrega = Convert.ToDateTime(txtDataEntrega.Text);

				classCompragado.PecuaristaId = Convert.ToInt32(cmbPecuarista.SelectedValue);

				int Id;
				if (txtId.Text == "NOVO")
				{
					Id = wbClient.InserirCompraGado(classCompragado);
					txtId.Text = Id.ToString();
				}
				else
				{
					wbClient.UpdateCompraGado(classCompragado);
				}
			}
			catch (Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			frmCompraGadoItem frmcompragadoitem = new frmCompraGadoItem(Convert.ToInt32(txtId.Text));
			frmcompragadoitem.ShowDialog();

			//Atualiza o grid
			getAllCompraGadoItem(Convert.ToInt32(txtId.Text));

			btnExcluirAnimal.Enabled = true;
		}

		private void frmCompraGado_Load(object sender, EventArgs e)
		{
			if (oEntity == EntityState.Inserir)
			{
				GetAllPecuarista();
			}
			else if(oEntity == EntityState.Alterar)
			{
				PopulaFormulario(compraGadoId);
			}
		}

		private void PopulaFormulario(string compragadoId)
		{
			getAllCompraGadoItem(Convert.ToInt32(compragadoId));
			GetAllPecuarista();

			txtId.Text = compragadoId;

			cmbPecuarista.Text = gpecuarista;

			txtDataEntrega.Enabled = true;

			if (gdataentrega != null)
				if (gdataentrega >= Convert.ToDateTime("01/01/2001"))
				{
					txtDataEntrega.Checked = true;
					txtDataEntrega.Value = Convert.ToDateTime(gdataentrega);
				}

			btnNovo.Text = "Salvar";

			btnNovoAnimal.Enabled = true;
			btnExcluirAnimal.Enabled = true;

			cmbPecuarista.Enabled = true;
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			if (btnNovo.Text == "Novo")
			{
				btnNovoAnimal.Enabled = true;
				txtDataEntrega.Enabled = true;
				txtDataEntrega.Checked = false;
				cmbPecuarista.Enabled = true;

				txtId.Text = "NOVO";

				btnNovo.Enabled = false;
			}
			else
			{
				if (MetroFramework.MetroMessageBox.Show(this, "Tem certeza que deseja salvar as alterações", "Salvar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					return;

				WebServiceMarfrigSoapClient wbClinet = null;
				CompraGado classCompragado = null;

				try
				{
					wbClinet = new WebServiceMarfrigSoapClient();
					classCompragado = new WebServiceMarfrig.CompraGado();

					if (txtDataEntrega.Checked)
						classCompragado.DataEntrega = Convert.ToDateTime(txtDataEntrega.Text);

					classCompragado.Id = Convert.ToInt32(txtId.Text);
					classCompragado.PecuaristaId = Convert.ToInt32(cmbPecuarista.SelectedValue);

					wbClinet.UpdateCompraGado(classCompragado);

					this.Close();
				}
				catch (Exception ex)
				{
					MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnExcluirAnimal_Click(object sender, EventArgs e)
		{
			if (txtId.Text == "NOVO")
				return;

			if (metroGrid1.CurrentRow.Cells[4].Value.ToString() == "")
				return;

			if (MetroFramework.MetroMessageBox.Show(this, "Tem certeza que deseja excluir o item: " + metroGrid1.CurrentRow.Cells[0].Value.ToString(), "Excluir ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;

			WebServiceMarfrigSoapClient wbClinet = null;

			try
			{
				wbClinet = new WebServiceMarfrigSoapClient();
				wbClinet.DeleteCompraGadoItem(Convert.ToInt32(metroGrid1.CurrentRow.Cells[4].Value.ToString()));

				getAllCompraGadoItem(Convert.ToInt32(txtId.Text));
			}
			catch (Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
