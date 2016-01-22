CREATE PROC dbo.usp_SeedInitialColors
AS
	IF ((SELECT COUNT(*) FROM dbo.Colors) = 0)
		BEGIN
			INSERT INTO PetStore.dbo.Colors(Name)
			VALUES ('Black'), ('White'), ('Red'), ('Mixed')			
		END
	ELSE
		PRINT 'There are already colors in the database!'
GO

EXEC dbo.usp_SeedInitialColors
GO