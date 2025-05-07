---
title: IDerivedObjectsExtraction
---

# <small>BH.oM.Verification.Extraction.</small>**IDerivedObjectsExtraction**

Interface for all extraction workflows based on 'extract from' or 'calculate from' modes.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IDerivedObjectsExtraction is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Extraction.[IExtraction](/api/oM/Framework/Verification/Extraction/Interfaces/IExtraction)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IDerivedObjectsExtraction : BH.oM.Verification.Extraction.IExtraction, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# interface definition is available on github:

- [IDerivedObjectsExtraction.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Extraction\Interfaces\IDerivedObjectsExtraction.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Verification_oM/Extraction/IDerivedObjectsExtraction.json"
}
```

The JSON Schema is available on github here:

- [IDerivedObjectsExtraction.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Verification_oM/Extraction/IDerivedObjectsExtraction.json)
