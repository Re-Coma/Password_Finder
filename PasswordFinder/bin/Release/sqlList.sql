create table member (
	ID varchar(20) not null,
	Pswd varchar(20) not null
);

create table Info (
	Name varchar(128) not null,
	ID varchar(128) not null,
	Pswd varchar(128) not null
);

insert into member (ID, PSWD) values('1234', '1234');