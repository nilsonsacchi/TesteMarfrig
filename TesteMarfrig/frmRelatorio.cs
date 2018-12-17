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
	public partial class frmRelatorio : MetroFramework.Forms.MetroForm
	{
		public frmRelatorio()
		{
			InitializeComponent();
		}

		private void frmRelatorio_Load(object sender, EventArgs e)
		{

			this.rpRelatorio.RefreshReport();
			this.rpRelatorio.RefreshReport();
		}
	}
}
