---
title: ObjectIdentifierAttribute
---

# <small>BH.oM.Analytical.Results.</small>**ObjectIdentifierAttribute**

Attribute to be assigned to properties of `IResult`-implementing classes. Tagged properties must contain the Identifier of the object (or of a subpart of the object) which the result is targeting.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ObjectIdentifierAttribute is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Analytical.Results.[IdentifierAttribute](/api/oM/Analytical/Analytical/Results/Attributes/IdentifierAttribute)
    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties

### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ObjectIdentifierAttribute : BH.oM.Analytical.Results.IdentifierAttribute, System.Attribute, BH.oM.Base.IObject
```

Assembly: Analytical_oM.dll

The class is defined in C#. The class definition is available on github:

- [ObjectIdentifierAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Results\Attributes\ObjectIdentifierAttribute.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Analytical_oM/Results/ObjectIdentifierAttribute.json}
```

The JSON Schema is available on github here:

- [ObjectIdentifierAttribute.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Analytical_oM/Results/ObjectIdentifierAttribute.json)
