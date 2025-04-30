---
title: IPropertyDifference
---

# <small>BH.oM.Diffing.</small>**IPropertyDifference**

Represents a difference found between a Previous and Following version of an object.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IPropertyDifference is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Diffing.[PropertyDifference](/api/oM/Framework/Diffing/PropertyDifference)
    - BH.oM.Adapters.Revit.[RevitParameterDifference](/api/oM/Adapter/Adapters/Revit/Misc/RevitParameterDifference)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The human-friendly name associated with this property difference. This may differ from the actual property name: see `FullName`. | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A human-friendly description associated with this property difference. | - |
| PastValue | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | The older value of this property (associated with the past version of the object). | - |
| FollowingValue | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | The newer value of this property (associated with the following version of the object). | - |
| FullName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Actual Full Name of the object's property whose value is different. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IPropertyDifference : BH.oM.Base.IObject
```

Assembly: Diffing_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IPropertyDifference.cs](https://github.com/BHoM/BHoM/blob/develop/Diffing_oM/IPropertyDifference.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Diffing_oM/IPropertyDifference.json}
```

The JSON Schema is available on github here:

- [IPropertyDifference.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Diffing_oM/IPropertyDifference.json)
