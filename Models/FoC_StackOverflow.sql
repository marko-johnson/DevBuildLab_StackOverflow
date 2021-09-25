create database FoC_StackOverflow;
use FoC_StackOverflow;


create table Questions (
    id int NOT NULL auto_increment,
    username varchar(30) NOT NULL,
    title varchar(30) NOT NULL,
    detail varchar(200),
    posted datetime ,
    category varchar(30),
    tags varchar(30),
    status int NOT NULL,  
    PRIMARY KEY (id)
);

create table Answers (
    id int NOT NULL auto_increment,
    username varchar(30) NOT NULL,
    detail varchar(200),
    questionID int,
    posted datetime,
    upvotes int,
    PRIMARY KEY (id),
    foreign key (QuestionID) references Questions(id)       
);
insert into Questions (ID, Username, Title, Detail, Posted, Category, Tags, Status) values (1,'ccopel','Business Analyst','What application should be used to write SQL?', '2021-09-20','SQL','Programming',1);
insert into Questions (ID, Username, Title, Detail, Posted, Category, Tags, Status) values (2,'mjohns','Associate Software Engineer','What application should be used to write C#?', '2021-09-19','C#','Programming',2);
insert into Questions (ID, Username, Title, Detail, Posted, Category, Tags, Status) values (3,'tsmith','Application Support Analyst','Microsoft Visual Studio keeps freezing.  What should I do?', '2021-09-21','C#','Applications',3);

insert into Answers (ID, Username, Detail, QuestionID, Posted, Upvotes) values (1,'wsmith','You should be using Microsoft Visual Studio',2, '2021-09-21',3);