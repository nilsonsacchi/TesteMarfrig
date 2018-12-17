using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServiceMarfrig.Models.Animal;

namespace WebServiceMarfrig
{
	/// <summary>
	/// Summary description for AnimalService
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class AnimalService : System.Web.Services.WebService
	{

		[WebMethod]
		public List<Animal> GetAll()
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				return db.Query<Animal>("SELECT * FROM Animal", commandType: CommandType.Text).ToList();
			}
		}

		[WebMethod]
		public int Inserir(Animal oAnimal)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSqlServer"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				DynamicParameters p = new DynamicParameters();
				p.AddDynamicParams(new { Descricao = oAnimal.Descricao, Preco = oAnimal.Preco});
				int resultado = db.Execute("sp_Inserir_Animal", p, commandType: CommandType.StoredProcedure);
				if (resultado != 0)
					return p.Get<int>("@Id");
				return 0;
			}
		}

		[WebMethod]
		public bool Update(Animal oAnimal)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSqlServer"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				int resultado = db.Execute("sp_Atualizar_Animal", new
				{
					Id = oAnimal.Id,
					Descricao = oAnimal.Descricao,
					Preco = oAnimal.Preco
				}, commandType: CommandType.StoredProcedure);
				return resultado != 0;
			}
		}

		[WebMethod]
		public bool Delete(int oAnimalId)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSqlServer"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				int resultado = db.Execute("DELETE FROM Animal WHERE Id = @Id", new { Id = oAnimalId }, commandType: CommandType.Text);
				return resultado != 0;
			}
		}
	}
}
