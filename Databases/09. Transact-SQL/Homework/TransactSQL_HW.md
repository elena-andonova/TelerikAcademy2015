## 06. Transact SQL
### _Homework_

1.	Create a database with two tables: `Persons(Id(PK), FirstName, LastName, SSN)` and `Accounts(Id(PK), PersonId(FK), Balance)`.
	*	Insert few records for testing.
	*	Write a stored procedure that selects the full names of all persons.

			CREATE DATABASE BankAccounts
			GO
			
			USE BankAccounts
			GO

			CREATE TABLE Persons
			(Id INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
			 FirstName NVARCHAR(20), 
			 LastName NVARCHAR(20), 
			 SSN CHAR(10) 
			)
			GO

			CREATE TABLE Accounts
			(Id INT NOT NULL PRIMARY KEY IDENTITY,  
			 PersonId INT NOT NULL, 
			 Balance MONEY, 
			 CONSTRAINT FK_PersonID_Id FOREIGN KEY (PersonId) 
				REFERENCES Persons (Id) 
			)
			GO
			
			INSERT INTO Persons(FirstName, LastName, SSN)
			VALUES('Jane', 'Doe', '9010289094'), 
			('John', 'Dow', '9410179094')
			
			INSERT INTO Accounts(PersonId, Balance)
			VALUES (1, 125.50), (2, 635.15)
			GO


			CREATE PROC dbo.usp_SelectAllPersonsNames
			AS
			  SELECT FirstName + ' ' + LastName 
			  FROM Persons
			GO

			EXEC usp_SelectAllPersonsNames
			GO

1.	Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.

		CREATE PROC dbo.usp_SelectAllPersonsWithMoneyMoreThan(@number MONEY = 0)
		AS
		  SELECT p.FirstName + ' ' + p.LastName AS FullName,
		  a.Balance
		  FROM Persons p
			INNER JOIN Accounts a
			ON p.Id = a.PersonId
		  WHERE a.Balance > @number
		GO

		EXEC usp_SelectAllPersonsWithMoneyMoreThan 500
		GO
		EXEC usp_SelectAllPersonsWithMoneyMoreThan
		GO


1.	Create a function that accepts as parameters – sum, yearly interest rate and number of months.
	*	It should calculate and return the new sum.
	*	Write a `SELECT` to test whether the function works as expected.

			CREATE FUNCTION dbo.ufn_CalcSumWithRate(@sum MONEY, @rate DECIMAL, @months INT)
			RETURNS MONEY
			AS
			BEGIN
			RETURN @sum * (1 + (@rate * @months/12)/100)
			END
			GO
			
			SELECT Balance, dbo.ufn_CalcSumWithRate(Balance, 10.00, 6) AS RatedBalance
			FROM Accounts
			GO

1.	Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month.
	*	It should take the `AccountId` and the interest rate as parameters.

			CREATE PROC dbo.usp_FindInterestForOneMonth(@id INT, @rate DECIMAL)
			AS
			  UPDATE Accounts
			  SET Balance = dbo.ufn_CalcSumWithRate(Balance, @rate, 1)
			  WHERE Id = @id
			  SELECT p.FirstName + ' ' + p.LastName AS FullName, a.Balance
			  FROM Persons p
			    INNER JOIN Accounts a
			    ON p.Id = a.PersonId
			GO
			
			EXEC dbo.usp_FindInterestForOneMonth @id = 1, @rate = 10
			GO

1.	Add two more stored procedures `WithdrawMoney(AccountId, money)` and `DepositMoney(AccountId, money)` that operate in transactions.

			CREATE PROC dbo.usp_WithdrawMoney(@id INT, @amount MONEY)
			AS
			  UPDATE Accounts
			  SET Balance = Balance - @amount
			  WHERE Id = @id
			  SELECT p.FirstName + ' ' + p.LastName AS FullName, a.Balance
			  FROM Persons p
			    INNER JOIN Accounts a
			    ON p.Id = a.PersonId
			GO
			
			EXEC dbo.usp_WithdrawMoney 1, 100
			GO


			CREATE PROC dbo.usp_DepositMoney(@id INT, @amount MONEY)
			AS
			  UPDATE Accounts
			  SET Balance = Balance + @amount
			  WHERE Id = @id	
			  SELECT p.FirstName + ' ' + p.LastName AS FullName, a.Balance
			  FROM Persons p
			    INNER JOIN Accounts a
			    ON p.Id = a.PersonId
			GO
			
			EXEC dbo.usp_DepositMoney 1, 100
			GO

1.	Create another table – `Logs(LogID, AccountID, OldSum, NewSum)`.
	*	Add a trigger to the `Accounts` table that enters a new entry into the `Logs` table every time the sum on an account changes.

				CREATE TABLE Logs
			(LogsId INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
			AccountId INT NOT NULL, 
			OldSum MONEY, 
			NewSum MONEY
			CONSTRAINT FK_AccountID_Id FOREIGN KEY (AccountId) 
			    REFERENCES Accounts (Id)
			)
			GO

			CREATE TRIGGER tr_BalanceUpdate ON Accounts FOR UPDATE
			AS
			    DECLARE @oldSum money;
			    SELECT @oldSum = Balance FROM deleted;
			
			    INSERT INTO Logs(AccountId, OldSum, NewSum)
			        SELECT Id, @oldSum, Balance
			        FROM inserted
			GO
			
			EXEC usp_DepositMoney 1, 2000


1.	Define a function in the database `TelerikAcademy` that returns all Employee's names (first or middle or last name) and all town's names that are comprised of given set of letters.
	*	_Example_: '`oistmiahf`' will return '`Sofia`', '`Smith`', … but not '`Rob`' and '`Guy`'.

			USE TelerikAcademy
			GO
			
			CREATE FUNCTION ufn_SearchForWordsInGivenPattern(@pattern nvarchar(255))
				RETURNS @MatchedNames TABLE (Name varchar(50))
			AS
			BEGIN
				INSERT @MatchedNames
				SELECT * 
				FROM
					(SELECT e.FirstName FROM Employees e
			        UNION
			        SELECT e.LastName FROM Employees e
			        UNION 
			        SELECT t.Name FROM Towns t) as temp(name)
			    WHERE PATINDEX('%[' + @pattern + ']', Name) > 0
				RETURN
			END
			GO
			
			SELECT * FROM dbo.ufn_SearchForWordsInGivenPattern('oistmiahf')


1.	Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees that live in the same town.



1.	*Write a T-SQL script that shows for each town a list of all employees that live in it.
	*	_Sample output_:	
```sql
Sofia -> Martin Kulov, George Denchev
Ottawa -> Jose Saraiva
…
```

1.	Define a .NET aggregate function `StrConcat` that takes as input a sequence of strings and return a single string that consists of the input strings separated by '`,`'.
	*	For example the following SQL statement should return a single string:

```sql
SELECT StrConcat(FirstName + ' ' + LastName)
FROM Employees
```