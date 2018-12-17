using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteMarfrig
{
	public partial class frmPrincipal : MetroFramework.Forms.MetroForm
	{
		public frmPrincipal()
		{
			InitializeComponent();
		}
		private void animalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAnimal frmanimal = new frmAnimal();
			frmanimal.ShowDialog();
		}

		private void pecuaristaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPecuarista frmpecuarista = new frmPecuarista();
			frmpecuarista.ShowDialog();
		}

		private void compraGadoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmConsultaCompraGado frmconsultaGado = new frmConsultaCompraGado();
			frmconsultaGado.ShowDialog();

			//frmConsultaCompraGado frmconsultacompragado = new frmConsultaCompraGado();
			//frmconsultacompragado.ShowDialog();

			//frmCompraGado frmcompragado = new frmCompraGado();
			//frmcompragado.ShowDialog();
		}

		private void compraDeGadoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}
	}
}
