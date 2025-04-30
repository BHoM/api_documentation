---
title: InsertionPoint
---

# <small>BH.oM.Adapters.ETABS.Elements.</small>**InsertionPoint**



## Class structure

### Implemented interfaces and base types

???+ bhom "The InsertionPoint is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BarInsertionPoint | [BarInsertionPoint](/api/oM/Adapter/Adapters/ETABS/Enums/BarInsertionPoint) | - | - |
| ModifyStiffness | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Transform frame stiffness for offsets from centroid for non-P/T floors | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class InsertionPoint : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: ETABS_oM.dll

The class is defined in C#. The class definition is available on github:

- [InsertionPoint.cs](https://github.com/BHoM/ETABS_Toolkit/blob/develop/ETABS_oM/Fragments\InsertionPoint.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/ETABS_oM/Elements/InsertionPoint.json}
```

The JSON Schema is available on github here:

- [InsertionPoint.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/ETABS_oM/Elements/InsertionPoint.json)
