---
title: SunPathData
---

# <small>BH.oM.LadybugTools.</small>**SunPathData**



## Class structure

### Implemented interfaces and base types

???+ bhom "The SunPathData is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LadybugTools.[ISimulationData](/api/oM/Adapter/LadybugTools/MetaData/ISimulationData)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| DecemberSolstice | [SunData](/api/oM/Adapter/LadybugTools/MetaData/SunData) | Data describing the December (winter) solstice. | - |
| MarchEquinox | [SunData](/api/oM/Adapter/LadybugTools/MetaData/SunData) | Data describing the March (spring) equinox. | - |
| JuneSolstice | [SunData](/api/oM/Adapter/LadybugTools/MetaData/SunData) | Data describing the June (summer) solstice. | - |
| SeptemberEquinox | [SunData](/api/oM/Adapter/LadybugTools/MetaData/SunData) | Data describing the September (autumn) equinox. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SunPathData : BH.oM.LadybugTools.ISimulationData, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The C# class definition is available on github:

- [SunPathData.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/MetaData\SunPathData.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/SunPathData.json"
}
```

The JSON Schema is available on github here:

- [SunPathData.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/SunPathData.json)
