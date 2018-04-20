USE TravelAgency;

INSERT INTO TourOperator (TourOpName, TourOpCountry, TourOpPhone)
VALUES  ('Pegas Touristik', 'Россия', '74952878787'),
		('TEZ TOUR', 'Россия', '84956692240'),
		('Сoral Travel', 'Россия', '84952550605'),
		('Anex Tour', 'Россия', '88007755000'),
		('TUI Group', 'Германия', '84955067054'),
		('Thomas Cook Group', 'Великобритания', '88003334433'); 

INSERT INTO Insurance (CompanyName, TripType, InsCategory)
VALUES  ('Ингосстрах', 'Пляжный отдых', 'Средняя'),
		('Тинькофф Страхование', 'Пляжный отдых', 'Средняя'),
		('Альфа-Страхование', 'Активный отдых', 'Высокая'),
		('EVR', 'Путешествия по Европе', 'Средняя'),
		('Сбербанк Страхование', 'Экстримальный отдых', 'Полная'),
		('Сбербанк Страхование', 'Путешествия по России', 'Полная');

INSERT INTO Airline (AirlineName, Class)
VALUES  ('I-Fly', 'Эконом'),
		('Pegas Fly', 'Эконом'),
		('Nordstar', 'Эконом'),
		('Аэрофлот', 'Эконом'),
		('Аэрофлот', 'Бизнес'),
		('Azur air', ''),
		('TUI', 'Эконом'),
		('TUI', 'Бизнес');		

INSERT INTO Accommodation (AcName, AcCategory, NumberOfStars, Food, AcOptions, AcPhone, Address)
VALUES  ('Vienna Apartments', 'Апартаменты', '', 'RO', 'Центр города', '+43 676 5370273','Wiedner Hauptstrasse 5, 1040 Wien, Австрия'),
		('Limak Lara Deluxe Hotel & Resort', 'Отель', '4', 'AL', '1 линия', '+90 242 3522700','Lara Turizm Yolu, 07110, Турция, Анталья, Лара'),
		('Concorde De Luxe Resort', 'Отель', '5', 'AL', '1 линия', '+90 242 3522626','Lara Turizm Yolu, 07110, Турция, Анталья, Лара'),
		('Apartment in Larnaca', 'Апартаменты', '', 'RO', 'Рядом музей', '+357 70 079368','Archiepiskopou Leontiou I, 6021 Ларнака, Кипр'),
		('Holiday Inn Beijing Downtown', 'Отель', '4', 'BB', 'Рядом с вокзалом', '+86 10 6833 8822','98 Beilishilu Xichengqu, Beijing, Китай, 100037'),
		('Cool Residence', 'Отель', '3', 'HB', '2 линия', '+66 86 659 6544','24/268 Amphoe Mueang Phuket, Chang Wat Phuket 83000, Таиланд'),
		('Four Seasons Hotel Moscow', 'Отель', '5', 'BB', 'Центр города', '+7 499 2777100','ул. Охотный Ряд, 2, Москва, 109012'),
		('Best Western Plus Buckingham International', 'Апарт-отель', '4', 'BB', '15км от центра, Сад, Фитнес-центр', '+61 3 95550011','1130 Nepean Hwy, Highett VIC 3190, Австралия'),
		('Rayfont Downtown Hotel Shanghai', 'Отель', '4', 'BB', 'Крытый бассейн', '+86 21 5407 7000','7 Zhaojiabang Rd, Xuhui Qu, Shanghai Shi, Китай')

UPDATE Accommodation
SET AcName = 'Center Hotel Kazan Kremlin', NumberOfStars='4', AcPhone='+7 843 2100140', Address='ул. Карла Маркса 6, Казань, Респ.Татарстан, 420111'
WHERE IdAccommodation='7'

DELETE Accommodation 
WHERE IdAccommodation='1'

