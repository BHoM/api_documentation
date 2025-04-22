---
title: ReportHeader
---

# Environment.SAP.XML.ReportHeader



## Class structure

### Implemented interfaces and base types

???+ bhom "The ReportHeader in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


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
| HomeInspector | [HomeInspector](/api_documentation/oM/Adapter/Environment/SAP/XML/HomeInspector) | . | - |
| Property | [Property](/api_documentation/oM/Adapter/Environment/SAP/XML/Property) | . | - |
| RegionCode | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Regional code. | - |
| CountryCode | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| RelatedPartyDisclosure | [RelatedPartyDisclosure](/api_documentation/oM/Adapter/Environment/SAP/XML/RelatedPartyDisclosure) | . | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [ReportHeader.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML/ReportHeader.cs)

All history and changes of the class can be found by inspection the history.
