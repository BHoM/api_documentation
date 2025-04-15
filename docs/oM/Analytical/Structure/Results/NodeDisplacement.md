---
title: NodeDisplacement
---

# Structure.Results.NodeDisplacement

Resulting displacements and rotations for a Node.

## Class structure

### Implemented interfaces and base types

???+ bhom "The NodeDisplacement in inheriting from the following base type(s) and implements the following interfaces:"

    -  Structure.Results.[NodeResult](/om_documentation/oM/Analytical/Structure/Results/NodeResult)
    -  Structure.Results.[IStructuralResult](/om_documentation/oM/Analytical/Structure/Results/IStructuralResult)
    -  Analytical.Results.[IObjectIdResult](/om_documentation/oM/Analytical/Analytical/Results/IObjectIdResult)
    -  Analytical.Results.[IResult](/om_documentation/oM/Analytical/Analytical/Results/IResult)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;Analytical.Results.[IResult](/om_documentation/oM/Analytical/Analytical/Results/IResult)&gt;
    -  Base.[IImmutable](/om_documentation/oM/Framework/Base/IImmutable)
    -  Analytical.Results.[ICasedResult](/om_documentation/oM/Analytical/Analytical/Results/ICasedResult)
    -  Analytical.Results.[ITimeStepResult](/om_documentation/oM/Analytical/Analytical/Results/ITimeStepResult)
    -  Analytical.Results.[IObjectResult](/om_documentation/oM/Analytical/Analytical/Results/IObjectResult)
    -  Structure.Results.[INodeDisplacement](/om_documentation/oM/Analytical/Structure/Results/INodeDisplacement)
    -  Structure.Results.[IDisplacement](/om_documentation/oM/Analytical/Structure/Results/IDisplacement)
    -  Analytical.Results.[IResultItem](/om_documentation/oM/Analytical/Analytical/Results/IResultItem)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| UX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Translational displacement in the X-direction as defined by orientation basis. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| UY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Translational displacement in the Y-direction as defined by orientation basis. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| UZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Translational displacement in the Z-direction as defined by orientation basis. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| RX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Rotational displacement about the X-axis as defined by orientation basis. | [Angle](/om_documentation/oM/Dimensional/Quantities/Attributes/Angle) [rad] |
| RY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Rotational displacement about the Y-axis as defined by orientation basis. | [Angle](/om_documentation/oM/Dimensional/Quantities/Attributes/Angle) [rad] |
| RZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Rotational displacement about the Z-axis as defined by orientation basis. | [Angle](/om_documentation/oM/Dimensional/Quantities/Attributes/Angle) [rad] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ObjectId | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Id of the node that this result belongs to. When extracted from an analysis package, the object id will match the format and value used in that particular package. | - |
| ResultCase | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Identifier for the Loadcase or LoadCombination that the result belongs to. Is generally name or number of the loadcase, depending on the analysis package. | - |
| ModeNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Positive index, starting at one. Only set for cases with modal outputs such as dynamic cases. | - |
| TimeStep | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Time step for time history results. | - |
| Orientation | [Basis](/om_documentation/oM/Dimensional/Geometry/Basis) | Defines the directionality of the results. Defaults to global XYZ. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| AllIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of identifier types. This is all properties tagged with any IdentifierAttribute. | - | Results_Engine |
| ObjectIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of ObjectIdentifier types. This is all properties tagged with the ObjectIdentifierAttribute. | - | Results_Engine |
| ResultPropertyKeys | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Returns the result value carrying properties available for the result type provided. Currently only supported for IResultItem and IResultCollection&lt;IResultItem&gt; type results. | - | Results_Engine |
| RTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total resolved rotational displacement of the three components of the result. | [Angle](/om_documentation/oM/Dimensional/Quantities/Attributes/Angle) [rad] | Structure_Engine |
| ScenarioIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of Scenario types. This is all properties tagged with the ScenarioIdentifierAttribute. | - | Results_Engine |
| UTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total resolved translational displacement of the three components of the result. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [NodeDisplacement.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Results/Nodal Results/NodeDisplacement.cs)

All history and changes of the class can be found by inspection the history.
