<h3>Вопрос №3: 

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.</h3>

```sql
SELECT P.Name AS ProductName, C.Name AS CategoryName
FROM Products P
LEFT JOIN ProductCategories PC ON P.ProductID = PC.ProductID
LEFT JOIN Categories C ON PC.CategoryID = C.CategoryID;
```

