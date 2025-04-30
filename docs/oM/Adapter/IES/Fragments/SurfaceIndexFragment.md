---
title: SurfaceIndexFragment
---

# <small>BH.oM.IES.Fragments.</small>**SurfaceIndexFragment**

Fragment containing the surface index from IES

## Class structure

### Implemented interfaces and base types

???+ bhom "The SurfaceIndexFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SurfaceID | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Index of panel in the space it is connected to | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SurfaceIndexFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: IES_oM.dll

The class is defined in C#. The class definition is available on github:

- [SurfaceIndexFragment.cs](https://github.com/BHoM/IES_Toolkit/blob/develop/IES_oM/Fragments\SurfaceIndexFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/IES_oM/Fragments/SurfaceIndexFragment.json}
```

The JSON Schema is available on github here:

- [SurfaceIndexFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/IES_oM/Fragments/SurfaceIndexFragment.json)
