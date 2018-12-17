using System;

namespace TesteMarfrig.Model.CompraGado
{
	public class CompraGado
	{
		public int? Id { get; set; }
		public DateTime? DataEntrega { get; set; }
		public DateTime? DataEntregaAte { get; set; }
		public int? PecuaristaId { get; set; }
		public int? Impresso { get; set; }
	}
}
