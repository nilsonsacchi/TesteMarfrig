namespace TesteMarfrig
{
	partial class frmRelatorio
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.rpRelatorio = new Microsoft.Reporting.WinForms.ReportViewer();
			this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pecuaristaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantidadeItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.impressoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.compraGadoConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.compraGadoConsultaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// rpRelatorio
			// 
			this.rpRelatorio.AutoSize = true;
			reportDataSource1.Name = "DataSetRelatorio";
			reportDataSource1.Value = this.compraGadoConsultaBindingSource;
			this.rpRelatorio.LocalReport.DataSources.Add(reportDataSource1);
			this.rpRelatorio.LocalReport.ReportEmbeddedResource = "TesteMarfrig.Relatorio.rdlc";
			this.rpRelatorio.Location = new System.Drawing.Point(1, 7);
			this.rpRelatorio.Name = "rpRelatorio";
			this.rpRelatorio.ServerReport.BearerToken = null;
			this.rpRelatorio.Size = new System.Drawing.Size(980, 470);
			this.rpRelatorio.TabIndex = 0;
			// 
			// metroGrid1
			// 
			this.metroGrid1.AllowUserToResizeRows = false;
			this.metroGrid1.AutoGenerateColumns = false;
			this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.pecuaristaIdDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataEntregaDataGridViewTextBoxColumn,
            this.quantidadeItemDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn,
            this.impressoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn});
			this.metroGrid1.DataSource = this.compraGadoConsultaBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
			this.metroGrid1.EnableHeadersVisualStyles = false;
			this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.metroGrid1.Location = new System.Drawing.Point(215, 200);
			this.metroGrid1.Name = "metroGrid1";
			this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.metroGrid1.Size = new System.Drawing.Size(240, 150);
			this.metroGrid1.TabIndex = 1;
			this.metroGrid1.Visible = false;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// pecuaristaIdDataGridViewTextBoxColumn
			// 
			this.pecuaristaIdDataGridViewTextBoxColumn.DataPropertyName = "PecuaristaId";
			this.pecuaristaIdDataGridViewTextBoxColumn.HeaderText = "PecuaristaId";
			this.pecuaristaIdDataGridViewTextBoxColumn.Name = "pecuaristaIdDataGridViewTextBoxColumn";
			// 
			// nomeDataGridViewTextBoxColumn
			// 
			this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
			this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
			this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
			// 
			// dataEntregaDataGridViewTextBoxColumn
			// 
			this.dataEntregaDataGridViewTextBoxColumn.DataPropertyName = "DataEntrega";
			this.dataEntregaDataGridViewTextBoxColumn.HeaderText = "DataEntrega";
			this.dataEntregaDataGridViewTextBoxColumn.Name = "dataEntregaDataGridViewTextBoxColumn";
			// 
			// quantidadeItemDataGridViewTextBoxColumn
			// 
			this.quantidadeItemDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeItem";
			this.quantidadeItemDataGridViewTextBoxColumn.HeaderText = "QuantidadeItem";
			this.quantidadeItemDataGridViewTextBoxColumn.Name = "quantidadeItemDataGridViewTextBoxColumn";
			// 
			// valorTotalDataGridViewTextBoxColumn
			// 
			this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
			this.valorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal";
			this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
			// 
			// impressoDataGridViewTextBoxColumn
			// 
			this.impressoDataGridViewTextBoxColumn.DataPropertyName = "Impresso";
			this.impressoDataGridViewTextBoxColumn.HeaderText = "Impresso";
			this.impressoDataGridViewTextBoxColumn.Name = "impressoDataGridViewTextBoxColumn";
			// 
			// precoDataGridViewTextBoxColumn
			// 
			this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
			this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
			this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
			// 
			// compraGadoConsultaBindingSource
			// 
			this.compraGadoConsultaBindingSource.DataSource = typeof(TesteMarfrig.Model.CompraGado.CompraGadoConsulta);
			// 
			// frmRelatorio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(985, 488);
			this.Controls.Add(this.metroGrid1);
			this.Controls.Add(this.rpRelatorio);
			this.Name = "frmRelatorio";
			this.Text = "Relatório";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmRelatorio_Load);
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.compraGadoConsultaBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rpRelatorio;
		private MetroFramework.Controls.MetroGrid metroGrid1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pecuaristaIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataEntregaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeItemDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn impressoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource compraGadoConsultaBindingSource;
	}
}