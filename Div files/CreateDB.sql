CREATE DATABASE Ineos_Beredskap_Checklists
GO
USE Ineos_Beredskap_Checklists
GO


CREATE TABLE Checklist
( 
	checklist_Id         int  IDENTITY ( 1,1 )  NOT NULL ,
	title                char(50)  NULL ,
	description          char(50)  NULL ,
	created              datetime  NULL ,
	updated              datetime  NULL ,
	sign                 binary  NULL ,
	shift                char(1)  NULL ,
	operator_id          int  NULL ,
	approved             binary  NULL 
)
go

CREATE TABLE Item
( 
	item_Id              int  IDENTITY ( 1,1 )  NOT NULL ,
	description          char(50)  NULL ,
	completed            binary  NULL ,
	position             char(50)  NULL ,
	checklist_Id         int  NULL 
)
go

CREATE TABLE Operator
( 
	operator_id          int  IDENTITY ( 1,1 )  NOT NULL ,
	username             char(7)  NULL ,
	password             char(64)  NULL 
)
go

ALTER TABLE Checklist
	ADD PRIMARY KEY  CLUSTERED (checklist_Id ASC)
go

ALTER TABLE Item
	ADD PRIMARY KEY  CLUSTERED (item_Id ASC)
go

ALTER TABLE Operator
	ADD PRIMARY KEY  CLUSTERED (operator_id ASC)
go


ALTER TABLE Checklist
	ADD  FOREIGN KEY (operator_id) REFERENCES Operator(operator_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE Item
	ADD  FOREIGN KEY (checklist_Id) REFERENCES Checklist(checklist_Id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go
