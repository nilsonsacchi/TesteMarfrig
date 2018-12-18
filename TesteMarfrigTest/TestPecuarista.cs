using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteMarfrig.WebServiceMarfrig;

namespace TesteMarfrigTest
{
	[TestClass]
	public class TestPecuarista
	{
		WebServiceMarfrigSoapClient wbClinet = new WebServiceMarfrigSoapClient();
		Pecuarista classNova = new TesteMarfrig.WebServiceMarfrig.Pecuarista();

		[TestInitialize]
		public void Iniciarteste()
		{
			// ----- publicar metodo -----
		}

		[TestMethod]
		public void TestCreatePecuarista()
		{
			classNova.Id = 1;
			classNova.Nome = "Novo";

			int resultado = wbClinet.InserirPecuarista(classNova);

			Assert.AreEqual(resultado != 0, resultado);
		}

		[TestMethod]
		public void TestEditPecuarista()
		{
			classNova.Id = 1;
			classNova.Nome = "Novo";

			bool resultado = wbClinet.UpdatePecuarista(classNova);

			Assert.AreEqual(true, resultado);
		}

		[TestMethod]
		public void TestDeletePecuarista()
		{
			bool resultado = wbClinet.DeletePecuarista(1);

			Assert.AreEqual(true, resultado);
		}

		[TestCleanup]
		public void FinalizarTest()
		{
			// ----- publicar metodo -----
		}
	}
}
