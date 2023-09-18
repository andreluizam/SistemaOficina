IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'Clientes' AND TYPE = 'U')
CREATE TABLE Clientes(
ID int NOT NULL primary key identity,
Nome varchar(60),
CpfCnpj varchar(15),
Telefone varchar(15),
Carro varchar(15),
Placa varchar(8),
Cep varchar(14),
Cidade varchar(30),
Estado varchar(2),
Bairro varchar(60),
Rua varchar(60)
)
GO

IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'Pecas' AND TYPE = 'U')
CREATE TABLE Pecas(
ID int NOT NULL primary key identity,
Nome varchar(60),
Tipo int,
Valor decimal(18,2),
Estoque decimal
)
GO

IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'Orcamentos' AND TYPE = 'U')
CREATE TABLE Orcamentos(
ID int NOT NULL primary key identity,
ClienteID int,
Data datetime,
Carro varchar(30),
Total decimal(18,2),
FOREIGN KEY (ClienteID) REFERENCES Clientes(ID))
GO

IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'OrcamentosItem' AND TYPE = 'U')
CREATE TABLE OrcamentosItem(
ID int NOT NULL primary key identity,
OrcamentoID int,
PecasID int,
Descricao varchar(60),
Quantidade decimal,
Valor decimal(18,2),
Subtotal decimal(18,2)
FOREIGN KEY (OrcamentoID) REFERENCES Orcamentos(ID),
FOREIGN KEY (PecasID) REFERENCES Pecas(ID)
)
GO

IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'Fornecedores' AND TYPE = 'U')
CREATE TABLE Fornecedores(
ID int NOT NULL primary key identity,
Nome varchar(200) not null,
Fantasia varchar(200),
CpfCnpj varchar(20),
Telefone varchar(50),
Situacao varchar(15),
DataCriacao varchar(12),
Cep varchar(18),
Cidade varchar(80),
Estado varchar(2),
Bairro varchar(120),
Rua varchar(120),
Numero varchar(10),
Email varchar (150),
)
GO