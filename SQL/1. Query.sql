SELECT
		Product.Name AS ProductName
	,	ISNULL(Category.Name, '') AS CategoryName
	FROM
		Product
	LEFT JOIN
		ProductCategory ON Product.Id = ProductId
	LEFT JOIN
		Category ON CategoryId = Category.Id
    ORDER BY
		Product.Name;

SELECT
		Product.Id AS ProductId
	,	Product.Name AS ProductName
	,	ISNULL(STRING_AGG(Category.Name, ', '), '') AS CategoryName
	FROM
		Product
	LEFT JOIN
		ProductCategory ON Product.Id = ProductId
	LEFT JOIN
		Category ON CategoryId = Category.Id
    GROUP BY
    	Product.Id, Product.Name
    ORDER BY
		Product.Name;