---
title: SlideCreate
---

# <small>BH.oM.</small>**SlideCreate**

Use with a push action to create a new slide from a slide layout in the first slide master template, at the position provided.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SlideCreate is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.PowerPoint.[ISlideCreate](/api/oM/Adapter/PowerPoint/Create/ISlideCreate)
    -  BH.oM.PowerPoint.[IPowerPointModification](/api/oM/Adapter/PowerPoint/IPowerPointModification)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SlideMasterName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The name of the slide master to get the layout from. If this is blank, the first slide master in the list will be used instead. | - |
| LayoutName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The name of the layout to use from the slide master. | - |
| SlideNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The location to place the slide in the presentation, starting from 1. -1 to append the slide to the end of the presentation. | - |
| SlideUpdates | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ISlideUpdate](/api/oM/Adapter/PowerPoint/Update/ISlideUpdate)&gt; | The slide updates to be applied to the created slide. Any set slide numbers will b | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SlideCreate : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.PowerPoint.ISlideCreate,
BH.oM.PowerPoint.IPowerPointModification,
BH.oM.Base.IImmutable
```

Assembly: PowerPoint_oM.dll

The class is defined in C#. The class definition is available on github:

- [SlideCreate.cs](https://github.com/BHoM/PowerPoint_Toolkit/blob/develop/PowerPoint_oM/Create\SlideCreate.cs)

All history and changes of the class can be found by inspection the history.
