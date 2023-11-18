CREATE DATABASE Banking
USE Banking
-- Create the AdminInfo table
CREATE TABLE AdminInfo (
	AdminID INT IDENTITY(1,1) PRIMARY KEY,
    AdminName VARCHAR(100) NOT NULL,
    AdminPhoneNumber VARCHAR(15),
    PasswordHash VARCHAR(255) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL
)
-- Insert data into the AdminInfo table
INSERT INTO AdminInfo (AdminName, AdminPhoneNumber, PasswordHash, Email)
VALUES
    ('Pandi', '6385813582', 'Pandi@123', 'pandi@gmail.com'),
    ('Raja', '9944960800', 'Raja@123', 'raja@gamil.com')
-- Create the BankInfo table
CREATE TABLE BankInfo (
    BankID INT PRIMARY KEY IDENTITY(1,1),
    BankName VARCHAR(100) NOT NULL,
	IFSCCode VARCHAR(50) NOT NULL,
	MICRCode VARCHAR(50) NOT NULL,																				
    BankAddress VARCHAR(255) NOT NULL,
    City VARCHAR(50) NOT NULL,
    BankState VARCHAR(50) NOT NULL,
    PinCode VARCHAR(10) NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL,
    Website VARCHAR(100) NOT NULL,
)
-- Create the Accountholdinfo table
CREATE TABLE Accountholdinfo (
    AccountNo BIGINT,
    HolderFirstName VARCHAR(50) NOT NULL,
    HolderLastName VARCHAR(50) NOT NULL,
    DateOfBirth DATE,
    Gender CHAR(1),
    AddressLine1 VARCHAR(255),
    AddressLine2 VARCHAR(255),
    City VARCHAR(50),
    HState VARCHAR(50),
    PinCode VARCHAR(10),
    Email VARCHAR(100) UNIQUE,
    PhoneNumber VARCHAR(15),
    AccountType VARCHAR(20) NOT NULL,
    AccountBalance DECIMAL(18, 2) NOT NULL,
    AccountStatus VARCHAR(20),
    OpenedDate DATETIME DEFAULT GETDATE()
)
-- Create the Profile table
CREATE TABLE Profile (
    
    AccountNo BIGINT  NOT NULL,
    Name VARCHAR(50) NOT NULL,
	Amount VARCHAR(50) NOT NULL,
	Balance money NOT NULL,
    Date DATETIME DEFAULT GETDATE(),
	Detail VARCHAR(250) NOT NULL,

)
drop  table Profile
select * from AdminInfo
select * from BankInfo
select * from Accountholdinfo
select * from Profile

