-- Insert data into UserTable
INSERT INTO UserTable (Email, Fname, Lname, Password)
VALUES ('user1@example.com', 'John', 'Doe', 'password1');

-- Insert data into AdminTable
INSERT INTO AdminTable (AdminID, Salary)
VALUES (1, 5000);

-- Insert data into Aircraft
INSERT INTO Aircraft (Model, Manufacturer, AircraftType, ManufactureYear, Capacity, Status)
VALUES ('Boeing 747', 'Boeing', 'Passenger', '2022-01-01', 400, 1);

-- Insert data into AircraftDispatchControl
INSERT INTO AircraftDispatchControl (AdminID, AircraftID)
VALUES (1, 1);

-- Insert data into Flight
INSERT INTO Flight (AircraftID, deptDate, expectedArrival, arrivalCountry, deptCountry)
VALUES (1, '2022-05-01', '2022-05-02', 'United States', 'Canada');

-- Insert data into BookingManagment
INSERT INTO BookingManagment (AdminID, FlightNo)
VALUES (1, 1);

