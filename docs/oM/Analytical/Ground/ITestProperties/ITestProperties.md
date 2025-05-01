---
title: ITestProperties
---

# <small>BH.oM.Ground.</small>**ITestProperties**

Base interface for testing properties.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ITestProperties is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Ground.[InSituVaneReferenceProperties](/api/oM/Analytical/Ground/ITestProperties/InSituVaneReferenceProperties)
    - BH.oM.Ground.[InSituVaneResultProperties](/api/oM/Analytical/Ground/ITestProperties/InSituVaneResultProperties)
    - BH.oM.Ground.[InSituVaneTestProperties](/api/oM/Analytical/Ground/ITestProperties/InSituVaneTestProperties)
    - BH.oM.Ground.[SPTReferenceProperties](/api/oM/Analytical/Ground/ITestProperties/SPTReferenceProperties)
    - BH.oM.Ground.[SPTResultProperties](/api/oM/Analytical/Ground/ITestProperties/SPTResultProperties)
    - BH.oM.Ground.[SPTTestProperties](/api/oM/Analytical/Ground/ITestProperties/SPTTestProperties)
    - BH.oM.Ground.[TriaxialReferenceProperties](/api/oM/Analytical/Ground/ITestProperties/TriaxialReferenceProperties)
    - BH.oM.Ground.[TriaxialResultProperties](/api/oM/Analytical/Ground/ITestProperties/TriaxialResultProperties)
    - BH.oM.Ground.[TriaxialTestProperties](/api/oM/Analytical/Ground/ITestProperties/TriaxialTestProperties)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface ITestProperties : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Ground_oM.dll

The C# interface definition is available on github:

- [ITestProperties.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/ITestProperties\ITestProperties.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Ground_oM/ITestProperties.json"
}
```

The JSON Schema is available on github here:

- [ITestProperties.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Ground_oM/ITestProperties.json)
