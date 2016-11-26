DROP DATABASE IF EXISTS dbNerdBlock;
CREATE DATABASE dbNerdBlock;

DROP TABLE IF EXISTS tblAddress;
DROP TABLE IF EXISTS tblCustomers;
DROP TABLE IF EXISTS tblEmployees;
DROP TABLE IF EXISTS tblEmployeeRole;
DROP TABLE IF EXISTS tblEmployeeJob;
DROP TABLE IF EXISTS tblBillingInfo;
DROP TABLE IF EXISTS tblGenre;
DROP TABLE IF EXISTS tblBlockSeries;
DROP TABLE IF EXISTS tblSubscription;
DROP TABLE IF EXISTS tblPaymentInstance;
DROP TABLE IF EXISTS tblTicket;
DROP TABLE IF EXISTS tblProduct;
DROP TABLE IF EXISTS tblProductNote;
DROP TABLE IF EXISTS tblTicketNote;
DROP TABLE IF EXISTS tblBlock;
DROP TABLE IF EXISTS tblBlockItem;
DROP TABLE IF EXISTS tblSubscriptionFullfillment;
DROP TABLE IF EXISTS tblSupplierContact;
DROP TABLE IF EXISTS tblOrder;
DROP TABLE IF EXISTS tblMortarStore;
DROP TABLE IF EXISTS tblTransfer;
DROP TABLE IF EXISTS tblSupplier;

CREATE TABLE tblAddress (
	AddressId serial PRIMARY KEY,
	StreetAddress VARCHAR(100) NOT NULL,
	State VARCHAR (30) NOT NULL,
	Country VARCHAR (40) NOT NULL,
	ApartmentNumber INT,
	Specialrequests TEXT
);

CREATE TABLE tblCustomers (
	CustomerId serial PRIMARY KEY,
	Email VARCHAR(255) NOT NULL,
	DateJoined DATE NOT NULL,
	Username VARCHAR(30) NOT NULL,
	HashedPass VARCHAR(32) NOT NULL,
	LoginToken VARCHAR(255),
	PasswordResetToken VARCHAR(255),
	FirstName VARCHAR(30) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	HomeAddress INT NOT NULL REFERENCES tblAddress(AddressId),
	BillingAddress INT REFERENCES tblAddress(AddressId)
);

CREATE TABLE tblEmployees (
	EmployeeId serial PRIMARY KEY,
	DateJoined DATE NOT NULL,
	SIN VARCHAR(9) NOT NULL,
	FirstName VARCHAR(30) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	Phone BIGINT,
	Email VARCHAR(100),
	HomeAddress INT NOT NULL REFERENCES tblAddress(AddressId),
	TerminationDate DATE 
);

CREATE TABLE tblEmployeeRole (
	RoleId serial PRIMARY KEY,
	Name VARCHAR(50) NOT NULL,
	Description VARCHAR (100) NOT NULL
);

CREATE TABLE tblEmployeeJob (
	EmployeeId INT NOT NULL REFERENCES tblEmployees(EmployeeId),
	RoleId INT NOT NULL REFERENCES tblEmployeeRole(RoleId),
	PRIMARY KEY (EmployeeId, RoleId)
);

CREATE TABLE tblBillingInfo (
	BillingInfoId serial PRIMARY KEY,
	PaymentType VARCHAR(10) NOT NULL,
	Address INT REFERENCES tblAddress(AddressId),
	AccountNum BIGINT,
	Token VARCHAR(255)
);

