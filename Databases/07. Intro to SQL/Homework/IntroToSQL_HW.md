## Structured Query Language (SQL)
### _Homework_

1.	What is SQL? What is DML? What is DDL? Recite the most important SQL commands.
1.	What is Transact-SQL (T-SQL)?
1.	Start SQL Management Studio and connect to the database TelerikAcademy. Examine the major tables in the "TelerikAcademy" database.
1.	Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
			
		SELECT * FROM [Departments]

1.	Write a SQL query to find all department names.

		SELECT [Name] FROM [Departments]

1.	Write a SQL query to find the salary of each employee.

		SELECT [FirstName] + ' ' + [LastName] AS FullName, [Salary] FROM [Employees]

1.	Write a SQL to find the full name of each employee.

		SELECT [FirstName] + ' ' + ISNULL([MiddleName], '') + ' ' + [LastName] AS FullName FROM [Employees]

1.	Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".

		SELECT [FirstName] + '.' + [LastName] + '@' + 'telerik.com' AS [Full Email Addresses] FROM [Employees]

1.	Write a SQL query to find all different employee salaries.

		SELECT DISTINCT [Salary] FROM [Employees]

1.	Write a SQL query to find all information about the employees whose job title is “Sales Representative“.

		SELECT * FROM [Employees] WHERE [JobTitle] = 'Sales Representative'

1.	Write a SQL query to find the names of all employees whose first name starts with "SA".

		SELECT * FROM Employees WHERE FirstName LIKE 'Sa' + '%'

1.	Write a SQL query to find the names of all employees whose last name contains "ei".

		SELECT * FROM Employees WHERE CHARINDEX('ei', LastName) > 0

1.	Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

		SELECT * FROM Employees WHERE Salary BETWEEN 20000 AND 30000

1.	Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

		SELECT * FROM Employees WHERE 
		Salary=25000
		OR Salary=14000
		OR Salary=12500
		OR Salary=23600

1.	Write a SQL query to find all employees that do not have manager.

		SELECT FirstName + ' ' + LastName 
		FROM Employees WHERE ManagerID IS NULL

1.	Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.

		SELECT FirstName + ' ' + LastName AS FullName, Salary
		FROM Employees WHERE Salary > 50000
		ORDER BY Salary DESC

1.	Write a SQL query to find the top 5 best paid employees.

		SELECT TOP 5 FirstName + ' ' + LastName, Salary
		FROM Employees
		
		ORDER BY Salary DESC		

1.	Write a SQL query to find all employees along with their address. Use inner join with `ON` clause.

		SELECT e.FirstName, e.LastName, e.AddressID, a.AddressID, a.AddressText
		FROM Employees e
		JOIN Addresses a
		ON e.AddressID=a.AddressID

1.	Write a SQL query to find all employees and their address. Use equijoins (conditions in the `WHERE` clause).
		
		SELECT e.FirstName, e.LastName, a.AddressText
		FROM 
		Employees e,
		Addresses a
		WHERE e.AddressID=a.AddressID

1.	Write a SQL query to find all employees along with their manager.

		SELECT
		e.FirstName + ' ' + e.LastName AS Employee,
		ISNULL(m.FirstName + ' ' + m.LastName, 'No manager') AS Manager
		FROM Employees e
		LEFT JOIN Employees m
		ON e.ManagerID = m.EmployeeID

1.	Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: `Employees e`, `Employees m` and `Addresses a`.

		SELECT
		e.FirstName + ' ' + e.LastName AS Employee,
		ISNULL(m.FirstName + ' ' + m.LastName , 'No manager') AS Manager,
		a.AddressText
		FROM Employees e
		LEFT JOIN Employees m
		ON e.ManagerID = m.EmployeeID
		INNER JOIN Addresses a
		ON e.AddressID=a.AddressID

1.	Write a SQL query to find all departments and all town names as a single list. Use `UNION`.

		SELECT d.Name
		FROM Departments d
		UNION
		SELECT t.Name
		FROM Towns t

1.	Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.

		SELECT
		m.FirstName + ' ' + m.LastName AS Manager,
		ISNULL(e.FirstName + ' ' + e.LastName, 'No employees') AS Employee
		FROM Employees e
		RIGHT JOIN Employees m
		ON e.ManagerID = m.EmployeeID

1.	Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.

		SELECT
		e.FirstName + ' ' + e.LastName AS Employee,
		e.HireDate,
		d.Name AS DepartmentName
		FROM Employees e, Departments d 
		WHERE e.DepartmentID=d.DepartmentID 
		AND (d.Name IN ('Sales','Finance')) AND 
		e.HireDate BETWEEN '1995-01-01' AND '2005-12-3'