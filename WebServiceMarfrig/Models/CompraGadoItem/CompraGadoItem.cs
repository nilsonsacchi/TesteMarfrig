using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceMarfrig.Models.CompraGadoItem
{
	public class CompraGadoItem
	{
		public int Id { get; set; }
		public int Quantidade { get; set; }
		public int CompraGadoId { get; set; }
		public int AnimalId { get; set; }
	}
}