---
title: IFlowSectionProperty
---

# <small>BH.oM.MEP.System.SectionProperties.</small>**IFlowSectionProperty**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFlowSectionProperty is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.MEP.System.SectionProperties.[DuctSectionProperty](/api/oM/Analytical/MEP/System/SectionProperties/DuctSectionProperty)
    - BH.oM.MEP.System.SectionProperties.[PipeSectionProperty](/api/oM/Analytical/MEP/System/SectionProperties/PipeSectionProperty)
    - BH.oM.MEP.System.SectionProperties.[WireSectionProperty](/api/oM/Analytical/MEP/System/SectionProperties/WireSectionProperty)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IFlowSectionProperty : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: MEP_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IFlowSectionProperty.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/System\SectionProperties\IFlowSectionProperty.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/MEP_oM/System/SectionProperties/IFlowSectionProperty.json}
```

The JSON Schema is available on github here:

- [IFlowSectionProperty.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/MEP_oM/System/SectionProperties/IFlowSectionProperty.json)
