---
title: SAP2000Id
---

# Adapters.SAP2000.SAP2000Id



## Class structure

### Implemented interfaces and base types

???+ bhom "The SAP2000Id in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IAdapterId](/om_documentation/oM/Framework/Base/IAdapterId)
    -  Base.[IFragment](/om_documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Base.[IPersistentAdapterId](/om_documentation/oM/Framework/Base/IPersistentAdapterId)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Id or multi-ids of the element as assigned in SAP2000 | - |
| PersistentId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Persistent GUID assigned by SAP2000 upon element creation. This does not vary when the element is modified. Only populated for Element-type objects | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [SAP2000Id.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments/SAP2000Id.cs)

All history and changes of the class can be found by inspection the history.
