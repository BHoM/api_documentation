---
title: IGain
---

# <small>BH.oM.Environment.SpaceCriteria.</small>**IGain**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IGain is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Environment.SpaceCriteria.[Equipment](/api/oM/Analytical/Environment/SpaceCriteria/Equipment)
    - BH.oM.Environment.SpaceCriteria.[Infiltration](/api/oM/Analytical/Environment/SpaceCriteria/Infiltration)
    - BH.oM.Environment.SpaceCriteria.[Lighting](/api/oM/Analytical/Environment/SpaceCriteria/Lighting)
    - BH.oM.Environment.SpaceCriteria.[People](/api/oM/Analytical/Environment/SpaceCriteria/People)
    - BH.oM.Environment.SpaceCriteria.[Plug](/api/oM/Analytical/Environment/SpaceCriteria/Plug)
    - BH.oM.Environment.SpaceCriteria.[Pollutant](/api/oM/Analytical/Environment/SpaceCriteria/Pollutant)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IGain : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Environment_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IGain.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/SpaceCriteria\IGain.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/SpaceCriteria/IGain.json}
```

The JSON Schema is available on github here:

- [IGain.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/SpaceCriteria/IGain.json)
