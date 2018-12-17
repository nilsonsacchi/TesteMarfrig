using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServiceMarfrig.Models.Pecuarista;

namespace WebServiceMarfrig
{
	/// <summary>
	/// Summary description for PecuaristaService
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class PecuaristaService : System.Web.Services.WebService
	{

		[WebMethod]
		public List<Pecuarista> GetAll()
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				return db.Query<Pecuarista>("SELECT * FROM Pecuarista", commandType: CommandType.Text).ToList();
			}
		}

		[WebMethod]
		public int Inserir(Pecuarista oPecuarista)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSqlServer"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				DynamicParameters p = new DynamicParameters();
				p.Add("@Id", dbType: DbType.Int32, direction: ParameterDirection.Output);
				p.AddDynamicParams(new { Nome = oPecuarista.Nome });
				int resultado = db.Execute("sp_Inserir_Pecuarista", p, commandType: CommandType.StoredProcedure);
				if (resultado != 0)
					return p.Get<int>("@Id");
				return 0;
			}
		}

		[WebMethod]
		public bool Update(Pecuarista oPecuarista)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSqlServer"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				int resultado = db.Execute("sp_Atualizar_Pecuarista", new
				{
					Id = oPecuarista.Id,
					Nome = oPecuarista.Nome
				}, commandType: CommandType.StoredProcedure);
				return resultado != 0;
			}
		}

		[WebMethod]
		public bool Delete(int oPecuaristaId)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSqlServer"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				int resultado = db.Execute("DELETE FROM Pecuarista WHERE Id = @Id", new { Id = oPecuaristaId }, commandType: CommandType.Text);
				return resultado != 0;
			}
		}
	}
}
