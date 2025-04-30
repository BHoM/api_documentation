---
title: DependencyChart
---

# <small>BH.oM.Graphics.Views.</small>**DependencyChart**

Scale for mapping from a discrete domain and range.

## Class structure

### Implemented interfaces and base types

???+ bhom "The DependencyChart is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Graphics.Views.[IView](/api/oM/Graphics/Graphics/Views/IView)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Boxes | [Boxes](/api/oM/Graphics/Graphics/Components/Boxes) | - | - |
| Links | [Links](/api/oM/Graphics/Graphics/Components/Links) | - | - |
| ViewConfig | [ViewConfig](/api/oM/Graphics/Graphics/Views/ViewConfig) | - | - |


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
public class DependencyChart : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Graphics.Views.IView
```

Assembly: Graphics_oM.dll

The class is defined in C#. The class definition is available on github:

- [DependencyChart.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Views\DependencyChart.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Graphics_oM/Views/DependencyChart.json}
```

The JSON Schema is available on github here:

- [DependencyChart.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Graphics_oM/Views/DependencyChart.json)
