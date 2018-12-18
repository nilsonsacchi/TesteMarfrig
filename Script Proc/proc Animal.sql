ALTER PROCEDURE ..sp_Inserir_Animal
(
	@Id int output,
	@Descricao varchar(50),
	@Preco numeric(10,2)
)
AS
	INSERT INTO Animal (Descricao, Preco)
	VALUES
	(@Descricao, @Preco)
	SET @Id = SCOPE_IDENTITY();
GO

ALTER PROCEDURE ..sp_Atualizar_Animal
(
	@Id int output,
	@Descricao varchar(50),
	@Preco numeric(10,2)
)
AS
	UPDATE Animal
	SET
		Descricao = @Descricao, 
		Preco = @Preco
	WHERE Id = @ID	
GO


select * from Animal