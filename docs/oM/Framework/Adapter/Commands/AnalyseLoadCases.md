---
title: AnalyseLoadCases
---

# Adapter.Commands.AnalyseLoadCases

Used to instruct the external software to run an Analysis on certain load cases.

## Class structure

### Implemented interfaces and base types

???+ bhom "The AnalyseLoadCases in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/IExecuteCommand)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| LoadCases | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | This should contain Loadcases, Loadcombinations or identifiers of a type compatible with the specific Toolkit in use. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [AnalyseLoadCases.cs](https://github.com/BHoM/BHoM_Adapter/blob/develop/Adapter_oM/ExecuteCommands/AnalyseLoadCases.cs)

All history and changes of the class can be found by inspection the history.
