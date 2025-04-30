---
title: RevitRepresentation
---

# <small>BH.oM.Adapters.Revit.</small>**RevitRepresentation**

Fragment containing the representation extracted from Revit element represented by the BHoM object.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevitRepresentation is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| RenderMeshes | [ReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1?view=netstandard-2.0)&lt;[RenderMesh](/api/oM/Graphics/Graphics/Render/RenderMesh)&gt; | Mesh representation of Revit element represented by the BHoM object carrying this fragment. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RevitRepresentation : BH.oM.Base.IFragment, BH.oM.Base.IObject, BH.oM.Base.IImmutable
```

Assembly: Revit_oM.dll

The class is defined in C#. The class definition is available on github:

- [RevitRepresentation.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Misc\RevitRepresentation.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/RevitRepresentation.json}
```

The JSON Schema is available on github here:

- [RevitRepresentation.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/RevitRepresentation.json)
