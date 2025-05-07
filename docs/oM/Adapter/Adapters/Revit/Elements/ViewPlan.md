---
title: ViewPlan
---

# <small>BH.oM.Adapters.Revit.Elements.</small>**ViewPlan**

A wrapper BHoM type for Revit plan view, used to create or update Revit plans (on Push) and represent them as BHoMObjects (on Pull).

## Class structure

### Implemented interfaces and base types

???+ bhom "The ViewPlan is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Adapters.Revit.Elements.[IView](/api/oM/Adapter/Adapters/Revit/Elements/IView)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| InstanceProperties | [InstanceProperties](/api/oM/Adapter/Adapters/Revit/Properties/InstanceProperties) | An entity storing the information about Revit view type. | - |
| LevelName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of Revit level to which the Revit view belongs (Associated Level parameter). | - |
| ViewName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the Revit view. | - |
| TemplateName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the view template applied to the Revit view. | - |


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
public class ViewPlan : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Adapters.Revit.Elements.IView
```

Assembly: Revit_oM.dll

The C# class definition is available on github:

- [ViewPlan.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Elements\ViewPlan.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Elements/ViewPlan.json"
}
```

The JSON Schema is available on github here:

- [ViewPlan.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Elements/ViewPlan.json)
