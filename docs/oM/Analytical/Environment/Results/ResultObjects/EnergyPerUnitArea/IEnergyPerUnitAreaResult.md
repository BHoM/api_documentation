---
title: IEnergyPerUnitAreaResult
---

# <small>BH.oM.Environment.Results.</small>**IEnergyPerUnitAreaResult**

A results object containing energy per unit area data.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IEnergyPerUnitAreaResult is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Environment.Results.[IAnalysisResult](/api/oM/Analytical/Environment/Results/ResultObjects/IAnalysisResult)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Environment.Results.[DiffuseHorizontalRadiationResult](/api/oM/Analytical/Environment/Results/ResultObjects/EnergyPerUnitArea/DiffuseHorizontalRadiationResult)
    - BH.oM.Environment.Results.[DirectNormalRadiationResult](/api/oM/Analytical/Environment/Results/ResultObjects/EnergyPerUnitArea/DirectNormalRadiationResult)
    - BH.oM.Environment.Results.[GlobalHorizontalRadiationResult](/api/oM/Analytical/Environment/Results/ResultObjects/EnergyPerUnitArea/GlobalHorizontalRadiationResult)
    - BH.oM.Environment.Results.[InsolationResult](/api/oM/Analytical/Environment/Results/ResultObjects/EnergyPerUnitArea/InsolationResult)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IEnergyPerUnitAreaResult : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Environment.Results.IAnalysisResult
```

Assembly: Environment_oM.dll

The C# interface definition is available on github:

- [IEnergyPerUnitAreaResult.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Results\ResultObjects\EnergyPerUnitArea\IEnergyPerUnitAreaResult.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/Results/IEnergyPerUnitAreaResult.json"
}
```

The JSON Schema is available on github here:

- [IEnergyPerUnitAreaResult.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/Results/IEnergyPerUnitAreaResult.json)
