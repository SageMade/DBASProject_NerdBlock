CREATE UNIQUE INDEX addr_3col_uni_indx ON tbladdress (streetaddress, state, country) 
    WHERE apartmentnumber IS NULL;
    
CREATE UNIQUE INDEX addr_4col_uni_indx ON tbladdress (streetaddress, state, country, apartmentnumber) 
    WHERE apartmentnumber IS NOT NULL;
	
CREATE UNIQUE INDEX empl_uni_sin ON tblemployees (sin);