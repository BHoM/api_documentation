---
title: IRevitParameterFragment
---

# <small>BH.oM.Adapters.Revit.Parameters.</small>**IRevitParameterFragment**

Interface for all fragments that carry information about Revit parameters that have been pulled or are meant to be pushed.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRevitParameterFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.Revit.Parameters.[RevitParametersToPush](/api/oM/Adapter/Adapters/Revit/Parameters/RevitParametersToPush)
    - BH.oM.Adapters.Revit.Parameters.[RevitPulledParameters](/api/oM/Adapter/Adapters/Revit/Parameters/RevitPulledParameters)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Parameters | [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netstandard-2.0)&lt;[RevitParameter](/api/oM/Adapter/Adapters/Revit/Parameters/RevitParameter)&gt; | Collection of parameters pulled from or meant to be pushed to Revit. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IRevitParameterFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The C# interface definition is available on github:

- [IRevitParameterFragment.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Parameters\IRevitParameterFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Parameters/IRevitParameterFragment.json"
}
```

The JSON Schema is available on github here:

- [IRevitParameterFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Parameters/IRevitParameterFragment.json)
