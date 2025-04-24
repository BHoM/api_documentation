---
title: CategoryDisciplineAttribute
---

# <small>BH.oM.Revit.</small>**CategoryDisciplineAttribute**

Attribute that defines disciplines, to which a category belongs as defined in Visibility &amp; Graphics window.
Allowed values of Disciplines property are: 'Architecture', 'Structure', 'Mechanical', 'Electrical', 'Piping' and 'Infrastructure'.
Each category added to Category needs to have CategoryDisciplineAttribute assigned to be successfully reflected.

## Class structure

### Implemented interfaces and base types

???+ bhom "The CategoryDisciplineAttribute is inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Disciplines | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)[] | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class CategoryDisciplineAttribute : System.Attribute, BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The class is defined in C#. The class definition is available on github:

- [CategoryDisciplineAttribute.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Attributes\CategoryDisciplineAttribute.cs)

All history and changes of the class can be found by inspection the history.
