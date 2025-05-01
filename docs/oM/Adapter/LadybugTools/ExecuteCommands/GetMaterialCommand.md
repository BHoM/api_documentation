---
title: GetMaterialCommand
---

# <small>BH.oM.LadybugTools.</small>**GetMaterialCommand**

Command that when executed with the LadybugTools Adapter, returns a list of materials from the Python Materials list.

## Class structure

### Implemented interfaces and base types

???+ bhom "The GetMaterialCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Filter | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Text to filter the resultant list by. Filter applies to the Material Name. Leave blank to return all Materials. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class GetMaterialCommand : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The class is defined in C#. The class definition is available on github:

- [GetMaterialCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands\GetMaterialCommand.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/GetMaterialCommand.json"
}
```

The JSON Schema is available on github here:

- [GetMaterialCommand.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/GetMaterialCommand.json)
