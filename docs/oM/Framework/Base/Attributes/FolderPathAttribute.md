---
title: FolderPathAttribute
---

# Base.Attributes.FolderPathAttribute

Path to a folder in the client's file system.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FolderPathAttribute in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.Attributes.[ClassificationAttribute](/om_documentation/oM/Framework/Base/Attributes/ClassificationAttribute)
    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  Base.[IImmutable](/om_documentation/oM/Framework/Base/IImmutable)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties

### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the method parameter this attribute corresponds to (not relevant in case of object properties). | - |
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Return the description of a folder path attribute. | - | Reflection_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Return the custom description of a classification attribute. | - | Reflection_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [FolderPathAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Attributes\FolderPathAttribute.cs)

All history and changes of the class can be found by inspection the history.
