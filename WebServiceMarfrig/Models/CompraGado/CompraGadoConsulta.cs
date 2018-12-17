using System;

namespace WebServiceMarfrig.Models.CompraGado
{
	public class CompraGadoConsulta
	{
		public int Id { get; set; }
		public int PecuaristaId { get; set; }
		public string Nome { get; set; }
		public DateTime DataEntrega { get; set; }
		public int QuantidadeItem { get; set; }
		public double ValorTotal { get; set; }
		public string Impresso { get; set; }
		public double? Preco { get; set; }
	}
}