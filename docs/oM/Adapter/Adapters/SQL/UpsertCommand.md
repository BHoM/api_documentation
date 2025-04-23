---
title: UpsertCommand
---

# Adapters.SQL.UpsertCommand

Specify objects to update or insert (upsert) depending on whether existing data exists. If the data does not exist based on the Primary Key given, then the data is inserted into the table. If the data did previously exist, then its columns are updated.

## Class structure

### Implemented interfaces and base types

???+ bhom "The UpsertCommand in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/IExecuteCommand)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PrimaryKey | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Specify the primary key of the data used to identify existing data to update, or to insert if the data does not exist. | - |
| DefaultPrimaryKeyValue | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Specify what the default value of your primary key is to determine whether data should be updated or inserted. E.G. if your primary key is 'ID' and is of type 'int', then specify 0 for objects which are new and need inserting. | - |
| PrimaryKeyType | [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0) | Set the type of the primary key value - used to ensure queried properties from objects to upsert match the right type and the DefaultPrimaryKeyValue is correctly casted to this type. | - |
| ObjectsToUpsert | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | List of objects which are to be upserted into the database. Objects must all be of a single type. | - |
| Table | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The name of the table which the data should be upserted to. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [UpsertCommand.cs](https://github.com/BHoM/SQL_Toolkit/blob/develop/SQL_oM/Commands/UpsertCommand.cs)

All history and changes of the class can be found by inspection the history.
