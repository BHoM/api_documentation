---
title: IPowerPointModification
---

# <small>BH.oM.PowerPoint.</small>**IPowerPointModification**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IPowerPointModification is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.PowerPoint.[ISlideCreate](/api/oM/Adapter/PowerPoint/Create/ISlideCreate)
    - BH.oM.PowerPoint.[ISlideUpdate](/api/oM/Adapter/PowerPoint/Update/ISlideUpdate)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.PowerPoint.[SlideCreate](/api/oM/Adapter/PowerPoint/Create/SlideCreate)
    - BH.oM.PowerPoint.[DeleteSlides](/api/oM/Adapter/PowerPoint/DeleteSlides)
    - BH.oM.PowerPoint.[ChartUpdate](/api/oM/Adapter/PowerPoint/Update/ChartUpdate)
    - BH.oM.PowerPoint.[ImageUpdate](/api/oM/Adapter/PowerPoint/Update/ImageUpdate)
    - BH.oM.PowerPoint.[ImageUpdateStream](/api/oM/Adapter/PowerPoint/Update/ImageUpdateStream)
    - BH.oM.PowerPoint.[MultiLineTextUpdate](/api/oM/Adapter/PowerPoint/Update/MultiLineTextUpdate)
    - BH.oM.PowerPoint.[MultiPolylineUpdate](/api/oM/Adapter/PowerPoint/Update/MultiPolylineUpdate)
    - BH.oM.PowerPoint.[ShapeColourUpdate](/api/oM/Adapter/PowerPoint/Update/ShapeColourUpdate)
    - BH.oM.PowerPoint.[SimpleTextUpdate](/api/oM/Adapter/PowerPoint/Update/SimpleTextUpdate)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IPowerPointModification : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: PowerPoint_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IPowerPointModification.cs](https://github.com/BHoM/PowerPoint_Toolkit/blob/develop/PowerPoint_oM/IPowerPointModification.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/PowerPoint_oM/IPowerPointModification.json"
}
```

The JSON Schema is available on github here:

- [IPowerPointModification.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/PowerPoint_oM/IPowerPointModification.json)
