USE CLIENTES;

CREATE TABLE CLIENTE(
	
	ID INT IDENTITY PRIMARY KEY,
	NOME VARCHAR(50),
	DATA_CADASTRO DATETIME
	
);

CREATE NONCLUSTERED INDEX [IDX_CLIENTE__DATA_CADASTRO] ON [dbo].[CLIENTE] ([DATA_CADASTRO] ASC)