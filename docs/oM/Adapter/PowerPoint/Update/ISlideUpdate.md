---
title: ISlideUpdate
---

# <small>BH.oM.PowerPoint.</small>**ISlideUpdate**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISlideUpdate is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.PowerPoint.[IExcelModification](/api/oM/Adapter/PowerPoint/IExcelModification)
    -  BH.oM.PowerPoint.[IPowerPointModification](/api/oM/Adapter/PowerPoint/IPowerPointModification)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.PowerPoint.[ChartUpdate](/api/oM/Adapter/PowerPoint/Update/ChartUpdate)
    - BH.oM.PowerPoint.[ImageUpdate](/api/oM/Adapter/PowerPoint/Update/ImageUpdate)
    - BH.oM.PowerPoint.[ImageUpdateStream](/api/oM/Adapter/PowerPoint/Update/ImageUpdateStream)
    - BH.oM.PowerPoint.[MultiLineTextUpdate](/api/oM/Adapter/PowerPoint/Update/MultiLineTextUpdate)
    - BH.oM.PowerPoint.[MultiPolylineUpdate](/api/oM/Adapter/PowerPoint/Update/MultiPolylineUpdate)
    - BH.oM.PowerPoint.[ShapeColourUpdate](/api/oM/Adapter/PowerPoint/Update/ShapeColourUpdate)
    - BH.oM.PowerPoint.[SimpleTextUpdate](/api/oM/Adapter/PowerPoint/Update/SimpleTextUpdate)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SlideNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of the slide where the update needs to happen. | - |
| ElementName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the element that needs to be updated. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ISlideUpdate : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.PowerPoint.IExcelModification, BH.oM.PowerPoint.IPowerPointModification
```

Assembly: PowerPoint_oM.dll

The interface is defined in C#. The class definition is available on github:

- [ISlideUpdate.cs](https://github.com/BHoM/PowerPoint_Toolkit/blob/develop/PowerPoint_oM/Update\ISlideUpdate.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/PowerPoint_oM/ISlideUpdate.json"
}
```

The JSON Schema is available on github here:

- [ISlideUpdate.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/PowerPoint_oM/ISlideUpdate.json)
