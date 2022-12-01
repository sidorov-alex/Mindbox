SELECT	Product.Name
	,	ISNULL(Category.Name, '')
	FROM
		Product
	LEFT JOIN
		ProductCategory ON Product.Id = ProductId
	LEFT JOIN
		Category ON CategoryId = Category.Id
    ORDER BY
		Product.Name;