use Blog
go
create table [User]  --�û���Ϣ��
(
	[UserID] varchar(255) primary key,--���
	[UserName] varchar(64) unique,--�û���
	[UserPwd] varchar(256) not null,--����
	--[HeadImgeID] varchar(20), --ͷ��
	[Phone] varchar(32) unique,--�绰����
	[Address] varchar(256),  --סַ
	[Email] varchar(128),--����
	[QQWeChar] varchar(64),--QQ/΢��
	[FullName] varchar(64) not null,--����
	[Gender] varchar(2) not null,--�Ա�
	[IDCard] char(18) not null,--���֤����
	[AStatusID] int default 1,--���ã�������
	[SecurityQuestion] varchar(64) not null,--�ܱ�����
	[Answer] varchar(64) not null,--��
	[Tips] varchar(64), --������ʾ
	[Desc] varchar(1000) ,--˵��
	[Autograph] varchar(192),--���˼������൱�ڸ���ǩ����
	[DateTime] datetime default getdate()--ע��ʱ��
)
go
--����Ա�˺�
create table [Admin]
(
	AID int primary key identity,--ID
	AName varchar(32) not null,--����Ա����
	ALoginName varchar(32) not null,--����Ա�û���
	ALoginPwd varchar(128)--����Ա����
)
go
--�������ͱ� ArticleType
create table ArticleType
(
	[ID] int primary key identity ,--���ͱ��
	[TypeName] varchar(24) unique,--��������
)
go
--���·��� Article
create table Article
(
	[ArticleID] varchar(255) primary key ,--����ID
	[UserID] varchar(255) references [User](UserID) not null,--�û�ID
	[PublishTime] datetime default getdate() ,--����ʱ��
	[ArticleTitle] varchar(128) not null,--���±���
	[ArticleTypeID] int references [ArticleType](ID) not null,--��������
	[ArticleContent] varchar(max) not null,--��������
	[Image] varchar(128) ,--���ͼƬ
	[Video] varchar(128),--�����Ƶ
	[ReadCount] int default 0--�Ķ����������
)
go
--�ĵñʼǱ� Notes
create table Notes
(
	NotesID varchar(255) primary key, --�ĵñʼ�ID
	NotesImage varchar(255) not null,
	NoteTtile varchar(255) not null, --����
	NoteTime datetime not null default(getdate()), --����ʱ��
	UserID varchar(255) references [User](UserID) not null, --����
	NoteType int references [ArticleType](ID) not null, --����
	NoteContent varchar(max) not null, --����
)
go
--���Ա�
create table words
(
	wordID varchar(255) primary key ,
	worddate datetime not null default(getdate()),
	UserID varchar(255) ,
	wordContent varchar(max) not null,
	wordState int default(0) not null,
)

select * from [User]
select * from [Admin]
select U.UserName,T.TypeName,A.* from [Article] A left join ArticleType T on A.ArticleTypeID=T.ID left join [User] U on A.UserID=A.UserID

