To run code in VS Code

1) Create and run .net projects in vs code. 
   dotnet new -l  (to see list of all projects in vs code.)
   dotnet new console  (to create new .net core project).
   dotnet new mvc      (to create asp.net core mvc project).
   ....                (continues) 
   dotnet run          (to run project).

2) Ctrl+K+O to open already created projects in vs code.

3) For Database access.
RunCommand> dotnet add package Microsoft.Data.SqlClient --version 4.1.0
(or get latest package version from https://www.nuget.org/packages/Microsoft.Data.SqlClient)

step 1:
Install SQL Server (mssql) extension in your vs code.
Step 2:
Download and install SQL server Express edition.
Step 3:
Search services and open computer services and make sure SQL SERVER(SQLEXPRESS) service is up and running if(not){Start this service}.
Step 4:
Click on add connection in VS Code:
    >server name: .\sqlexpress
    >Database name: master
    >Select Integrated
    >profile name: local
Step 5:
    Create new database and add tables to your database.
>CREATE DATABASE aux;
>CREATE TABLE Users(
    [uid] INT IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (100) NOT NULL,
    [email] VARCHAR (100) NOT NULL,
    [username] VARCHAR (100) NOT NULL,
    [password] VARCHAR (100) NOT NULL,
    PRIMARY KEY (uid),
    UNIQUE(username)
);
Step 6:
Use this connection string.
string constr = @"Server=localhost\SQLEXPRESS;Database=aux;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
Replace Database name in above connection string with the one you just created.


------------------------------------------sql server on command line------------------------------------------
if(password_protected)
{
	sqlcmd -S localhost\SQLEXPRESS -U AUX
	password>........
}
else
{
	sqlcmd -S localhost\SQLEXPRESS

	SELECT DB_NAME()                                               //TO CHECK CURRENT CONNECTED DB
	GO

	SELECT NAME FROM SYS.DATABASES                                 //TO SEE ALL DATABASES
	GO

	USE AUX                                                        //TO CONNECT TO THE DATABASE NAMED AUXI
	GO	
	
	SELECT TABLE_NAME FROM AUXI.INFORMATION_SCHEMA.TABLES;         //TO SHOW TABLES IN THAT DB.
	GO

	SELECT * FROM USERS;                                           //EXECUTE QUERY
	GO
}

Enjoy :)
