create table member(
pid	int identity(1,1) primary key,
id	nvarchar(15) not null,
pw	nvarchar(15) not null,
que nvarchar(20) not null,
ans nvarchar(20) not null
)

select * from member;

--alter table member alter column id nvarchar(15) not null;
--alter table member alter column pw nvarchar(15) not null;
--alter table member add que nvarchar(20) not null default '1+1?'with values;
--alter table member add ans nvarchar(20) not null default '2' with values;

--update member set id=N'나태주' where pid='5';
--update member set que=N'내가 쓴 시?',ans=N'풀꽃' where pid='5';

--insert into member values('hi','halo');
--insert into member values('HelloWorld','70');

--delete from member where pid = '2004';
--delete from member where pid = '12';


create table tblBrd(
num			int identity(1,1) primary key,
name		nvarchar(15) not null,
title		nvarchar(50) not null,
contents	ntext,
writedate	varchar(20),
readcnt		int
)

select * from tblBrd;

--alter table tblBrd alter column name nvarchar(15) not null

-- ALTER DATABASE Board SET IDENTITY_CACHE = OFF

--update tblBrd set name=N'나태주' where num='3';

--delete from tblBrd where name='123';

--insert into tblBrd values(N'hi', N'반갑습니다', N'Nice to meet U', '2020-11-07', 2);
--insert into tblBrd values(N'hi', N'Test Success', N'성공입니다', '2020-11-07', 2);

--update tblBrd set title='test4', writedate='2020-11-06', contents='aa' where title='test2';

--delete from tblBrd where num=2003;