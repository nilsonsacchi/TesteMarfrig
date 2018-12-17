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
using WebServiceMarfrig.Models.Animal;
using WebServiceMarfrig.Models.CompraGado;
using WebServiceMarfrig.Models.CompraGadoItem;

namespace WebServiceMarfrig
{
	/// <summary>
	/// Summary description for WebServiceMarfrig
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class WebServiceMarfrig : System.Web.Services.WebService
	{

		// --------------------------------- PESQUISAS -----------------------------
		[WebMethod]
		public List<CompraGadoItemSelect> GetCompraGadoItemPorCompraGado(int gadoId)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				DynamicParameters p = new DynamicParameters();
				p.AddDynamicParams(new { Id = gadoId });
				string select;
				select = "SELECT a.descricao, cgi.quantidade, a.preco, cgi.quantidade* a.preco AS valortotal, cgi.id FROM ";
				select = select + "CompraGado cg ";
				select = select + "INNER JOIN CompraGadoItem cgi ON cgi.CompraGadoId = cg.Id ";
				select = select + "INNER JOIN Animal a ON a.id = cgi.AnimalId ";
				select = select + "WHERE cg.id = @id";

				return db.Query<CompraGadoItemSelect>(select, p, commandType: CommandType.Text).ToList();
			}
		}

		[WebMethod]
		public List<CompraGadoConsulta> GetConsultaCompraGado (CompraGado compraGado)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				DynamicParameters p = new DynamicParameters();

				if (compraGado.Id != null)
					p.AddDynamicParams(new { Id = compraGado.Id });

				if (compraGado.PecuaristaId != null)
					p.AddDynamicParams(new { PecuaristaId = compraGado.PecuaristaId });

				if (compraGado.DataEntrega != null)
					p.AddDynamicParams(new { DataEntrega = compraGado.DataEntrega });

				if (compraGado.DataEntregaAte != null)
					p.AddDynamicParams(new { DataEntregaAte = compraGado.DataEntregaAte });

				string select = null;
				if (compraGado.Id == null)
					select = select + "DECLARE @id int = null ";

				if (compraGado.PecuaristaId == null)
					select = select + "DECLARE @PecuaristaId int = null ";

				if (compraGado.DataEntrega == null)
					select = select + "DECLARE @DataEntrega datetime = null ";

				if (compraGado.DataEntregaAte == null)
					select = select + "DECLARE @DataEntregaAte datetime = null ";

				select = select + "SELECT cg.id, cg.PecuaristaId, p.Nome, cg.DataEntrega, COUNT(a.Id) QuantidadeItem, ";
				select = select + "SUM(cgi.Quantidade * a.Preco) AS ValorTotal, CASE WHEN cg.Impresso = 0 THEN 'Não' ELSE 'SIM' END AS Impresso ";
				select = select + "FROM CompraGado cg ";
				select = select + "	INNER JOIN Pecuarista p ON p.id = cg.PecuaristaId ";
				select = select + "	LEFT JOIN CompraGadoItem cgi ON cgi.CompraGadoId = cg.Id ";
				select = select + "	LEFT JOIN Animal a ON a.id = cgi.AnimalId ";
				select = select + "	WHERE ";
				select = select + "		(@id             IS NULL OR cg.id = @id) AND ";
				select = select + "		(@PecuaristaId   IS NULL OR cg.PecuaristaId = @PecuaristaId) AND ";
				select = select + "		(@DataEntrega  IS NULL OR cg.DataEntrega >= @DataEntrega) AND ";
				select = select + "		(@DataEntregaAte IS NULL OR cg.DataEntrega <= @DataEntregaAte) ";
				select = select + "	GROUP BY cg.id, cg.PecuaristaId, p.Nome, cg.DataEntrega, cg.Impresso";

				return db.Query<CompraGadoConsulta>(select, p, commandType: CommandType.Text).ToList();
			}
		}

		[WebMethod]
		public List<CompraGadoConsulta> GetRelatorioCompraGado(int compraGadoId)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				DynamicParameters p = new DynamicParameters();

				p.AddDynamicParams(new { Id = compraGadoId });
				string select = null;
				select = "SELECT cg.id, p.Nome, cg.DataEntrega, COUNT(a.Id) QuantidadeItem, a.Preco, ";
				select = select + "SUM(cgi.Quantidade * a.Preco) AS ValorTotal ";
				select = select + "FROM CompraGado cg ";
				select = select + "	INNER JOIN Pecuarista p ON p.id = cg.PecuaristaId ";
				select = select + "	LEFT JOIN CompraGadoItem cgi ON cgi.CompraGadoId = cg.Id ";
				select = select + "	LEFT JOIN Animal a ON a.id = cgi.AnimalId ";
				select = select + "	WHERE ";
				select = select + "		(@id             IS NULL OR cg.id = @id) ";
				select = select + "	GROUP BY cg.id, p.Nome, cg.DataEntrega, a.Preco";

				return db.Query<CompraGadoConsulta>(select, p, commandType: CommandType.Text).ToList();
			}
		}

		// ---------------------------------------------- Pecuarista INICIO
		[WebMethod]
		public List<Pecuarista> GetAllPecuarista()
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
		public List<Pecuarista>GetAllPecuaristaCompraGado()
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				return db.Query<Pecuarista>("SELECT 0 AS Id, '---' AS Nome UNION SELECT * FROM Pecuarista", commandType: CommandType.Text).ToList();
			}
		}

		[WebMethod]
		public int InserirPecuarista(Pecuarista oPecuarista)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				DynamicParameters p = new DynamicParameters();
				//p.Add("@Id", dbType: DbType.Int32, direction: ParameterDirection.Output);
				p.AddDynamicParams(new { Nome = oPecuarista.Nome });
				int resultado = db.Execute("sp_Inserir_Pecuarista", p, commandType: CommandType.StoredProcedure);
				/*if (resultado != 0) 
					return p.Get<int>("@Id");*/
				return 0;
			}
		}

		[WebMethod]
		public bool UpdatePecuarista(Pecuarista oPecuarista)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
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
		public bool DeletePecuarista(int oPecuaristaId)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				int resultado = db.Execute("DELETE FROM Pecuarista WHERE Id = @Id", new { Id = oPecuaristaId }, commandType: CommandType.Text);
				return resultado != 0;
			}
		}
		// ---------------------------------------------- Pecuarista FIM  -------------------------------

		// ---------------------------------------------- Animal INICIO ---------------------------------
		[WebMethod]
		public List<Animal> GetAllAnimal()
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
		public List<Animal> GetAllAnimalCompraGadoItem(int compraGadoId)
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
		public int InserirAnimal(Animal oAnimal)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				DynamicParameters p = new DynamicParameters();
				//p.Add("@Id", dbType: DbType.Int32, direction: ParameterDirection.Output);
				p.AddDynamicParams(new { Descricao = oAnimal.Descricao, Preco = oAnimal.Preco });
				int resultado = db.Execute("sp_Inserir_Animal", p, commandType: CommandType.StoredProcedure);
				//if (resultado != 0)
					//return p.Get<int>("@Id");
				return 0;
			}
		}

		[WebMethod]
		public bool UpdateAnimal(Animal oAnimal)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
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
		public bool DeleteAnimal(int oAnimalId)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				int resultado = db.Execute("DELETE FROM Animal WHERE Id = @Id", new { Id = oAnimalId }, commandType: CommandType.Text);
				return resultado != 0;
			}
		}
		// ---------------------------------------------- Animal FIM ---------------------------------

		// ---------------------------------------------- CompraGado INICIO ---------------------------------
		[WebMethod]
		public List<CompraGado> GetAllCompraGado()
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
		public int InserirCompraGado(CompraGado oGado)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
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
		public bool UpdateCompraGado(CompraGado oGado)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				int resultado = db.Execute("sp_Atualizar_CompraGado", new
				{
					Id = oGado.Id,
					DataEntrega = oGado.DataEntrega,
					PecuaristaId = oGado.PecuaristaId
				}, commandType: CommandType.StoredProcedure);
				return resultado != 0;
			}
		}

		[WebMethod]
		public bool UpdateCompraGadoImpresso(int oGado)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				int resultado = db.Execute("sp_Atualizar_CompraGadoImpresso", new
				{
					Id = oGado
				}, commandType: CommandType.StoredProcedure);
				return resultado != 0;
			}
		}

		[WebMethod]
		public bool DeleteCompraGado(int gadoId)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				int resultado = db.Execute("DELETE FROM CompraGadoItem WHERE CompraGadoId = @Id; DELETE FROM CompraGado WHERE Id = @Id", new { Id = gadoId }, commandType: CommandType.Text);
				return resultado != 0;
			}
		}
		// ---------------------------------------------- CompraGado FIM ---------------------------------

		// ---------------------------------------------- CompraGadoItem INICIO ---------------------------------
		[WebMethod]
		public List<CompraGadoItem> GetAllCompraGadoItem()
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
		public int InserirCompraGadoItem(CompraGadoItem oGadoItem)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				DynamicParameters p = new DynamicParameters();
				//p.Add("@Id", dbType: DbType.Int32, direction: ParameterDirection.Output);
				p.AddDynamicParams(new { Quantidade = oGadoItem.Quantidade, CompraGadoId = oGadoItem.CompraGadoId, AnimalId = oGadoItem.AnimalId });
				int resultado = db.Execute("sp_Inserir_CompraGadoItem", p, commandType: CommandType.StoredProcedure);
				//if (resultado != 0)
					//return p.Get<int>("@Id");
				return 0;
			}
		}

		[WebMethod]
		public bool UpdateCompraGadoItem(CompraGadoItem oGadoItem)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
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
		public bool DeleteCompraGadoItem(int gadoItemId)
		{
			using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSql"].ConnectionString))
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				int resultado = db.Execute("DELETE FROM CompraGadoItem WHERE Id = @Id", new { Id = gadoItemId }, commandType: CommandType.Text);
				return resultado != 0;
			}
		}
		// ---------------------------------------------- CompraGadoItem FIM ---------------------------------
	}
}
