---Consider the Products table and Cart table 
---Write a Query to display the results from the above two tables:
---CartId,  ProductName, Quantity, UnitPrice
---Try to appy inner join,  right outer join , left outer join and full outer join on the above tables.
select c.CartId,  p.Name, c.Quantity, p.UnitPrice from Cart as c INNER JOIN Products as p on c.ProductId=p.ProductId;
select c.CartId,  p.Name, c.Quantity, p.UnitPrice from Cart as c LEFT OUTER JOIN Products as p on c.ProductId=p.ProductId;
select c.CartId,  p.Name, c.Quantity, p.UnitPrice from Cart as c RIGHT OUTER JOIN Products as p on c.ProductId=p.ProductId;
select c.CartId,  p.Name, c.Quantity, p.UnitPrice from Cart as c FULL OUTER JOIN Products as p on c.ProductId=p.ProductId;

---create student table
create table student(StudentId int Primary Key,
                     StudentName varchar(25),
					 Course varchar(25),
					 city varchar(25));

---inserting values into student table
INSERT INTO student VALUES
(1, 'John Doe', 'Angular', 'Hyderabad'),
(2, 'Jane Smith', 'HTML', 'Pune'),
(3, 'Alice Jones', 'CSS', 'Kolkata'),
(4, 'Bob Brown', 'React', 'Chennai'),
(5, 'Carol White', '.NET', 'Mumbai'),
(6, 'David Black', 'Angular', 'Pune'),
(7, 'Eva Green', 'HTML', 'Hyderabad'),
(8, 'Frank Blue', 'CSS', 'Mumbai'),
(9, 'Grace Yellow', 'React', 'Kolkata'),
(10, 'Henry Purple', '.NET', 'Chennai');


---Find out how many Students are joined for "Angular"  Course
select count(*) from student where course='Angular';
---Find out how many Students are joined from  "Hyderabad"  City
select count(*) from student where city='hyderabad';
---Display No. of Students are join from each  City based 
select count(*) as count, city from student group by city;
---Display No. of Students are join from each  Course  based 
select count(*) as count, course from student group by course;
---Display the counts  by grouping based on  city, course 
select count(*),course, city from student group by course, city;



---subqueries
---Display the products if any items exists in the cart table
SELECT * FROM products  
WHERE EXISTS (SELECT * FROM cart WHERE cart.productid=products.ProductId);
---Display the cart items whoe product price greater than 5000 
select * from cart where Productid in (select productid from Products where UnitPrice>100);

