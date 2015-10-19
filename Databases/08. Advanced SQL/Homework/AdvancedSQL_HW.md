## 05. Advanced SQL
### _Homework_

1.	Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
	*	Use a nested `SELECT` statement.

			SELECT e.FirstName + ' ' + e.LastName AS FullName,
			Salary
			FROM Employees e
			WHERE Salary=(SELECT MIN(Salary) FROM Employees)

1.	Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.

		SELECT e.FirstName + ' ' + e.LastName AS FullName,
		Salary
		FROM Employees e
		WHERE Salary>(SELECT MIN(Salary)*1.1 FROM Employees)

1.	Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
	*	Use a nested `SELECT` statement.

			SELECT FirstName + ' ' + LastName AS FullName,
			Salary, d.Name
			FROM Employees e 
			JOIN Departments d ON e.DepartmentID=d.DepartmentID
			WHERE Salary=(SELECT MIN(Salary) FROM Employees emp
			WHERE emp.DepartmentID=d.DepartmentID)

1.	Write a SQL query to find the average salary in the department #1.

		SELECT AVG(e.Salary) AS AVGSalaray
		FROM Employees e	
		WHERE e.DepartmentID=1

1.	Write a SQL query to find the average salary  in the "Sales" department.

		SELECT AVG(e.Salary) AS AVGSalaray
		FROM Employees e
		JOIN Departments d 
		ON e.DepartmentID=d.DepartmentID 
		AND d.Name = 'Sales';

1.	Write a SQL query to find the number of employees in the "Sales" department.

		SELECT COUNT(*) Cnt 
		FROM Employees e
		JOIN Departments d
		ON e.DepartmentID=d.DepartmentID
		AND d.Name = 'Sales';

1.	Write a SQL query to find the number of all employees that have manager.

		SELECT COUNT(*) Cnt 
		FROM Employees e
		WHERE e.ManagerID IS NOT NULL;

1.	Write a SQL query to find the number of all employees that have no manager.

		SELECT COUNT(*) Cnt 
		FROM Employees e
		WHERE e.ManagerID IS NULL;

1.	Write a SQL query to find all departments and the average salary for each of them.

		SELECT AVG(Salary) AS AVGSalary, d.Name AS Department 
		FROM Employees e
		JOIN Departments d
		ON e.DepartmentID=d.DepartmentID
		GROUP BY d.Name	

1.	Write a SQL query to find the count of all employees in each department and for each town.

		SELECT COUNT(e.EmployeeID) AS empNum, d.Name AS Department, t.Name AS Town
		FROM Employees e
		JOIN Departments d ON e.DepartmentID=d.DepartmentID
		JOIN Addresses a ON a.AddressID=e.AddressID
		JOIN Towns t ON t.TownID=a.TownID
		GROUP BY d.Name, t.Name

1.	Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.

		SELECT m.FirstName + ' ' + m.LastName AS Manager,
		COUNT(m.EmployeeID) AS EmpCount
		FROM Employees m
		JOIN Employees emp
		ON emp.ManagerID = m.EmployeeID
		GROUP BY m.EmployeeID, m.FirstName, m.LastName
		HAVING COUNT(m.EmployeeID) = 5

1.	Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".

		SELECT e.FirstName + ' ' + e.LastName AS Employee,
		ISNULL(m.FirstName + ' ' + m.LastName, 'No manager') As Manager
		FROM Employees e
		LEFT JOIN Employees m ON e.ManagerID=m.EmployeeID

1.	Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in `LEN(str)` function.

		SELECT e.FirstName + ' ' + e.LastName AS Employee
		FROM Employees e WHERE LEN(e.LastName)=5

1.	Write a SQL query to display the current date and time in the following format "`day.month.year hour:minutes:seconds:milliseconds`".
	*	Search in Google to find how to format dates in SQL Server.

			SELECT FORMAT(GETDATE(), 'dd.MM.yyyy HH:mm:ss:fff')

