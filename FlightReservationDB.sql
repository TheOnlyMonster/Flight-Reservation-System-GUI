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
    CardNum VARCHAR(16),
    CVV INT,
    ExpiryDate varchar(50),
    PassportExpirationDate Date,
    Nationality VARCHAR(50),
    CONSTRAINT CHK_CustomerTable_CardNum CHECK (LEN(CardNum) = 16),
    CONSTRAINT CHK_CustomerTable_CVV CHECK (CVV >= 0 AND CVV <= 999),
);

create table AdminTable (
    AdminID int primary key references UserTable(UserID),
    Salary int not null
);

CREATE TABLE Aircraft (
    AircraftID INT PRIMARY KEY IDENTITY(1, 1),
    Model VARCHAR(30) NOT NULL,
    Manufacturer VARCHAR(20) NOT NULL,
    AircraftType VARCHAR(20) NOT NULL,
    ManufactureYear Int NOT NULL,
    Capacity SMALLINT NOT NULL,
    Status VARCHAR(50) NOT NULL,
    CONSTRAINT CHK_MANUFACTUREYEAR_CONSTRAINT CHECK (ManufactureYear >= 1000 AND ManufactureYear <= 9999)
);

create table AircraftDispatchControl (
    AdminID int foreign key references AdminTable(AdminID) NOT NULL,
    AircraftID int foreign key references Aircraft(AircraftID) ON DELETE SET NULL NOT NULL,
    Primary key(AdminID,AircraftID)
);

CREATE TABLE Flight (
    FlightNo INT PRIMARY KEY IDENTITY(1,1),
    AircraftID INT FOREIGN KEY REFERENCES Aircraft(AircraftID) ON DELETE SET NULL NOT NULL,
    DeptDate Date NOT NULL,
    ExpectedArrival Date NOT NULL,
    ArrivalCountry VARCHAR(50) NOT NULL,
    DeptCountry VARCHAR(50) NOT NULL,
    AvailableSeats SMALLINT,
    Rank1Price DECIMAL(10, 2) NOT NULL,
    Rank2Price DECIMAL(10, 2) NOT NULL,
    Rank3Price DECIMAL(10, 2) NOT NULL
);

create table BookingManagment (
    AdminID int foreign key references AdminTable(AdminID) NOT NULL,
    FlightNo int foreign key references Flight(FlightNo) ON DELETE SET NULL NOT NULL,
    PRIMARY KEY (AdminID, FlightNo)
);

CREATE TABLE BookingDetails (
    BookingID INT IDENTITY(1, 1),
    CustomerID INT REFERENCES CustomerTable(CustomerID) NOT NULL,
    FlightNo INT REFERENCES Flight(FlightNo) ON DELETE SET NULL NOT NULL,
    BookingDate VARCHAR(15) NOT NULL,
    SeatAssignment INT NOT NULL,
    TicketPrice DECIMAL(10, 2) NOT NULL,
    Rank VARCHAR(15) NOT NULL,
    Status VARCHAR(50) NOT NULL,
    CONSTRAINT CHK_BookingDetails_SeatAssignment CHECK (SeatAssignment > 0),
    PRIMARY KEY (BookingID,CustomerID,FlightNo)
);
