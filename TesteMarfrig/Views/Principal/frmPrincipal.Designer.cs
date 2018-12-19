namespace TesteMarfrig
{
	partial class frmPrincipal
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.animalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pecuaristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.compraGadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relatórioDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(20, 60);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(885, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cadastroToolStripMenuItem
			// 
			this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animalToolStripMenuItem,
            this.pecuaristaToolStripMenuItem});
			this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
			this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
			this.cadastroToolStripMenuItem.Text = "Cadastro";
			// 
			// animalToolStripMenuItem
			// 
			this.animalToolStripMenuItem.Name = "animalToolStripMenuItem";
			this.animalToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.animalToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.animalToolStripMenuItem.Text = "&Animal";
			this.animalToolStripMenuItem.Click += new System.EventHandler(this.animalToolStripMenuItem_Click);
			// 
			// pecuaristaToolStripMenuItem
			// 
			this.pecuaristaToolStripMenuItem.Name = "pecuaristaToolStripMenuItem";
			this.pecuaristaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.pecuaristaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.pecuaristaToolStripMenuItem.Text = "&Pecuarista";
			this.pecuaristaToolStripMenuItem.Click += new System.EventHandler(this.pecuaristaToolStripMenuItem_Click);
			// 
			// comprasToolStripMenuItem
			// 
			this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraGadoToolStripMenuItem});
			this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
			this.comprasToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
			this.comprasToolStripMenuItem.Text = "Manutenção\\Relatório";
			// 
			// compraGadoToolStripMenuItem
			// 
			this.compraGadoToolStripMenuItem.Name = "compraGadoToolStripMenuItem";
			this.compraGadoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
			this.compraGadoToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
			this.compraGadoToolStripMenuItem.Text = "&Consulta de compra do gado";
			this.compraGadoToolStripMenuItem.Click += new System.EventHandler(this.compraGadoToolStripMenuItem_Click);
			// 
			// relatóriosToolStripMenuItem
			// 
			this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeComprasToolStripMenuItem});
			this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
			this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
			this.relatóriosToolStripMenuItem.Text = "Relatórios";
			this.relatóriosToolStripMenuItem.Visible = false;
			// 
			// relatórioDeComprasToolStripMenuItem
			// 
			this.relatórioDeComprasToolStripMenuItem.Name = "relatórioDeComprasToolStripMenuItem";
			this.relatórioDeComprasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.relatórioDeComprasToolStripMenuItem.Size = new System.Drawing.Size(340, 22);
			this.relatórioDeComprasToolStripMenuItem.Text = "&Relatório de movimentações de compra";
			this.relatórioDeComprasToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeComprasToolStripMenuItem_Click);
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(925, 525);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmPrincipal";
			this.Text = "Marfrig";
			this.TransparencyKey = System.Drawing.Color.Empty;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem animalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pecuaristaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem compraGadoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem relatórioDeComprasToolStripMenuItem;
	}
}