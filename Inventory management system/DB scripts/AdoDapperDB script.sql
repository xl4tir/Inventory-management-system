CREATE DATABASE AdoDapperDB COLLATE LATIN1_GENERAL_100_CI_AS_SC_UTF8;
GO
USE AdoDapperDB

CREATE TABLE Warehouses (
    [Id] [int] IDENTITY(1, 1) NOT NULL,
    CONSTRAINT PK_Warehouses_Id PRIMARY KEY (Id),
    [LocationId] [int] NULL,
    [Name] [nvarchar] (30)
)
GO

CREATE TABLE WarehouseProducts (
    [Id] [int] IDENTITY(1, 1) NOT NULL,
    CONSTRAINT PK_WarehouseProducts_Id PRIMARY KEY (Id),
    [WarehouseId] [int] NOT NULL FOREIGN KEY REFERENCES Warehouses(Id),
    [ProductId] [int],
    [Quantity] [int]
)
GO
    
CREATE TABLE PurchaseOrders (
    [Id] [int] IDENTITY(1, 1) NOT NULL,
    CONSTRAINT PK_PurchaseOrders_Id PRIMARY KEY (Id),
    [WarehouseId] [int] NOT NULL FOREIGN KEY REFERENCES Warehouses(Id),
    [Date] [date],
    [OrderStatusCode] [int],
    [TotalPrice] [decimal] (10, 2)
)
GO

CREATE TABLE PurchaseOrderProducts (
    [Id] [int] IDENTITY(1, 1) NOT NULL,
    CONSTRAINT PK_PurchaseOrderProducts_Id PRIMARY KEY (Id),
    [PurchaseOrderId] [int] NOT NULL FOREIGN KEY REFERENCES PurchaseOrders(Id),
    [ProductId] [int],
    [OrderedQuantity] [int]
)
GO

--Stored procedures
CREATE PROC GetAllProc
  @Table_Name sysname
AS
BEGIN
  DECLARE @DynamicSQL nvarchar(50);
  SET @DynamicSQL = 'SELECT * FROM ' + @Table_Name;
  EXEC (@DynamicSQL);
END
GO

CREATE PROC GetByIdProc
  @Table_Name sysname, @Id INT 
AS
BEGIN
  DECLARE @DynamicSQL nvarchar(70);
  SET @DynamicSQL = 'SELECT * FROM ' + @Table_Name + ' WHERE Id=' + CONVERT(nvarchar(10), @Id);
  EXEC (@DynamicSQL);
END
GO

CREATE PROC DeleteByIdProc
  @Table_Name sysname, @Id INT 
AS
BEGIN
  DECLARE @DynamicSQL nvarchar(70);
  SET @DynamicSQL = 'DELETE FROM ' + @Table_Name + ' WHERE Id=' + CONVERT(VARCHAR(10), @Id);
  EXEC (@DynamicSQL);
END
GO
--Stored procedures

--Warehouses insertation
INSERT INTO Warehouses ([LocationId], [Name])
VALUES
(21, N'Київський склад'),
(22, N'Дніпровський склад'),
(23, N'Луцький склад');
--Warehouses insertation

--WarehouseProducts insertation
INSERT INTO WarehouseProducts ([WarehouseId], [ProductId], [Quantity])
VALUES 
(1, 1, 4),
(1, 3, 1),
(1, 4, 20),
(1, 5, 2),
(1, 6, 1),
(1, 8, 52),
(1, 9, 10),
(1, 10, 3),
(1, 11, 2),
(2, 1, 5),
(2, 2, 8),
(2, 3, 3),
(2, 4, 2),
(2, 5, 3),
(2, 7, 78),
(2, 8, 70),
(2, 9, 10),
(2, 11, 10),
(2, 12, 5),
(3, 2, 0),
(3, 4, 10),
(3, 5, 4),
(3, 7, 49),
(3, 8, 98),
(3, 9, 1),
(3, 10, 2),
(3, 12, 7);
--WarehouseProducts insertation

--PurchaseOrders insertation
INSERT INTO PurchaseOrders ([WarehouseId], [Date], [OrderStatusCode], [TotalPrice])
VALUES 
(1, '2022-02-20', 3, 5855.00),
(2, '2022-02-23', 3, 6369.00),
(3, '2022-02-26', 3, 6734.00);
--PurchaseOrders insertation

--PurchaseOrderProducts insertation
INSERT INTO PurchaseOrderProducts ([PurchaseOrderId], [ProductId], [OrderedQuantity])
VALUES 
(1, 4, 20),
(1, 5, 5),
(1, 3, 3),
(1, 10, 3),
(1, 1, 8),
(1, 6, 4),
(1, 8, 73),
(1, 9, 12),
(1, 11, 5),
(2, 1, 5),
(2, 2, 8),
(2, 3, 3),
(2, 4, 8),
(2, 5, 5),
(2, 7, 78),
(2, 8, 70),
(2, 9, 10),
(2, 11, 10),
(2, 12, 5),
(3, 12, 13),
(3, 2, 4),
(3, 4, 15),
(3, 5, 8),
(3, 7, 60),
(3, 9, 5),
(3, 8, 110),
(3, 10, 5);
--PurchaseOrderProducts insertation