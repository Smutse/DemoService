Use the package manager command to build the database creation file 'dotnet ef migrations add CreateInitial'
Use the package manager command to build the database 'dotnet ef database update'

Use the below cql to populate after importing data as flat table: 


SET IDENTITY_INSERT[MeterReadingsDb].[dbo].[Accounts] ON


insert into [MeterReadingsDb].[dbo].[Accounts] ([AccountId]
,[FirstName]
,[LastName])
SELECT[AccountId]
      ,[FirstName]
      ,[LastName]

FROM[MeterReadingsDb].[dbo].[Test_Accounts]

  SET IDENTITY_INSERT[MeterReadingsDb].[dbo].[Accounts] off