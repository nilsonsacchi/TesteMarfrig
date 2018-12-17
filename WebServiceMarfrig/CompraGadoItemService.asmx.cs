using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Services;
using WebServiceMarfrig.Models.CompraGadoItem;

namespace WebServiceMarfrig
{
	/// <summary>
	/// Summary description for CompraGadoItemService
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class CompraGadoItemService : System.Web.Services.WebService
	{

		[WebMethod]
		public List<CompraGadoItem> GetAll()
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				return db.Query<CompraGadoItem>("SELECT * FROM CompraGadoItem", commandType: CommandType.Text).ToList();
			}
		}

		[WebMethod]
		public int Inserir(CompraGadoItem oGadoItem)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSqlServer"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				DynamicParameters p = new DynamicParameters();
				p.Add("@Id", dbType: DbType.Int32, direction: ParameterDirection.Output);
				p.AddDynamicParams(new { Quantidade = oGadoItem.Quantidade, CompraGadoId = oGadoItem.CompraGadoId, AnimalId = oGadoItem.AnimalId });
				int resultado = db.Execute("sp_Inserir_CompraGadoItem", p, commandType: CommandType.StoredProcedure);
				if (resultado != 0)
					return p.Get<int>("@Id");
				return 0;
			}
		}

		[WebMethod]
		public bool Update(CompraGadoItem oGadoItem)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSqlServer"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				int resultado = db.Execute("sp_Atualizar_CompraGadoItem", new
				{
					Id = oGadoItem.Id,
					Quantidade = oGadoItem.Quantidade,
					CompraGadoId = oGadoItem.CompraGadoId,
					AnimalId = oGadoItem.AnimalId
				}, commandType: CommandType.StoredProcedure);
				return resultado != 0;
			}
		}

		[WebMethod]
		public bool Delete(int gadoItemId)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSqlServer"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				int resultado = db.Execute("DELETE FROM CompraGadoItem WHERE Id = @Id", new { Id = gadoItemId }, commandType: CommandType.Text);
				return resultado != 0;
			}
		}
	}
}
