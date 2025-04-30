---
title: RevitParameter
---

# <small>BH.oM.Adapters.Revit.Parameters.</small>**RevitParameter**

A BHoM wrapper class for a Revit parameter.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevitParameter is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the Revit parameter as seen in the UI. | - |
| Value | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Value of the Revit parameter. Enums are converted to strings, ElementIds to integers. | - |
| UnitType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Unit type of the Revit parameter. | - |
| IsReadOnly | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Whether the parameter is read only or modifiable by the Revit user. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| HashString | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Computes the Hash string for a Revit Parameter. This will then be used by the Hash algorithm to compute the overall Hash of an object owning Revit Parameters. | - | Revit_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RevitParameter : BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The class is defined in C#. The class definition is available on github:

- [RevitParameter.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Parameters\RevitParameter.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Parameters/RevitParameter.json}
```

The JSON Schema is available on github here:

- [RevitParameter.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Parameters/RevitParameter.json)
