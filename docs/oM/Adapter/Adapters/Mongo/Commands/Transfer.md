---
title: Transfer
---

# Adapters.Mongo.Commands.Transfer

Used to instruct Mongo to transfer from a database to another.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Transfer in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapter.[IExecuteCommand](/om_documentation/oM/Framework/Adapter/IExecuteCommand)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Destination | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | This has to be a MongoAdapter instance. | - |
| ReplaceContent | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Transfer.cs](https://github.com/BHoM/Mongo_Toolkit/blob/develop/Mongo_oM/Commands/Transfer.cs)

All history and changes of the class can be found by inspection the history.