1.	Write a SQL statement to create a table `Users`. Users should have username, password, full name and last login time.
	*	Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
	*	Define the primary key column as identity to facilitate inserting records.
	*	Define unique constraint to avoid repeating usernames.
	*	Define a check constraint to ensure the password is at least 5 characters long.

			CREATE TABLE Users(
			UserID int IDENTITY PRIMARY KEY,
			Username nvarchar(20) NOT NULL CHECK(LEN(Username)>3) UNIQUE,
			Pass nvarchar(30) NOT NULL CHECK(LEN(Pass)>5),
			FullName nvarchar(100) NOT NULL CHECK(LEN(FullName)>3),
			LastLogin DATETIME NOT NULL
			)

1.	Write a SQL statement to create a view that displays the users from the `Users` table that have been in the system today.
	*	Test if the view works correctly.

			CREATE VIEW [Logged Users Today] AS 
			SELECT Username FROM Users
			WHERE DATEDIFF(DAY, LastLogin, GETDATE()) = 0

1.	Write a SQL statement to create a table `Groups`. Groups should have unique name (use unique constraint).
	*	Define primary key and identity column.
			
			CREATE TABLE Groups(
			GroupID int IDENTITY PRIMARY KEY,
			Name nvarchar(20) NOT NULL CHECK(LEN(Name)>3) UNIQUE
			)

1.	Write a SQL statement to add a column `GroupID` to the table `Users`.
	*	Fill some data in this new column and as well in the `Groups` table.
	*	Write a SQL statement to add a foreign key constraint between tables `Users` and `Groups` tables.

			ALTER TABLE Users
			Add GroupID int NOT NULL
			
			ALTER TABLE Users
			ADD CONSTRAINT FK_Users_Groups
			FOREIGN KEY(GroupID)
			REFERENCES Groups(GroupID)

1.	Write SQL statements to insert several records in the `Users` and `Groups` tables.

		INSERT INTO Groups VALUES
		('Telerik'),
		('FaceB'),
		('Gmail')
		
		INSERT INTO Users VALUES
		('username1', 'pass12345', 'fullname1', '2015-10-10 00:00:00', 1),
		('username2', 'pass12345', 'fullname2', '2015-10-10 00:00:00', 2),
		('username3', 'pass12345', 'fullname3', '2015-10-10 00:00:00', 1),
		('username4', 'pass12345', 'fullname4', '2015-10-10 00:00:00', 3)

1.	Write SQL statements to update some of the records in the `Users` and `Groups` tables.

		UPDATE Users
		SET Username=REPLACE(Username,'username','user4e')
		WHERE Username='username2';

1.	Write SQL statements to delete some of the records from the `Users` and `Groups` tables.

		DELETE 
		FROM TelerikAcademy.dbo.Users
		WHERE TelerikAcademy.dbo.Users.GroupID=2;
		
		DELETE FROM TelerikAcademy.dbo.Groups
		WHERE TelerikAcademy.dbo.Groups.GroupID=2;

1.	Write SQL statements to insert in the `Users` table the names of all employees from the `Employees` table.
	*	Combine the first and last names as a full name.
	*	For username use the first letter of the first name + the last name (in lowercase).
	*	Use the same for the password, and `NULL` for last login time.

			INSERT INTO TelerikAcademy.dbo.Users 
			(myUsersDB.dbo.Username, 
			myUsersDB.dbo.Pass, 
			myUsersDB.dbo.FullName, 
			myUsersDB.dbo.LastLogin, 
			myUsersDB.dbo.GroupID)
			SELECT LOWER(CONCAT(LEFT( TelerikAcademy.dbo.Employees.FirstName, 5), '.', LEFT(TelerikAcademy.dbo.Employees.LastName, 5))),
			LOWER(CONCAT(TelerikAcademy.dbo.Employees.FirstName,'.', TelerikAcademy.dbo.Employees.LastName)),
			CONCAT(TelerikAcademy.dbo.Employees.FirstName, ' ', TelerikAcademy.dbo.Employees.LastName),
			'20100110 10:30:09 AM',
			1
			FROM TelerikAcademy.dbo.Employees

