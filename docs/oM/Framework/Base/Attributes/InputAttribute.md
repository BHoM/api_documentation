---
title: InputAttribute
---

# Base.Attributes.InputAttribute

Attribute providing information about an input parameter of a method.

## Class structure

### Implemented interfaces and base types

???+ bhom "The InputAttribute in inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the method parameter this attribute corresponds to. | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Description of the correspondent input parameter. | - |
| Classification | [ClassificationAttribute](/api_documentation/oM/Framework/Base/Attributes/ClassificationAttribute) | Classification of the correspondent input parameter, e.g. folder path, quantity etc. | - |
| Exposure | [UIExposure](/api_documentation/oM/Framework/Base/Attributes/Enums/UIExposure) | Information whether the correspondent input parameter is meant to be shown in the UI or not. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [InputAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Attributes\InputAttribute.cs)

All history and changes of the class can be found by inspection the history.
