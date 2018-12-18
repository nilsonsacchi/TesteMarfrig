namespace TesteMarfrig
{
	partial class frmConsultaCompraGado
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cmbPecuarista = new MetroFramework.Controls.MetroComboBox();
			this.pecuaristaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.txtDataEntregaDe = new MetroFramework.Controls.MetroDateTime();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtId = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtDataEntregaAte = new MetroFramework.Controls.MetroDateTime();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.btnPesquisar = new MetroFramework.Controls.MetroButton();
			this.btnSair = new MetroFramework.Controls.MetroButton();
			this.btnExcluir = new MetroFramework.Controls.MetroButton();
			this.btnNovo = new MetroFramework.Controls.MetroButton();
			this.btnAlterar = new MetroFramework.Controls.MetroButton();
			this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
			this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.compraGadoConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnImprimir = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this.pecuaristaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.compraGadoConsultaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbPecuarista
			// 
			this.cmbPecuarista.DataSource = this.pecuaristaBindingSource;
			this.cmbPecuarista.DisplayMember = "Nome";
			this.cmbPecuarista.FormattingEnabled = true;
			this.cmbPecuarista.ItemHeight = 23;
			this.cmbPecuarista.Location = new System.Drawing.Point(326, 84);
			this.cmbPecuarista.Name = "cmbPecuarista";
			this.cmbPecuarista.Size = new System.Drawing.Size(282, 29);
			this.cmbPecuarista.TabIndex = 113;
			this.cmbPecuarista.UseSelectable = true;
			this.cmbPecuarista.ValueMember = "Id";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(326, 62);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(68, 19);
			this.metroLabel3.TabIndex = 117;
			this.metroLabel3.Text = "Pecuarista";
			// 
			// txtDataEntregaDe
			// 
			this.txtDataEntregaDe.Checked = false;
			this.txtDataEntregaDe.Location = new System.Drawing.Point(14, 141);
			this.txtDataEntregaDe.MinimumSize = new System.Drawing.Size(0, 29);
			this.txtDataEntregaDe.Name = "txtDataEntregaDe";
			this.txtDataEntregaDe.ShowCheckBox = true;
			this.txtDataEntregaDe.Size = new System.Drawing.Size(306, 29);
			this.txtDataEntregaDe.TabIndex = 112;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(14, 62);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(53, 19);
			this.metroLabel2.TabIndex = 116;
			this.metroLabel2.Text = "Código";
			// 
			// txtId
			// 
			// 
			// 
			// 
			this.txtId.CustomButton.Image = null;
			this.txtId.CustomButton.Location = new System.Drawing.Point(31, 1);
			this.txtId.CustomButton.Name = "";
			this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtId.CustomButton.TabIndex = 1;
			this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtId.CustomButton.UseSelectable = true;
			this.txtId.CustomButton.Visible = false;
			this.txtId.Lines = new string[0];
			this.txtId.Location = new System.Drawing.Point(14, 84);
			this.txtId.MaxLength = 32767;
			this.txtId.Name = "txtId";
			this.txtId.PasswordChar = '\0';
			this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtId.SelectedText = "";
			this.txtId.SelectionLength = 0;
			this.txtId.SelectionStart = 0;
			this.txtId.ShortcutsEnabled = true;
			this.txtId.Size = new System.Drawing.Size(53, 23);
			this.txtId.TabIndex = 114;
			this.txtId.UseSelectable = true;
			this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(14, 119);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(123, 19);
			this.metroLabel1.TabIndex = 115;
			this.metroLabel1.Text = "Data de entrega de";
			// 
			// txtDataEntregaAte
			// 
			this.txtDataEntregaAte.Checked = false;
			this.txtDataEntregaAte.Location = new System.Drawing.Point(326, 141);
			this.txtDataEntregaAte.MinimumSize = new System.Drawing.Size(0, 29);
			this.txtDataEntregaAte.Name = "txtDataEntregaAte";
			this.txtDataEntregaAte.ShowCheckBox = true;
			this.txtDataEntregaAte.Size = new System.Drawing.Size(297, 29);
			this.txtDataEntregaAte.TabIndex = 118;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(326, 119);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(126, 19);
			this.metroLabel4.TabIndex = 119;
			this.metroLabel4.Text = "Data de entrega até";
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(643, 147);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
			this.btnPesquisar.TabIndex = 120;
			this.btnPesquisar.Text = "&Pesquisar";
			this.btnPesquisar.UseSelectable = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(652, 439);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 23);
			this.btnSair.TabIndex = 121;
			this.btnSair.Text = "&Sair";
			this.btnSair.UseSelectable = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(176, 439);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 122;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseSelectable = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnNovo
			// 
			this.btnNovo.Location = new System.Drawing.Point(14, 439);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(75, 23);
			this.btnNovo.TabIndex = 123;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseSelectable = true;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(95, 439);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(75, 23);
			this.btnAlterar.TabIndex = 124;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseSelectable = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// metroGrid1
			// 
			this.metroGrid1.AllowUserToAddRows = false;
			this.metroGrid1.AllowUserToDeleteRows = false;
			this.metroGrid1.AllowUserToResizeColumns = false;
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
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
			this.metroGrid1.DataSource = this.compraGadoConsultaBindingSource;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle6;
			this.metroGrid1.EnableHeadersVisualStyles = false;
			this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.metroGrid1.Location = new System.Drawing.Point(14, 176);
			this.metroGrid1.Name = "metroGrid1";
			this.metroGrid1.ReadOnly = true;
			this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.metroGrid1.Size = new System.Drawing.Size(713, 257);
			this.metroGrid1.TabIndex = 125;
			// 
			// dataGridViewTextBoxColumn18
			// 
			this.dataGridViewTextBoxColumn18.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn18.HeaderText = "Id";
			this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
			this.dataGridViewTextBoxColumn18.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn19
			// 
			this.dataGridViewTextBoxColumn19.DataPropertyName = "PecuaristaId";
			this.dataGridViewTextBoxColumn19.HeaderText = "PecuaristaId";
			this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
			this.dataGridViewTextBoxColumn19.ReadOnly = true;
			this.dataGridViewTextBoxColumn19.Visible = false;
			// 
			// dataGridViewTextBoxColumn20
			// 
			this.dataGridViewTextBoxColumn20.DataPropertyName = "Nome";
			this.dataGridViewTextBoxColumn20.HeaderText = "Pecuarista";
			this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
			this.dataGridViewTextBoxColumn20.ReadOnly = true;
			this.dataGridViewTextBoxColumn20.Width = 150;
			// 
			// dataGridViewTextBoxColumn21
			// 
			this.dataGridViewTextBoxColumn21.DataPropertyName = "DataEntrega";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn21.HeaderText = "Data Entrega";
			this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
			this.dataGridViewTextBoxColumn21.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn22
			// 
			this.dataGridViewTextBoxColumn22.DataPropertyName = "QuantidadeItem";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn22.HeaderText = "Qtd Item";
			this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
			this.dataGridViewTextBoxColumn22.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn23
			// 
			this.dataGridViewTextBoxColumn23.DataPropertyName = "ValorTotal";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "C2";
			dataGridViewCellStyle4.NullValue = "0,00";
			this.dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewTextBoxColumn23.HeaderText = "Valor Total";
			this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
			this.dataGridViewTextBoxColumn23.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn24
			// 
			this.dataGridViewTextBoxColumn24.DataPropertyName = "Impresso";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn24.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewTextBoxColumn24.HeaderText = "Impresso";
			this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
			this.dataGridViewTextBoxColumn24.ReadOnly = true;
			// 
			// compraGadoConsultaBindingSource
			// 
			this.compraGadoConsultaBindingSource.DataSource = typeof(TesteMarfrig.Model.CompraGado.CompraGadoConsulta);
			// 
			// btnImprimir
			// 
			this.btnImprimir.Location = new System.Drawing.Point(257, 439);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(75, 23);
			this.btnImprimir.TabIndex = 126;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseSelectable = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// frmConsultaCompraGado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(741, 473);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.metroGrid1);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.txtDataEntregaAte);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.cmbPecuarista);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.txtDataEntregaDe);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.metroLabel1);
			this.Name = "frmConsultaCompraGado";
			this.Text = "Consulta compra de gado";
			this.Load += new System.EventHandler(this.frmConsultaCompraGado_Load);
			((System.ComponentModel.ISupportInitialize)(this.pecuaristaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.compraGadoConsultaBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroComboBox cmbPecuarista;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroDateTime txtDataEntregaDe;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTextBox txtId;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroDateTime txtDataEntregaAte;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroButton btnPesquisar;
		private MetroFramework.Controls.MetroButton btnSair;
		private MetroFramework.Controls.MetroButton btnExcluir;
		private MetroFramework.Controls.MetroButton btnNovo;
		private MetroFramework.Controls.MetroButton btnAlterar;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomePecuaristaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataEntregaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource pecuaristaBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn pecuaristaIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeItemDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn impressoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private MetroFramework.Controls.MetroGrid metroGrid1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
		private System.Windows.Forms.BindingSource compraGadoConsultaBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
		private MetroFramework.Controls.MetroButton btnImprimir;
	}
}