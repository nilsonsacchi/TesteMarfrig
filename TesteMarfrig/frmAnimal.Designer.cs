namespace TesteMarfrig
{
	partial class frmAnimal
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
			this.btnCancelar = new MetroFramework.Controls.MetroButton();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.btnAlterar = new MetroFramework.Controls.MetroButton();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtId = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnSair = new MetroFramework.Controls.MetroButton();
			this.btnInserir = new MetroFramework.Controls.MetroButton();
			this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.txtPreco = new MetroFramework.Controls.MetroTextBox();
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(253, 276);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 8;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseSelectable = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// metroButton2
			// 
			this.metroButton2.Location = new System.Drawing.Point(172, 276);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(75, 23);
			this.metroButton2.TabIndex = 7;
			this.metroButton2.Text = "Excluir";
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(91, 276);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(75, 23);
			this.btnAlterar.TabIndex = 6;
			this.btnAlterar.Text = "Salvar";
			this.btnAlterar.UseSelectable = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(10, 60);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(53, 19);
			this.metroLabel2.TabIndex = 19;
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
			this.txtId.Location = new System.Drawing.Point(10, 82);
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
			this.metroLabel1.Location = new System.Drawing.Point(69, 60);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(65, 19);
			this.metroLabel1.TabIndex = 17;
			this.metroLabel1.Text = "Descrição";
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
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
			this.metroGrid1.Location = new System.Drawing.Point(10, 111);
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
			this.metroGrid1.Size = new System.Drawing.Size(468, 159);
			this.metroGrid1.TabIndex = 98;
			this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Código";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 50;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
			this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 250;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Preco";
			dataGridViewCellStyle2.Format = "C2";
			dataGridViewCellStyle2.NullValue = "0,00";
			this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn3.HeaderText = "Preço";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// animalBindingSource
			// 
			this.animalBindingSource.DataSource = typeof(TesteMarfrig.Model.Animal.Animal);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(403, 276);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 23);
			this.btnSair.TabIndex = 9;
			this.btnSair.Text = "Sair";
			this.btnSair.UseSelectable = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnInserir
			// 
			this.btnInserir.Location = new System.Drawing.Point(10, 276);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(75, 23);
			this.btnInserir.TabIndex = 5;
			this.btnInserir.Text = "Novo";
			this.btnInserir.UseSelectable = true;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// txtDescricao
			// 
			// 
			// 
			// 
			this.txtDescricao.CustomButton.Image = null;
			this.txtDescricao.CustomButton.Location = new System.Drawing.Point(305, 1);
			this.txtDescricao.CustomButton.Name = "";
			this.txtDescricao.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtDescricao.CustomButton.TabIndex = 1;
			this.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtDescricao.CustomButton.UseSelectable = true;
			this.txtDescricao.CustomButton.Visible = false;
			this.txtDescricao.Lines = new string[0];
			this.txtDescricao.Location = new System.Drawing.Point(69, 82);
			this.txtDescricao.MaxLength = 32767;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.PasswordChar = '\0';
			this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtDescricao.SelectedText = "";
			this.txtDescricao.SelectionLength = 0;
			this.txtDescricao.SelectionStart = 0;
			this.txtDescricao.ShortcutsEnabled = true;
			this.txtDescricao.Size = new System.Drawing.Size(327, 23);
			this.txtDescricao.TabIndex = 2;
			this.txtDescricao.UseSelectable = true;
			this.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(402, 60);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(43, 19);
			this.metroLabel3.TabIndex = 24;
			this.metroLabel3.Text = "Preço";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(-15, -15);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
			this.maskedTextBox1.TabIndex = 25;
			// 
			// txtPreco
			// 
			// 
			// 
			// 
			this.txtPreco.CustomButton.Image = null;
			this.txtPreco.CustomButton.Location = new System.Drawing.Point(54, 1);
			this.txtPreco.CustomButton.Name = "";
			this.txtPreco.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtPreco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPreco.CustomButton.TabIndex = 1;
			this.txtPreco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPreco.CustomButton.UseSelectable = true;
			this.txtPreco.CustomButton.Visible = false;
			this.txtPreco.Lines = new string[0];
			this.txtPreco.Location = new System.Drawing.Point(402, 82);
			this.txtPreco.MaxLength = 32767;
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.PasswordChar = '\0';
			this.txtPreco.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPreco.SelectedText = "";
			this.txtPreco.SelectionLength = 0;
			this.txtPreco.SelectionStart = 0;
			this.txtPreco.ShortcutsEnabled = true;
			this.txtPreco.Size = new System.Drawing.Size(76, 23);
			this.txtPreco.TabIndex = 3;
			this.txtPreco.UseSelectable = true;
			this.txtPreco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPreco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
			this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
			// 
			// frmAnimal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 315);
			this.Controls.Add(this.txtPreco);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.metroButton2);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.metroGrid1);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.txtDescricao);
			this.MaximizeBox = false;
			this.Name = "frmAnimal";
			this.Text = "Animal";
			this.TransparencyKey = System.Drawing.Color.Empty;
			this.Load += new System.EventHandler(this.frmAnimal_Load);
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton btnCancelar;
		private MetroFramework.Controls.MetroButton metroButton2;
		private MetroFramework.Controls.MetroButton btnAlterar;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTextBox txtId;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroGrid metroGrid1;
		private MetroFramework.Controls.MetroButton btnSair;
		private MetroFramework.Controls.MetroButton btnInserir;
		private MetroFramework.Controls.MetroTextBox txtDescricao;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource animalBindingSource;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private MetroFramework.Controls.MetroTextBox txtPreco;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
	}
}