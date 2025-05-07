---
title: ComparisonInclusion
---

# <small>BH.oM.Base.</small>**ComparisonInclusion**

Information about how an object's property should be included or not in a comparison (i.e. when computing an object's Hash or Diffing).A ComparisonInclusion object is returned by the extension method of the same name (which is invoked automatically when Hashing or Diffing).The ComparisonInclusion() method can be implemented in specific Toolkits/namespaces to customise the comparison (i.e. with Toolkit-specific information which would be otherwise unavailable to the base Hash/Diffing).See the wiki for examples of this.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ComparisonInclusion is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Include | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Whether the current property should be included or not in the comparison (i.e. Hash or Diffing). | - |
| DisplayName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A custom DisplayName can be set so changes detected will be displayed with this name instead of the default Property Name. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ComparisonInclusion : BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# class definition is available on github:

- [ComparisonInclusion.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/ComparisonInclusion.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/ComparisonInclusion.json"
}
```

The JSON Schema is available on github here:

- [ComparisonInclusion.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/ComparisonInclusion.json)
