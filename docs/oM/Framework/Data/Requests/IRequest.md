---
title: IRequest
---

# Data.Requests.IRequest



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRequest in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Data.Requests.[ILogicalRequest](/api_documentation/oM/Framework/Data/Requests/ILogicalRequest)
    - Data.Requests.[IResultRequest](/api_documentation/oM/Framework/Data/Requests/IResultRequest)
    - Adapters.File.[IDirectoryRequest](/api_documentation/oM/Adapter/Adapters/File/IDirectoryRequest)
    - Adapters.File.[IFileRequest](/api_documentation/oM/Adapter/Adapters/File/IFileRequest)
    - Adapters.File.[IFilingRequest](/api_documentation/oM/Adapter/Adapters/File/IFilingRequest)
    - Adapters.File.[IResourceRequest](/api_documentation/oM/Adapter/Adapters/File/IResourceRequest)
    - Adapters.File.[ISortableRequest](/api_documentation/oM/Adapter/Adapters/File/ISortableRequest)
    - Structure.Requests.[IStructuralResultRequest](/api_documentation/oM/Analytical/Structure/Requests/IStructuralResultRequest)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

    - Data.Requests.[BatchRequest](/api_documentation/oM/Framework/Data/Requests/BatchRequest)
    - Data.Requests.[CustomRequest](/api_documentation/oM/Framework/Data/Requests/CustomRequest)
    - Data.Requests.[FilterRequest](/api_documentation/oM/Framework/Data/Requests/FilterRequest)
    - Data.Requests.[LogicalAndRequest](/api_documentation/oM/Framework/Data/Requests/LogicalAndRequest)
    - Data.Requests.[LogicalNotRequest](/api_documentation/oM/Framework/Data/Requests/LogicalNotRequest)
    - Data.Requests.[LogicalOrRequest](/api_documentation/oM/Framework/Data/Requests/LogicalOrRequest)
    - Data.Requests.[SelectionRequest](/api_documentation/oM/Framework/Data/Requests/SelectionRequest)
    - Adapters.ETABS.Requests.[PierAndSpandrelForceRequest](/api_documentation/oM/Adapter/Adapters/ETABS/Requests/PierAndSpandrelForceRequest)
    - Adapters.Excel.[CellContentsRequest](/api_documentation/oM/Adapter/Adapters/Excel/CellContentsRequest)
    - Adapters.Excel.[CellValuesRequest](/api_documentation/oM/Adapter/Adapters/Excel/CellValuesRequest)
    - Adapters.Excel.[ObjectRequest](/api_documentation/oM/Adapter/Adapters/Excel/ObjectRequest)
    - Adapters.Excel.[WorksheetsRequest](/api_documentation/oM/Adapter/Adapters/Excel/WorksheetsRequest)
    - Adapters.File.[DirectoryRequest](/api_documentation/oM/Adapter/Adapters/File/DirectoryRequest)
    - Adapters.File.[FileContentRequest](/api_documentation/oM/Adapter/Adapters/File/FileContentRequest)
    - Adapters.File.[FileDirRequest](/api_documentation/oM/Adapter/Adapters/File/FileDirRequest)
    - Adapters.File.[FileRequest](/api_documentation/oM/Adapter/Adapters/File/FileRequest)
    - Adapters.File.[RemoveRequest](/api_documentation/oM/Adapter/Adapters/File/RemoveRequest)
    - Adapters.HTTP.[GetRequest](/api_documentation/oM/Adapter/Adapters/HTTP/GetRequest)
    - Adapters.Mongo.Requests.[CollectionNames](/api_documentation/oM/Adapter/Adapters/Mongo/Requests/CollectionNames)
    - Adapters.Revit.Requests.[ConditionRequest](/api_documentation/oM/Adapter/Adapters/Revit/Requests/ConditionRequest)
    - Adapters.Revit.Requests.[EnergyAnalysisModelRequest](/api_documentation/oM/Adapter/Adapters/Revit/Requests/EnergyAnalysisModelRequest)
    - Adapters.Revit.Requests.[FilterActiveView](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterActiveView)
    - Adapters.Revit.Requests.[FilterByActiveWorkset](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByActiveWorkset)
    - Adapters.Revit.Requests.[FilterByCategory](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByCategory)
    - Adapters.Revit.Requests.[FilterByDBTypeName](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByDBTypeName)
    - Adapters.Revit.Requests.[FilterByElementIds](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByElementIds)
    - Adapters.Revit.Requests.[FilterByFamilyAndTypeName](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByFamilyAndTypeName)
    - Adapters.Revit.Requests.[FilterByFamilyType](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByFamilyType)
    - Adapters.Revit.Requests.[FilterByLink](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByLink)
    - Adapters.Revit.Requests.[FilterByParameterExistence](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByParameterExistence)
    - Adapters.Revit.Requests.[FilterByScopeBox](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByScopeBox)
    - Adapters.Revit.Requests.[FilterBySelectionSet](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterBySelectionSet)
    - Adapters.Revit.Requests.[FilterByUniqueIds](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByUniqueIds)
    - Adapters.Revit.Requests.[FilterByUsage](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByUsage)
    - Adapters.Revit.Requests.[FilterByViewSpecific](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByViewSpecific)
    - Adapters.Revit.Requests.[FilterByVisibleInActiveView](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByVisibleInActiveView)
    - Adapters.Revit.Requests.[FilterByVisibleInView](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByVisibleInView)
    - Adapters.Revit.Requests.[FilterByWorkset](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterByWorkset)
    - Adapters.Revit.Requests.[FilterEverything](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterEverything)
    - Adapters.Revit.Requests.[FilterFamilyByName](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterFamilyByName)
    - Adapters.Revit.Requests.[FilterFamilyTypeByName](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterFamilyTypeByName)
    - Adapters.Revit.Requests.[FilterLinkInstance](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterLinkInstance)
    - Adapters.Revit.Requests.[FilterMemberElements](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterMemberElements)
    - Adapters.Revit.Requests.[FilterModelElements](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterModelElements)
    - Adapters.Revit.Requests.[FilterTypesOfFamily](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterTypesOfFamily)
    - Adapters.Revit.Requests.[FilterViewByName](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterViewByName)
    - Adapters.Revit.Requests.[FilterViewsByTemplate](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterViewsByTemplate)
    - Adapters.Revit.Requests.[FilterViewsByType](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterViewsByType)
    - Adapters.Revit.Requests.[FilterViewTemplateByName](/api_documentation/oM/Adapter/Adapters/Revit/Requests/FilterViewTemplateByName)
    - Adapters.SAP2000.Requests.[SteelUtilisationRequest](/api_documentation/oM/Adapter/Adapters/SAP2000/Requests/SteelUtilisationRequest)
    - Adapters.SQL.[CustomRequest](/api_documentation/oM/Adapter/Adapters/SQL/CustomRequest)
    - Adapters.SQL.[TableRequest](/api_documentation/oM/Adapter/Adapters/SQL/TableRequest)
    - Structure.Requests.[BarResultRequest](/api_documentation/oM/Analytical/Structure/Requests/BarResultRequest)
    - Structure.Requests.[GlobalResultRequest](/api_documentation/oM/Analytical/Structure/Requests/GlobalResultRequest)
    - Structure.Requests.[MeshResultRequest](/api_documentation/oM/Analytical/Structure/Requests/MeshResultRequest)
    - Structure.Requests.[NodeResultRequest](/api_documentation/oM/Analytical/Structure/Requests/NodeResultRequest)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api_documentation/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IRequest.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Requests\IRequest.cs)

All history and changes of the class can be found by inspection the history.
