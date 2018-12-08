CREATE TABLE dbo.Course
(	CourseID		Int not NULL,
	CourseNum		varchar(25) not NULL,
	CourseDesc		varchar(50) not NULL,
CONSTRAINT Customer_PK PRIMARY KEY (CourseID)
);

INSERT INTO dbo.Course (CourseID, CourseNum, CourseDesc) values ('1001', 'ISMG6080', 'Database Programming and Administration');
INSERT INTO dbo.Course (CourseID, CourseNum, CourseDesc) values ('1002', 'ISMG6470', 'Data Warehouse Design and Administration');
INSERT INTO dbo.Course (CourseID, CourseNum, CourseDesc) values ('1003', 'ISMG6020', '.Net Programming Fundamentals');
INSERT INTO dbo.Course (CourseID, CourseNum, CourseDesc) values ('1004', 'ISMG6240', '.Net Website Development');