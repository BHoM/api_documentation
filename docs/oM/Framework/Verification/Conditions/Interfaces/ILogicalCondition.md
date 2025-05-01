---
title: ILogicalCondition
---

# <small>BH.oM.Verification.Conditions.</small>**ILogicalCondition**

Interface for all logical conditions (AND, OR, NOT etc.).

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ILogicalCondition is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Conditions.[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Verification.Conditions.[ILogicalCollectionCondition](/api/oM/Framework/Verification/Conditions/Interfaces/ILogicalCollectionCondition)
    - BH.oM.Verification.Conditions.[ISingleLogicalCondition](/api/oM/Framework/Verification/Conditions/Interfaces/ISingleLogicalCondition)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Verification.Conditions.[LogicalAndCondition](/api/oM/Framework/Verification/Conditions/Logical/LogicalAndCondition)
    - BH.oM.Verification.Conditions.[LogicalNotCondition](/api/oM/Framework/Verification/Conditions/Logical/LogicalNotCondition)
    - BH.oM.Verification.Conditions.[LogicalOrCondition](/api/oM/Framework/Verification/Conditions/Logical/LogicalOrCondition)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api/oM/Framework/Verification/Conditions/Interfaces/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ILogicalCondition : BH.oM.Verification.Conditions.ICondition, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The interface is defined in C#. The class definition is available on github:

- [ILogicalCondition.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions\Interfaces\ILogicalCondition.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Verification_oM/Conditions/ILogicalCondition.json"
}
```

The JSON Schema is available on github here:

- [ILogicalCondition.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Verification_oM/Conditions/ILogicalCondition.json)
