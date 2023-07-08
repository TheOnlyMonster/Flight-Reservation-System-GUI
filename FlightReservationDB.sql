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
    PhoneNumber varchar(20) NOT NULL,
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
    ManufactureYear INT NOT NULL,
    Capacity SMALLINT NOT NULL,
    Status VARCHAR(50) NOT NULL,
    RankASeats SMALLINT NOT NULL,
    RankBSeats SMALLINT NOT NULL,
    RankCSeats SMALLINT NOT NULL,
    CONSTRAINT CHK_MANUFACTUREYEAR_CONSTRAINT CHECK (ManufactureYear >= 1000 AND ManufactureYear <= 9999)
);

create table AircraftDispatchControl (
    AdminID int foreign key references AdminTable(AdminID) NOT NULL,
    AircraftID int foreign key references Aircraft(AircraftID) ON DELETE cascade,
    Primary key(AdminID,AircraftID)
);

CREATE TABLE Flight (
    FlightNo INT PRIMARY KEY IDENTITY(1,1),
    AircraftID INT FOREIGN KEY REFERENCES Aircraft(AircraftID) ON DELETE SET NULL,
    DeptDate VARCHAR(50) NOT NULL,
    ExpectedArrival VARCHAR(50) NOT NULL,
    ArrivalCountry VARCHAR(50) NOT NULL,
    DeptCountry VARCHAR(50) NOT NULL,
    AvailableSeats SMALLINT,
    Rank1Price DECIMAL(10, 2) NOT NULL,
    Rank2Price DECIMAL(10, 2) NOT NULL,
    Rank3Price DECIMAL(10, 2) NOT NULL
);

create table BookingManagment (
    AdminID int foreign key references AdminTable(AdminID) NOT NULL,
    FlightNo int foreign key references Flight(FlightNo) ON DELETE cascade,
    PRIMARY KEY (AdminID, FlightNo)
);

CREATE TABLE BookingDetails (
    BookingID INT IDENTITY(1, 1),
    CustomerID INT REFERENCES CustomerTable(CustomerID) NOT NULL,
    FlightNo INT REFERENCES Flight(FlightNo) ON DELETE cascade,
    BookingDate VARCHAR(15) NOT NULL,
    FirstName VARCHAR(15) NOT NULL,
    LastName VARCHAR(15) NOT NULL,
    PassportNumber VARCHAR(15) NOT NULL,
    PassportEXPDate VARCHAR(15) NOT NULL,
    SeatAssignment INT NOT NULL,
    TicketPrice DECIMAL(10, 2) NOT NULL,
    Rank VARCHAR(15) NOT NULL,
    Status VARCHAR(50) NOT NULL,
    CONSTRAINT CHK_BookingDetails_SeatAssignment CHECK (SeatAssignment > 0),
    PRIMARY KEY (BookingID,CustomerID,FlightNo)
);

-- Insert sample records into UserTable
INSERT INTO UserTable (Email, Fname, Lname, Password, Identifier)
VALUES
    ('john@example.com', 'John', 'Smith', 'password1', 'A'),
    ('mary@example.com', 'Mary', 'Johnson', 'password2', 'A'),
    ('david@example.com', 'David', 'Brown', 'password3', 'A'),
    ('emily@example.com', 'Emily', 'Davis', 'password4', 'C'),
    ('michael@example.com', 'Michael', 'Wilson', 'password5', 'C'),
    ('sarah@example.com', 'Sarah', 'Anderson', 'password6', 'C'),
    ('jason@example.com', 'Jason', 'Taylor', 'password7', 'C'),
    ('laura@example.com', 'Laura', 'Thomas', 'password8', 'C'),
    ('andrew@example.com', 'Andrew', 'Clark', 'password9', 'C'),
    ('jennifer@example.com', 'Jennifer', 'Lee', 'password10', 'C');

-- Insert sample records into CustomerTable
INSERT INTO CustomerTable (CustomerID, PhoneNumber)
VALUES
    (4, '+5556667778'),
    (5, '+9998887776'),
    (6, '+3332221110'),
    (7, '+4445556662'),
    (8, '+7778889994'),
    (9, '+1234567890'),
    (10,'+2223334446');

-- Insert sample records into AdminTable
INSERT INTO AdminTable (AdminID, Salary)
VALUES
    (1, 5000),
    (2, 6000),
    (3, 5500);

	-- Insert sample records into Aircraft table
INSERT INTO Aircraft (Model, Manufacturer, AircraftType, ManufactureYear, Capacity, Status, RankASeats, RankBSeats, RankCSeats)
VALUES
    ('Boeing 747', 'Boeing', 'Commercial', 2020, 300, 'Active', 50, 100, 150),
    ('Airbus A320', 'Airbus', 'Commercial', 2018, 200, 'Active', 40, 80, 80),
    ('Cessna 172', 'Cessna', 'Private', 2015, 4, 'Active', 2, 0, 2),
    ('Embraer E190', 'Embraer', 'Commercial', 2019, 120, 'Active', 20, 50, 50),
    ('Bombardier Challenger 350', 'Bombardier', 'Private', 2017, 10, 'Active', 8, 0, 2),
    ('Boeing 777', 'Boeing', 'Commercial', 2016, 400, 'Active', 80, 150, 170),
    ('Gulfstream G650', 'Gulfstream', 'Private', 2021, 12, 'Active', 10, 0, 2),
    ('Airbus A380', 'Airbus', 'Commercial', 2014, 500, 'Active', 100, 200, 200),
    ('Cessna Citation X', 'Cessna', 'Private', 2019, 8, 'Active', 6, 0, 2),
    ('Bombardier Global 6000', 'Bombardier', 'Private', 2018, 16, 'Active', 12, 0, 4);

-- Insert sample records into Flight table
INSERT INTO Flight (AircraftID, DeptDate, ExpectedArrival, ArrivalCountry, DeptCountry, AvailableSeats, Rank1Price, Rank2Price, Rank3Price)
VALUES
    (1, '09/29/2023 9:50 AM', '05/29/2015 5:50 AM', 'USA', 'UK', 150, 500.00, 300.00, 200.00),
    (2, '10/29/2023 10:50 AM', '10/30/2023 5:50 AM', 'France', 'Germany', 100, 400.00, 250.00, 150.00),
    (3, '11/25/2015 5:50 AM', '11/26/2015 5:50 AM', 'Spain', 'Italy', 200, 450.00, 280.00, 180.00),
    (4, '12/03/2015 5:50 AM', '12/05/2015 5:50 AM', 'Canada', 'Mexico', 120, 550.00, 350.00, 220.00),
    (5, '07/28/2015 5:50 AM', '07/29/2015 5:50 AM', 'Japan', 'China', 180, 600.00, 400.00, 250.00)