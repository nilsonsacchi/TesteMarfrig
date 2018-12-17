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
	public partial class frmRelatorio : MetroFramework.Forms.MetroForm
	{
		int compraGado;

		public frmRelatorio(int compraGadoId)
		{
			InitializeComponent();
			compraGado = compraGadoId;
		}

		private void frmRelatorio_Load(object sender, EventArgs e)
		{
			try
			{
				WebServiceMarfrigSoapClient webclient = new WebServiceMarfrigSoapClient();
				compraGadoConsultaBindingSource.DataSource = webclient.GetRelatorioCompraGado(compraGado);

				CompraGado oCompragado = compraGadoConsultaBindingSource.Current as CompraGado;
			}
			catch (Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.rpRelatorio.AutoSize = true;
			
			this.rpRelatorio.RefreshReport();
			this.rpRelatorio.RefreshReport();
		}
	}
}
