---
title: Roof
---

# <small>BH.oM.Environment.SAP.XML.</small>**Roof**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Roof is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Unique name which identifies this roof.  Can be just a number, e.g. "1".  However, a roof cannot have the same name as a wall. | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Descriptive notes about the roof. | - |
| UValue | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Exposed roof U-value. | - |
| Area | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Total roof area in square metres, inclusive of any openings. | - |
| Type | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| KappaValue | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Heat capacity per unit area in kJ/m�K. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Roof : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: SAP_oM.dll

The C# class definition is available on github:

- [Roof.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML\Roof.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/XML/Roof.json"
}
```

The JSON Schema is available on github here:

- [Roof.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/XML/Roof.json)
