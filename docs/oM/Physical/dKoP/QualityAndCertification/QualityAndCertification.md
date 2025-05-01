---
title: QualityAndCertification
---

# <small>BH.oM.dKoP.</small>**QualityAndCertification**



## Class structure

### Implemented interfaces and base types

???+ bhom "The QualityAndCertification is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| DLUHCPrincipalsDocumentReferenceNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| DLUHCPrincipalsDocumentReferenceVersion | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| CompliantWithDLUHCPrincipalsDocument | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| AssuranceSchemeName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| AssuranceCertification | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class QualityAndCertification : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [QualityAndCertification.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/QualityAndCertification\QualityAndCertification.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/QualityAndCertification.json"
}
```

The JSON Schema is available on github here:

- [QualityAndCertification.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/QualityAndCertification.json)
