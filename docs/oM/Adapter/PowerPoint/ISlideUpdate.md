---
title: ISlideUpdate
---

# PowerPoint.ISlideUpdate



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISlideUpdate in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  PowerPoint.[IExcelModification](/api/oM/Adapter/PowerPoint/IExcelModification)
    -  PowerPoint.[IPowerPointModification](/api/oM/Adapter/PowerPoint/IPowerPointModification)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - PowerPoint.[ChartUpdate](/api/oM/Adapter/PowerPoint/ChartUpdate)
    - PowerPoint.[ImageUpdate](/api/oM/Adapter/PowerPoint/ImageUpdate)
    - PowerPoint.[ImageUpdateStream](/api/oM/Adapter/PowerPoint/ImageUpdateStream)
    - PowerPoint.[MultiLineTextUpdate](/api/oM/Adapter/PowerPoint/MultiLineTextUpdate)
    - PowerPoint.[MultiPolylineUpdate](/api/oM/Adapter/PowerPoint/MultiPolylineUpdate)
    - PowerPoint.[ShapeColourUpdate](/api/oM/Adapter/PowerPoint/ShapeColourUpdate)
    - PowerPoint.[SimpleTextUpdate](/api/oM/Adapter/PowerPoint/SimpleTextUpdate)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SlideNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of the slide where the update needs to happen. | - |
| ElementName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the element that needs to be updated. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ISlideUpdate.cs](https://github.com/BHoM/PowerPoint_Toolkit/blob/develop/PowerPoint_oM/Update/ISlideUpdate.cs)

All history and changes of the class can be found by inspection the history.
