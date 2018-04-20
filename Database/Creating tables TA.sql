USE TravelAgency;

IF OBJECT_ID ('Tour', 'U') IS NOT NULL
DROP TABLE Accommodation;

CREATE TABLE Tour
(
IdTour BIGINT IDENTITY (1,1) CONSTRAINT
									PK_Tour PRIMARY KEY,
Country VARCHAR (30) NOT NULL, 
City VARCHAR (30) NOT NULL, 
BeginDate DATE NOT NULL,
EndDate DATE NOT NULL,
Price INT NOT NULL,
TourOpId BIGINT NOT NULL,
AirlineId BIGINT NULL,
AccommodationId BIGINT NULL,
InsuranceId BIGINT NULL,
Unique (Country, City, BeginDate, EndDate, Price, TourOpId, AirlineId, AccommodationId, InsuranceId)
);


CREATE TABLE TourOperator
(
IdTourOperator BIGINT IDENTITY (1,1) CONSTRAINT
									PK_TourOperator PRIMARY KEY,
TourOpName VARCHAR(60) NOT NULL,
TourOpCountry VARCHAR(60) NOT NULL,
TourOpPhone VARCHAR(15) NOT NULL,
Unique(TourOpName),
Unique(TourOpPhone)
);

CREATE TABLE Airline
(
IdAirline BIGINT IDENTITY (1,1) CONSTRAINT
									PK_Airline PRIMARY KEY,
AirlineName VARCHAR (60) NOT NULL,
Class VARCHAR (60) NULL,
Unique(AirlineName, Class)
);

CREATE TABLE Accommodation
(
IdAccommodation BIGINT IDENTITY (1,1) CONSTRAINT
									PK_Accommodation PRIMARY KEY,
AcName VARCHAR(70) NOT NULL,
AcCategory VARCHAR(20) NOT NULL,
NumberOfStars INT NULL,
Food CHAR (2) NOT NULL,
AcOptions VARCHAR (50) NULL,
AcPhone VARCHAR(20) NOT NULL,
Address VARCHAR(70) NOT NULL,
/*CHECK ( AcCategory IN ('Hotel','Apartment', '', '')),*/
CHECK (Food IN ('AL','FB','HB','BB','RO')),
Unique(AcName, Food),

);

CREATE TABLE Insurance
(
IdInsurance BIGINT IDENTITY (1,1) CONSTRAINT
									PK_Insurance PRIMARY KEY,
CompanyName VARCHAR(60) NOT NULL,
TripType VARCHAR (60) NOT NULL,
InsCategory VARCHAR (20) NOT NULL,
Unique(CompanyName, TripType, InsCategory)
);

CREATE TABLE Orders
(
IdOrders BIGINT IDENTITY (1,1) CONSTRAINT
									PK_Orders PRIMARY KEY,
TourId BIGINT NOT NULL,
GroupId BIGINT NOT NULL,
OrderDate DATE NOT NULL,
PaymentDate DATE NULL,
Status VARCHAR (60) NOT NULL,
PaymentStatus VARCHAR (10) NOT NULL,
CHECK (Status IN ('Ожидает подтверждения', 'Подтвержден','Не подтвержден', 'Документы не готовы', 'Готов','Выполнен')),
CHECK (PaymentStatus IN ('Оплачен', 'Не оплачен')),
CHECK (OrderDate <= PaymentDate),
CHECK (
		((PaymentDate IS NULL) AND PaymentStatus='Не оплачен') OR
		(PaymentDate IS NOT NULL) AND PaymentStatus='Оплачен')
	  );

ALTER TABLE Orders
ADD Unique(GroupId, TourId)

/*ALTER TABLE Orders
ADD Constraint Paid_OrdersDate_PaymentDate
CHECK (OrderDate <= PaymentDate)*/

CREATE TABLE TouristGroup
(
IdGroup BIGINT IDENTITY (1,1) CONSTRAINT
									PK_TouristGroup PRIMARY KEY,
NumberOfTourists INT NOT NULL,
CustomerLastName VARCHAR(60) NOT NULL,
CustomerFirstName VARCHAR (60) NOT NULL,
CustomerPhone VARCHAR(15) NOT NULL,
CustomerEmail VARCHAR(60) NULL,
Unique(NumberOfTourists, CustomerLastName, CustomerFirstName)
);


CREATE TABLE Tourist
(
idTourist BIGINT IDENTITY (1,1) CONSTRAINT
									PK_Tourist PRIMARY KEY,
GroupId BIGINT NOT NULL,
LastName VARCHAR(60) NOT NULL,
FirstName VARCHAR (60) NOT NULL,
PassportNumber INT NOT NULL,
DateOfBirth DATE NOT NULL,
TouristPhone VARCHAR(15) NOT NULL,
TouristEmail VARCHAR(60) NULL,
Unique (GroupId, PassportNumber)
);

ALTER TABLE Tour /*побочная таблица*/
ADD CONSTRAINT FK_Tour_TourOperator /*между какими таблицами связь*/
FOREIGN KEY (TourOpId) /*наследственный ключ*/
REFERENCES TourOperator (IdTourOperator) /*главный ключ*/
/*ON DELETE CASCADE
ON UPDATE CASCADE*/

ALTER TABLE Tour
ADD CONSTRAINT FK_Tour_Airline
FOREIGN KEY (AirlineId)
REFERENCES Airline (IdAirline);

ALTER TABLE Tour
ADD CONSTRAINT FK_Tour_Accommodation
FOREIGN KEY (AccommodationId)
REFERENCES Accommodation (IdAccommodation);

ALTER TABLE Tour
ADD CONSTRAINT FK_Tour_Insurance
FOREIGN KEY (InsuranceId)
REFERENCES Insurance (IdInsurance);

ALTER TABLE Orders
ADD CONSTRAINT FK_Orders_Tour
FOREIGN KEY (TourId)
REFERENCES Tour (IdTour);

ALTER TABLE Orders
ADD CONSTRAINT FK_Orders_Group
FOREIGN KEY (GroupId)
REFERENCES TouristGroup (IdGroup);

ALTER TABLE Tourist
ADD CONSTRAINT FK_Tourist_Group
FOREIGN KEY (GroupId)
REFERENCES TouristGroup (IdGroup);

-- ------------------------------------
ALTER TABLE Orders
DROP CONSTRAINT FK_Orders_Tour

drop table Orders
-- ------------------------------------

CREATE TABLE Staff
(
IdLoginPassword BIGINT IDENTITY (1,1) CONSTRAINT
									PK_LoginPassword PRIMARY KEY,
UserType VARCHAR (20) NOT NULL,
FirstName VARCHAR (20) NOT NULL,
LastName VARCHAR (20) NOT NULL,
Pass VARCHAR (20) NOT NULL,
Unique (UserType, LastName)
);