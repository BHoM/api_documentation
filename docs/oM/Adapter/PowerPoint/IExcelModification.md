---
title: IExcelModification
---

# <small>BH.oM.</small>**IExcelModification**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IExcelModification is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.PowerPoint.[ISlideUpdate](/api/oM/Adapter/PowerPoint/Update/ISlideUpdate)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

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
public interface IExcelModification : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: PowerPoint_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IExcelModification.cs](https://github.com/BHoM/PowerPoint_Toolkit/blob/develop/PowerPoint_oM/IExcelModification.cs)

All history and changes of the class can be found by inspection the history.
