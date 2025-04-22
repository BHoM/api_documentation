---
title: Skeleton
---

# Humans.Skeleton



## Class structure

### Implemented interfaces and base types

???+ bhom "The Skeleton in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Humans.[IHumanRole](/api_documentation/oM/Physical/Humans/IHumanRole)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Head | [Head](/api_documentation/oM/Physical/Humans/BodyParts/Head) | - | - |
| RightHand | [RightHand](/api_documentation/oM/Physical/Humans/BodyParts/RightHand) | - | - |
| LeftHand | [LeftHand](/api_documentation/oM/Physical/Humans/BodyParts/LeftHand) | - | - |
| RightThumb | [RightThumb](/api_documentation/oM/Physical/Humans/BodyParts/RightThumb) | - | - |
| LeftThumb | [LeftThumb](/api_documentation/oM/Physical/Humans/BodyParts/LeftThumb) | - | - |
| Neck | [Neck](/api_documentation/oM/Physical/Humans/BodyParts/Neck) | - | - |
| RightShoulder | [RightShoulder](/api_documentation/oM/Physical/Humans/BodyParts/RightShoulder) | - | - |
| LeftShoulder | [LeftShoulder](/api_documentation/oM/Physical/Humans/BodyParts/LeftShoulder) | - | - |
| Spine | [Spine](/api_documentation/oM/Physical/Humans/BodyParts/Spine) | - | - |
| RightHip | [RightHip](/api_documentation/oM/Physical/Humans/BodyParts/RightHip) | - | - |
| LeftHip | [LeftHip](/api_documentation/oM/Physical/Humans/BodyParts/LeftHip) | - | - |
| RightUpperArm | [RightUpperArm](/api_documentation/oM/Physical/Humans/BodyParts/RightUpperArm) | - | - |
| LeftUpperArm | [LeftUpperArm](/api_documentation/oM/Physical/Humans/BodyParts/LeftUpperArm) | - | - |
| RightLowerArm | [RightLowerArm](/api_documentation/oM/Physical/Humans/BodyParts/RightLowerArm) | - | - |
| LeftLowerArm | [LeftLowerArm](/api_documentation/oM/Physical/Humans/BodyParts/LeftLowerArm) | - | - |
| RightUpperLeg | [RightUpperLeg](/api_documentation/oM/Physical/Humans/BodyParts/RightUpperLeg) | - | - |
| LeftUpperLeg | [LeftUpperLeg](/api_documentation/oM/Physical/Humans/BodyParts/LeftUpperLeg) | - | - |
| RightLowerLeg | [RightLowerLeg](/api_documentation/oM/Physical/Humans/BodyParts/RightLowerLeg) | - | - |
| LeftLowerLeg | [LeftLowerLeg](/api_documentation/oM/Physical/Humans/BodyParts/LeftLowerLeg) | - | - |
| RightFoot | [RightFoot](/api_documentation/oM/Physical/Humans/BodyParts/RightFoot) | - | - |
| LeftFoot | [LeftFoot](/api_documentation/oM/Physical/Humans/BodyParts/LeftFoot) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| TrackingLines | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [Line](/api_documentation/oM/Dimensional/Geometry/Line)&gt; | - | - | Humans_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Skeleton.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/Skeleton.cs)

All history and changes of the class can be found by inspection the history.
