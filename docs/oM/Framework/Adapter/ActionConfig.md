---
title: ActionConfig
---

# Adapter.ActionConfig

Configurations specific for an Adapter Action (Push, Pull, etc).
Consider that your tookit might have a more specific implementation available. Try to look for [your toolkit name]ActionConfig.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ActionConfig in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Classes inheriting from this class

???+ bhom "The following classes are inheriting from this class:"

    - Adapters.CarbonQueryDatabase.[CQDConfig](/om_documentation/oM/Adapter/Adapters/CarbonQueryDatabase/CQDConfig)
    - Adapters.Excel.[ExcelPushConfig](/om_documentation/oM/Adapter/Adapters/Excel/ExcelPushConfig)
    - Adapters.File.[ExecuteConfig](/om_documentation/oM/Adapter/Adapters/File/ExecuteConfig)
    - Adapters.File.[PullConfig](/om_documentation/oM/Adapter/Adapters/File/PullConfig)
    - Adapters.File.[PushConfig](/om_documentation/oM/Adapter/Adapters/File/PushConfig)
    - Adapters.File.[RemoveConfig](/om_documentation/oM/Adapter/Adapters/File/RemoveConfig)
    - Adapters.GSA.[GSAConfig](/om_documentation/oM/Adapter/Adapters/GSA/GSAConfig)
    - Adapters.HTTP.[HTTPConfig](/om_documentation/oM/Adapter/Adapters/HTTP/HTTPConfig)
    - Adapters.iAuditor.[iAuditorConfig](/om_documentation/oM/Adapter/Adapters/iAuditor/iAuditorConfig)
    - Environment.IES.[PullConfigIES](/om_documentation/oM/Adapter/Environment/IES/PullConfigIES)
    - Environment.IES.[PushConfigIES](/om_documentation/oM/Adapter/Environment/IES/PushConfigIES)
    - LadybugTools.[LadybugConfig](/om_documentation/oM/Adapter/LadybugTools/LadybugConfig)
    - Adapters.Revit.[RevitPullConfig](/om_documentation/oM/Adapter/Adapters/Revit/RevitPullConfig)
    - Adapters.Revit.[RevitPushConfig](/om_documentation/oM/Adapter/Adapters/Revit/RevitPushConfig)
    - Adapters.Revit.[RevitRemoveConfig](/om_documentation/oM/Adapter/Adapters/Revit/RevitRemoveConfig)
    - Adapters.SAP2000.[SAP2000PushConfig](/om_documentation/oM/Adapter/Adapters/SAP2000/SAP2000PushConfig)
    - Environment.SAP.[SAPMarkUpPullConfig](/om_documentation/oM/Adapter/Environment/SAP/SAPMarkUpPullConfig)
    - Environment.SAP.[SAPPushConfig](/om_documentation/oM/Adapter/Environment/SAP/SAPPushConfig)
    - Environment.SAP.[SAPReportPullConfig](/om_documentation/oM/Adapter/Environment/SAP/SAPReportPullConfig)
    - Adapters.SQL.[PushConfig](/om_documentation/oM/Adapter/Adapters/SQL/PushConfig)
    - Adapters.XML.[XMLConfig](/om_documentation/oM/Adapter/Adapters/XML/XMLConfig)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WrapNonBHoMObjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the Push action wraps any non-BHoM type into a BH.oM.Adapter.ObjectWrapper, allowing them to make use of the full Adapter workflow. | - |
| AllowHashForComparing | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true and if no specific EqualityComparer is found for the type, Diffing hashes are computed and used to compare the objects. | - |
| DiffingConfig | [DiffingConfig](/om_documentation/oM/Framework/Diffing/DiffingConfig) | Configurations for the Diffing hashing. Requires `AllowHashForComparing` to be set to true. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [ActionConfig.cs](https://github.com/BHoM/BHoM_Adapter/blob/develop/Adapter_oM/Settings-Config/ActionConfig.cs)

All history and changes of the class can be found by inspection the history.
