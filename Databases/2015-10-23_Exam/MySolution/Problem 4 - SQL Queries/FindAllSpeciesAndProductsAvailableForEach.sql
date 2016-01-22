SELECT s.Name AS SpeciesName, COUNT(ps.ProductId) AS ProductsAvailableForThisSpecies
FROM ProductsSpecies ps
JOIN Species s ON ps.SpeciesId = s.SpeciesId
GROUP BY s.Name
ORDER BY ProductsAvailableForThisSpecies ASC