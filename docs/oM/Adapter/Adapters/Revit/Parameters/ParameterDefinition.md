---
title: ParameterDefinition
---

# <small>BH.oM.Adapters.Revit.Parameters.</small>**ParameterDefinition**

An object representing the definition of a Revit parameter (project parameter or shared parameter as such, not its value related to certain element or type).

## Class structure

### Implemented interfaces and base types

???+ bhom "The ParameterDefinition is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ParameterGroup | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Parameter group, to which the Revit parameter represented by this object belongs. One of the dropdown values for project parameters, any value for shared parameter. | - |
| ParameterType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Parameter type of the Revit parameter represented by this object. | - |
| Discipline | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Discipline, to which the Revit parameter represented by this object belongs. Only relevant in case if there is more than one types with the same name (e.g. piping, HVAC and structural Velocity).<br>Six sensible values can be applied: Common, Electrical, Energy, HVAC, Piping and Structural. | - |
| Instance | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the Revit parameter represented by this object is an instance parameter, otherwise it is a type parameter. | - |
| Categories | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Categories, to which the Revit parameter represented by this object is bound. On Push, it will get bound to all categories if this value is null. | - |
| Shared | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the Revit parameter represented by this object is a shared parameter, otherwise it is a project parameter. | - |


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
public class ParameterDefinition : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The class is defined in C#. The class definition is available on github:

- [ParameterDefinition.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Parameters\ParameterDefinition.cs)

All history and changes of the class can be found by inspection the history.
