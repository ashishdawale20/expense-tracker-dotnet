create table Category
( 
id int primary key identity (1,1),
name varchar(20)
)

create table TransactionType
(
id int primary key identity (1,1),
name varchar(20)
)

create table TransactionHistory
(
id int primary key identity (1,1),
transactionType int foreign key references TransactionType(id),
place varchar(50),
[description] varchar(500),
categoryId int foreign key references Category(id),
currency char(3),
amount decimal,
note varchar(10),
tags varchar(20)
)
