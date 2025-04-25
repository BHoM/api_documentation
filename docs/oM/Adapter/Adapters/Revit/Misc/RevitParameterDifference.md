---
title: RevitParameterDifference
---

# <small>BH.oM.Adapters.Revit.</small>**RevitParameterDifference**

Represents a difference in terms of RevitParameters found between a Previous and Following version of an object.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevitParameterDifference is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Diffing.[IPropertyDifference](/api/oM/Framework/Diffing/IPropertyDifference)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The name of the Parameter that is different. | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A human-friendly description associated with this difference. | - |
| PastValue | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | The older value of this RevitParameter (associated with the past version of the object). | - |
| FollowingValue | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | The newer value of this RevitParameter (associated with the following version of the object). | - |
| UnitType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Unit type of the Revit parameter. | - |
| FullName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Full Name of the object's property that owns the RevitParameter that was different. | - |
| DifferenceType | [RevitParameterDifferenceType](/api/oM/Adapter/Adapters/Revit/Enums/RevitParameterDifferenceType) | Whether the RevitParameter that is Different was Modified, Removed or Added with respect to the old version of the owner object. Useful for filtering. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RevitParameterDifference : BH.oM.Diffing.IPropertyDifference, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The class is defined in C#. The class definition is available on github:

- [RevitParameterDifference.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Misc\RevitParameterDifference.cs)

All history and changes of the class can be found by inspection the history.
