namespace TesteMarfrig
{
	partial class frmCompraGado
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtId = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.btnSair = new MetroFramework.Controls.MetroButton();
			this.txtDataEntrega = new MetroFramework.Controls.MetroDateTime();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.cmbPecuarista = new MetroFramework.Controls.MetroComboBox();
			this.pecuaristaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnExcluirAnimal = new MetroFramework.Controls.MetroButton();
			this.btnNovoAnimal = new MetroFramework.Controls.MetroButton();
			this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
			this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valortotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.compraGadoItemSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnNovo = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this.pecuaristaBindingSource)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.compraGadoItemSelectBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(12, 60);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(53, 19);
			this.metroLabel2.TabIndex = 107;
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
			this.txtId.Location = new System.Drawing.Point(12, 82);
			this.txtId.MaxLength = 32767;
			this.txtId.Name = "txtId";
			this.txtId.PasswordChar = '\0';
			this.txtId.ReadOnly = true;
			this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtId.SelectedText = "";
			this.txtId.SelectionLength = 0;
			this.txtId.SelectionStart = 0;
			this.txtId.ShortcutsEnabled = true;
			this.txtId.Size = new System.Drawing.Size(53, 23);
			this.txtId.TabIndex = 99;
			this.txtId.UseSelectable = true;
			this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(12, 117);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(104, 19);
			this.metroLabel1.TabIndex = 105;
			this.metroLabel1.Text = "Data de Entrega";
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(512, 401);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 23);
			this.btnSair.TabIndex = 2;
			this.btnSair.Text = "Sair";
			this.btnSair.UseSelectable = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// txtDataEntrega
			// 
			this.txtDataEntrega.Enabled = false;
			this.txtDataEntrega.Location = new System.Drawing.Point(12, 139);
			this.txtDataEntrega.MinimumSize = new System.Drawing.Size(0, 29);
			this.txtDataEntrega.Name = "txtDataEntrega";
			this.txtDataEntrega.ShowCheckBox = true;
			this.txtDataEntrega.Size = new System.Drawing.Size(297, 29);
			this.txtDataEntrega.TabIndex = 3;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(315, 117);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(68, 19);
			this.metroLabel3.TabIndex = 111;
			this.metroLabel3.Text = "Pecuarista";
			// 
			// cmbPecuarista
			// 
			this.cmbPecuarista.DataSource = this.pecuaristaBindingSource;
			this.cmbPecuarista.DisplayMember = "Nome";
			this.cmbPecuarista.Enabled = false;
			this.cmbPecuarista.FormattingEnabled = true;
			this.cmbPecuarista.ItemHeight = 23;
			this.cmbPecuarista.Location = new System.Drawing.Point(315, 139);
			this.cmbPecuarista.Name = "cmbPecuarista";
			this.cmbPecuarista.Size = new System.Drawing.Size(305, 29);
			this.cmbPecuarista.TabIndex = 4;
			this.cmbPecuarista.UseSelectable = true;
			this.cmbPecuarista.ValueMember = "Id";
			// 
			// pecuaristaBindingSource
			// 
			this.pecuaristaBindingSource.DataSource = typeof(TesteMarfrig.Model.Pecuarista.Pecuarista);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnExcluirAnimal);
			this.groupBox1.Controls.Add(this.btnNovoAnimal);
			this.groupBox1.Controls.Add(this.metroGrid1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 174);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(635, 221);
			this.groupBox1.TabIndex = 114;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Animais";
			// 
			// btnExcluirAnimal
			// 
			this.btnExcluirAnimal.Enabled = false;
			this.btnExcluirAnimal.Location = new System.Drawing.Point(90, 21);
			this.btnExcluirAnimal.Name = "btnExcluirAnimal";
			this.btnExcluirAnimal.Size = new System.Drawing.Size(75, 23);
			this.btnExcluirAnimal.TabIndex = 6;
			this.btnExcluirAnimal.Text = "Excluir";
			this.btnExcluirAnimal.UseSelectable = true;
			this.btnExcluirAnimal.Click += new System.EventHandler(this.btnExcluirAnimal_Click);
			// 
			// btnNovoAnimal
			// 
			this.btnNovoAnimal.Enabled = false;
			this.btnNovoAnimal.Location = new System.Drawing.Point(9, 21);
			this.btnNovoAnimal.Name = "btnNovoAnimal";
			this.btnNovoAnimal.Size = new System.Drawing.Size(75, 23);
			this.btnNovoAnimal.TabIndex = 5;
			this.btnNovoAnimal.Text = "Novo";
			this.btnNovoAnimal.UseSelectable = true;
			this.btnNovoAnimal.Click += new System.EventHandler(this.btnInserir_Click);
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
            this.descricaoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.precoDataGridViewTextBoxColumn,
            this.valortotalDataGridViewTextBoxColumn,
            this.Id});
			this.metroGrid1.DataSource = this.compraGadoItemSelectBindingSource;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle4;
			this.metroGrid1.EnableHeadersVisualStyles = false;
			this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.metroGrid1.Location = new System.Drawing.Point(9, 50);
			this.metroGrid1.Name = "metroGrid1";
			this.metroGrid1.ReadOnly = true;
			this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.metroGrid1.Size = new System.Drawing.Size(616, 159);
			this.metroGrid1.TabIndex = 7;
			// 
			// descricaoDataGridViewTextBoxColumn
			// 
			this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
			this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
			this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
			this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
			this.descricaoDataGridViewTextBoxColumn.Width = 180;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
			this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// precoDataGridViewTextBoxColumn
			// 
			this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Format = "C2";
			dataGridViewCellStyle2.NullValue = "0,00";
			this.precoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
			this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
			this.precoDataGridViewTextBoxColumn.ReadOnly = true;
			this.precoDataGridViewTextBoxColumn.Width = 90;
			// 
			// valortotalDataGridViewTextBoxColumn
			// 
			this.valortotalDataGridViewTextBoxColumn.DataPropertyName = "Valortotal";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "C2";
			dataGridViewCellStyle3.NullValue = "0,00";
			this.valortotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.valortotalDataGridViewTextBoxColumn.HeaderText = "Valortotal";
			this.valortotalDataGridViewTextBoxColumn.Name = "valortotalDataGridViewTextBoxColumn";
			this.valortotalDataGridViewTextBoxColumn.ReadOnly = true;
			this.valortotalDataGridViewTextBoxColumn.Width = 180;
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			// 
			// compraGadoItemSelectBindingSource
			// 
			this.compraGadoItemSelectBindingSource.DataSource = typeof(TesteMarfrig.Model.CompraGadoItem.CompraGadoItemSelect);
			// 
			// btnNovo
			// 
			this.btnNovo.Location = new System.Drawing.Point(56, 401);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(75, 23);
			this.btnNovo.TabIndex = 1;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseSelectable = true;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// frmCompraGado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(660, 433);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cmbPecuarista);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.txtDataEntrega);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.btnSair);
			this.MaximizeBox = false;
			this.Name = "frmCompraGado";
			this.Text = "Compra de Gado";
			this.Load += new System.EventHandler(this.frmCompraGado_Load);
			((System.ComponentModel.ISupportInitialize)(this.pecuaristaBindingSource)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.compraGadoItemSelectBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTextBox txtId;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroButton btnSair;
		private MetroFramework.Controls.MetroDateTime txtDataEntrega;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroComboBox cmbPecuarista;
		private System.Windows.Forms.GroupBox groupBox1;
		private MetroFramework.Controls.MetroGrid metroGrid1;
		private MetroFramework.Controls.MetroButton btnExcluirAnimal;
		private MetroFramework.Controls.MetroButton btnNovoAnimal;
		private MetroFramework.Controls.MetroButton btnNovo;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn compraGadoIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn animalIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource pecuaristaBindingSource;
		private System.Windows.Forms.BindingSource compraGadoItemSelectBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn valortotalDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
	}
}