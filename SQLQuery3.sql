INSERT INTO Aircraft (Model, Manufacturer, AircraftType, ManufactureYear, Capacity, Status)
VALUES
    ('Boeing 737', 'Boeing', 'Passenger', '2018-01-01', 150, 1),
    ('Airbus A320', 'Airbus', 'Passenger', '2017-02-01', 180, 1),
    ('Embraer E175', 'Embraer', 'Regional', '2019-03-01', 80, 1),
    ('Bombardier CRJ900', 'Bombardier', 'Regional', '2016-05-01', 90, 0),
    ('Boeing 777', 'Boeing', 'Passenger', '2020-08-01', 350, 2);
INSERT INTO Flight (AircraftID, deptDate, expectedArrival, arrivalCountry, deptCountry)
VALUES
    (1, '2022-05-01', '2022-05-02', 'United States', 'United Kingdom'),
    (2, '2022-05-03', '2022-05-04', 'Germany', 'France'),
    (3, '2022-05-05', '2022-05-06', 'Spain', 'Italy'),
    (4, '2022-05-07', '2022-05-08', 'Canada', 'Mexico'),
    (5, '2022-05-09', '2022-05-10', 'Australia', 'Japan'),
    (2, '2022-05-11', '2022-05-12', 'United States', 'Canada'),
    (3, '2022-05-13', '2022-05-14', 'France', 'Germany'),
    (4, '2022-05-15', '2022-05-16', 'Italy', 'Spain'),
    (5, '2022-05-17', '2022-05-18', 'Mexico', 'United States'),
    (1, '2022-05-19', '2022-05-20', 'Japan', 'Australia');
