---
title: ShapeColourUpdate
---

# PowerPoint.ShapeColourUpdate

Allows to update the colour of a shape

## Class structure

### Implemented interfaces and base types

???+ bhom "The ShapeColourUpdate in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  PowerPoint.[ISlideUpdate](/om_documentation/oM/Adapter/PowerPoint/ISlideUpdate)
    -  PowerPoint.[IExcelModification](/om_documentation/oM/Adapter/PowerPoint/IExcelModification)
    -  PowerPoint.[IPowerPointModification](/om_documentation/oM/Adapter/PowerPoint/IPowerPointModification)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SlideNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of the slide where the update needs to happen. | - |
| ElementName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the shape element that needs to be updated. | - |
| EdgeColour | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | New edge hex colour represenation of the element. | - |
| FillColour | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | New fill hex colour represenation of the element. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [ShapeColourUpdate.cs](https://github.com/BHoM/PowerPoint_Toolkit/blob/develop/PowerPoint_oM/Update/ShapeColourUpdate.cs)

All history and changes of the class can be found by inspection the history.
