using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteMarfrig.WebServiceMarfrig;

namespace TesteMarfrigTest
{
	[TestClass]
	public class TestAnimal
	{
		WebServiceMarfrigSoapClient wbClinet = new WebServiceMarfrigSoapClient();
		Animal classNova = new TesteMarfrig.WebServiceMarfrig.Animal();

		[TestInitialize]
		public void Iniciarteste()
		{
			// ----- publicar metodo -----
		}

		[TestMethod]
		public void TestCreateAnimal()
		{
			classNova.Id = 1;
			classNova.Descricao = "Novo";
			classNova.Preco = 12.0;

			int resultado = wbClinet.InserirAnimal(classNova);

			Assert.AreEqual(resultado != 0, resultado);
		}

		[TestMethod]
		public void TestEditAnimal()
		{
			classNova.Id = 1;
			classNova.Descricao = "Novo";
			classNova.Preco = 12.0;

			bool resultado = wbClinet.UpdateAnimal(classNova);

			Assert.AreEqual(true, resultado);
		}

		[TestMethod]
		public void TestDeleteAnimal()
		{
			bool resultado = wbClinet.DeleteAnimal(1);

			Assert.AreEqual(true, resultado);
		}

		[TestCleanup]
		public void FinalizarTest()
		{
			// ----- publicar metodo -----
		}
	}
}
