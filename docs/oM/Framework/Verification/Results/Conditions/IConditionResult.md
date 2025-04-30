---
title: IConditionResult
---

# <small>BH.oM.Verification.Results.</small>**IConditionResult**

Top interface for all condition results.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IConditionResult is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Verification.Results.[FormulaConditionResult](/api/oM/Framework/Verification/Results/Conditions/FormulaConditionResult)
    - BH.oM.Verification.Results.[IsNotNullResult](/api/oM/Framework/Verification/Results/Conditions/IsNotNullResult)
    - BH.oM.Verification.Results.[IsOfTypeResult](/api/oM/Framework/Verification/Results/Conditions/IsOfTypeResult)
    - BH.oM.Verification.Results.[LogicalCollectionConditionResult](/api/oM/Framework/Verification/Results/Conditions/LogicalCollectionConditionResult)
    - BH.oM.Verification.Results.[SingleLogicalConditionResult](/api/oM/Framework/Verification/Results/Conditions/SingleLogicalConditionResult)
    - BH.oM.Verification.Results.[ValueConditionResult](/api/oM/Framework/Verification/Results/Conditions/ValueConditionResult)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Passed | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Information whether the object passed or failed the condition. Null means inconclusive result. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IConditionResult : BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IConditionResult.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Results\Conditions\IConditionResult.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Verification_oM/Results/IConditionResult.json}
```

The JSON Schema is available on github here:

- [IConditionResult.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Verification_oM/Results/IConditionResult.json)
