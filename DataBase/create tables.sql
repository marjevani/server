﻿
create table Customer
(
id nchar(9) primary key,
name nvarchar(10) not null,
pass char(9) not null,
isAdmin int check(isAdmin >= 0 & isAdmin <=1)
);
---------------------------
create table Movie
(
id int identity(1,1) primary key,
name nvarchar(30) not null,
publish_date date default(getdate()),
langth smallint check(langth > 0),
genre varchar(6) NOT NULL CHECK (genre IN('פעולה', 'מתח', 'קומדיה', 'דרמה', 'רומנטי', 'אימה'))
);
---------------------------
create table PlayTime
(
id int identity(1,1) primary key,
movie_id int foreign key references Movie(id),
play datetime not null,
total_sits int check(total_sits > 0),
availble_sits int default(0)
);
------------------------
create table CustomerBuyTickets
(
id int identity(1,1) primary key,
customer_id nchar(9) foreign key references Customer(id),
movie_id int foreign key references Movie(id),
amount int check(amount > 0)
);









