---
title: IRequest
---

# Data.Requests.IRequest



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRequest in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Data.Requests.[ILogicalRequest](/documentation/oM/Framework/Data/Requests/ILogicalRequest)
    - Data.Requests.[IResultRequest](/documentation/oM/Framework/Data/Requests/IResultRequest)
    - Adapters.File.[IDirectoryRequest](/documentation/oM/Adapter/Adapters/File/IDirectoryRequest)
    - Adapters.File.[IFileRequest](/documentation/oM/Adapter/Adapters/File/IFileRequest)
    - Adapters.File.[IFilingRequest](/documentation/oM/Adapter/Adapters/File/IFilingRequest)
    - Adapters.File.[IResourceRequest](/documentation/oM/Adapter/Adapters/File/IResourceRequest)
    - Adapters.File.[ISortableRequest](/documentation/oM/Adapter/Adapters/File/ISortableRequest)
    - Structure.Requests.[IStructuralResultRequest](/documentation/oM/Analytical/Structure/Requests/IStructuralResultRequest)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

    - Data.Requests.[BatchRequest](/documentation/oM/Framework/Data/Requests/BatchRequest)
    - Data.Requests.[CustomRequest](/documentation/oM/Framework/Data/Requests/CustomRequest)
    - Data.Requests.[FilterRequest](/documentation/oM/Framework/Data/Requests/FilterRequest)
    - Data.Requests.[LogicalAndRequest](/documentation/oM/Framework/Data/Requests/LogicalAndRequest)
    - Data.Requests.[LogicalNotRequest](/documentation/oM/Framework/Data/Requests/LogicalNotRequest)
    - Data.Requests.[LogicalOrRequest](/documentation/oM/Framework/Data/Requests/LogicalOrRequest)
    - Data.Requests.[SelectionRequest](/documentation/oM/Framework/Data/Requests/SelectionRequest)
    - Adapters.ETABS.Requests.[PierAndSpandrelForceRequest](/documentation/oM/Adapter/Adapters/ETABS/Requests/PierAndSpandrelForceRequest)
    - Adapters.Excel.[CellContentsRequest](/documentation/oM/Adapter/Adapters/Excel/CellContentsRequest)
    - Adapters.Excel.[CellValuesRequest](/documentation/oM/Adapter/Adapters/Excel/CellValuesRequest)
    - Adapters.Excel.[ObjectRequest](/documentation/oM/Adapter/Adapters/Excel/ObjectRequest)
    - Adapters.Excel.[WorksheetsRequest](/documentation/oM/Adapter/Adapters/Excel/WorksheetsRequest)
    - Adapters.File.[DirectoryRequest](/documentation/oM/Adapter/Adapters/File/DirectoryRequest)
    - Adapters.File.[FileContentRequest](/documentation/oM/Adapter/Adapters/File/FileContentRequest)
    - Adapters.File.[FileDirRequest](/documentation/oM/Adapter/Adapters/File/FileDirRequest)
    - Adapters.File.[FileRequest](/documentation/oM/Adapter/Adapters/File/FileRequest)
    - Adapters.File.[RemoveRequest](/documentation/oM/Adapter/Adapters/File/RemoveRequest)
    - Adapters.HTTP.[GetRequest](/documentation/oM/Adapter/Adapters/HTTP/GetRequest)
    - Adapters.Mongo.Requests.[CollectionNames](/documentation/oM/Adapter/Adapters/Mongo/Requests/CollectionNames)
    - Adapters.Revit.Requests.[ConditionRequest](/documentation/oM/Adapter/Adapters/Revit/Requests/ConditionRequest)
    - Adapters.Revit.Requests.[EnergyAnalysisModelRequest](/documentation/oM/Adapter/Adapters/Revit/Requests/EnergyAnalysisModelRequest)
    - Adapters.Revit.Requests.[FilterActiveView](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterActiveView)
    - Adapters.Revit.Requests.[FilterByActiveWorkset](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterByActiveWorkset)
    - Adapters.Revit.Requests.[FilterByCategory](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterByCategory)
    - Adapters.Revit.Requests.[FilterByDBTypeName](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterByDBTypeName)
    - Adapters.Revit.Requests.[FilterByElementIds](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterByElementIds)
    - Adapters.Revit.Requests.[FilterByFamilyAndTypeName](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterByFamilyAndTypeName)
    - Adapters.Revit.Requests.[FilterByFamilyType](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterByFamilyType)
    - Adapters.Revit.Requests.[FilterByLink](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterByLink)
    - Adapters.Revit.Requests.[FilterByParameterExistence](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterByParameterExistence)
    - Adapters.Revit.Requests.[FilterByScopeBox](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterByScopeBox)
    - Adapters.Revit.Requests.[FilterBySelectionSet](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterBySelectionSet)
    - Adapters.Revit.Requests.[FilterByUniqueIds](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterByUniqueIds)
    - Adapters.Revit.Requests.[FilterByUsage](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterByUsage)
    - Adapters.Revit.Requests.[FilterByViewSpecific](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterByViewSpecific)
    - Adapters.Revit.Requests.[FilterByVisibleInActiveView](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterByVisibleInActiveView)
    - Adapters.Revit.Requests.[FilterByVisibleInView](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterByVisibleInView)
    - Adapters.Revit.Requests.[FilterByWorkset](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterByWorkset)
    - Adapters.Revit.Requests.[FilterEverything](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterEverything)
    - Adapters.Revit.Requests.[FilterFamilyByName](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterFamilyByName)
    - Adapters.Revit.Requests.[FilterFamilyTypeByName](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterFamilyTypeByName)
    - Adapters.Revit.Requests.[FilterLinkInstance](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterLinkInstance)
    - Adapters.Revit.Requests.[FilterMemberElements](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterMemberElements)
    - Adapters.Revit.Requests.[FilterModelElements](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterModelElements)
    - Adapters.Revit.Requests.[FilterTypesOfFamily](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterTypesOfFamily)
    - Adapters.Revit.Requests.[FilterViewByName](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterViewByName)
    - Adapters.Revit.Requests.[FilterViewsByTemplate](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterViewsByTemplate)
    - Adapters.Revit.Requests.[FilterViewsByType](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterViewsByType)
    - Adapters.Revit.Requests.[FilterViewTemplateByName](/documentation/oM/Adapter/Adapters/Revit/Requests/FilterViewTemplateByName)
    - Adapters.SAP2000.Requests.[SteelUtilisationRequest](/documentation/oM/Adapter/Adapters/SAP2000/Requests/SteelUtilisationRequest)
    - Adapters.SQL.[CustomRequest](/documentation/oM/Adapter/Adapters/SQL/CustomRequest)
    - Adapters.SQL.[TableRequest](/documentation/oM/Adapter/Adapters/SQL/TableRequest)
    - Structure.Requests.[BarResultRequest](/documentation/oM/Analytical/Structure/Requests/BarResultRequest)
    - Structure.Requests.[GlobalResultRequest](/documentation/oM/Analytical/Structure/Requests/GlobalResultRequest)
    - Structure.Requests.[MeshResultRequest](/documentation/oM/Analytical/Structure/Requests/MeshResultRequest)
    - Structure.Requests.[NodeResultRequest](/documentation/oM/Analytical/Structure/Requests/NodeResultRequest)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/documentation/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IRequest.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Requests\IRequest.cs)

All history and changes of the class can be found by inspection the history.
