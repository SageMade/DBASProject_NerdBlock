CREATE UNIQUE INDEX addr_3col_uni_indx ON tbladdress (streetaddress, state, country) 
    WHERE apartmentnumber IS NULL;
    
CREATE UNIQUE INDEX addr_4col_uni_indx ON tbladdress (streetaddress, state, country, apartmentnumber) 
    WHERE apartmentnumber IS NOT NULL;
	
CREATE UNIQUE INDEX empl_uni_sin ON tblemployees (sin);

alter table tbladdress drop constraint if exists addr_3col_uni_indx;
alter table tbladdress drop constraint if exists addr_4col_uni_indx;

create unique index addr_5col_uni on tbladdress (streetaddress, state, country, city, postalcode);
create unique index addr_6col_uni on tbladdress (streetaddress, state, country, city, postalcode, apartmentnumber);