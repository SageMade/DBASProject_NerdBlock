alter table tbladdress add postalcode varchar(10) not null default 'A0A0A0';
alter table tbladdress add city varchar(64) not null default 'unknown';

alter table tbladdress alter postalcode drop default;
alter table tbladdress alter city drop default;

drop table tblemployeejob;

alter table tblemployees add roleid integer not null references tblemployeerole(roleid) default 3;
alter table tblemployees alter roleid drop default;

alter table tblgenre drop isactive;

alter table tblblockseries add startdate date not null default now();
alter table tblblockseries add endeddate date;
alter table tblblock add shipbydate date not null default now();

alter table tblblockseries alter startdate drop default;
alter table tblblock alter shipbydate drop default;