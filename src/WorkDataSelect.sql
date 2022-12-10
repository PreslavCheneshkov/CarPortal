SELECT 
	r.Id AS RegionId,
	r.[Name] AS RegionName,
	c.Id AS CityId,
	c.[Name] AS CityName
FROM Cities AS c
JOIN Regions AS r ON RegionId = r.Id

SELECT
	man.Id AS ManufacturerID,
	man.[Name] AS ManufacturerName,
	mo.Id AS ModelID,
	mo.[Name] AS ModelName
FROM Models AS mo
JOIN Manufacturers AS man ON mo.ManufacturerId = man.Id

SELECT * FROM VehicleCategories
SELECT * FROM FuelTypes
SELECT * FROM TransmissionTypes
SELECT * FROM Extras
SELECT * FROM Colors
