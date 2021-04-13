select ProductName , Price , SupplierName, city, Country, CategoryName,Description from Products join Suppliers 
on Products.SupplierID = Suppliers.SupplierID 
join Categories 
on Products.CategoryID = Categories.CategoryID
where ProductName LIKE 'C%'

select ProductName , Price, SupplierName, city, Country, CategoryName, Description from Products join Suppliers 
on Products.SupplierID = Suppliers.SupplierID 
join Categories 
on Products.CategoryID = Categories.CategoryID
Where Price = (select min(price) from products)

select sum(Price) as 'Cost of all products' from Products join Suppliers 
on Products.SupplierID = Suppliers.SupplierID 
join Categories 
on Products.CategoryID = Categories.CategoryID
Where Country = 'USA'

select SupplierName, city, Country, products.SupplierID from Products join Suppliers 
on Products.SupplierID = Suppliers.SupplierID 
join Categories 
on Products.CategoryID = Categories.CategoryID
Where CategoryName = 'Condiments'


insert into Suppliers(SupplierName, City, Country) values ('Norske Meierier','Lviv','Urraine')
go                                                                 
DECLARE
@SupplierID INT =  (Select SupplierID from Suppliers where SupplierName='Norske Meierier'),
@CategoryID INT = (select CategoryID from Categories where CategoryName = 'Baverages')

insert into Products(ProductName,SupplierID,CategoryID,Price )  values('Green Tea',@SupplierID,@CategoryID, 10)