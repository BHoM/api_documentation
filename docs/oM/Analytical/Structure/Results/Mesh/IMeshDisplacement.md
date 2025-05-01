---
title: IMeshDisplacement
---

# <small>BH.oM.Structure.Results.</small>**IMeshDisplacement**

Base interface for mesh displacements

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IMeshDisplacement is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.Results.[IStructuralResult](/api/oM/Analytical/Structure/Results/IStructuralResult)
    -  BH.oM.Analytical.Results.[IObjectIdResult](/api/oM/Analytical/Analytical/Results/IObjectIdResult)
    -  BH.oM.Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;BH.oM.Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)&gt;
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Analytical.Results.[ICasedResult](/api/oM/Analytical/Analytical/Results/ICasedResult)
    -  BH.oM.Analytical.Results.[ITimeStepResult](/api/oM/Analytical/Analytical/Results/ITimeStepResult)
    -  BH.oM.Analytical.Results.[IResultItem](/api/oM/Analytical/Analytical/Results/IResultItem)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.Results.[MeshDisplacement](/api/oM/Analytical/Structure/Results/Mesh/MeshDisplacement)
    - BH.oM.Structure.Results.[MeshModeShape](/api/oM/Analytical/Structure/Results/Mesh/MeshModeShape)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| UXX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| UYY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| UZZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| RXX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| RYY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| RZZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| NodeId | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | - | - |
| Orientation | [Basis](/api/oM/Dimensional/Geometry/Vector/Basis) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| AllIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of identifier types. This is all properties tagged with any IdentifierAttribute. | - | Results_Engine |
| ObjectIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of ObjectIdentifier types. This is all properties tagged with the ObjectIdentifierAttribute. | - | Results_Engine |
| ResultPropertyKeys | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Returns the result value carrying properties available for the result type provided. Currently only supported for IResultItem and IResultCollection&lt;IResultItem&gt; type results. | - | Results_Engine |
| RTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total resolved rotational displacement of the three components of the result. | [Angle](/api/oM/Dimensional/Quantities/Attributes/Angle) [rad] | Structure_Engine |
| ScenarioIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of Scenario types. This is all properties tagged with the ScenarioIdentifierAttribute. | - | Results_Engine |
| UTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total resolved translational displacement of the three components of the result. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IMeshDisplacement : BH.oM.Structure.Results.IStructuralResult,
BH.oM.Analytical.Results.IObjectIdResult,
BH.oM.Analytical.Results.IResult,
BH.oM.Base.IObject,
System.IComparable<BH.oM.Analytical.Results.IResult>,
BH.oM.Base.IImmutable,
BH.oM.Analytical.Results.ICasedResult,
BH.oM.Analytical.Results.ITimeStepResult,
BH.oM.Analytical.Results.IResultItem
```

Assembly: Structure_oM.dll

The C# interface definition is available on github:

- [IMeshDisplacement.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Results\Mesh\IMeshDisplacement.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Results/IMeshDisplacement.json"
}
```

The JSON Schema is available on github here:

- [IMeshDisplacement.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Results/IMeshDisplacement.json)
