using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServiceMarfrig.Models.CompraGado;

namespace WebServiceMarfrig
{
	/// <summary>
	/// Summary description for CompraGadoService
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class CompraGadoService : System.Web.Services.WebService
	{

		[WebMethod]
		public List<CompraGado> GetAll()
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				return db.Query<CompraGado>("SELECT * FROM CompraGado", commandType: CommandType.Text).ToList();
			}
		}

		[WebMethod]
		public int Inserir(CompraGado oGado)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSqlServer"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				DynamicParameters p = new DynamicParameters();
				p.Add("@Id", dbType: DbType.Int32, direction: ParameterDirection.Output);
				p.AddDynamicParams(new { DataEntrega = oGado.DataEntrega, PecuaristaId = oGado.PecuaristaId });
				int resultado = db.Execute("sp_Inserir_CompraGado", p, commandType: CommandType.StoredProcedure);
				if (resultado != 0)
					return p.Get<int>("@Id");
				return 0;
			}
		}

		[WebMethod]
		public bool Update(CompraGado oGado)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSqlServer"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				int resultado = db.Execute("sp_Atualizar_CompraGado", new
				{
					Id = oGado.Id,
					DataEntrega = oGado.DataEntrega					
				}, commandType: CommandType.StoredProcedure);
				return resultado != 0;
			}
		}

		[WebMethod]
		public bool Delete(int gadoId)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSqlServer"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				int resultado = db.Execute("DELETE FROM CompraGado WHERE Id = @Id", new { Id = gadoId }, commandType: CommandType.Text);
				return resultado != 0;
			}
		}
	}
}
