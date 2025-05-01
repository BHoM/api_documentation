---
title: IdentifierAttribute
---

# <small>BH.oM.Analytical.Results.</small>**IdentifierAttribute**

Base attribute for identifier attributes for properties of results.

## Class structure

### Implemented interfaces and base types

???+ bhom "The IdentifierAttribute is inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes inheriting from this class

???+ bhom "The following classes are inheriting from this class:"

    - BH.oM.Analytical.Results.[ObjectIdentifierAttribute](/api/oM/Analytical/Analytical/Results/Attributes/ObjectIdentifierAttribute)
    - BH.oM.Analytical.Results.[ScenarioIdentifierAttribute](/api/oM/Analytical/Analytical/Results/Attributes/ScenarioIdentifierAttribute)


## Properties

### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public abstract class IdentifierAttribute : System.Attribute, BH.oM.Base.IObject
```

Assembly: Analytical_oM.dll

The C# abstract class definition is available on github:

- [IdentifierAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Results\Attributes\IdentifierAttribute.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Analytical_oM/Results/IdentifierAttribute.json"
}
```

The JSON Schema is available on github here:

- [IdentifierAttribute.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Analytical_oM/Results/IdentifierAttribute.json)
