---
title: ActionConfig
---

# Adapter.ActionConfig

Configurations specific for an Adapter Action (Push, Pull, etc).
Consider that your tookit might have a more specific implementation available. Try to look for [your toolkit name]ActionConfig.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ActionConfig in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes inheriting from this class

???+ bhom "The following classes are inheriting from this class:"

    - Adapters.CarbonQueryDatabase.[CQDConfig](/api_documentation/oM/Adapter/Adapters/CarbonQueryDatabase/CQDConfig)
    - Adapters.Excel.[ExcelPushConfig](/api_documentation/oM/Adapter/Adapters/Excel/ExcelPushConfig)
    - Adapters.File.[ExecuteConfig](/api_documentation/oM/Adapter/Adapters/File/ExecuteConfig)
    - Adapters.File.[PullConfig](/api_documentation/oM/Adapter/Adapters/File/PullConfig)
    - Adapters.File.[PushConfig](/api_documentation/oM/Adapter/Adapters/File/PushConfig)
    - Adapters.File.[RemoveConfig](/api_documentation/oM/Adapter/Adapters/File/RemoveConfig)
    - Adapters.GSA.[GSAConfig](/api_documentation/oM/Adapter/Adapters/GSA/GSAConfig)
    - Adapters.HTTP.[HTTPConfig](/api_documentation/oM/Adapter/Adapters/HTTP/HTTPConfig)
    - Adapters.iAuditor.[iAuditorConfig](/api_documentation/oM/Adapter/Adapters/iAuditor/iAuditorConfig)
    - Environment.IES.[PullConfigIES](/api_documentation/oM/Adapter/Environment/IES/PullConfigIES)
    - Environment.IES.[PushConfigIES](/api_documentation/oM/Adapter/Environment/IES/PushConfigIES)
    - LadybugTools.[LadybugConfig](/api_documentation/oM/Adapter/LadybugTools/LadybugConfig)
    - Adapters.Revit.[RevitPullConfig](/api_documentation/oM/Adapter/Adapters/Revit/RevitPullConfig)
    - Adapters.Revit.[RevitPushConfig](/api_documentation/oM/Adapter/Adapters/Revit/RevitPushConfig)
    - Adapters.Revit.[RevitRemoveConfig](/api_documentation/oM/Adapter/Adapters/Revit/RevitRemoveConfig)
    - Adapters.SAP2000.[SAP2000PushConfig](/api_documentation/oM/Adapter/Adapters/SAP2000/SAP2000PushConfig)
    - Environment.SAP.[SAPMarkUpPullConfig](/api_documentation/oM/Adapter/Environment/SAP/SAPMarkUpPullConfig)
    - Environment.SAP.[SAPPushConfig](/api_documentation/oM/Adapter/Environment/SAP/SAPPushConfig)
    - Environment.SAP.[SAPReportPullConfig](/api_documentation/oM/Adapter/Environment/SAP/SAPReportPullConfig)
    - Adapters.SQL.[PushConfig](/api_documentation/oM/Adapter/Adapters/SQL/PushConfig)
    - Adapters.XML.[XMLConfig](/api_documentation/oM/Adapter/Adapters/XML/XMLConfig)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WrapNonBHoMObjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the Push action wraps any non-BHoM type into a BH.oM.Adapter.ObjectWrapper, allowing them to make use of the full Adapter workflow. | - |
| AllowHashForComparing | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true and if no specific EqualityComparer is found for the type, Diffing hashes are computed and used to compare the objects. | - |
| DiffingConfig | [DiffingConfig](/api_documentation/oM/Framework/Diffing/DiffingConfig) | Configurations for the Diffing hashing. Requires `AllowHashForComparing` to be set to true. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [ActionConfig.cs](https://github.com/BHoM/BHoM_Adapter/blob/develop/Adapter_oM/Settings-Config/ActionConfig.cs)

All history and changes of the class can be found by inspection the history.
