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
			this.rpRelatorio = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// rpRelatorio
			// 
			this.rpRelatorio.Location = new System.Drawing.Point(23, 63);
			this.rpRelatorio.Name = "rpRelatorio";
			this.rpRelatorio.ServerReport.BearerToken = null;
			this.rpRelatorio.Size = new System.Drawing.Size(626, 414);
			this.rpRelatorio.TabIndex = 0;
			// 
			// frmRelatorio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(672, 500);
			this.Controls.Add(this.rpRelatorio);
			this.Name = "frmRelatorio";
			this.Text = "Relatório";
			this.Load += new System.EventHandler(this.frmRelatorio_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rpRelatorio;
	}
}