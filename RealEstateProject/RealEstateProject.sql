--CREATE DATABASE RealEstateDB;

USE RealEstateDB;
CREATE TABLE Client (
    ClientNo INT NOT NULL,
    ClientName VARCHAR(100) NOT NULL,
	C_Gender VARCHAR(6),
    C_Email VARCHAR(100),
    C_Phone VARCHAR(15) NOT NULL,
    C_Address VARCHAR(200),
	C_Province VARCHAR(30),
	C_City VARCHAR(50),
    C_DOB DATE,
    C_NationalID VARCHAR(15) NOT NULL,
    
    CONSTRAINT PK_Client PRIMARY KEY (ClientNo),
	CONSTRAINT UQ_CNationalID UNIQUE (C_NationalID),
);
CREATE TABLE PropertyOwner (
    OwnerNo INT NOT NULL,
    OwnerName VARCHAR(100) NOT NULL,
	O_Gender VARCHAR(6),
    O_Email VARCHAR(100),
    O_Phone VARCHAR(15) NOT NULL,
    O_Address VARCHAR(200),
	O_Province VARCHAR(30),
	O_City VARCHAR(50),
	O_DOB DATE,
    O_NationalID VARCHAR(15) NOT NULL,
    O_BankAccountNo VARCHAR(50),

    CONSTRAINT PK_Owner PRIMARY KEY (OwnerNo),
	CONSTRAINT UQ_ONationalID UNIQUE (O_NationalID)
);
CREATE TABLE Property (
    PropertyNo INT NOT NULL,
    P_Address VARCHAR(200) NOT NULL,
	P_Province VARCHAR(30) NOT NULL,
	P_City VARCHAR(100) NOT NULL,
    P_Rent DECIMAL(20, 2),
    P_Type VARCHAR(20) NOT NULL,         --e.g , Shop,Apartment,House
    P_Size INT NOT NULL,                  -- e.g., in square feet
    P_Status VARCHAR(20) NOT NULL, -- Available, Rented etc.
    P_DateListed DATE DEFAULT GETDATE() NOT NULL,
    P_Description VARCHAR(300),
    OwnerNo INT,

    CONSTRAINT PK_Property PRIMARY KEY (PropertyNo),
    CONSTRAINT FK_Property_Owner FOREIGN KEY (OwnerNo) REFERENCES PropertyOwner(OwnerNo)
	ON DELETE SET NULL
);

CREATE TABLE ClientRental (
    ClientNo INT NOT NULL,
    PropertyNo INT NOT NULL,
    RentStart DATE NOT NULL,
    RentFinish DATE NOT NULL,
    DepositAmount DECIMAL(20, 2),
    MonthlyRent DECIMAL(20, 2),
    PaymentStatus VARCHAR(20),
    RentDescription VARCHAR(300),  

    CONSTRAINT PK_ClientRental PRIMARY KEY (ClientNo,PropertyNo,RentStart),
    CONSTRAINT FK_ClientRental_Client FOREIGN KEY (ClientNo) REFERENCES Client(ClientNo)
	ON DELETE CASCADE,
    CONSTRAINT FK_ClientRental_Property FOREIGN KEY (PropertyNo) REFERENCES Property(PropertyNo)
	ON DELETE CASCADE 
);





--DROP Table Client;
--DROP Table ClientRental;
--DROP Table Property;
--DROP Table PropertyOwner;

SELECT * FROM Client;
SELECT * FROM ClientRental;
SELECT * FROM Property;
SELECT * FROM PropertyOwner;


