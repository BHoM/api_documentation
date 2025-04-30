---
title: AnalyseLoadCases
---

# <small>BH.oM.Adapter.Commands.</small>**AnalyseLoadCases**

Used to instruct the external software to run an Analysis on certain load cases.

## Class structure

### Implemented interfaces and base types

???+ bhom "The AnalyseLoadCases is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| LoadCases | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | This should contain Loadcases, Loadcombinations or identifiers of a type compatible with the specific Toolkit in use. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class AnalyseLoadCases : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: Adapter_oM.dll

The class is defined in C#. The class definition is available on github:

- [AnalyseLoadCases.cs](https://github.com/BHoM/BHoM_Adapter/blob/develop/Adapter_oM/ExecuteCommands\AnalyseLoadCases.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Adapter_oM/Commands/AnalyseLoadCases.json}
```

The JSON Schema is available on github here:

- [AnalyseLoadCases.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Adapter_oM/Commands/AnalyseLoadCases.json)
