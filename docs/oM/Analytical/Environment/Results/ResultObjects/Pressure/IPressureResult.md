---
title: IPressureResult
---

# <small>BH.oM.Environment.Results.</small>**IPressureResult**

A results object containing pressure data.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IPressureResult is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Environment.Results.[IAnalysisResult](/api/oM/Analytical/Environment/Results/ResultObjects/IAnalysisResult)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Environment.Results.[AtmosphericPressureResult](/api/oM/Analytical/Environment/Results/ResultObjects/Pressure/AtmosphericPressureResult)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IPressureResult : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Environment.Results.IAnalysisResult
```

Assembly: Environment_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IPressureResult.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Results\ResultObjects\Pressure\IPressureResult.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/Results/IPressureResult.json}
```

The JSON Schema is available on github here:

- [IPressureResult.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/Results/IPressureResult.json)
