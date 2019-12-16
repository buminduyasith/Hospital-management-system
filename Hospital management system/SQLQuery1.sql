

create database hospital_management_system;


create table patientreg(
	
	id int identity(1,1),
	patientid varchar(16) not null,
	firstname varchar(52) not null,
	middelname varchar(52),
	lastname varchar(52) not null,
	gender char(8) not null,
	nid char(14) not null,
	relationship varchar(10),
	dob date not null,
	age int not null,
	mobileno char(10) not null,
	telephoneno char(10),
	email varchar(100) not null,
	city varchar(50) not null,
	address varchar(150) not null,
	dateofentry date,
	bloodgroup char(4) not null,

	constraint pk_nid primary key(patientid)



)

select * from patientreg

create table patientmedicalinfo(
	
	nid char(14),
	id int identity(1,1),
	bloodgroup varchar(5),
	kintype char(5),
	chronic char(10),
	primary key(id),
	foreign key(nid) references patientreg(nid)


)

create table medicalre(
	
	nid char(14),
	records varchar(150),
	updateddate date,
	foreign key(nid) references patientreg(nid)
)




create table receptionist(
	
	id int identity,
	recepid varchar(30) not null,
	honorific char(6) not null,
	fname varchar(50) not null,
	lname varchar(50) not null,
	dob date not null,
	age int not null,
	gender varchar(10) not null,
	nid varchar(15) unique not null,
	phonenum char(10) not null,
	email varchar(100) unique not null,
	
	
	primary key(recepid)



)
ALTER TABLE receptionist
ADD honorific char(6) not null;



drop table receptionist;
drop table userlogins;
drop table doctor;

select * from receptionist;
select * from userlogins;
select * from doctor;
select * from lastlogin;
select * from admins;

TRUNCATE TABLE receptionist;
TRUNCATE TABLE userlogins;
TRUNCATE TABLE doctor;

select lastdate from lastlogin where email='bumiduyasith@gmail.com'

create table userlogins(
	
	id int identity,
	email varchar(100) not null,
	password varchar(25) not null,
	nid varchar(15) unique not null,
	userrole varchar(20) not null,
	pwdchange int not null,
	docid varchar(30),
	recepid varchar(30),
	adminid varchar(30),
	primary key(email),
	foreign key(recepid) references receptionist(recepid),
	foreign key(docid) references doctor(docid),
	FOREIGN KEY (adminid) REFERENCES admins(adminid)
	
)

ALTER TABLE userlogins
ADD adminid varchar(30);

ALTER TABLE userlogins
ADD FOREIGN KEY (adminid) REFERENCES admins(adminid);

select * from userlogins;

create table doctor(
	
	id int identity,
	docid varchar(30) not null,
	fname varchar(50) not null,
	lname varchar(50) not null,
	specialization varchar(100) not null,
	gender char(8) not null,
	dob date not null,
	age int not null,
	dnid varchar(15) unique not null,
	phonenum char(10) not null,
	email varchar(100) unique not null,
	
	primary key(docid)



)

ALTER TABLE doctor
ADD UNIQUE (dnid);


select receptionist.recepid from receptionist,userlogins where userlogins.email ='bumiduyasith@gmail.com';


SELECT receptionist.recepid,fname,lname,receptionist.email,receptionist.nid
FROM receptionist
INNER JOIN userlogins ON receptionist.recepid=userlogins.recepid where userlogins.email='bumiduyasith@gmail.com';


create table lastlogin(
	
	lastdate datetime not null,
	email varchar(100) not null,
	foreign key(email) references userlogins(email)
)

create table admins(
	
	id int identity,
	adminid varchar(30) not null,
	honorific char(6) not null,
	fname varchar(50) not null,
	lname varchar(50) not null,
	dob date not null,
	age int not null,
	gender varchar(10) not null,
	nid varchar(15) unique not null,
	phonenum char(10) not null,
	email varchar(100) unique not null,
	
	
	primary key(adminid)



)

create table doctoravailable(
	
	int int identity,
	docid varchar(30),
	
	specialization varchar(100),
	dateis date,
	date_as_string varchar(100),
	time time(0),
	primary key(docid,dateis),
	foreign key(docid) references doctor(docid)
    


)

ALTER TABLE doctoravailable
ADD Endtime time(0);



drop table doctoravailable;
select *from doctoravailable;


truncate table doctoravailable;


select * from doctoravailable where specialization= "[A-z]" and dateis = '2019-11-10';


SELECT doctor.fname,doctor.lname,doctoravailable.docid,doctoravailable.specialization,doctoravailable.dateis,
doctoravailable.date_as_string,doctoravailable.time
FROM doctor
INNER JOIN doctoravailable ON doctoravailable.docid=doctor.docid where doctor.fname = 'yasith' or doctoravailable.specialization = ""

drop table channeling;

create table channeling(

	id int identity,

	honorifics varchar(10) not null,
	patientFName varchar(50) not null,
	patientLName varchar(50),
	Gender char(10) not null,
	age int not null,
	nic char(15) unique ,
	phonenum char(11) unique,
	email varchar(60) unique not null,
	city varchar(50) not null,
	doctorName varchar(50),
	doctorID varchar(30),
	specialization varchar(100),
	channelDate date not null,
	channelTIme time(0) not null,
	channelNum int not null,
	recepid varchar(30) not null,
	recepname varchar(100) not null,

	primary key(nic,channelNum),
	foreign key(doctorID) references doctor(docid),
	foreign key(recepid) references receptionist(recepid)


)

ALTER TABLE channeling
ADD Endtime time(0);

select * from channeling

select count(*) from channeling where doctorID ='DOC -2019- 29 -11-155416' and channelDate = '2019-12-01';

select lastdate from lastlogin where email='bro@gmail.com';

select pwdchange from userlogins where ;

update userlogins set pwdchange = 0 where email = 'thosh@gmail.com';