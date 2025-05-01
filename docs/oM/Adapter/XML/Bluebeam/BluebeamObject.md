---
title: BluebeamObject
---

# <small>BH.oM.XML.Bluebeam.</small>**BluebeamObject**



## Class structure

### Implemented interfaces and base types

???+ bhom "The BluebeamObject is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes inheriting from this class

???+ bhom "The following classes are inheriting from this class:"

    - BH.oM.XML.Bluebeam.[Markup](/api/oM/Adapter/XML/Bluebeam/Markup)
    - BH.oM.XML.Bluebeam.[MarkupSummary](/api/oM/Adapter/XML/Bluebeam/MarkupSummary)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class BluebeamObject : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: XML_oM.dll

The C# class definition is available on github:

- [BluebeamObject.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/Bluebeam\BluebeamObject.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/XML_oM/Bluebeam/BluebeamObject.json"
}
```

The JSON Schema is available on github here:

- [BluebeamObject.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/XML_oM/Bluebeam/BluebeamObject.json)
