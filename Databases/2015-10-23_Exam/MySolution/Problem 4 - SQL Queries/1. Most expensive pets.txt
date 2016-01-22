SELECT TOP 5 dbo.Pets.Price, dbo.Pets.Breed, DATEPART(YEAR, dbo.Pets.DateOfBirth) AS BirthYear
FROM PetStore.dbo.Pets
WHERE DATEPART(YEAR, dbo.Pets.DateOfBirth) >= 2012 
ORDER BY Pets.Price DESC