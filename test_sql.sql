SELECT
	CONCAT(p.Name,' - ',c.Name) AS ProductCategoryName
FROM Products p
LEFT JOIN ProductsCategories pc ON p.Id=pc.IdProduct
LEFT JOIN Categories c ON c.Id=pc.IdCategory