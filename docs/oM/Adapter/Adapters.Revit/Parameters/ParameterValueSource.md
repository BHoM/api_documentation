---
title: ParameterValueSource
---

# <small>BH.oM.Adapters.Revit.</small>**ParameterValueSource**

Object pointing at a Revit parameter as the source of a value to extract.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ParameterValueSource is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Conditions.[IValueSource](/api/oM/Framework/Verification/Conditions/Interfaces/IValueSource)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ParameterName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the parameter to extract the value from. | - |
| FromType | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the value to be extracted from the underlying type, not the instance. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IValueSourceLabel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a human readable label for a value source based on provided value condition reporting config. | - | Verification_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ParameterValueSource : BH.oM.Verification.Conditions.IValueSource, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The class is defined in C#. The class definition is available on github:

- [ParameterValueSource.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Parameters\ParameterValueSource.cs)

All history and changes of the class can be found by inspection the history.
