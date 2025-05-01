---
title: PanelAutoMeshByNumberOfObjects
---

# <small>BH.oM.Adapters.SAP2000.Fragments.</small>**PanelAutoMeshByNumberOfObjects**

Divide the panel into a given number of elements in each direction.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PanelAutoMeshByNumberOfObjects is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.SAP2000.Fragments.[IPanelAutoMesh](/api/oM/Adapter/Adapters/SAP2000/Fragments/IPanelAutoMesh)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| N1 | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | This is the number of objects created along the edge of the meshed area object that runs from point 1 to point 2. | - |
| N2 | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | This is the number of objects created along the edge of the meshed area object that runs from point 1 to point 3. | - |
| LocalAxesOnEdge | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| LocalAxesOnFace | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| RestraintsOnEdge | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| RestraintsOnFace | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| Group | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| SubMesh | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| SubMeshSize | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PanelAutoMeshByNumberOfObjects : BH.oM.Adapters.SAP2000.Fragments.IPanelAutoMesh, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: SAP2000_oM.dll

The C# class definition is available on github:

- [PanelAutoMeshByNumberOfObjects.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments\PanelAutoMeshByNumberOfObjects.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP2000_oM/Fragments/PanelAutoMeshByNumberOfObjects.json"
}
```

The JSON Schema is available on github here:

- [PanelAutoMeshByNumberOfObjects.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP2000_oM/Fragments/PanelAutoMeshByNumberOfObjects.json)
