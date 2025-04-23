---
title: SAPReport
---

# Environment.SAP.XML.SAPReport



## Class structure

### Implemented interfaces and base types

???+ bhom "The SAPReport in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SchemaVersionOriginal | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The schema version that the data conformed to when it was lodged. | - |
| SchemaVersionCurrent | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The schema version that the data conformed to when it was lodged. | - |
| SAPVersion | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | SAP version that was used for the calculation. | - |
| SAPDataVersion | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Version of SAP that was used to define the input data for the calculation. | - |
| PCDFRevisionNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Revision Number of the PCDF file used for the calculations. | - |
| CalculationSoftwareName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the software used to perform the SAP calculation. | - |
| CalculationSoftwareVersion | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Version of the software used to perform the SAP calculation. | - |
| UserInterfaceName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| UserInterfaceVersion | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| ReportHeader | [ReportHeader](/api/oM/Adapter/Environment/SAP/XML/ReportHeader) | . | - |
| EnergyAssessment | [EnergyAssessment](/api/oM/Adapter/Environment/SAP/XML/EnergyAssessment) | . | - |
| SAP10Data | [SAP10Data](/api/oM/Adapter/Environment/SAP/XML/SAP10Data) | . | - |
| InsuranceDetails | [InsuranceDetails](/api/oM/Adapter/Environment/SAP/XML/InsuranceDetails) | Details of the Professional Indemnity Insurance policy used to provide cover against a compensation claim against any particular Home Condition Report. | - |
| ExternalDefinitionsRevisionNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A number indicating the version of related ExternalDefinitions. | - |


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

The class is defined in C#. The class definition is available on github:

- [SAPReport.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML/SAPReport.cs)

All history and changes of the class can be found by inspection the history.
