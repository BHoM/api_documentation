---
title: NodeModeShape
---

# <small>BH.oM.Structure.Results.</small>**NodeModeShape**

Node mode shape in global coordinates, normalised to 1.

## Class structure

### Implemented interfaces and base types

???+ bhom "The NodeModeShape is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.Results.[NodeResult](/api/oM/Analytical/Structure/Results/Nodal Results/NodeResult)
    -  BH.oM.Structure.Results.[IStructuralResult](/api/oM/Analytical/Structure/Results/IStructuralResult)
    -  BH.oM.Analytical.Results.[IObjectIdResult](/api/oM/Analytical/Analytical/Results/IObjectIdResult)
    -  BH.oM.Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;BH.oM.Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)&gt;
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Analytical.Results.[ICasedResult](/api/oM/Analytical/Analytical/Results/ICasedResult)
    -  BH.oM.Analytical.Results.[ITimeStepResult](/api/oM/Analytical/Analytical/Results/ITimeStepResult)
    -  BH.oM.Analytical.Results.[IObjectResult](/api/oM/Analytical/Analytical/Results/IObjectResult)
    -  BH.oM.Structure.Results.[INodeDisplacement](/api/oM/Analytical/Structure/Results/Nodal Results/INodeDisplacement)
    -  BH.oM.Structure.Results.[IDisplacement](/api/oM/Analytical/Structure/Results/IDisplacement)
    -  BH.oM.Analytical.Results.[IResultItem](/api/oM/Analytical/Analytical/Results/IResultItem)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| UX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Translational X component of the mode shape in global coordinates. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| UY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Translational Y component of the mode shape in global coordinates. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| UZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Translational Z component of the mode shape in global coordinates. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| RX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Rotational component about the X-axis of the mode shape in global coordinates. | [Angle](/api/oM/Dimensional/Quantities/Attributes/Angle) [rad] |
| RY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Rotational component about the Y-axis of the mode shape in global coordinates. | [Angle](/api/oM/Dimensional/Quantities/Attributes/Angle) [rad] |
| RZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Rotational component about the Z-axis of the mode shape in global coordinates. | [Angle](/api/oM/Dimensional/Quantities/Attributes/Angle) [rad] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ObjectId | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Id of the node that this result belongs to. When extracted from an analysis package, the object id will match the format and value used in that particular package. | - |
| ResultCase | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Identifier for the Loadcase or LoadCombination that the result belongs to. Is generally name or number of the loadcase, depending on the analysis package. | - |
| ModeNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Positive index, starting at one. Only set for cases with modal outputs such as dynamic cases. | - |
| TimeStep | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Time step for time history results. | - |
| Orientation | [Basis](/api/oM/Dimensional/Geometry/Vector/Basis) | Defines the directionality of the results. Defaults to global XYZ. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| AllIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of identifier types. This is all properties tagged with any IdentifierAttribute. | - | Results_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Result is null and outputs relevant error message. | - | Results_Engine |
| ObjectIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of ObjectIdentifier types. This is all properties tagged with the ObjectIdentifierAttribute. | - | Results_Engine |
| ResultPropertyKeys | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Returns the result value carrying properties available for the result type provided. Currently only supported for IResultItem and IResultCollection&lt;IResultItem&gt; type results. | - | Results_Engine |
| ResultValuePropertiesItem | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [Tuple](https://learn.microsoft.com/en-us/dotnet/api/System.Tuple-2?view=netstandard-2.0)&lt;[Func](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=netstandard-2.0)&lt;T, [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt;, [QuantityAttribute](/api/oM/Dimensional/Quantities/Attributes/Abstract/QuantityAttribute)&gt;&gt; | Extract all potential result carrying property getters from a result class, i.e. properties of type double that is defined on the class. Properties defined on a base class are ignored.<br>Also extracts methods returning a double that has the result type as the only argument.<br>Func&lt;T,double&gt; returned together with corresponding QuantityAttribute in a Dictionary with the property or method name as the Key. | - | Results_Engine |
| RTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total resolved rotational displacement of the three components of the result. | [Angle](/api/oM/Dimensional/Quantities/Attributes/Angle) [rad] | Structure_Engine |
| ScenarioIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of Scenario types. This is all properties tagged with the ScenarioIdentifierAttribute. | - | Results_Engine |
| UTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total resolved translational displacement of the three components of the result. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class NodeModeShape : BH.oM.Structure.Results.NodeResult,
BH.oM.Structure.Results.IStructuralResult,
BH.oM.Analytical.Results.IObjectIdResult,
BH.oM.Analytical.Results.IResult,
BH.oM.Base.IObject,
System.IComparable<BH.oM.Analytical.Results.IResult>,
BH.oM.Base.IImmutable,
BH.oM.Analytical.Results.ICasedResult,
BH.oM.Analytical.Results.ITimeStepResult,
BH.oM.Analytical.Results.IObjectResult,
BH.oM.Structure.Results.INodeDisplacement,
BH.oM.Structure.Results.IDisplacement,
BH.oM.Analytical.Results.IResultItem
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [NodeModeShape.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Results\Nodal Results\NodeModeShape.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Results/NodeModeShape.json"
}
```

The JSON Schema is available on github here:

- [NodeModeShape.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Results/NodeModeShape.json)
