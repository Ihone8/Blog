use Blog
go
create table [User]  --用户信息表
(
	[UserID] varchar(255) primary key,--编号
	[UserName] varchar(64) unique,--用户名
	[UserPwd] varchar(256) not null,--密码
	--[HeadImgeID] varchar(20), --头像
	[Phone] varchar(32) unique,--电话号码
	[Address] varchar(256),  --住址
	[Email] varchar(128),--邮箱
	[QQWeChar] varchar(64),--QQ/微信
	[FullName] varchar(64) not null,--姓名
	[Gender] varchar(2) not null,--性别
	[IDCard] char(18) not null,--身份证号码
	[AStatusID] int default 1,--可用（正常）
	[SecurityQuestion] varchar(64) not null,--密保问题
	[Answer] varchar(64) not null,--答案
	[Tips] varchar(64), --密码提示
	[Desc] varchar(1000) ,--说明
	[Autograph] varchar(192),--个人简述（相当于个性签名）
	[DateTime] datetime default getdate()--注册时间
)
go
--管理员账号
create table [Admin]
(
	AID int primary key identity,--ID
	AName varchar(32) not null,--管理员姓名
	ALoginName varchar(32) not null,--管理员用户名
	ALoginPwd varchar(128)--管理员密码
)
go
--文章类型表 ArticleType
create table ArticleType
(
	[ID] int primary key identity ,--类型编号
	[TypeName] varchar(24) unique,--类型名称
)
go
--文章发表 Article
create table Article
(
	[ArticleID] varchar(255) primary key ,--文章ID
	[UserID] varchar(255) references [User](UserID) not null,--用户ID
	[PublishTime] datetime default getdate() ,--发表时间
	[ArticleTitle] varchar(128) not null,--文章标题
	[ArticleTypeID] int references [ArticleType](ID) not null,--文章类型
	[ArticleContent] varchar(max) not null,--文章内容
	[Image] varchar(128) ,--相关图片
	[Video] varchar(128),--相关视频
	[ReadCount] int default 0--阅读（点击）量
)
go
--心得笔记表 Notes
create table Notes
(
	NotesID varchar(255) primary key, --心得笔记ID
	NotesImage varchar(255) not null,
	NoteTtile varchar(255) not null, --标题
	NoteTime datetime not null default(getdate()), --发布时间
	UserID varchar(255) references [User](UserID) not null, --作者
	NoteType int references [ArticleType](ID) not null, --类型
	NoteContent varchar(max) not null, --正文
)
go
--留言表
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

