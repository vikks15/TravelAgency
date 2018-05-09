USE TravelAgency
-- ------------Nuber of orders for period---------------------------------
select * from orders
SELECT COUNT(IdOrders) AS SumOfOrders FROM Orders 
WHERE PaymentDate IS NOT NULL AND PaymentDate > '20180401' AND PaymentDate < '20180509'

-- ------------Orders for period-------------------------------------
SELECT IdOrders, Country, City, OrderDate, PaymentStatus
FROM Orders, Tour
WHERE (TourId=IdTour) AND (OrderDate BETWEEN '20180303' AND '20180405')

-- ------------Orders by country-------------------------------------
SELECT IdOrders, Country, City, EndDate, BeginDate, OrderDate
FROM Orders, Tour
WHERE  (TourId=IdTour) AND (Country='Австрия') AND (PaymentDate IS NOT NULL)

-- ---------------------------Income------------------------------
Select * FROM TouristGroup
Select * FROM Orders
Select * FROM Tour
SELECT COUNT(IdOrders) as NumOfOrders, Country, SUM(NumberOfTourists*Price) as TotalPrice
FROM TouristGroup, Orders, Tour
WHERE (IdTour=TourId) AND (GroupId=IdGroup)
GROUP BY Country

-- -----------Income by country-----------------------
Select * FROM TouristGroup
Select * FROM Orders
Select * FROM Tour
SELECT COUNT(IdOrders) as NumOfOrders, Country, SUM(NumberOfTourists*Price) as TotalPrice
FROM TouristGroup, Orders, Tour
WHERE (Country='Турция') AND (IdTour=TourId) AND (GroupId=IdGroup)
GROUP BY Country

