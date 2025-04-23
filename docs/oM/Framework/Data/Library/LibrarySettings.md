---
title: LibrarySettings
---

# Data.Library.LibrarySettings

Settings object to be used by the Library_Engine for controling Dataset extraction.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LibrarySettings in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[ISettings](/api/oM/Framework/Base/ISettings)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| UserLibraryPaths | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | List of folder paths to user-specified folder paths to be used by the Library_Engine when extracting Datasets. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [LibrarySettings.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Library\LibrarySettings.cs)

All history and changes of the class can be found by inspection the history.
