---
title: InputAttribute
---

# <small>BH.oM.Base.Attributes.</small>**InputAttribute**

Attribute providing information about an input parameter of a method.

## Class structure

### Implemented interfaces and base types

???+ bhom "The InputAttribute is inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the method parameter this attribute corresponds to. | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Description of the correspondent input parameter. | - |
| Classification | [ClassificationAttribute](/api/oM/Framework/Base/Attributes/ClassificationAttribute) | Classification of the correspondent input parameter, e.g. folder path, quantity etc. | - |
| Exposure | [UIExposure](/api/oM/Framework/Base/Attributes/Enums/UIExposure) | Information whether the correspondent input parameter is meant to be shown in the UI or not. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class InputAttribute : System.Attribute, BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# class definition is available on github:

- [InputAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Attributes\InputAttribute.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/Attributes/InputAttribute.json"
}
```

The JSON Schema is available on github here:

- [InputAttribute.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/Attributes/InputAttribute.json)
