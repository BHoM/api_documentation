---
title: ReportHeader
---

# <small>BH.oM.Environment.SAP.XML.</small>**ReportHeader**



## Class structure

### Implemented interfaces and base types

???+ bhom "The ReportHeader is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ReportReferenceNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Report Reference Number is the unique report Identifier that the report will be publicly known by. | - |
| InspectionDate | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The date that the inspection was actually carried out by the Home Inspector. In the form yyyy-mm-dd | - |
| ReportType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The type of Home Inspection that was carried out. | - |
| CompletionDate | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The date that the Home Inspector completed the report. In the form yyyy-mm-dd | - |
| RegistrationDate | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The date that the report was submitted to the HCR Registration Organisation for lodging in the HCR Register. In the form yyyy-mm-dd | - |
| Status | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The Status of the Report. | - |
| LanguageCode | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The language that the report is written in. | - |
| Tenure | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| TransactionType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| SellerCommissionReport | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| PropertyType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Describes the type of Property that is being inspected. This should be the same as the Property-Type recorded in the Property-Details section. | - |
| HomeInspector | [HomeInspector](/api/oM/Adapter/Environment/XML/HomeInspector) | . | - |
| Property | [Property](/api/oM/Adapter/Environment/XML/Property) | . | - |
| RegionCode | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Regional code. | - |
| CountryCode | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| RelatedPartyDisclosure | [RelatedPartyDisclosure](/api/oM/Adapter/Environment/XML/RelatedPartyDisclosure) | . | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ReportHeader : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: SAP_oM.dll

The class is defined in C#. The class definition is available on github:

- [ReportHeader.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML\ReportHeader.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/XML/ReportHeader.json}
```

The JSON Schema is available on github here:

- [ReportHeader.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/XML/ReportHeader.json)
