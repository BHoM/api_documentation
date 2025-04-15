---
title: Skeleton
---

# Humans.Skeleton



## Class structure

### Implemented interfaces and base types

???+ bhom "The Skeleton in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Humans.[IHumanRole](/om_documentation/oM/Physical/Humans/IHumanRole)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Head | [Head](/om_documentation/oM/Physical/Humans/BodyParts/Head) | - | - |
| RightHand | [RightHand](/om_documentation/oM/Physical/Humans/BodyParts/RightHand) | - | - |
| LeftHand | [LeftHand](/om_documentation/oM/Physical/Humans/BodyParts/LeftHand) | - | - |
| RightThumb | [RightThumb](/om_documentation/oM/Physical/Humans/BodyParts/RightThumb) | - | - |
| LeftThumb | [LeftThumb](/om_documentation/oM/Physical/Humans/BodyParts/LeftThumb) | - | - |
| Neck | [Neck](/om_documentation/oM/Physical/Humans/BodyParts/Neck) | - | - |
| RightShoulder | [RightShoulder](/om_documentation/oM/Physical/Humans/BodyParts/RightShoulder) | - | - |
| LeftShoulder | [LeftShoulder](/om_documentation/oM/Physical/Humans/BodyParts/LeftShoulder) | - | - |
| Spine | [Spine](/om_documentation/oM/Physical/Humans/BodyParts/Spine) | - | - |
| RightHip | [RightHip](/om_documentation/oM/Physical/Humans/BodyParts/RightHip) | - | - |
| LeftHip | [LeftHip](/om_documentation/oM/Physical/Humans/BodyParts/LeftHip) | - | - |
| RightUpperArm | [RightUpperArm](/om_documentation/oM/Physical/Humans/BodyParts/RightUpperArm) | - | - |
| LeftUpperArm | [LeftUpperArm](/om_documentation/oM/Physical/Humans/BodyParts/LeftUpperArm) | - | - |
| RightLowerArm | [RightLowerArm](/om_documentation/oM/Physical/Humans/BodyParts/RightLowerArm) | - | - |
| LeftLowerArm | [LeftLowerArm](/om_documentation/oM/Physical/Humans/BodyParts/LeftLowerArm) | - | - |
| RightUpperLeg | [RightUpperLeg](/om_documentation/oM/Physical/Humans/BodyParts/RightUpperLeg) | - | - |
| LeftUpperLeg | [LeftUpperLeg](/om_documentation/oM/Physical/Humans/BodyParts/LeftUpperLeg) | - | - |
| RightLowerLeg | [RightLowerLeg](/om_documentation/oM/Physical/Humans/BodyParts/RightLowerLeg) | - | - |
| LeftLowerLeg | [LeftLowerLeg](/om_documentation/oM/Physical/Humans/BodyParts/LeftLowerLeg) | - | - |
| RightFoot | [RightFoot](/om_documentation/oM/Physical/Humans/BodyParts/RightFoot) | - | - |
| LeftFoot | [LeftFoot](/om_documentation/oM/Physical/Humans/BodyParts/LeftFoot) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| TrackingLines | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [Line](/om_documentation/oM/Dimensional/Geometry/Line)&gt; | - | - | Humans_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Skeleton.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/Skeleton.cs)

All history and changes of the class can be found by inspection the history.
