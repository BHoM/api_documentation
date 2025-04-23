---
title: IRequest
---

# Data.Requests.IRequest



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRequest in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Data.Requests.[ILogicalRequest](/api/oM/Framework/Data/Requests/ILogicalRequest)
    - Data.Requests.[IResultRequest](/api/oM/Framework/Data/Requests/IResultRequest)
    - Adapters.File.[IDirectoryRequest](/api/oM/Adapter/Adapters/File/IDirectoryRequest)
    - Adapters.File.[IFileRequest](/api/oM/Adapter/Adapters/File/IFileRequest)
    - Adapters.File.[IFilingRequest](/api/oM/Adapter/Adapters/File/IFilingRequest)
    - Adapters.File.[IResourceRequest](/api/oM/Adapter/Adapters/File/IResourceRequest)
    - Adapters.File.[ISortableRequest](/api/oM/Adapter/Adapters/File/ISortableRequest)
    - Structure.Requests.[IStructuralResultRequest](/api/oM/Analytical/Structure/Requests/IStructuralResultRequest)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

    - Data.Requests.[BatchRequest](/api/oM/Framework/Data/Requests/BatchRequest)
    - Data.Requests.[CustomRequest](/api/oM/Framework/Data/Requests/CustomRequest)
    - Data.Requests.[FilterRequest](/api/oM/Framework/Data/Requests/FilterRequest)
    - Data.Requests.[LogicalAndRequest](/api/oM/Framework/Data/Requests/LogicalAndRequest)
    - Data.Requests.[LogicalNotRequest](/api/oM/Framework/Data/Requests/LogicalNotRequest)
    - Data.Requests.[LogicalOrRequest](/api/oM/Framework/Data/Requests/LogicalOrRequest)
    - Data.Requests.[SelectionRequest](/api/oM/Framework/Data/Requests/SelectionRequest)
    - Adapters.ETABS.Requests.[PierAndSpandrelForceRequest](/api/oM/Adapter/Adapters/ETABS/Requests/PierAndSpandrelForceRequest)
    - Adapters.Excel.[CellContentsRequest](/api/oM/Adapter/Adapters/Excel/CellContentsRequest)
    - Adapters.Excel.[CellValuesRequest](/api/oM/Adapter/Adapters/Excel/CellValuesRequest)
    - Adapters.Excel.[ObjectRequest](/api/oM/Adapter/Adapters/Excel/ObjectRequest)
    - Adapters.Excel.[WorksheetsRequest](/api/oM/Adapter/Adapters/Excel/WorksheetsRequest)
    - Adapters.File.[DirectoryRequest](/api/oM/Adapter/Adapters/File/DirectoryRequest)
    - Adapters.File.[FileContentRequest](/api/oM/Adapter/Adapters/File/FileContentRequest)
    - Adapters.File.[FileDirRequest](/api/oM/Adapter/Adapters/File/FileDirRequest)
    - Adapters.File.[FileRequest](/api/oM/Adapter/Adapters/File/FileRequest)
    - Adapters.File.[RemoveRequest](/api/oM/Adapter/Adapters/File/RemoveRequest)
    - Adapters.HTTP.[GetRequest](/api/oM/Adapter/Adapters/HTTP/GetRequest)
    - Adapters.Mongo.Requests.[CollectionNames](/api/oM/Adapter/Adapters/Mongo/Requests/CollectionNames)
    - Adapters.Revit.Requests.[ConditionRequest](/api/oM/Adapter/Adapters/Revit/Requests/ConditionRequest)
    - Adapters.Revit.Requests.[EnergyAnalysisModelRequest](/api/oM/Adapter/Adapters/Revit/Requests/EnergyAnalysisModelRequest)
    - Adapters.Revit.Requests.[FilterActiveView](/api/oM/Adapter/Adapters/Revit/Requests/FilterActiveView)
    - Adapters.Revit.Requests.[FilterByActiveWorkset](/api/oM/Adapter/Adapters/Revit/Requests/FilterByActiveWorkset)
    - Adapters.Revit.Requests.[FilterByCategory](/api/oM/Adapter/Adapters/Revit/Requests/FilterByCategory)
    - Adapters.Revit.Requests.[FilterByDBTypeName](/api/oM/Adapter/Adapters/Revit/Requests/FilterByDBTypeName)
    - Adapters.Revit.Requests.[FilterByElementIds](/api/oM/Adapter/Adapters/Revit/Requests/FilterByElementIds)
    - Adapters.Revit.Requests.[FilterByFamilyAndTypeName](/api/oM/Adapter/Adapters/Revit/Requests/FilterByFamilyAndTypeName)
    - Adapters.Revit.Requests.[FilterByFamilyType](/api/oM/Adapter/Adapters/Revit/Requests/FilterByFamilyType)
    - Adapters.Revit.Requests.[FilterByLink](/api/oM/Adapter/Adapters/Revit/Requests/FilterByLink)
    - Adapters.Revit.Requests.[FilterByParameterExistence](/api/oM/Adapter/Adapters/Revit/Requests/FilterByParameterExistence)
    - Adapters.Revit.Requests.[FilterByScopeBox](/api/oM/Adapter/Adapters/Revit/Requests/FilterByScopeBox)
    - Adapters.Revit.Requests.[FilterBySelectionSet](/api/oM/Adapter/Adapters/Revit/Requests/FilterBySelectionSet)
    - Adapters.Revit.Requests.[FilterByUniqueIds](/api/oM/Adapter/Adapters/Revit/Requests/FilterByUniqueIds)
    - Adapters.Revit.Requests.[FilterByUsage](/api/oM/Adapter/Adapters/Revit/Requests/FilterByUsage)
    - Adapters.Revit.Requests.[FilterByViewSpecific](/api/oM/Adapter/Adapters/Revit/Requests/FilterByViewSpecific)
    - Adapters.Revit.Requests.[FilterByVisibleInActiveView](/api/oM/Adapter/Adapters/Revit/Requests/FilterByVisibleInActiveView)
    - Adapters.Revit.Requests.[FilterByVisibleInView](/api/oM/Adapter/Adapters/Revit/Requests/FilterByVisibleInView)
    - Adapters.Revit.Requests.[FilterByWorkset](/api/oM/Adapter/Adapters/Revit/Requests/FilterByWorkset)
    - Adapters.Revit.Requests.[FilterEverything](/api/oM/Adapter/Adapters/Revit/Requests/FilterEverything)
    - Adapters.Revit.Requests.[FilterFamilyByName](/api/oM/Adapter/Adapters/Revit/Requests/FilterFamilyByName)
    - Adapters.Revit.Requests.[FilterFamilyTypeByName](/api/oM/Adapter/Adapters/Revit/Requests/FilterFamilyTypeByName)
    - Adapters.Revit.Requests.[FilterLinkInstance](/api/oM/Adapter/Adapters/Revit/Requests/FilterLinkInstance)
    - Adapters.Revit.Requests.[FilterMemberElements](/api/oM/Adapter/Adapters/Revit/Requests/FilterMemberElements)
    - Adapters.Revit.Requests.[FilterModelElements](/api/oM/Adapter/Adapters/Revit/Requests/FilterModelElements)
    - Adapters.Revit.Requests.[FilterTypesOfFamily](/api/oM/Adapter/Adapters/Revit/Requests/FilterTypesOfFamily)
    - Adapters.Revit.Requests.[FilterViewByName](/api/oM/Adapter/Adapters/Revit/Requests/FilterViewByName)
    - Adapters.Revit.Requests.[FilterViewsByTemplate](/api/oM/Adapter/Adapters/Revit/Requests/FilterViewsByTemplate)
    - Adapters.Revit.Requests.[FilterViewsByType](/api/oM/Adapter/Adapters/Revit/Requests/FilterViewsByType)
    - Adapters.Revit.Requests.[FilterViewTemplateByName](/api/oM/Adapter/Adapters/Revit/Requests/FilterViewTemplateByName)
    - Adapters.SAP2000.Requests.[SteelUtilisationRequest](/api/oM/Adapter/Adapters/SAP2000/Requests/SteelUtilisationRequest)
    - Adapters.SQL.[CustomRequest](/api/oM/Adapter/Adapters/SQL/CustomRequest)
    - Adapters.SQL.[TableRequest](/api/oM/Adapter/Adapters/SQL/TableRequest)
    - Structure.Requests.[BarResultRequest](/api/oM/Analytical/Structure/Requests/BarResultRequest)
    - Structure.Requests.[GlobalResultRequest](/api/oM/Analytical/Structure/Requests/GlobalResultRequest)
    - Structure.Requests.[MeshResultRequest](/api/oM/Analytical/Structure/Requests/MeshResultRequest)
    - Structure.Requests.[NodeResultRequest](/api/oM/Analytical/Structure/Requests/NodeResultRequest)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IRequest.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Requests\IRequest.cs)

All history and changes of the class can be found by inspection the history.
