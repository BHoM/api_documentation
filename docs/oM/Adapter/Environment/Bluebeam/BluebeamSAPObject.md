---
title: BluebeamSAPObject
---

# <small>BH.oM.Environment.SAP.Bluebeam.</small>**BluebeamSAPObject**



## Class structure

### Implemented interfaces and base types

???+ bhom "The BluebeamSAPObject is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes inheriting from this class

???+ bhom "The following classes are inheriting from this class:"

    - BH.oM.Environment.SAP.Bluebeam.[SAPMarkup](/api/oM/Adapter/Environment/Bluebeam/SAPMarkup)
    - BH.oM.Environment.SAP.Bluebeam.[SAPMarkupSummary](/api/oM/Adapter/Environment/Bluebeam/SAPMarkupSummary)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class BluebeamSAPObject : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: SAP_oM.dll

The class is defined in C#. The class definition is available on github:

- [BluebeamSAPObject.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Bluebeam\BluebeamSAPObject.cs)

All history and changes of the class can be found by inspection the history.
