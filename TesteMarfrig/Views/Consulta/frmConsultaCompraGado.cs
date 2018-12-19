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
		WebServiceMarfrigSoapClient wbclient = new WebServiceMarfrigSoapClient();

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
				
				pecuaristaBindingSource.DataSource = wbclient.GetAllPecuaristaCompraGado();

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
			if (metroGrid1.RowCount > 0)
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
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			if (metroGrid1.RowCount > 0)
			{
				if (metroGrid1.CurrentRow.Cells[6].Value.ToString() != null)
					if (metroGrid1.CurrentRow.Cells[6].Value.ToString() == "Não")
					{
						if (metroGrid1.CurrentRow.Cells[0].Value.ToString() != null)
						{
							if (MetroFramework.MetroMessageBox.Show(this, "Tem certeza que deseja excluir a compra : " + metroGrid1.CurrentRow.Cells[0].Value.ToString(), "Excluir ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
								return;

							try
							{
								wbclient.DeleteCompraGado(Convert.ToInt32(metroGrid1.CurrentRow.Cells[0].Value.ToString()));
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
		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			Pesquisar();
		}

		private void Pesquisar()
		{
			bool validaPesquisa = false;

			CompraGado compragado = new CompraGado();

			if (txtDataEntregaDe.Checked)
			{
				compragado.DataEntrega = Convert.ToDateTime(txtDataEntregaDe.Value);
				validaPesquisa = true;
			}

			if (txtDataEntregaAte.Checked)
			{
				compragado.DataEntregaAte = Convert.ToDateTime(txtDataEntregaAte.Value);
				validaPesquisa = true;
			}

			if (Convert.ToInt32(cmbPecuarista.SelectedValue) > 0)
			{
				compragado.PecuaristaId = Convert.ToInt32(cmbPecuarista.SelectedValue);
				validaPesquisa = true;
			}

			if (txtId.Text != "")
			{
				compragado.Id = Convert.ToInt32(txtId.Text);
				validaPesquisa = true;
			}

			if (validaPesquisa != true)
			{
				MetroFramework.MetroMessageBox.Show(this, "Por favor, digite um item para pesquisa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			try
			{
				compraGadoConsultaBindingSource.DataSource = wbclient.GetConsultaCompraGado(compragado);

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

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			if (metroGrid1.RowCount > 0)
			{

				if (metroGrid1.CurrentRow.Cells[0].Value.ToString() == "")
					return;

				frmRelatorio frmrelatorio = new frmRelatorio(Convert.ToInt32(metroGrid1.CurrentRow.Cells[0].Value.ToString()));
				frmrelatorio.ShowDialog();

				try
				{
					wbclient.UpdateCompraGadoImpresso(Convert.ToInt32(metroGrid1.CurrentRow.Cells[0].Value.ToString()));
				}
				catch (Exception ex)
				{
					MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				Pesquisar();
			}
		}
	}
}