---
title: TransposedConvolution2d
---

# DeepLearning.Layers.TransposedConvolution2d



## Class structure

### Implemented interfaces and base types

???+ bhom "The TransposedConvolution2d in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  DeepLearning.[IModule](/api/oM/Framework/DeepLearning/IModule)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FeaturesIn | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| FeaturesOut | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| KernelSize | [Shape2d](/api/oM/Framework/DeepLearning/Shape2d) | - | - |
| Stride | [Shape2d](/api/oM/Framework/DeepLearning/Shape2d) | - | - |
| Padding | [Shape2d](/api/oM/Framework/DeepLearning/Shape2d) | - | - |
| Dilation | [Shape2d](/api/oM/Framework/DeepLearning/Shape2d) | - | - |
| OutputSize | [Shape2d](/api/oM/Framework/DeepLearning/Shape2d) | - | - |


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

- [TransposedConvolution2d.cs](https://github.com/BHoM/BHoM/blob/develop/DeepLearning_oM/Layers\TransposedConvolution2d.cs)

All history and changes of the class can be found by inspection the history.
