---
title: ReinforcementFragment
---

# <small>BH.oM.Physical.Reinforcement.</small>**ReinforcementFragment**



## Class structure

### Implemented interfaces and base types

???+ bhom "The ReinforcementFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ReinforcingBars | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IReinforcingBar](/api/oM/Physical/Physical/Reinforcement/IReinforcingBar)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ReinforcementFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Physical_oM.dll

The class is defined in C#. The class definition is available on github:

- [ReinforcementFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Reinforcement\ReinforcementFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Physical_oM/Reinforcement/ReinforcementFragment.json}
```

The JSON Schema is available on github here:

- [ReinforcementFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Physical_oM/Reinforcement/ReinforcementFragment.json)
