---1.  Implement the following requirements (Concept: Views) : 
select * from Products;
select avg(unitPrice) as avg from products;
---creating view
create view ProductsLessthanAverage2 
as
select ProductName, UnitPrice from Products where UnitPrice < (select avg(UnitPrice) from Products);
---displaying the view
select *from LowCostProducts;
---renaming view
exec sp_rename 'ProductsLessthanAverage2', 'LowCostProducts';
---dropiing view
drop view LowCostProducts;



---2.  Implement the following requirement using Stored Procedures and cursors
---creating procedure displaying products data
create procedure ProductsData
as
begin
     select * from products;
end
exec ProductsData;


---Find the total amount of each product :  Consider UnitsOnOrder, UnitPrice
alter procedure ProductsData2
as
begin
     select ProductName, UnitsOnOrder*UnitPrice as Totalamount from Products;
end;
exec ProductsData2;


---displaying product name and unitprice using cursors , displaying grand total, and total amount upto 2 decimal places
alter procedure ProductsData4
as
begin
DECLARE cursor_pro CURSOR
FOR SELECT ProductName, UnitPrice*UnitsOnOrder as TotalAmount FROM  Products;
DECLARE @ProductName VARCHAR(MAX),  @TotalAmount   DECIMAL(10,2),  @GrandTotal   DECIMAl(10,2) ;
set @GrandTotal=0.00;
OPEN cursor_pro;
FETCH NEXT FROM cursor_pro INTO @ProductName, @TotalAmount;

WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT @ProductName + ' - ' +  CAST(@TotalAmount AS varchar);
        FETCH NEXT FROM cursor_pro INTO @ProductName, @TotalAmount;
		set @GrandTotal=@GrandTotal+@TotalAmount;
    END;
 PRINT 'GrandTotal' + ' - ' +  CAST(@GrandTotal AS varchar);
	CLOSE cursor_pro;

deallocate cursor_pro;
End;
exec ProductsData4;
