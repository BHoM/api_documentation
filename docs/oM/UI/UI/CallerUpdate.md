---
title: CallerUpdate
---

# UI.CallerUpdate



## Class structure

### Implemented interfaces and base types

???+ bhom "The CallerUpdate in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  UI.[IUpdate](/api/oM/UI/UI/IUpdate)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Cause | [CallerUpdateCause](/api/oM/UI/UI/CallerUpdateCause) | - | - |
| ComponentUpdate | [ComponentUpdate](/api/oM/UI/UI/ComponentUpdate) | - | - |
| InputUpdates | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IParamUpdate](/api/oM/UI/UI/IParamUpdate)&gt; | - | - |
| OutputUpdates | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IParamUpdate](/api/oM/UI/UI/IParamUpdate)&gt; | - | - |


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

The class is defined in C#. The class definition is available on github:

- [CallerUpdate.cs](https://github.com/BHoM/BHoM_UI/blob/develop/UI_oM/Updates/CallerUpdate.cs)

All history and changes of the class can be found by inspection the history.
