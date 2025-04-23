---
title: OutputAttribute
---

# Base.Attributes.OutputAttribute

Attribute providing information about an output parameter of a method.
To be applied to all methods that do not return void nor BH.oM.Base.Output types.

## Class structure

### Implemented interfaces and base types

???+ bhom "The OutputAttribute in inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  Base.[IImmutable](/api/oM/Framework/Base/IImmutable)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the correspondent output parameter (to be used in the UI). | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Description of the correspondent output parameter. | - |
| Classification | [ClassificationAttribute](/api/oM/Framework/Base/Attributes/ClassificationAttribute) | Classification of the correspondent output parameter, e.g. folder path, quantity etc. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [OutputAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Attributes\OutputAttribute.cs)

All history and changes of the class can be found by inspection the history.
