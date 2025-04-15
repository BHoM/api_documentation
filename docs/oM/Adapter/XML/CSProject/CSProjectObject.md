---
title: CSProjectObject
---

# XML.CSProject.CSProjectObject



## Class structure

### Implemented interfaces and base types

???+ bhom "The CSProjectObject in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Classes inheriting from this class

???+ bhom "The following classes are inheriting from this class:"

    - XML.CSProject.[Import](/om_documentation/oM/Adapter/XML/CSProject/Import)
    - XML.CSProject.[IncludedFile](/om_documentation/oM/Adapter/XML/CSProject/IncludedFile)
    - XML.CSProject.[ItemGroup](/om_documentation/oM/Adapter/XML/CSProject/ItemGroup)
    - XML.CSProject.[ProjectReference](/om_documentation/oM/Adapter/XML/CSProject/ProjectReference)
    - XML.CSProject.[Reference](/om_documentation/oM/Adapter/XML/CSProject/Reference)
    - XML.CSProject.[Project](/om_documentation/oM/Adapter/XML/CSProject/Project)
    - XML.CSProject.[Configuration](/om_documentation/oM/Adapter/XML/CSProject/Configuration)
    - XML.CSProject.[PropertyGroup](/om_documentation/oM/Adapter/XML/CSProject/PropertyGroup)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [CSProjectObject.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/CSProject\CSProjectObject.cs)

All history and changes of the class can be found by inspection the history.
