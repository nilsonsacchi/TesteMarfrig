drop PROCEDURE ..sp_ConsultaCompraGado
(
	@id int = null,
	@PecuaristaId int = null,
	@DataEntregaDe datetime = null,
	@DataEntregaAte datetime = null
)
AS

SELECT cg.id, cg.PecuaristaId, p.Nome, cg.DataEntrega, COUNT(a.Id) QuantidadeItem,
SUM(cgi.Quantidade * a.Preco) AS ValoTotal, cg.Impresso
FROM CompraGado cg 
	INNER JOIN Pecuarista p ON p.id = cg.PecuaristaId 
	INNER JOIN CompraGadoItem cgi ON cgi.CompraGadoId = cg.Id 
	INNER JOIN Animal a ON a.id = cgi.AnimalId 
	WHERE 
		(@id             IS NULL OR cg.id = @id) AND
		(@PecuaristaId   IS NULL OR cg.PecuaristaId = @PecuaristaId) AND 
		(@DataEntregaDe  IS NULL OR cg.DataEntrega >= @DataEntregaDe) AND
		(@DataEntregaAte IS NULL OR cg.DataEntrega <= @DataEntregaAte)
	GROUP BY cg.id, cg.PecuaristaId, p.Nome, cg.DataEntrega, cg.Impresso
GO





drop PROCEDURE ..sp_Select_CompraGadoItem
(
	@id int output
)
AS
SELECT 
	a.descricao, cgi.quantidade, a.preco, cgi.quantidade * a.preco AS valortotal
FROM
	CompraGado cg
INNER JOIN CompraGadoItem cgi ON cgi.CompraGadoId = cg.Id
INNER JOIN Animal a ON a.id = cgi.AnimalId
WHERE cg.id = @id
GO
