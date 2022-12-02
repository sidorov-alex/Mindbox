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
		Product.Name AS ProductName
	,	ISNULL(
			(SELECT
				STRING_AGG(Category.Name, ', ')
			FROM
				ProductCategory
			INNER JOIN
				Category ON Category.Id = CategoryId
			WHERE
				ProductId = Product.Id
			)
		,	''
	)	AS Categories
	FROM
		Product
    ORDER BY
		Product.Name;