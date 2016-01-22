CREATE PROC dbo.usp_CheckAndSeedInitialColors
AS
	BEGIN
	IF (EXISTS(SELECT dbo.Colors.Name FROM dbo.Colors WHERE Colors.Name = 'Black'))
	PRINT 'The color Black is already in the database!'
	ELSE 
	INSERT INTO PetStore.dbo.Colors(Name) VALUES ('Black')
	END

	BEGIN
	IF (EXISTS(SELECT dbo.Colors.Name FROM dbo.Colors WHERE Colors.Name = 'White'))
	PRINT 'The color White is already in the database!'
	ELSE 
	INSERT INTO PetStore.dbo.Colors(Name) VALUES ('White')
	END

	BEGIN
	IF (EXISTS(SELECT dbo.Colors.Name FROM dbo.Colors WHERE Colors.Name = 'Red'))
	PRINT 'The color Red is already in the database!'
	ELSE 
	INSERT INTO PetStore.dbo.Colors(Name) VALUES ('Red')
	END

	BEGIN
	IF (EXISTS(SELECT dbo.Colors.Name FROM dbo.Colors WHERE Colors.Name = 'Mixed'))
	PRINT 'The color Mixed is already in the database!'
	ELSE 
	INSERT INTO PetStore.dbo.Colors(Name) VALUES ('Mixed')
	END
GO

EXEC dbo.usp_CheckAndSeedInitialColors
GO