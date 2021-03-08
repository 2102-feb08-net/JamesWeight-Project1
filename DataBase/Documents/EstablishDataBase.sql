CREATE DATABASE MLiMa;
CREATE TABLE Customers(ID INT NOT NULL, PRIMARY KEY (ID),
                 Name VARCHAR(100) NOT NULL, Address VARCHAR(300), Phone BIGINT, eMail VARCHAR(100),
                 HomeStore INT);
CREATE TABLE Locations(ID INT NOT NULL, PRIMARY KEY (ID),
                 Name VARCHAR(100) NOT NULL, Address VARCHAR(300), Phone BIGINT, eMail VARCHAR(100));
CREATE TABLE Products(ID INT NOT NULL, PRIMARY KEY (ID), LocationID INT,
                 Name VARCHAR(100) NOT NULL, Description VARCHAR(300), Price INT, Quantity INT);
CREATE TABLE Orders(ID INT NOT NULL, PRIMARY KEY (ID),
                 CustomerID INT REFERENCES Customers(ID), LocationID INT REFERENCES Locations(ID),

                 ProductID INT REFERENCES Products(ID),
                 Record DATETIMEOFFSET(7), DealsPercentageReduction INT, DealsAmountReduction INT);
INSERT INTO Customers (ID, Name, Address, Phone, eMail, HomeStore) VALUES (0, 'James Weight', 'Address', 11234567890, 'James.Weight@Revature.net', 99999);
INSERT INTO Customers (ID, Name, Address, Phone, eMail, HomeStore) VALUES (1, 'Chuck Yeager', 'Another Address', 11234567900, '', 99999);
INSERT INTO Customers (ID, Name, Address, Phone, eMail, HomeStore) VALUES (2, 'Yuri Yeager', 'Another Address', 11554567900, '', 99999);

INSERT INTO Products (ID, LocationID, Name, Description, Price, Quantity) VALUES (0, 99999, 'Widget', 'It Looks Like a Widget...', 9, 2);

INSERT INTO Locations (ID, Name, Address, Phone, eMail) VALUES (99999, 'Components, Inc.', 'Address', 11234568709, '99999@Store');

INSERT INTO Orders(ID, CustomerID, LocationID, ProductID, Record, DealsPercentageReduction, DealsAmountReduction)
VALUES(0, 0, 99999, 0, '2021-02-28 01:25:00.0000000 -08:00', 0, 0);