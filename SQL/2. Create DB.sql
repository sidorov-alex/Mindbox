CREATE TABLE Product
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(255) NOT NULL
);

CREATE UNIQUE INDEX [IX_Product_Name] ON [Product] ([Name]);

CREATE TABLE Category
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(255) NOT NULL
);

CREATE UNIQUE INDEX [IX_Category_Name] ON [Category] ([Name]);

CREATE TABLE ProductCategory
(
	[ProductId] INT NOT NULL , 
    [CategoryId] INT NOT NULL, 
    PRIMARY KEY ([CategoryId], [ProductId]), 
    CONSTRAINT [FK_ProductCategory_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id]), 
    CONSTRAINT [FK_ProductCategory_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Category]([Id])
);

INSERT INTO Product (Id, Name) VALUES
    (1, 'Tea')
,   (2, 'Milk')
,   (3, 'Bread');

INSERT INTO Category (Id, Name) VALUES
    (1, 'Beverages')
,   (2, 'Milk Products');

INSERT INTO ProductCategory (ProductId, CategoryId) VALUES
    (1, 1)
,   (2, 1)
,   (2, 2);