1.	Write a SQL statement that changes the password to `NULL` for all users that have not been in the system since 10.03.2010.

		UPDATE Users
		SET Pass = NULL
		WHERE DATEDIFF(day, LastLogin, '2010-3-10 00:00:00') > 0

1.	Write a SQL statement that deletes all users without passwords (`NULL` password).

		Delete FROM Users
		WHERE Pass IS NULL

1.	Write a SQL query to display the average employee salary by department and job title.

		SELECT AVG(e.Salary) AS AVGSalary,
		d.Name,
		e.JobTitle
		FROM Employees e
		JOIN Departments d
		ON e.DepartmentID=d.DepartmentID
		GROUP BY d.Name, e.JobTitle

1.	Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.

		SELECT MIN(e.Salary) AS MinSalary,
		d.Name,
		e.JobTitle,
		MIN(CONCAT(e.FirstName, ' ', e.LastName)) AS FullNAme
		FROM Employees e
		JOIN Departments d
		ON e.DepartmentID=d.DepartmentID
		GROUP BY d.Name, e.JobTitle
		ORDER BY e.JobTitle

1.	Write a SQL query to display the town where maximal number of employees work.

		SELECT MAX(e.EmployeeID) AS MaxEmps,
		t.Name
		FROM Employees e
		JOIN Addresses a
		ON a.AddressID=e.AddressID
		JOIN Towns t
		ON t.TownID=a.TownID
		GROUP BY e.EmployeeID, t.Name
		ORDER BY MaxEmps DESC

1.	Write a SQL query to display the number of managers from each town.

		SELECT COUNT(DISTINCT m.EmployeeID) AS CountManagers, t.Name
		FROM Employees m
		JOIN Addresses a
		ON m.AddressID=a.AddressID
		JOIN Towns t
		ON t.TownID=a.TownID
		JOIN Employees e
		ON m.EmployeeID=e.ManagerID
		GROUP BY t.Name
		ORDER BY CountManagers DESC

