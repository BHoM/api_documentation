---
title: IPanelOffset
---

# <small>BH.oM.Adapters.SAP2000.Fragments.</small>**IPanelOffset**

Base interface for panel offsets in SAP. Contains only the type of offset.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IPanelOffset is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.SAP2000.Fragments.[PanelOffsetByJointPattern](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelOffsetByJointPattern)
    - BH.oM.Adapters.SAP2000.Fragments.[PanelOffsetByPoint](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelOffsetByPoint)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IPanelOffset : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: SAP2000_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IPanelOffset.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments\IPanelOffset.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP2000_oM/Fragments/IPanelOffset.json"
}
```

The JSON Schema is available on github here:

- [IPanelOffset.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP2000_oM/Fragments/IPanelOffset.json)
