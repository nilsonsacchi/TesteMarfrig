using TesteMarfrig.WebServiceMarfrig;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TesteMarfrigTest
{
	[TestClass]
	public class TestCompraGado
	{
		WebServiceMarfrigSoapClient wbClinet = new WebServiceMarfrigSoapClient();
		CompraGado classNova = new TesteMarfrig.WebServiceMarfrig.CompraGado();

		[TestInitialize]
		public void Iniciarteste()
		{
			// ----- publicar metodo -----
		}

		[TestMethod]
		public void TestCreateCompraGado()
		{
			classNova.Id = 1;
			classNova.DataEntrega = Convert.ToDateTime("2018/01/01");
			classNova.PecuaristaId = 1;

			int resultado = wbClinet.InserirCompraGado(classNova);

			Assert.AreEqual(resultado != 0, resultado);
		}

		[TestMethod]
		public void TestEditCompraGado()
		{
			classNova.Id = 1;
			classNova.DataEntrega = Convert.ToDateTime("2018/01/01");
			classNova.PecuaristaId = 1;

			bool resultado = wbClinet.UpdateCompraGado(classNova);

			Assert.AreEqual(true, resultado);
		}

		[TestMethod]
		public void TestEditCompraGadoImpresso()
		{
			bool resultado = wbClinet.UpdateCompraGadoImpresso(1);

			Assert.AreEqual(true, resultado);
		}

		[TestMethod]
		public void TestDeleteCompraGado()
		{
			bool resultado = wbClinet.DeleteCompraGado(1);

			Assert.AreEqual(true, resultado);
		}

		[TestCleanup]
		public void FinalizarTest()
		{
			// ----- publicar metodo -----
		}
	}
}
