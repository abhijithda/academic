create database hotsoft;
use hotsoft;

create table login (
	name varchar(20) not null primary key,
	pass varchar(20) not null
);



create table account (
	uname varchar(20) references login(name),
	fname varchar(30) not null,
	mname varchar(30),
	lname varchar(30) not null,
	cid   varchar(100),
	email varchar(100) not null,
	passq varchar(100),
	passa varchar(100),
	elid  varchar(100),
	clid  varchar(100),
	degreeid varchar(100)
);



create table jdesc (
	id int(8) primary key  auto_increment,
	name varchar(30),
	cname varchar(50),
	email varchar(100),
	caddr varchar(100),
	country varchar(100),
	pincode varchar(20),
	phone varchar(20),
	jcat varchar(100),
	city varchar(100),
	jtitle varchar(100),
	jdesc varchar(250),
	jlevel varchar(100),
	jtype varchar(105),
	jstatus varchar(100),
	minpay varchar(10),
	maxpay varchar(10)
);


create table resume
(
	uname varchar(20) not null references login(name),
	title varchar(100) not null,
	rdesc varchar(250)
);


create table admin
(
	name varchar(20) not null primary key,
	pass varchar(20)
);
	
insert into admin values ('admin','admin');
insert into admin values ('abhijith','abhijith');
insert into admin values ('mahesh','mahesh');
