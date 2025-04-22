---
title: MultiPolylineUpdate
---

# PowerPoint.MultiPolylineUpdate

Allows to change the geometry of a shape element.

## Class structure

### Implemented interfaces and base types

???+ bhom "The MultiPolylineUpdate in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  PowerPoint.[ISlideUpdate](/api_documentation/oM/Adapter/PowerPoint/ISlideUpdate)
    -  PowerPoint.[IExcelModification](/api_documentation/oM/Adapter/PowerPoint/IExcelModification)
    -  PowerPoint.[IPowerPointModification](/api_documentation/oM/Adapter/PowerPoint/IPowerPointModification)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SlideNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of the slide where the update needs to happen. | - |
| ElementName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the shape element that needs to be updated. | - |
| Shapes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[PolylineData](/api_documentation/oM/Adapter/PowerPoint/PolylineData)&gt; | Shape to be updated. | - |
| CentreShapes | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the provided shapes are centred in the template box, if false, the shapes are drawn from the top left corner. | - |
| KeepShapeAspectRatio | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the shape aspect ratio is kept, and the shapes are made to fit the extents of the template shape. If false, the shapes are atempted to fill up the template shape as much as possible which can lead to change in aspect ratio of the provided shapes. | - |
| GroupPolylinesWithSameProperties | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the provided shapes that share all properties in terms of colours will be added to the same shape object. If false, all PolylineData obejcts will be added to separate shape objects. | - |
| Scale | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Scale factor to be applied to the figure. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [MultiPolylineUpdate.cs](https://github.com/BHoM/PowerPoint_Toolkit/blob/develop/PowerPoint_oM/Update/MultiPolylineUpdate.cs)

All history and changes of the class can be found by inspection the history.
