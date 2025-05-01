---
title: PanelOffsetByPoint
---

# <small>BH.oM.Adapters.SAP2000.Fragments.</small>**PanelOffsetByPoint**



## Class structure

### Implemented interfaces and base types

???+ bhom "The PanelOffsetByPoint is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.SAP2000.Fragments.[IPanelOffset](/api/oM/Adapter/Adapters/SAP2000/Fragments/IPanelOffset)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Offset | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)[] | This is an array of joint offsets for each of the points that define the area object. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PanelOffsetByPoint : BH.oM.Adapters.SAP2000.Fragments.IPanelOffset, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: SAP2000_oM.dll

The C# class definition is available on github:

- [PanelOffsetByPoint.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments\PanelOffsetByPoint.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP2000_oM/Fragments/PanelOffsetByPoint.json"
}
```

The JSON Schema is available on github here:

- [PanelOffsetByPoint.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP2000_oM/Fragments/PanelOffsetByPoint.json)
