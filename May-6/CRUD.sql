CREATE TABLE Books(
	BookID INT PRIMARY KEY,
	Title VARCHAR(100),
	Author VARCHAR(100),
	Genre VARCHAR(50),
	Price DECIMAL(8,2),
	PublishedYear INT,
);

//INSERT
Insert INTO Books (BookID ,Title,Author,Genre,Price,PublishedYear) Values
	(1, 'Atomic Habits','James Clear','Self-help',499.00,2018),
	(2, 'The Alchemist','Paulo Coelho','Ficton',299.00,1993),
	(3,'Clean Code','Robert C.Martin','Programming',799.00,2008),
	(4, 'Sapiens','Yuval Noah Harari','History',599.00,2015);
//Select
Select * from Books;

Select * from Books where Price=499.00;

Select Title,Author from Books where Genre='Programming';

//Update
Update Books SET Genre= 'Programming Skills' Where Title='Clean Code';

//Delete

Delete from books where Price <600;