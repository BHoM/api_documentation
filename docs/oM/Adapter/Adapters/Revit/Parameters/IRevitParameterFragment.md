---
title: IRevitParameterFragment
---

# Adapters.Revit.Parameters.IRevitParameterFragment

Interface for all fragments that carry information about Revit parameters that have been pulled or are meant to be pushed.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRevitParameterFragment in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IFragment](/om_documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.Revit.Parameters.[RevitParametersToPush](/om_documentation/oM/Adapter/Adapters/Revit/Parameters/RevitParametersToPush)
    - Adapters.Revit.Parameters.[RevitPulledParameters](/om_documentation/oM/Adapter/Adapters/Revit/Parameters/RevitPulledParameters)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Parameters | [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netstandard-2.0)&lt;[RevitParameter](/om_documentation/oM/Adapter/Adapters/Revit/Parameters/RevitParameter)&gt; | Collection of parameters pulled from or meant to be pushed to Revit. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IRevitParameterFragment.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Parameters/IRevitParameterFragment.cs)

All history and changes of the class can be found by inspection the history.
