---
title: IRequest
---

# Data.Requests.IRequest



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRequest in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Data.Requests.[ILogicalRequest](/om_documentation/oM/Framework/Data/Requests/ILogicalRequest)
    - Data.Requests.[IResultRequest](/om_documentation/oM/Framework/Data/Requests/IResultRequest)
    - Adapters.File.[IDirectoryRequest](/om_documentation/oM/Adapter/Adapters/File/IDirectoryRequest)
    - Adapters.File.[IFileRequest](/om_documentation/oM/Adapter/Adapters/File/IFileRequest)
    - Adapters.File.[IFilingRequest](/om_documentation/oM/Adapter/Adapters/File/IFilingRequest)
    - Adapters.File.[IResourceRequest](/om_documentation/oM/Adapter/Adapters/File/IResourceRequest)
    - Adapters.File.[ISortableRequest](/om_documentation/oM/Adapter/Adapters/File/ISortableRequest)
    - Structure.Requests.[IStructuralResultRequest](/om_documentation/oM/Analytical/Structure/Requests/IStructuralResultRequest)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

    - Data.Requests.[BatchRequest](/om_documentation/oM/Framework/Data/Requests/BatchRequest)
    - Data.Requests.[CustomRequest](/om_documentation/oM/Framework/Data/Requests/CustomRequest)
    - Data.Requests.[FilterRequest](/om_documentation/oM/Framework/Data/Requests/FilterRequest)
    - Data.Requests.[LogicalAndRequest](/om_documentation/oM/Framework/Data/Requests/LogicalAndRequest)
    - Data.Requests.[LogicalNotRequest](/om_documentation/oM/Framework/Data/Requests/LogicalNotRequest)
    - Data.Requests.[LogicalOrRequest](/om_documentation/oM/Framework/Data/Requests/LogicalOrRequest)
    - Data.Requests.[SelectionRequest](/om_documentation/oM/Framework/Data/Requests/SelectionRequest)
    - Adapters.ETABS.Requests.[PierAndSpandrelForceRequest](/om_documentation/oM/Adapter/Adapters/ETABS/Requests/PierAndSpandrelForceRequest)
    - Adapters.Excel.[CellContentsRequest](/om_documentation/oM/Adapter/Adapters/Excel/CellContentsRequest)
    - Adapters.Excel.[CellValuesRequest](/om_documentation/oM/Adapter/Adapters/Excel/CellValuesRequest)
    - Adapters.Excel.[ObjectRequest](/om_documentation/oM/Adapter/Adapters/Excel/ObjectRequest)
    - Adapters.Excel.[WorksheetsRequest](/om_documentation/oM/Adapter/Adapters/Excel/WorksheetsRequest)
    - Adapters.File.[DirectoryRequest](/om_documentation/oM/Adapter/Adapters/File/DirectoryRequest)
    - Adapters.File.[FileContentRequest](/om_documentation/oM/Adapter/Adapters/File/FileContentRequest)
    - Adapters.File.[FileDirRequest](/om_documentation/oM/Adapter/Adapters/File/FileDirRequest)
    - Adapters.File.[FileRequest](/om_documentation/oM/Adapter/Adapters/File/FileRequest)
    - Adapters.File.[RemoveRequest](/om_documentation/oM/Adapter/Adapters/File/RemoveRequest)
    - Adapters.HTTP.[GetRequest](/om_documentation/oM/Adapter/Adapters/HTTP/GetRequest)
    - Adapters.Mongo.Requests.[CollectionNames](/om_documentation/oM/Adapter/Adapters/Mongo/Requests/CollectionNames)
    - Adapters.Revit.Requests.[ConditionRequest](/om_documentation/oM/Adapter/Adapters/Revit/Requests/ConditionRequest)
    - Adapters.Revit.Requests.[EnergyAnalysisModelRequest](/om_documentation/oM/Adapter/Adapters/Revit/Requests/EnergyAnalysisModelRequest)
    - Adapters.Revit.Requests.[FilterActiveView](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterActiveView)
    - Adapters.Revit.Requests.[FilterByActiveWorkset](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByActiveWorkset)
    - Adapters.Revit.Requests.[FilterByCategory](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByCategory)
    - Adapters.Revit.Requests.[FilterByDBTypeName](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByDBTypeName)
    - Adapters.Revit.Requests.[FilterByElementIds](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByElementIds)
    - Adapters.Revit.Requests.[FilterByFamilyAndTypeName](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByFamilyAndTypeName)
    - Adapters.Revit.Requests.[FilterByFamilyType](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByFamilyType)
    - Adapters.Revit.Requests.[FilterByLink](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByLink)
    - Adapters.Revit.Requests.[FilterByParameterExistence](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByParameterExistence)
    - Adapters.Revit.Requests.[FilterByScopeBox](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByScopeBox)
    - Adapters.Revit.Requests.[FilterBySelectionSet](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterBySelectionSet)
    - Adapters.Revit.Requests.[FilterByUniqueIds](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByUniqueIds)
    - Adapters.Revit.Requests.[FilterByUsage](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByUsage)
    - Adapters.Revit.Requests.[FilterByViewSpecific](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByViewSpecific)
    - Adapters.Revit.Requests.[FilterByVisibleInActiveView](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByVisibleInActiveView)
    - Adapters.Revit.Requests.[FilterByVisibleInView](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByVisibleInView)
    - Adapters.Revit.Requests.[FilterByWorkset](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByWorkset)
    - Adapters.Revit.Requests.[FilterEverything](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterEverything)
    - Adapters.Revit.Requests.[FilterFamilyByName](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterFamilyByName)
    - Adapters.Revit.Requests.[FilterFamilyTypeByName](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterFamilyTypeByName)
    - Adapters.Revit.Requests.[FilterLinkInstance](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterLinkInstance)
    - Adapters.Revit.Requests.[FilterMemberElements](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterMemberElements)
    - Adapters.Revit.Requests.[FilterModelElements](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterModelElements)
    - Adapters.Revit.Requests.[FilterTypesOfFamily](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterTypesOfFamily)
    - Adapters.Revit.Requests.[FilterViewByName](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterViewByName)
    - Adapters.Revit.Requests.[FilterViewsByTemplate](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterViewsByTemplate)
    - Adapters.Revit.Requests.[FilterViewsByType](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterViewsByType)
    - Adapters.Revit.Requests.[FilterViewTemplateByName](/om_documentation/oM/Adapter/Adapters/Revit/Requests/FilterViewTemplateByName)
    - Adapters.SAP2000.Requests.[SteelUtilisationRequest](/om_documentation/oM/Adapter/Adapters/SAP2000/Requests/SteelUtilisationRequest)
    - Adapters.SQL.[CustomRequest](/om_documentation/oM/Adapter/Adapters/SQL/CustomRequest)
    - Adapters.SQL.[TableRequest](/om_documentation/oM/Adapter/Adapters/SQL/TableRequest)
    - Structure.Requests.[BarResultRequest](/om_documentation/oM/Analytical/Structure/Requests/BarResultRequest)
    - Structure.Requests.[GlobalResultRequest](/om_documentation/oM/Analytical/Structure/Requests/GlobalResultRequest)
    - Structure.Requests.[MeshResultRequest](/om_documentation/oM/Analytical/Structure/Requests/MeshResultRequest)
    - Structure.Requests.[NodeResultRequest](/om_documentation/oM/Analytical/Structure/Requests/NodeResultRequest)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/om_documentation/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IRequest.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Requests\IRequest.cs)

All history and changes of the class can be found by inspection the history.
