---
title: UpgraderAttribute
---

# <small>BH.oM.Versioning.</small>**UpgraderAttribute**

Attribute identifying a class as an upgrader for versioning. The version specified should be the the version that the object is being upgraded to which generally correspond to the current version of the BHoM.

## Class structure

### Implemented interfaces and base types

???+ bhom "The UpgraderAttribute is inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| MajorVersion | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| MinorVersion | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class UpgraderAttribute : System.Attribute, BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: Versioning_oM.dll

The C# class definition is available on github:

- [UpgraderAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/Versioning_oM/Attributes\UpgraderAttribute.cs)

All history and changes of the class can be found by inspection the history.
