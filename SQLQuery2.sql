-- çalıştırmak istenilen kod seçilip çalıştırılırsa sadece seçilen kod çalışır.
--Selct 
Select ContactName,CompanyName,City from Customers

Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City='London'

--case insensitive büyük küçük duyarsızdır.

Select * from Products where CategoryID=1


Select * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>=30
Select * from Products where CategoryID=1 and UnitsInStock<>17

select * from Products order by ProductName --ürün ismine göre sırala

select * from Products order by CategoryID, ProductName

select * from Products order by UnitPrice asc -- ascending artan. varsayılan bu şekilde

select * from Products order by UnitPrice desc -- descending azalan.

select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) from Products --product tablosunda kaç tane kolon var, yani ürün var? demek

select count(*) from Products where CategoryID=2
select count(*) Adet from Products where CategoryID=2

select categoryId from Products group by CategoryID-- bütün kategorileri tekrar etmeyecek şekilde listele
select categoryId, count(*) from Products group by CategoryID--hangi kategoride kaç farklı ürün var?

select categoryId, count(*) from Products group by CategoryID having count (*)<10-- ürün sayıları 10 dan az sayıdaki olanları listele

select categoryId, count(*) from Products where UnitPrice>20 group by CategoryID having count (*)<10

--buradaki from hem products hem categorilerin bir araya gelmesidir. on ile neye göre birleştireceğini belirtiyorsun
select * from Products inner join Categories on Products.CategoryID=Categories.CategoryID 


select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories on Products.CategoryID=Categories.CategoryID 
-- c sharpta DTO (data transformation object) demek olacak.

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories on Products.CategoryID=Categories.CategoryID where products.UnitPrice>10
--inner join sadece iki tabloda eşleşen datayı getirir, eşleşmeyenleri getirmez.



-- köşeli parantez olmasının sebebi arasında boşluk olmaması gerekiyor onu tablo ismi alsın diye köşeli parantez. 
select * from Products p inner join [Order Details] od on p.ProductID=od.ProductID 

--hiç satış yapılmayan ürünler hangileri
select * from Products p left join [Order Details] od on p.ProductID=od.ProductID --left solda yazılan olup sağda olmayanları getirir
--"right join" sol joinin tersidir.
select * from Customers c left join Orders o on c.CustomerID=o.CustomerID


--sisteme kayıt olmuş ama ürün almamış kişiler kimler?
select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null

--ikiden fazla tabloyu birleştireceksek
select * from Products p inner join [Order Details] od on p.ProductID=od.ProductID inner join Orders o
on o.OrderID=od.OrderID