---
title: Loading
---

# <small>BH.oM.</small>**Loading**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Loading is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SelfWeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| VariableLoad | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| WindLoad | [WindLoad](/api/oM/Physical/dKoP/Perfomance/Loading/WindLoad) | - | - |
| SnowLoad | [SnowLoad](/api/oM/Physical/dKoP/Perfomance/Loading/SnowLoad) | - | - |
| StructuralConfirmation | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| StructuralVerificationMethod | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| ContinuousHeadRestraint | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| MaxUnrestrainedLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Loading : BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [Loading.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Perfomance\Loading\Loading.cs)

All history and changes of the class can be found by inspection the history.
