---
title: Transfer
---

# <small>BH.oM.Adapters.Mongo.Commands.</small>**Transfer**

Used to instruct Mongo to transfer from a database to another.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Transfer is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Destination | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | This has to be a MongoAdapter instance. | - |
| ReplaceContent | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Transfer : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: Mongo_oM.dll

The C# class definition is available on github:

- [Transfer.cs](https://github.com/BHoM/Mongo_Toolkit/blob/develop/Mongo_oM/Commands\Transfer.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Mongo_oM/Commands/Transfer.json"
}
```

The JSON Schema is available on github here:

- [Transfer.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Mongo_oM/Commands/Transfer.json)
