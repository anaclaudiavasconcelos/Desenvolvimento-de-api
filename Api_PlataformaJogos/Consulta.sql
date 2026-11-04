CREATE table Categorias(
Id INT Identity(1,1) PRIMARY KEY,
Nome NVARCHAR(50),
Descricao NVARCHAR(50),
);
GO

CREATE table Estudios(
Id INT Identity(1,1) PRIMARY KEY,
Nome NVARCHAR(50),
Pais NVARCHAR(50),

);
GO

CREATE table Usuarios(
Id INT Identity(1,1) PRIMARY KEY,
Email NVARCHAR(50),
Senha NVARCHAR(50)
);
GO