CREATE TABLE tblGenre (
	GenreId serial PRIMARY KEY,
	Title VARCHAR(32) NOT NULL,
	Description TEXT NOT NULL,
	IsActive BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE tblBlockSeries (
	SeriesId serial PRIMARY KEY,
	GenreId INT NOT NULL REFERENCES tblGenre(GenreId),
	Title VARCHAR(32) NOT NULL,
	SubscriptionPrice MONEY NOT NULL,
	BlockVolume INT NOT NULL
);

CREATE TABLE tblSubscription (
	SubscriptionId serial PRIMARY KEY,
	CustomerId INT NOT NULL REFERENCES tblCustomers(CustomerId),
	SeriesId INT NOT NULL REFERENCES tblBlockSeries(SeriesId),
	StartedOn DATE NOT NULL,
	EndedOn DATE,
	BillingType VARCHAR(2) NOT NULL,
	ShippingAddress INT NOT NULL REFERENCES tblAddress(AddressId)
);

CREATE TABLE tblPaymentInstance (
	SubscriptionId INT NOT NULL REFERENCES tblSubscription(SubscriptionId),
	PaymentDate DATE NOT NULL,
	BillingInfoId INT NOT NULL REFERENCES tblBillingInfo(BillingInfoId),
	IsPayed BOOLEAN NOT NULL DEFAULT FALSE,
	PRIMARY KEY (SubscriptionId,PaymentDate)
);
/*
CREATE TABLE tblTicket (
	TicketId serial PRIMARY KEY,
	CustomerId INT NOT NULL REFERENCES tblCustomers(CustomerId),
	HandledBy INT NOT NULL REFERENCES tblEmployees(EmployeeId),
	Title VARCHAR(255) NOT NULL,
	Issue TEXT NOT NULL,
	CreatedOn DATE NOT NULL,
	ResolvedOn DATE
);
*/
CREATE TABLE tblProduct (
	ProductId serial PRIMARY KEY,
	Name VARCHAR(255) NOT NULL,
	Description TEXT NOT NULL,
	Width DECIMAL NOT NULL,
	Height DECIMAL NOT NULL,
	Depth DECIMAL NOT NULL,
	NumDamaged INT
);
/*
CREATE TABLE tblProductNote (
	ProductId INT NOT NULL REFERENCES tblProduct(ProductId),
	NoteId SERIAL NOT NULL,
	Note VARCHAR(100) NOT NULL,
	Poster INT NOT NULL REFERENCES tblEmployees(EmployeeId),
	CreatedOn TIMESTAMP NOT NULL,
	PRIMARY KEY (ProductId,NoteId)
);

CREATE TABLE tblTicketNote (
	TicketId INT NOT NULL REFERENCES tblTicket(TicketId),
	NoteId serial,
	Content VARCHAR(100) NOT NULL,
	CreatedOn DATE NOT NULL,
	IsStaffResponse BOOLEAN NOT NULL
);
*/
CREATE TABLE tblBlock (
	BlockId serial PRIMARY KEY,
	SeriesId INT NOT NULL REFERENCES tblBlockSeries(SeriesId),
	Title VARCHAR(255) NOT NULL,
	Description TEXT NOT NULL
);

CREATE TABLE tblBlockItem (
	BlockId INT NOT NULL REFERENCES tblBlock(BlockId),
	ProductId INT NOT NULL REFERENcES tblProduct(ProductId),
	Quantity INT NOT NULL DEFAULT 1,
	PRIMARY KEY (BlockId,ProductId)
);

CREATE TABLE tblSubscriptionFullfillment (
	SubscriptionId INT NOT NULL REFERENCES tblSubscription(SubscriptionId),
	BlockId INT NOT NULL REFERENCES tblBlock(BlockId),
	TrackingNumber VARCHAR(255) NOT NULL,
	FullfillingEmployee INT NOT NULL REFERENCES tblEmployees(EmployeeId),
	PRIMARY KEY (SubscriptionId,BlockId)
);

CREATE TABLE tblSupplier (
	SupplierId serial PRIMARY KEY,
	Company VARCHAR(255) NOT NULL,
	Address INT NOT NULL REFERENCES tblAddress(AddressId),
	Phone BIGINT NOT NULL
);

CREATE TABLE tblSupplierContact (
	ContactId serial PRIMARY KEY,
	Company INT NOT NULL REFERENCES tblSupplier(SupplierId),
	FirstName VARCHAR(255) NOT NULL,
	LastName VARCHAR(255) NOT NULL,
	PhoneNumber BIGINT NOT NULL,
	Email VARCHAR(255) NOT NULL
);

CREATE TABLE tblOrder (
	OrderId serial PRIMARY KEY,
	DateOrdered DATE NOT NULL,
	OrderedBy INT NOT NULL REFERENCES tblEmployees(EmployeeId), 
	SupplierId INT NOT NULL REFERENCES tblSupplierContact(ContactId)
);

CREATE TABLE tblOrderLineItem (
	OrderId INT NOT NULL REFERENCES tblOrder(OrderId),
	ProductId INT NOT NULL REFERENCES tblProduct(ProductId),
	Quantity INT NOT NULL DEFAULT 1,
	BatchCost MONEY NOT NULL,
	PRIMARY KEY (OrderId,ProductId)
);

CREATE TABLE tblMortarStore (
	StoreId serial PRIMARY KEY,
	Address INT NOT NULL REFERENCES tblAddress(AddressId),
	PhoneNumber BIGINT NOT NULL,
	GeneralManager INT NOT NULL REFERENCES tblEmployees(EmployeeId)
);

CREATE TABLE tblTransfer (
	TransferId serial PRIMARY KEY,
	StoreId INT NOT NULL REFERENCES tblMortarStore(StoreId),
	TransferDate DATE NOT NULL
);

CREATE TABLE tblTransferLineItem (
	TransferId INT NOT NULL REFERENCES tblTransfer(TransferId),
	ProductId INT NOT NULL REFERENCES tblProduct(ProductId),
	Quantity INT NOT NULL DEFAULT 1,
	PRIMARY KEY (TransferId,ProductId)
);

