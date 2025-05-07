---
title: CategoryTypeAttribute
---

# <small>BH.oM.Revit.Attributes.</small>**CategoryTypeAttribute**

Attribute that defines Revit category type as defined in Visibility &amp; Graphics window.
Allowed values of Type property are: 'Model', 'Annotation', 'Analytical' and 'Internal'.
Each category added to Category needs to have CategoryTypeAttribute assigned to be successfully reflected.

## Class structure

### Implemented interfaces and base types

???+ bhom "The CategoryTypeAttribute is inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Type | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class CategoryTypeAttribute : System.Attribute, BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The C# class definition is available on github:

- [CategoryTypeAttribute.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Attributes\CategoryTypeAttribute.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Attributes/CategoryTypeAttribute.json"
}
```

The JSON Schema is available on github here:

- [CategoryTypeAttribute.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Attributes/CategoryTypeAttribute.json)
