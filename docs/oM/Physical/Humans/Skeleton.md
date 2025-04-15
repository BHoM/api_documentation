---
title: Skeleton
---

# Humans.Skeleton



## Class structure

### Implemented interfaces and base types

???+ bhom "The Skeleton in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)
    -  Humans.[IHumanRole](/documentation/oM/Physical/Humans/IHumanRole)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Head | [Head](/documentation/oM/Physical/Humans/BodyParts/Head) | - | - |
| RightHand | [RightHand](/documentation/oM/Physical/Humans/BodyParts/RightHand) | - | - |
| LeftHand | [LeftHand](/documentation/oM/Physical/Humans/BodyParts/LeftHand) | - | - |
| RightThumb | [RightThumb](/documentation/oM/Physical/Humans/BodyParts/RightThumb) | - | - |
| LeftThumb | [LeftThumb](/documentation/oM/Physical/Humans/BodyParts/LeftThumb) | - | - |
| Neck | [Neck](/documentation/oM/Physical/Humans/BodyParts/Neck) | - | - |
| RightShoulder | [RightShoulder](/documentation/oM/Physical/Humans/BodyParts/RightShoulder) | - | - |
| LeftShoulder | [LeftShoulder](/documentation/oM/Physical/Humans/BodyParts/LeftShoulder) | - | - |
| Spine | [Spine](/documentation/oM/Physical/Humans/BodyParts/Spine) | - | - |
| RightHip | [RightHip](/documentation/oM/Physical/Humans/BodyParts/RightHip) | - | - |
| LeftHip | [LeftHip](/documentation/oM/Physical/Humans/BodyParts/LeftHip) | - | - |
| RightUpperArm | [RightUpperArm](/documentation/oM/Physical/Humans/BodyParts/RightUpperArm) | - | - |
| LeftUpperArm | [LeftUpperArm](/documentation/oM/Physical/Humans/BodyParts/LeftUpperArm) | - | - |
| RightLowerArm | [RightLowerArm](/documentation/oM/Physical/Humans/BodyParts/RightLowerArm) | - | - |
| LeftLowerArm | [LeftLowerArm](/documentation/oM/Physical/Humans/BodyParts/LeftLowerArm) | - | - |
| RightUpperLeg | [RightUpperLeg](/documentation/oM/Physical/Humans/BodyParts/RightUpperLeg) | - | - |
| LeftUpperLeg | [LeftUpperLeg](/documentation/oM/Physical/Humans/BodyParts/LeftUpperLeg) | - | - |
| RightLowerLeg | [RightLowerLeg](/documentation/oM/Physical/Humans/BodyParts/RightLowerLeg) | - | - |
| LeftLowerLeg | [LeftLowerLeg](/documentation/oM/Physical/Humans/BodyParts/LeftLowerLeg) | - | - |
| RightFoot | [RightFoot](/documentation/oM/Physical/Humans/BodyParts/RightFoot) | - | - |
| LeftFoot | [LeftFoot](/documentation/oM/Physical/Humans/BodyParts/LeftFoot) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| TrackingLines | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [Line](/documentation/oM/Dimensional/Geometry/Line)&gt; | - | - | Humans_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Skeleton.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/Skeleton.cs)

All history and changes of the class can be found by inspection the history.
