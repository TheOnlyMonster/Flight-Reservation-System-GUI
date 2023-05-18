create table UserTable (
    UserID int primary key identity(1,1),
    Email varchar(50) unique not null,
    Fname varchar(30) not null,
    Lname varchar(30) not null,
    Password varchar(20) not null,
    Identifier char not null,
);

CREATE TABLE CustomerTable (
    CustomerID INT PRIMARY KEY REFERENCES UserTable(UserID),
    PassportNumber VARCHAR(20),
    PhoneNumber varchar(20) NOT NULL,
    City VARCHAR(15),
    Country VARCHAR(15),
    CardNum INT,
    CVV INT,
    ExpiryDate DATE,
    PassportExpirationDate DATE,
    Nationality VARCHAR(50),
    CONSTRAINT CHK_CustomerTable_CardNum CHECK (LEN(CardNum) = 16),
    CONSTRAINT CHK_CustomerTable_CVV CHECK (CVV >= 0 AND CVV <= 999),
    CONSTRAINT CHK_CustomerTable_ExpiryDate CHECK (ExpiryDate >= GETDATE()),
    CONSTRAINT CHK_CustomerTable_PassportExpirationDate CHECK (PassportExpirationDate >= GETDATE())
);

create table AdminTable (
    AdminID int primary key references UserTable(UserID),
    Salary int not null
);

create table AdminCustomerAssignment (
    AdminID int foreign key references AdminTable(AdminID), 
    CustomerID int foreign key references CustomerTable(CustomerID),
    PRIMARY KEY (AdminID, CustomerID)
);

CREATE TABLE Aircraft (
    AircraftID INT PRIMARY KEY IDENTITY(1, 1),
    Model VARCHAR(30) NOT NULL,
    Manufacturer VARCHAR(20) NOT NULL,
    AircraftType VARCHAR(20) NOT NULL,
    ManufactureYear DATE NOT NULL,
    Capacity SMALLINT NOT NULL,
    Status TINYINT NOT NULL,
    CONSTRAINT CHK_Aircraft_Status CHECK (Status IN (0, 1, 2))
);

create table AircraftDispatchControl (
    AdminID int foreign key references AdminTable(AdminID) NOT NULL,
    AircraftID int foreign key references Aircraft(AircraftID) NOT NULL
    Primary key(AdminID,AircraftID)
);

create table Flight (
    FlightNo int primary key identity(1,1),
    AircraftID int foreign key references Aircraft(AircraftID) not null,
    deptDate DATETIME NOT NULL,
    expectedArrival DATETIME NOT NULL,
    arrivalCountry VARCHAR(50) NOT NULL,
    deptCountry VARCHAR(50) NOT NULL
);

create table BookingManagment (
    AdminID int foreign key references AdminTable(AdminID) NOT NULL,
    FlightNo int foreign key references Flight(FlightNo) NOT NULL,
    PRIMARY KEY (AdminID, FlightNo)
);

CREATE TABLE BookingDetails (
    BookingID INT PRIMARY KEY IDENTITY(1, 1),
    CustomerID INT REFERENCES CustomerTable(CustomerID) NOT NULL,
    FlightNo INT REFERENCES Flight(FlightNo) NOT NULL,
    BookingDate DATE NOT NULL,
    SeatAssignment INT NOT NULL,
    TicketPrice DECIMAL(10, 2) NOT NULL,
    CONSTRAINT CHK_BookingDetails_SeatAssignment CHECK (SeatAssignment > 0)
);