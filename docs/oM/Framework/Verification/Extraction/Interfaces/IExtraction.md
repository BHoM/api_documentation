---
title: IExtraction
---

# <small>BH.oM.Verification.Extraction.</small>**IExtraction**

Top interface for all extraction objects.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IExtraction is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Verification.Extraction.[IConditionBasedFilter](/api/oM/Framework/Verification/Extraction/Interfaces/IConditionBasedFilter)
    - BH.oM.Verification.Extraction.[IDerivedObjectsExtraction](/api/oM/Framework/Verification/Extraction/Interfaces/IDerivedObjectsExtraction)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Verification.Extraction.[ConditionBasedFilter](/api/oM/Framework/Verification/Extraction/ConditionBasedFilter)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IExtraction : BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# interface definition is available on github:

- [IExtraction.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Extraction\Interfaces\IExtraction.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Verification_oM/Extraction/IExtraction.json"
}
```

The JSON Schema is available on github here:

- [IExtraction.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Verification_oM/Extraction/IExtraction.json)
