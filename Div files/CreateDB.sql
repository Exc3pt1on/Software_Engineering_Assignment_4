
CREATE TABLE [User]
( 
	[user_Id]            int  IDENTITY ( 1,1 )  NOT NULL ,
	[username]           char(7)  NULL ,
	[password]           char(64)  NULL ,
	CONSTRAINT [XPKUser] PRIMARY KEY  CLUSTERED ([user_Id] ASC)
)
go

CREATE TABLE [Checklist]
( 
	[checklist_Id]       int  IDENTITY ( 1,1 )  NOT NULL ,
	[title]              char(50)  NULL ,
	[description]        char(50)  NULL ,
	[created]            datetime  NULL ,
	[updated]            datetime  NULL ,
	[sign]               binary  NULL ,
	[shift]              char(1)  NULL ,
	[user_Id]            int  NULL ,
	CONSTRAINT [XPKChecklist] PRIMARY KEY  CLUSTERED ([checklist_Id] ASC),
	CONSTRAINT [R_1] FOREIGN KEY ([user_Id]) REFERENCES [User]([user_Id])
)
go

CREATE TABLE [Item]
( 
	[item_Id]            int  IDENTITY ( 1,1 )  NOT NULL ,
	[description]        char(50)  NULL ,
	[completed]          binary  NULL ,
	[position]           char(50)  NULL ,
	[checklist_Id]       int  NULL ,
	CONSTRAINT [XPKItems] PRIMARY KEY  CLUSTERED ([item_Id] ASC),
	CONSTRAINT [R_2] FOREIGN KEY ([checklist_Id]) REFERENCES [Checklist]([checklist_Id])
)
go
