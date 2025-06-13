---
title: IEnvironmentalFactorsProvider
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.</small>**IEnvironmentalFactorsProvider**

Base interface for all classes able to used to evaluate LCA, namly the EnvironmentalProductDeclaration as well as CalculatedMaterialLifeCycleEnvironmentalImpactFactors.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IEnvironmentalFactorsProvider is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.LifeCycleAssessment.MaterialFragments.[CombinedLifeCycleAssessmentFactors](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/CombinedLifeCycleAssessmentFactors)
    - BH.oM.LifeCycleAssessment.MaterialFragments.[EnvironmentalProductDeclaration](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalProductDeclaration)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| MaterialEndOfLifeTreatment | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns End of Life processing information contained within an EPD dataset. | - | LifeCycleAssessment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IEnvironmentalFactorsProvider : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# interface definition is available on github:

- [IEnvironmentalFactorsProvider.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\IEnvironmentalFactorsProvider.cs)

All history and changes of the class can be found by inspection the history.
