namespace TesteMarfrig
{
	partial class frmCompraGadoItem
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtQuantidade = new MetroFramework.Controls.MetroTextBox();
			this.btnAlterar = new MetroFramework.Controls.MetroButton();
			this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.txtAnimal = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(9, 60);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(78, 19);
			this.metroLabel1.TabIndex = 101;
			this.metroLabel1.Text = "Quantidade";
			// 
			// txtQuantidade
			// 
			// 
			// 
			// 
			this.txtQuantidade.CustomButton.Image = null;
			this.txtQuantidade.CustomButton.Location = new System.Drawing.Point(56, 1);
			this.txtQuantidade.CustomButton.Name = "";
			this.txtQuantidade.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtQuantidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtQuantidade.CustomButton.TabIndex = 1;
			this.txtQuantidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtQuantidade.CustomButton.UseSelectable = true;
			this.txtQuantidade.CustomButton.Visible = false;
			this.txtQuantidade.Lines = new string[0];
			this.txtQuantidade.Location = new System.Drawing.Point(12, 82);
			this.txtQuantidade.MaxLength = 32767;
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.PasswordChar = '\0';
			this.txtQuantidade.PromptText = "0";
			this.txtQuantidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtQuantidade.SelectedText = "";
			this.txtQuantidade.SelectionLength = 0;
			this.txtQuantidade.SelectionStart = 0;
			this.txtQuantidade.ShortcutsEnabled = true;
			this.txtQuantidade.Size = new System.Drawing.Size(78, 23);
			this.txtQuantidade.TabIndex = 1;
			this.txtQuantidade.UseSelectable = true;
			this.txtQuantidade.WaterMark = "0";
			this.txtQuantidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtQuantidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(12, 276);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(75, 23);
			this.btnAlterar.TabIndex = 3;
			this.btnAlterar.Text = "Salvar";
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
            this.idDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn});
			this.metroGrid1.DataSource = this.animalBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle3;
			this.metroGrid1.EnableHeadersVisualStyles = false;
			this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.metroGrid1.Location = new System.Drawing.Point(12, 111);
			this.metroGrid1.Name = "metroGrid1";
			this.metroGrid1.ReadOnly = true;
			this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.metroGrid1.Size = new System.Drawing.Size(467, 159);
			this.metroGrid1.TabIndex = 2;
			this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Código";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 50;
			// 
			// descricaoDataGridViewTextBoxColumn
			// 
			this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
			this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
			this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
			this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
			this.descricaoDataGridViewTextBoxColumn.Width = 250;
			// 
			// precoDataGridViewTextBoxColumn
			// 
			this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
			dataGridViewCellStyle2.Format = "C2";
			dataGridViewCellStyle2.NullValue = "0,00";
			this.precoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.precoDataGridViewTextBoxColumn.HeaderText = "Preço";
			this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
			this.precoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// animalBindingSource
			// 
			this.animalBindingSource.DataSource = typeof(TesteMarfrig.Model.Animal.Animal);
			// 
			// txtAnimal
			// 
			// 
			// 
			// 
			this.txtAnimal.CustomButton.Image = null;
			this.txtAnimal.CustomButton.Location = new System.Drawing.Point(361, 1);
			this.txtAnimal.CustomButton.Name = "";
			this.txtAnimal.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtAnimal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtAnimal.CustomButton.TabIndex = 1;
			this.txtAnimal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtAnimal.CustomButton.UseSelectable = true;
			this.txtAnimal.CustomButton.Visible = false;
			this.txtAnimal.Lines = new string[0];
			this.txtAnimal.Location = new System.Drawing.Point(96, 82);
			this.txtAnimal.MaxLength = 32767;
			this.txtAnimal.Name = "txtAnimal";
			this.txtAnimal.PasswordChar = '\0';
			this.txtAnimal.ReadOnly = true;
			this.txtAnimal.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtAnimal.SelectedText = "";
			this.txtAnimal.SelectionLength = 0;
			this.txtAnimal.SelectionStart = 0;
			this.txtAnimal.ShortcutsEnabled = true;
			this.txtAnimal.Size = new System.Drawing.Size(383, 23);
			this.txtAnimal.TabIndex = 106;
			this.txtAnimal.UseSelectable = true;
			this.txtAnimal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtAnimal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(96, 60);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(50, 19);
			this.metroLabel3.TabIndex = 107;
			this.metroLabel3.Text = "Animal";
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(404, 276);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(75, 23);
			this.metroButton1.TabIndex = 4;
			this.metroButton1.Text = "Sair";
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// frmCompraGadoItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 312);
			this.Controls.Add(this.metroButton1);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.txtAnimal);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.metroGrid1);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.txtQuantidade);
			this.MaximizeBox = false;
			this.Name = "frmCompraGadoItem";
			this.Text = "Compra de Gado Item";
			this.Load += new System.EventHandler(this.frmCompraGadoItem_Load);
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox txtQuantidade;
		private MetroFramework.Controls.MetroButton btnAlterar;
		private MetroFramework.Controls.MetroGrid metroGrid1;
		private MetroFramework.Controls.MetroTextBox txtAnimal;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroButton metroButton1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource animalBindingSource;
	}
}