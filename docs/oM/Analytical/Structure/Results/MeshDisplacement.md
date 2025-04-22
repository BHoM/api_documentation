---
title: MeshDisplacement
---

# Structure.Results.MeshDisplacement

Displacements and rotations at a discrete location in the Panel/FEMesh.

## Class structure

### Implemented interfaces and base types

???+ bhom "The MeshDisplacement in inheriting from the following base type(s) and implements the following interfaces:"

    -  Structure.Results.[MeshElementResult](/api_documentation/oM/Analytical/Structure/Results/MeshElementResult)
    -  Analytical.Results.[IMeshElementResult](/api_documentation/oM/Analytical/Analytical/Results/IMeshElementResult)
    -  Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)&gt;
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)
    -  Structure.Results.[IStructuralResult](/api_documentation/oM/Analytical/Structure/Results/IStructuralResult)
    -  Analytical.Results.[IObjectIdResult](/api_documentation/oM/Analytical/Analytical/Results/IObjectIdResult)
    -  Analytical.Results.[ICasedResult](/api_documentation/oM/Analytical/Analytical/Results/ICasedResult)
    -  Analytical.Results.[ITimeStepResult](/api_documentation/oM/Analytical/Analytical/Results/ITimeStepResult)
    -  Structure.Results.[IMeshDisplacement](/api_documentation/oM/Analytical/Structure/Results/IMeshDisplacement)
    -  Analytical.Results.[IResultItem](/api_documentation/oM/Analytical/Analytical/Results/IResultItem)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| UXX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Translation in global X-direction. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| UYY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Translation in global Y-direction. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| UZZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Translation in global Z-direction. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| RXX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Rotation about global X-axis. | [Angle](/api_documentation/oM/Dimensional/Quantities/Attributes/Angle) [rad] |
| RYY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Rotation about global Y-axis. | [Angle](/api_documentation/oM/Dimensional/Quantities/Attributes/Angle) [rad] |
| RZZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Rotation about global Z-axis. | [Angle](/api_documentation/oM/Dimensional/Quantities/Attributes/Angle) [rad] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ObjectId | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Id of the FEMesh/Panel that this result belongs to. When extracted from an analysis package, the object id will match the format and value used in that particular package. | - |
| NodeId | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Id of the Node in the mesh that this result belongs to. Will be empty for smoothing types not relating to Nodes. When extracted from an analysis package, the Node id will correspond to the node id in the software and match the format and value used in that particular package. | - |
| MeshFaceId | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Id of the FEFace that this result belongs to. Will be empty for smoothing types not relating to Faces. When extracted from an analysis package, the face id will correspond to the face id in the software and match the format and value used in that particular package. | - |
| ResultCase | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Identifier for the Loadcase or LoadCombination that the result belongs to. Is generally name or number of the loadcase, depending on the analysis package. | - |
| ModeNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Positive index, starting at one. Only set for cases with modal outputs such as dynamic cases. | - |
| TimeStep | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Time step for time history results. | - |
| MeshResultLayer | [MeshResultLayer](/api_documentation/oM/Analytical/Structure/Results/MeshResultLayer) | - | - |
| LayerPosition | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Position within the element thickness that result is extracted from, normalised to 1. I.e. 0 = lower surface, 0.5 = middle, 1 = top surface. | - |
| Smoothing | [MeshResultSmoothingType](/api_documentation/oM/Analytical/Structure/Results/MeshResultSmoothingType) | - | - |
| Orientation | [Basis](/api_documentation/oM/Dimensional/Geometry/Basis) | Vector basis required in order to report results in a particular direction, for example, for anisotropic materials. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| AllIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of identifier types. This is all properties tagged with any IdentifierAttribute. | - | Results_Engine |
| ObjectIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of ObjectIdentifier types. This is all properties tagged with the ObjectIdentifierAttribute. | - | Results_Engine |
| ResultPropertyKeys | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Returns the result value carrying properties available for the result type provided. Currently only supported for IResultItem and IResultCollection&lt;IResultItem&gt; type results. | - | Results_Engine |
| RTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total resolved rotational displacement of the three components of the result. | [Angle](/api_documentation/oM/Dimensional/Quantities/Attributes/Angle) [rad] | Structure_Engine |
| ScenarioIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of Scenario types. This is all properties tagged with the ScenarioIdentifierAttribute. | - | Results_Engine |
| UTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total resolved translational displacement of the three components of the result. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [MeshDisplacement.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Results/Mesh/MeshDisplacement.cs)

All history and changes of the class can be found by inspection the history.
