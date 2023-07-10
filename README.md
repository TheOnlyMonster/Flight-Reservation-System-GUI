# Flight Reservation System

The Flight Reservation System is a desktop application developed by [Abdelrahman Adel](https://github.com/TheOnlyMonster), [Abdelrahman Atef](https://github.com/AbdoMan19) and [Yassin Tarek](https://github.com/YassinTarekHelmy), as part of a database course project. We have enhanced the project by applying design patterns, such as the Template Design Pattern and Singleton, and incorporating object-oriented programming concepts like inheritance and polymorphism. The code has been written with a focus on cleanliness and readability.

## Overview

The Flight Reservation System allows customers to make flight reservations and manage their personal information, while administrators have access to additional functionalities for managing flights, aircraft, and reservations. The system is connected to a SQL database hosted on Google Cloud, which requires users to contact the owner to obtain access with their IP address.

## Features

### Customer Panel

1. **Update Personal Information**: Customers can modify their first name, last name, password, and phone number.
2. **View Flights**: Customers can browse and view available flights.
3. **Book Flights**: Customers can reserve up to 7 tickets for a flight.
4. **Seat Selection**: Customers can choose their preferred seats from three ranks: A, B, or C.
5. **View Reservations**: Customers can view their existing flight reservations, but they cannot edit them.

### Admin Panel

1. **Add New Flight**: Administrators can add new flights to the system.
2. **Add New Aircraft**: Administrators can add new aircraft to the system.
3. **Seat Assignment**: Administrators can assign available seats for each flight, specifying the number of seats for ranks A, B, and C.
4. **Price Configuration**: Administrators can set prices for ranks A, B, and C seats.
5. **View Reservations**: Administrators can view all flight reservations made by customers.
6. **Modify Seat Assignments**: Administrators can change the assigned seats and modify the seat ranks for tickets.
7. **Update Flight Details**: Administrators can update departure and arrival dates for flights.
8. **Update Aircraft Details**: Administrators can update information about the aircraft.

## Implementation Details
The project successfully implemented all the required deliverables, including:

1. System Entity Relationship Diagram (ERD): The conceptual model of the system's database design. It includes at least 5 entities, including 1 many-to-many relationship.

2. Software Application: The Flight Reservation System has been implemented using C# and WinForms. The application provides a user-friendly interface for users to interact with the system.

3. Conceptual ERD: The graphical representation of the system's Entity Relationship Diagram. The ERD matches the conceptual model mentioned earlier.

![image](https://github.com/TheOnlyMonster/FlightReservationSystemGUI/assets/92688600/4a6b2e2e-6c4e-4780-9d8f-1fda28e04343)


4. Corresponding Physical ERD: The transformation of the Entity Relationship Diagram into the physical model. The physical ERD includes tables, attributes, primary keys, foreign keys, and additional constraints.

![image](https://github.com/TheOnlyMonster/FlightReservationSystemGUI/assets/92688600/ae2fc7da-63c4-4032-b857-54d7e289995d)


5. Implemented database on MS SQL Server: The database has been successfully implemented using MS SQL Server. It reflects the physical ERD and supports all required functionalities of the Flight Reservation System.

## GUI Screenshots

![image](https://github.com/TheOnlyMonster/Flight-Reservation-System-GUI/assets/92688600/8ec23a86-14ae-4dc5-a8b2-a1b2009f5f1f)

![image](https://github.com/TheOnlyMonster/Flight-Reservation-System-GUI/assets/92688600/1237abef-9ea2-494b-b8c2-64e626b4d0d7)

![image](https://github.com/TheOnlyMonster/Flight-Reservation-System-GUI/assets/92688600/f78e5678-bfca-48cc-b8cb-f8cdfd100359)

## Contributors
- [Abdelrahman Adel](https://github.com/TheOnlyMonster)  
- [Abdelrahman Atef](https://github.com/AbdoMan19)  
- [Yassin Tarek](https://github.com/YassinTarekHelmy)  

## Acknowledgments
I would like to express my gratitude to the teaching staff and the Department of Information Systems at Cairo University for providing the opportunity to work on this project and expand my knowledge of database systems and software development concepts.
