---
title: IView
---

# <small>BH.oM.Adapters.Revit.Elements.</small>**IView**

A base interface for BHoM wrapper classes that can wrap Revit views.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IView is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.Revit.Elements.[ViewPlan](/api/oM/Adapter/Adapters/Revit/Elements/ViewPlan)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| InstanceProperties | [InstanceProperties](/api/oM/Adapter/Adapters/Revit/Properties/InstanceProperties) | An entity storing the information about Revit view type. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IView : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IView.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Elements\IView.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Elements/IView.json}
```

The JSON Schema is available on github here:

- [IView.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Elements/IView.json)