1.	Write a SQL to create table `WorkHours` to store work reports for each employee (employee id, date, task, hours, comments).
	*	Don't forget to define  identity, primary key and appropriate foreign key. 
	*	Issue few SQL statements to insert, update and delete of some data in the table.
	*	Define a table `WorkHoursLogs` to track all changes in the `WorkHours` table with triggers.
	*	For each change keep the old record data, the new record data and the command (insert / update / delete).

			USE TelerikAcademy;
			CREATE TABLE WorkHours(
			WorkHoursID int IDENTITY PRIMARY KEY,
			EmployeeID int NOT NULL,
			OnDate DATETIME NOT NULL,
			Task nvarchar(100) NOT NULL,
			HoursToWorkOn int NOT NULL,
			Comments nvarchar (300) NOT NULL,
			CONSTRAINT FK_EmpID_WorkH FOREIGN KEY (EmployeeID)
			REFERENCES Employees(EmployeeID)
			)
			GO
			
			DECLARE @counter int;
			SET @counter=1;
			WHILE @counter <= 20
			BEGIN
			INSERT INTO WorkHours(EmployeeID, OnDate, Task, HoursToWorkOn, Comments)
			VALUES (@counter, GETDATE(),'task: ' + CONVERT(nvarchar(3),@counter), @counter, 
					'comment: ' + CONVERT(nvarchar(3),@counter))
			SET @counter=@counter + 1
			END
			
			UPDATE WorkHours
			SET Comments='what a small task'
			WHERE HoursToWorkOn<3;
			DELETE FROM WorkHours
			WHERE HoursToWorkOn<2
			CREATE TABLE WorkHoursLog(
			WorkHoursLogID int PRIMARY KEY,
			EmployeeID int NOT NULL,
			OnDate DATETIME NOT NULL,
			Task nvarchar(100) NOT NULL,
			HoursToWorkOn int NOT NULL,
			Comments nvarchar (300) NOT NULL,
			ActionInLog nvarchar(50) NOT NULL,
			CONSTRAINT FK_EmpID_WorkH_Log FOREIGN KEY (EmployeeID)
			REFERENCES Employees(EmployeeID),
			CONSTRAINT WorkReportsLog CHECK (ActionInLog IN ('INSERT', 'DELETE', 'DELETEUPDATE', 'INSERTUPDATE'))
			)
			GO
			
			CREATE TRIGGER tr_InsertReport ON WorkHours FOR INSERT
			AS
			INSERT INTO WorkHoursLog(WorkHoursLogID, EmployeeID, OnDate, Task, HoursToWorkOn, Comments, ActionInLog)
			SELECT WorkHoursID, EmployeeID, OnDate, Task, HoursToWorkOn, Comments, 'INSERT'
			FROM inserted
			GO
			CREATE TRIGGER tr_DelReport ON WorkHours FOR DELETE
			AS
			INSERT INTO WorkHoursLog(WorkHoursLogID, EmployeeID, OnDate, Task, HoursToWorkOn, Comments, ActionInLog)
			SELECT WorkHoursID, EmployeeID, OnDate, Task, HoursToWorkOn, Comments, 'DELETE'
			FROM deleted
			GO
			CREATE TRIGGER tr_UpdReport ON WorkHours FOR UPDATE
			AS
			INSERT INTO WorkHoursLog(WorkHoursLogID, EmployeeID, OnDate, Task, HoursToWorkOn, Comments, ActionInLog)
			SELECT WorkHoursID, EmployeeID, OnDate, Task, HoursToWorkOn, Comments, 'INSERTUPDATE'
			FROM deleted
			INSERT INTO WorkHoursLog(WorkHoursLogID, EmployeeID, OnDate, Task, HoursToWorkOn, Comments, ActionInLog)
			SELECT WorkHoursID, EmployeeID, OnDate, Task, HoursToWorkOn, Comments, 'DELETEUPDATE'
			FROM deleted GO
			DELETE 
			FROM WorkHours
			INSERT INTO WorkHours(EmployeeID, OnDate, Task, HoursToWorkOn, Comments)
			VALUES (4, GETDATE(),'task: ' + 'latest task', 6, 'it is very important')
			DELETE 
			FROM WorkHours
			WHERE EmployeeID=4
			INSERT INTO WorkHours(EmployeeID, OnDate, Task, HoursToWorkOn, Comments)
			VALUES (8, GETDATE(),'task: ' + 'latest task1', 6, 'it is very important!')
			UPDATE WorkHours
			SET Comments='now it`s not'
			WHERE EmployeeID=8


1.	Start a database transaction, delete all employees from the '`Sales`' department along with all dependent records from the pother tables.
	*	At the end rollback the transaction.

			BEGIN TRAN
			
			ALTER TABLE Departments
				DROP CONSTRAINT FK_Departments_Employees
			GO
			
			DELETE e FROM  Employees e, Departments d
				WHERE e.DepartmentID=d.DepartmentID
				AND d.Name='Sales'
			
			ROLLBACK TRAN

1.	Start a database transaction and drop the table `EmployeesProjects`.
	*	Now how you could restore back the lost table data?

			BEGIN TRANSACTION
			
			DROP TABLE EmployeesProjects
			
			ROLLBACK TRANSACTION

1.	Find how to use temporary tables in SQL Server.
	*	Using temporary tables backup all records from `EmployeesProjects` and restore them back after dropping and re-creating the table.

			BEGIN TRAN
			SELECT * 
			INTO #TmpEmployeesProjects
			FROM EmployeesProjects
			
			DROP TABLE EmployeesProjects
			
			SELECT * 
			INTO EmployeesProjects 
			FROM #TmpEmployeesProjects
			
			DROP TABLE #TmpEmployeesProjects
			
			ROLLBACK TRAN