
--create and use database commands
CREATE DATABASE ShoppingCartDb;
use ShoppingCartDb;

--- creating users table
create table Users(UserId int PRIMARY KEY,
                   UserName varchar(25),
				   Pwd varchar(25),
				   ContactNumber varchar(10),
				   City VARCHAR(25));


---creating products  table
 create table Products(ProductId int PRIMARY KEY,
                   Name varchar(25) not null,
				   QuantityInStock int not null,
				   Unitprice int not null,
				   Category VARCHAR(25) not null,
				   CONSTRAINT  CHK_Products_QuantityInstock  CHECK (QuantityInstock > 0),
				   CONSTRAINT  CHK_products_UnitPrice  CHECK (UnitPrice  > 0));


--- creating cart table
create table Cart(Id int PRIMARY KEY,
                  CartId int not null,
				  ProductId int,
				  Quantity int not null,
				  CONSTRAINT  CHK_Cart_Quantity  CHECK (Quantity > 0),
				  CONSTRAINT  FK_Cart_Products  FOREIGN KEY (ProductId)
				  REFERENCES Products(ProductId)
				  ON DELETE CASCADE
	              ON UPDATE CASCADE);


---inserting values into users table
insert into Users values(1, 'JohnDoe', 'Password123', 9875551234, 'New York');
insert into Users values(2, 'JaneSmith', 'SecurePass456', 8765555678, 'Los Angeles');
insert into Users values(3, 'MikeBrown', 'Pass789', 9545559101, 'Chicago');
insert into Users values(4, 'EmilyDavis', 'MyPassword321', 9235551122, 'Houston');
insert into Users values(15, 'ChrisWilson', 'PassWord654', 9125553344, 'Phoenix');



----inserting values into products table
insert into Products values(101, 'Laptop', 50, 999, 'Electronics');
insert into Products values(102, 'Smartphone', 150, 699, 'Electronics');
insert into Products values(103, 'Desk Chair', 75, 89, 'Furniture');
insert into Products values(104, 'Coffee Maker', 200, 49, 'Appliances');
insert into Products values(105, 'Headphones', 120, 1999, 'Electronics');
insert into Products values(106, 'Headphones', 120, 8000, 'Electronics');
insert into Products values(107, 'Headphones', 120, 1899, 'Electronics');
insert into Products values(108, 'Headphones', 120, 6750, 'Electronics');

---invalid date to check constraints on product table
insert into Products values(105, 'phone', 120, 199, 'Electronics');
insert into Products values(106, null,0, 199, 'Electronics');
insert into Products values(108, 'Headphones', 120, 0, 'Electronics');


----inserting values into cart table
insert into Cart values(201, 501, 101, 2);  ---laptop id
insert into Cart values(202, 502, 102, 1);  ---smartphone id
insert into Cart values(203, 503, 103, 4);  ---desk chair id
insert into Cart values(204, 504, 104, 3);  ---coffeemaker id
insert into Cart values(205, 505, 105, 2);  ---headphones id
insert into Cart values(210, 505, null, 2);
insert into Cart values(211, 505, null, 2);


---invalid data to check constraints on cart table
insert into Cart values(205, 505, 105, 2);
insert into Cart values(207, null, 105, 2);
insert into Cart values(208, 505, 105, 0);
insert into Cart values(209, 505, 110, 2);





--- on products table
---displaying all products
select * from products;
---Display Products belongs to particular category
select * from products where category='electronics';
---Display out of stock products (means quantity is zero)
select * from products where QuantityInstock=0;
---Display the products which price between 1000 to 10000 
select * from products where UnitPrice<=10000 and UnitPrice>=1000;
select * from products where UnitPrice between 1000 and 10000;
---Display the product details based on the ProductId
select * from products where ProductId=106;



--- on cart table
---Display data based on the given CartId
select * from Cart where CartId=501;
select * from cart;
---Check is there any products added in Cart based on the ProductId
delete from cart where id=203;
select * from cart;
select Id, CartId, Name from Cart INNER JOIN Products on Cart.ProductId=Products.ProductId ;


----on users table
---Display All users
select * from users;
---Display user details based on ContactNumber
select * from users where ContactNumber='9875551234';
---Display user details based on UserId
select * from users where UserId=1;






