using TesteMarfrig.WebServiceMarfrig;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TesteMarfrigTest
{
	[TestClass]
	public class TestCompraGadoItem
	{
		WebServiceMarfrigSoapClient wbClinet = new WebServiceMarfrigSoapClient();
		CompraGadoItem classNova = new TesteMarfrig.WebServiceMarfrig.CompraGadoItem();

		[TestInitialize]
		public void Iniciarteste()
		{
			// ----- publicar metodo -----
		}

		[TestMethod]
		public void TestCreateCompraGadoItem()
		{
			classNova.Id = 1;
			classNova.AnimalId = 1;
			classNova.CompraGadoId = 1;
			classNova.Quantidade = 1;

			int resultado = wbClinet.InserirCompraGadoItem(classNova);

			Assert.AreEqual(resultado != 0, resultado);
		}

		[TestMethod]
		public void TestEditCompraGadoItem()
		{
			classNova.Id = 1;
			classNova.AnimalId = 1;
			classNova.CompraGadoId = 1;
			classNova.Quantidade = 1;

			bool resultado = wbClinet.UpdateCompraGadoItem(classNova);

			Assert.AreEqual(true, resultado);
		}

		[TestMethod]
		public void TestDeleteCompraGadoItem()
		{
			bool resultado = wbClinet.DeleteCompraGadoItem(1);

			Assert.AreEqual(true, resultado);
		}

		[TestCleanup]
		public void FinalizarTest()
		{
			// ----- publicar metodo -----
		}
	}
}