INSERT INTO Tour (Country, City, BeginDate, EndDate, Price, TourOpId, AirlineId, AccommodationId, InsuranceId)
VALUES  ('Австрия','Вена','20171016','20171022','50000','1','2','1','1'),
		('Турция','Анталья, Лара','20180428','20180505','45000','2','1','2','2'),
		('Турция','Анталья, Лара','20180428','20180505','60000','2','1','3','2'),
		('Кипр','Ларнака','20180515','20180518','20000','3','6','4','4'),
		('Китай','Пекин','20180610','20180617','150000','4','4','5','3'),
		('Тайланд','Пхукет','20180427','20180505','60000','1','3','6','2'),
		('Россия','Казань','20180525','20180530','30000','1','1','7','6'),
		('Австралия','Мельбурн','20181230','20190111','430000','5','7','8','5'),
		('Китай','Пекин','20180613','20180620','100000','6','4','9','3');

UPDATE Tour
SET BeginDate = '20181016', EndDate='20181022'
WHERE IdTour='1'

INSERT INTO TouristGroup (NumberOfTourists, CustomerLastName, CustomerFirstName, CustomerPhone, CustomerEmail)
VALUES  ('2','Иванов','Иван', '+7 915 2479101','ivanov_ivan23@mail.ru'),
		('3','Петрова','Ксения', '+7 916 3343785','kseniaa15petrova@ya.ru'),
		('1','Cмирнова','Екатерина', '+7 917 3492645','smirnovaKatya@mail.ru'),
		('4','Кузнецова','Валерия', '+7 916 3343785','kuznetz3487@ya.ru'),
		('2','Михайлова','Ирина', '+7 917 1398214','irinaMih7@ya.ru')

		
INSERT INTO Tourist (GroupId, LastName, FirstName, PassportNumber,DateOfBirth,TouristPhone,TouristEmail)
VALUES  ('1','Иванов','Иван','123456789','19800302','+7 915 2479101','ivanov_ivan23@mail.ru'),
		('1','Иванова','Мария','123256387','19851205','+7 915 3659107','ivanovaM@mail.ru'),
		('2','Петров','Александр','646259380','19741102','+7 917 3559106','alexPetrov74@ya.ru'),
		('2','Петрова','Ксения','345253390','19750415','+7 916 3343785','kseniaa15petrova@ya.ru'),
		('2','Петрова','Дарья','462253890','20020619','+7 916 3343785',''),
		('4','Журавлева','Кристина','428659536','19730110','+7 916 3343785','krisjur@mail.ru'),
		('4','Попова','Анастасия','594753395','19731202','+7 916 3343785','nastyanastya@ya.ru'),
		('4','Кузнецова','Валерия','541236394','19730923','+7 916 3343785','kuznetz3487@ya.ru'),
		('3','Барышников','Олег','934567313','19680831','+7 999 1561298','oleggg7@ya.ru'),
		('5','Михайлов','Игорь','236728625','19830224','+7 915 1628945','igormih7@ya.ru'),
		('5','Михайлова','Ирина','437236272','19881013','+7 917 1398214','irinaMih7@ya.ru'),
		('4','Петрова','Ксения','345253390','19750415','+7 916 3343785','kseniaa15petrova@ya.ru');

DELETE Tourist 
WHERE IdTourist='43'


INSERT INTO Orders (TourId, GroupId, OrderDate, PaymentDate, Status, PaymentStatus)
VALUES  ('1','1','20180330','20180404','Документы не готовы','Оплачен'),
		('3','2','20180415',NULL,'Ожидает подтверждения','Не оплачен'),
		('7','3','20180413',NULL,'Подтвержден','Не оплачен'),
		('2','4','20180222','20180304','Готов','Оплачен'),
		('9','5','20171114','20171129','Документы не готовы','Оплачен')

INSERT INTO LoginPassword(LoginName, Pass)
VALUES  ('Admin','2345'),
		('Manager1','1')

SELECT * FROM Tour
SELECT * FROM Accommodation
SELECT * FROM Airline
SELECT * FROM TourOperator
SELECT * FROM Insurance
SELECT * FROM TouristGroup
SELECT * FROM Tourist
SELECT * FROM Orders
SELECT * FROM LoginPassword