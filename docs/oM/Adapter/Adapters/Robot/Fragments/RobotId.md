---
title: RobotId
---

# <small>BH.oM.Adapters.Robot.</small>**RobotId**

Fragment storing identifier information of the object in Robot.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RobotId is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IAdapterId](/api/oM/Framework/Base/Interface/IAdapterId)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | The identifier of the obejct in robot. Will be an integer for element types and cases and string for property types. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RobotId : BH.oM.Base.IAdapterId, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Robot_oM.dll

The class is defined in C#. The class definition is available on github:

- [RobotId.cs](https://github.com/BHoM/Robot_Toolkit/blob/develop/Robot_oM/Fragments\RobotId.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Robot_oM/RobotId.json"
}
```

The JSON Schema is available on github here:

- [RobotId.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Robot_oM/RobotId.json)
