select * from dc;
select * from dcgrid;
REVOKE
create table dcdetails(dcno int not null primary key,dcdate varchar(20),suppliername varchar(60),toconcern varchar(60),refer varchar(20),vehicleno varchar(20),purpose varchar(20));
alter table dcdetails add purpose varchar(50);  
select * from dcdetails;
insert into dcdetails(dcno,dcdate,suppliername,toconcern,reference,vehicleno,purpose) values(11,to_date('23-03-2021','dd/mm/yyyy'),'NAKULAN TEX','ARUL TEX','RAM',124,'ITEM CHAGED')
drop table dcdetails
insert into dcdetails(dcno,dcdate,suppliername,toconcern,refer,vehicleno,purpose) values (10,'23-03-2021','NAKULAN TEX                   ','EASTMAN                                           ','dinesh','tn369635','changed')

CREATE TABLE DCGRID(SNO INT PRIMARY KEY NOT NULL,CRDATE VARCHAR(20),PNAME VARCHAR(20),COLOR VARCHAR(20),PSIZE VARCHAR(20),QTY NUMBER(10));
insert into DCGRID values(2,'COTTON CLOTH ','BLUE','S',5)
UPDATE dcgrid SET PNAME='cotton',COLOR='GREEN            ',PSIZE=80,QTY='5' WHERE SNO =2;
select * from dcgrid ORDER BY SNO
commit;
ALTER TABLE TESTDB.DCGRID
MODIFY(PSIZE VARCHAR(20));
CREATE TABLE dcgrid
(
  sno    INTEGER NOT NULL primary key, 
  pname  CHAR(20),
  color  CHAR(10),
  psize   VARCHAR(20),
  qty    NUMBER
)
SELECT * FROM DCGRID;


CREATE TABLE DCUREG(USERID INT NOT NULL PRIMARY KEY,USERNAME VARCHAR(30),PASSWORD VARCHAR(30),REPASSWORD VARCHAR(30),EMAILID VARCHAR(20),MOBILENO NUMBER(10),AROLE CHAR(1));
INSERT INTO DCUREG VALUES(1,'Admin','123','123','admin123@gmail.com',9325874123,'y')

SELECT * FROM DCUREG
SELECT arole FROM dcUREG WHERE USERNAME
select dcno,suppliername,toconcern,refer,vehicleno,purpose from dcdetails where dcno= 18

create table tblFiles(Id int,Name varchar(20),Data blob)
select * from tblFiles

SELECT * FROM dcdetails

alter table dcgrid add CRDATE VARCHAR(20)

UPDATE DCGRID SET CRDATE='01-04-2021' WHERE SNO=3; 

update dcdetails set dcdate='02-04-2021' where dcno='13';

SELECT DCNO,SUPPLIERNAME,TOCONCERN,REFER,SNO,PNAME,COLOR,PSIZE,QTY,VEHICLENO,PURPOSE FROM DCDETAILS,DCGRID WHERE  CRDATE BETWEEN '15-02-2021'AND'30-03-2021' AND DCDATE =CRDATE


SELECT DCNO,SUPPLIERNAME,TOCONCERN,REFER FROM DCDETAILS WHERE DCDATE BETWEEN '15-02-2021' AND '30-03-2021';

SELECT SNO,PNAME,COLOR,PSIZE,QTY FROM DCGRID WHERE CRDATE BETWEEN '12-02-2021'AND '25-02-2021';
SELECT DCNO,SUPPLIERNAME,TOCONCERN,REFER,SNO,PNAME,COLOR,PSIZE,QTY,VEHICLENO,PURPOSE FROM DCDETAILS,DCGRID WHERE CRDATE BETWEEN '02-02-2021'AND '29-04-2021' AND DCDATE BETWEEN ('02-02-2021','dd/MM/yyyy') AND ('29-04-2021','dd/MM/yyyy');

S
INSERT INTO DCGRID VALUES(15,'12-03-2021','NEW BRIEF','PINK','M',25);

UPDATE DCGRID SET 

SELECT DCNO,SUPPLIERNAME,TOCONCERN,REFER,SNO,PNAME,COLOR,PSIZE,QTY,VEHICLENO,PURPOSE FROM DCDETAILS,DCGRID WHERE CRDATE BETWEEN '01-04-2021' AND '03-04-2021'AND DCDATE BETWEEN '01-04-2021' AND '03-04-2021' ORDER BY DCNO

DELETE FROM DCDETAILS WHERE DCNO=5;