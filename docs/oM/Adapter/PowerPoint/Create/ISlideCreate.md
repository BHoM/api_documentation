---
title: ISlideCreate
---

# <small>BH.oM.PowerPoint.</small>**ISlideCreate**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISlideCreate is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.PowerPoint.[IPowerPointModification](/api/oM/Adapter/PowerPoint/IPowerPointModification)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.PowerPoint.[SlideCreate](/api/oM/Adapter/PowerPoint/Create/SlideCreate)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface ISlideCreate : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.PowerPoint.IPowerPointModification
```

Assembly: PowerPoint_oM.dll

The interface is defined in C#. The class definition is available on github:

- [ISlideCreate.cs](https://github.com/BHoM/PowerPoint_Toolkit/blob/develop/PowerPoint_oM/Create\ISlideCreate.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/PowerPoint_oM/ISlideCreate.json}
```

The JSON Schema is available on github here:

- [ISlideCreate.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/PowerPoint_oM/ISlideCreate.json)
