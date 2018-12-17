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
	public partial class frmConsultaCompraGado : MetroFramework.Forms.MetroForm
	{
		EntityState oEntity = new EntityState();

		public frmConsultaCompraGado()
		{
			InitializeComponent();
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void getPecuarista()
		{
			try
			{
				WebServiceMarfrigSoapClient webclient = new WebServiceMarfrigSoapClient();
				pecuaristaBindingSource.DataSource = webclient.GetAllPecuaristaCompraGado();

				Pecuarista opecuarista = pecuaristaBindingSource.Current as Pecuarista;
			}
			catch (Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmConsultaCompraGado_Load(object sender, EventArgs e)
		{
			getPecuarista();
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			if (metroGrid1.CurrentRow.Cells[6].Value.ToString() != null)
				if (metroGrid1.CurrentRow.Cells[6].Value.ToString() == "Não")
				{
					if (metroGrid1.CurrentRow.Cells[0].Value.ToString() != null)
					{
						oEntity = EntityState.Alterar;
						frmCompraGado frmcompragado = new frmCompraGado(oEntity, metroGrid1.CurrentRow.Cells[0].Value.ToString(), Convert.ToDateTime(metroGrid1.CurrentRow.Cells[3].Value.ToString()), metroGrid1.CurrentRow.Cells[2].Value.ToString());
						frmcompragado.ShowDialog();

						Pesquisar();
					}
				}
				else
				{
					MetroFramework.MetroMessageBox.Show(this, "Não é permitido a alteração de compra já impresso.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			if (metroGrid1.CurrentRow.Cells[6].Value.ToString() != null)
				if (metroGrid1.CurrentRow.Cells[6].Value.ToString() == "Não")
				{
					if (metroGrid1.CurrentRow.Cells[0].Value.ToString() != null)
					{
						if (MetroFramework.MetroMessageBox.Show(this, "Tem certeza que deseja excluir a compra : " + metroGrid1.CurrentRow.Cells[0].Value.ToString(), "Excluir ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
							return;

						WebServiceMarfrigSoapClient wbClinet = null;

						try
						{
							wbClinet = new WebServiceMarfrigSoapClient();
							wbClinet.DeleteCompraGado(Convert.ToInt32(metroGrid1.CurrentRow.Cells[0].Value.ToString()));
						}
						catch (Exception ex)
						{
							MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}

						Pesquisar();
					}
				}
				else
				{
					MetroFramework.MetroMessageBox.Show(this, "Não é permitido excluir uma compra já impresso.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			Pesquisar();
		}

		private void Pesquisar()
		{
			CompraGado compragado = new CompraGado();

			if (txtDataEntregaDe.Checked)
				compragado.DataEntrega = Convert.ToDateTime(txtDataEntregaDe.Value);

			if (txtDataEntregaAte.Checked)
				compragado.DataEntregaAte = Convert.ToDateTime(txtDataEntregaAte.Value);

			if (Convert.ToInt32(cmbPecuarista.SelectedValue) > 0)
				compragado.PecuaristaId = Convert.ToInt32(cmbPecuarista.SelectedValue);

			if (txtId.Text != "")
				compragado.Id = Convert.ToInt32(txtId.Text);

			try
			{
				WebServiceMarfrigSoapClient webclient = new WebServiceMarfrigSoapClient();
				compraGadoConsultaBindingSource.DataSource = webclient.GetConsultaCompraGado(compragado);

				CompraGado oCompragado = compraGadoConsultaBindingSource.Current as CompraGado;
			}
			catch (Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			oEntity = EntityState.Inserir;
			frmCompraGado frmcompragado = new frmCompraGado(oEntity, "", null, "");
			frmcompragado.ShowDialog();

			Pesquisar();
		}
	}
}