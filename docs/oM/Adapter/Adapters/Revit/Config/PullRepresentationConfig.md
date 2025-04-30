---
title: PullRepresentationConfig
---

# <small>BH.oM.Adapters.Revit.</small>**PullRepresentationConfig**

Configuration used to specify representation to be pulled and passed to RevitRepresentation fragment.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PullRepresentationConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PullRenderMesh | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, representation of elements will be pulled and stored under RenderMesh in RevitRepresentation fragment. | - |
| DetailLevel | [DetailLevel](/api/oM/Adapter/Adapters/Revit/Enums/DetailLevel) | Detail level of representation, correspondent to level of detail in Revit. | - |
| IncludeNonVisible | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Invisible element parts will be pulled and passed to RevitRepresentation fragment if true. PullRepresentation switched to true needed for this to activate. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PullRepresentationConfig : BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The class is defined in C#. The class definition is available on github:

- [PullRepresentationConfig.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Config\PullRepresentationConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/PullRepresentationConfig.json}
```

The JSON Schema is available on github here:

- [PullRepresentationConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/PullRepresentationConfig.json)
