---
title: IElementResult&lt;T&gt;
---

# <small>BH.oM.LifeCycleAssessment.Results.</small>**IElementResult&lt;T&gt;**

Base interface for Life Cycle Assessment results for a particular element..

## Interface structure

### Generic parameters

The IElementResult contains the following generic paramters:

#### T

Constrained by the following arguments:

- BH.oM.LifeCycleAssessment.Results.[MaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/MaterialResult)

### Implemented interfaces and base types

???+ bhom "The IElementResult`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Analytical.Results.[IObjectResult](/api/oM/Analytical/Analytical/Results/IObjectResult)
    -  BH.oM.Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;BH.oM.Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)&gt;
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Analytical.Results.[IObjectIdResult](/api/oM/Analytical/Analytical/Results/IObjectIdResult)
    -  BH.oM.Analytical.Results.[IResultItem](/api/oM/Analytical/Analytical/Results/IResultItem)
    -  BH.oM.LifeCycleAssessment.Results.[IEnvironmentalResult](/api/oM/Analytical/LifeCycleAssessment/Results/IEnvironmentalResult)
    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentModuleData](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentModuleData)&lt;[ReadOnlyDictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyDictionary-2?view=netstandard-2.0)&lt;BH.oM.LifeCycleAssessment.[Module](/api/oM/Analytical/LifeCycleAssessment/Enums/Module), [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt;&gt;
    -  BH.oM.LifeCycleAssessment.Interfaces.[ILifeCycleAssessmentIndicator](/api/oM/Analytical/LifeCycleAssessment/Interfaces/ILifeCycleAssessmentIndicator)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.LifeCycleAssessment.Results.[AbioticDepletionFossilResourcesElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/AbioticDepletionFossilResourcesElementResult)
    - BH.oM.LifeCycleAssessment.Results.[AbioticDepletionMineralsAndMetalsElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/AbioticDepletionMineralsAndMetalsElementResult)
    - BH.oM.LifeCycleAssessment.Results.[AcidificationElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/AcidificationElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeBiogenicElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ClimateChangeBiogenicElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeFossilElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ClimateChangeFossilElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeLandUseElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ClimateChangeLandUseElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeTotalElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ClimateChangeTotalElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ClimateChangeTotalNoBiogenicElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ClimateChangeTotalNoBiogenicElementResult)
    - BH.oM.LifeCycleAssessment.Results.[ElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ElementResult)&lt;[T](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/ElementResult#t)&gt;
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationAquaticFreshwaterElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationAquaticFreshwaterElementResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationAquaticMarineElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationAquaticMarineElementResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationCMLElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationCMLElementResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationTerrestrialElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationTerrestrialElementResult)
    - BH.oM.LifeCycleAssessment.Results.[EutrophicationTRACIElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/EutrophicationTRACIElementResult)
    - BH.oM.LifeCycleAssessment.Results.[OzoneDepletionElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/OzoneDepletionElementResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationCMLElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/PhotochemicalOzoneCreationCMLElementResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/PhotochemicalOzoneCreationElementResult)
    - BH.oM.LifeCycleAssessment.Results.[PhotochemicalOzoneCreationTRACIElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/PhotochemicalOzoneCreationTRACIElementResult)
    - BH.oM.LifeCycleAssessment.Results.[WaterDeprivationElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/WaterDeprivationElementResult)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Scope | [ScopeType](/api/oM/Analytical/LifeCycleAssessment/Enums/ScopeType) | Scope the object this result was generated from belongs to, e.g. Foundation or Facade | - |
| Category | [ObjectCategory](/api/oM/Analytical/LifeCycleAssessment/Enums/ObjectCategory) | Category of the object this result was generated from, e.g. Beam or Wall | - |
| MaterialResults | [IReadOnlyList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1?view=netstandard-2.0)&lt;[T](#t)&gt; | Result breakdown per material type. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| AllIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of identifier types. This is all properties tagged with any IdentifierAttribute. | - | Results_Engine |
| ATotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all A-modules (A1-A5) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| BTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all B-modules (B1-B7) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| CTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all C-modules (C1-C4) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| IMetricType | [MetricType](/api/oM/Analytical/LifeCycleAssessment/Enums/MetricType) | - | - | LifeCycleAssessment_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Result is null and outputs relevant error message. | - | Results_Engine |
| ObjectIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of ObjectIdentifier types. This is all properties tagged with the ObjectIdentifierAttribute. | - | Results_Engine |
| ResultPropertyKeys | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Returns the result value carrying properties available for the result type provided. Currently only supported for IResultItem and IResultCollection&lt;IResultItem&gt; type results. | - | Results_Engine |
| ResultValuePropertiesItem | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [Tuple](https://learn.microsoft.com/en-us/dotnet/api/System.Tuple-2?view=netstandard-2.0)&lt;[Func](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=netstandard-2.0)&lt;T, [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt;, [QuantityAttribute](/api/oM/Dimensional/Quantities/Attributes/Abstract/QuantityAttribute)&gt;&gt; | Extract all potential result carrying property getters from a result class, i.e. properties of type double that is defined on the class. Properties defined on a base class are ignored.<br>Also extracts methods returning a double that has the result type as the only argument.<br>Func&lt;T,double&gt; returned together with corresponding QuantityAttribute in a Dictionary with the property or method name as the Key. | - | Results_Engine |
| ScenarioIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of Scenario types. This is all properties tagged with the ScenarioIdentifierAttribute. | - | Results_Engine |
| Total | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all modules with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IElementResult`1 : BH.oM.Analytical.Results.IObjectResult,
BH.oM.Analytical.Results.IResult,
BH.oM.Base.IObject,
System.IComparable<BH.oM.Analytical.Results.IResult>,
BH.oM.Base.IImmutable,
BH.oM.Analytical.Results.IObjectIdResult,
BH.oM.Analytical.Results.IResultItem,
BH.oM.LifeCycleAssessment.Results.IEnvironmentalResult,
BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentModuleData<System.Collections.ObjectModel.ReadOnlyDictionary<BH.oM.LifeCycleAssessment.Module, System.Double>>,
BH.oM.LifeCycleAssessment.Interfaces.ILifeCycleAssessmentIndicator
```

Assembly: LifeCycleAssessment_oM.dll

The C# interface definition is available on github:

- [IElementResult.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Results\IElementResult.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/Results/IElementResult`1.json"
}
```

The JSON Schema is available on github here:

- [IElementResult`1.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/Results/IElementResult`1.json)
