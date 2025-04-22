---
title: QuantityAttribute
---

# Quantities.Attributes.QuantityAttribute

Dimensional quantity as defined by the International System of Quantities

## Properties



### Defining properties

The following properties are defined on the base quantity attribute, to be overridden by the subclasses to indicate the dimensionality and SI units that make up the quantities. 

| Name             | Type             | Description      |
|------------------|------------------|------------------|
| L | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Length dimension |
| M | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Mass dimension |
| T | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Time dimension |
| I | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Electric current dimension |
| Θ | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Temperature dimension |
| N | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Amount of substance dimension |
| J | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Luminous intensity dimension |
| SIUnit | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | SI derived unit symbol |


### Inherited properties
The following properties are inherited from the base class of the object. These properties are framework related, and helps associate the quantity with specific targets.

| Name             | Type             | Description      |
|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the method parameter this attribute corresponds to (not relevant in case of object properties). |
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      |  Engine           |
|------------------|------------------|------------------|------------------|
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Return the custom description of a quantity attribute. | Reflection_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Return the custom description of a classification attribute. | Reflection_Engine |


## Class structure

### Implemented interfaces and base types

???+ bhom "The QuantityAttribute in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.Attributes.[ClassificationAttribute](/api_documentation/oM/Framework/Base/Attributes/ClassificationAttribute)
    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes inheriting from this class

??? bhom "The following classes are inheriting from this class:"

    - Quantities.Attributes.[AbioticDepletionMineralsAndMetals](/api_documentation/oM/Dimensional/Quantities/Attributes/AbioticDepletionMineralsAndMetals)
    - Quantities.Attributes.[AbioticDepletionMineralsAndMetalsPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/AbioticDepletionMineralsAndMetalsPerQuantity)
    - Quantities.Attributes.[Acceleration](/api_documentation/oM/Dimensional/Quantities/Attributes/Acceleration)
    - Quantities.Attributes.[Acidification](/api_documentation/oM/Dimensional/Quantities/Attributes/Acidification)
    - Quantities.Attributes.[AcidificationPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/AcidificationPerQuantity)
    - Quantities.Attributes.[AmountOfSubstance](/api_documentation/oM/Dimensional/Quantities/Attributes/AmountOfSubstance)
    - Quantities.Attributes.[Angle](/api_documentation/oM/Dimensional/Quantities/Attributes/Angle)
    - Quantities.Attributes.[AngularAcceleration](/api_documentation/oM/Dimensional/Quantities/Attributes/AngularAcceleration)
    - Quantities.Attributes.[AngularVelocity](/api_documentation/oM/Dimensional/Quantities/Attributes/AngularVelocity)
    - Quantities.Attributes.[Area](/api_documentation/oM/Dimensional/Quantities/Attributes/Area)
    - Quantities.Attributes.[AreaPerUnitLength](/api_documentation/oM/Dimensional/Quantities/Attributes/AreaPerUnitLength)
    - Quantities.Attributes.[ClimateChange](/api_documentation/oM/Dimensional/Quantities/Attributes/ClimateChange)
    - Quantities.Attributes.[ClimateChangePerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity)
    - Quantities.Attributes.[Density](/api_documentation/oM/Dimensional/Quantities/Attributes/Density)
    - Quantities.Attributes.[ElectricConductance](/api_documentation/oM/Dimensional/Quantities/Attributes/ElectricConductance)
    - Quantities.Attributes.[ElectricConductivity](/api_documentation/oM/Dimensional/Quantities/Attributes/ElectricConductivity)
    - Quantities.Attributes.[ElectricCurrent](/api_documentation/oM/Dimensional/Quantities/Attributes/ElectricCurrent)
    - Quantities.Attributes.[Energy](/api_documentation/oM/Dimensional/Quantities/Attributes/Energy)
    - Quantities.Attributes.[EnergyPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EnergyPerQuantity)
    - Quantities.Attributes.[EnergyPerUnitArea](/api_documentation/oM/Dimensional/Quantities/Attributes/EnergyPerUnitArea)
    - Quantities.Attributes.[EnergyPerUnitTime](/api_documentation/oM/Dimensional/Quantities/Attributes/EnergyPerUnitTime)
    - Quantities.Attributes.[EutrophicationAquaticFreshwater](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticFreshwater)
    - Quantities.Attributes.[EutrophicationAquaticFreshwaterPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticFreshwaterPerQuantity)
    - Quantities.Attributes.[EutrophicationAquaticMarine](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticMarine)
    - Quantities.Attributes.[EutrophicationAquaticMarinePerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticMarinePerQuantity)
    - Quantities.Attributes.[EutrophicationCML](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCML)
    - Quantities.Attributes.[EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity)
    - Quantities.Attributes.[EutrophicationTerrestrial](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationTerrestrial)
    - Quantities.Attributes.[EutrophicationTerrestrialPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationTerrestrialPerQuantity)
    - Quantities.Attributes.[EutrophicationTRACI](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationTRACI)
    - Quantities.Attributes.[EutrophicationTRACIPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationTRACIPerQuantity)
    - Quantities.Attributes.[Force](/api_documentation/oM/Dimensional/Quantities/Attributes/Force)
    - Quantities.Attributes.[ForcePerUnitLength](/api_documentation/oM/Dimensional/Quantities/Attributes/ForcePerUnitLength)
    - Quantities.Attributes.[Frequency](/api_documentation/oM/Dimensional/Quantities/Attributes/Frequency)
    - Quantities.Attributes.[Illuminance](/api_documentation/oM/Dimensional/Quantities/Attributes/Illuminance)
    - Quantities.Attributes.[Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length)
    - Quantities.Attributes.[LuminousIntensity](/api_documentation/oM/Dimensional/Quantities/Attributes/LuminousIntensity)
    - Quantities.Attributes.[Mass](/api_documentation/oM/Dimensional/Quantities/Attributes/Mass)
    - Quantities.Attributes.[MassFraction](/api_documentation/oM/Dimensional/Quantities/Attributes/MassFraction)
    - Quantities.Attributes.[MassPerUnitArea](/api_documentation/oM/Dimensional/Quantities/Attributes/MassPerUnitArea)
    - Quantities.Attributes.[MassPerUnitLength](/api_documentation/oM/Dimensional/Quantities/Attributes/MassPerUnitLength)
    - Quantities.Attributes.[Molality](/api_documentation/oM/Dimensional/Quantities/Attributes/Molality)
    - Quantities.Attributes.[Molarity](/api_documentation/oM/Dimensional/Quantities/Attributes/Molarity)
    - Quantities.Attributes.[Moment](/api_documentation/oM/Dimensional/Quantities/Attributes/Moment)
    - Quantities.Attributes.[MomentPerUnitAngle](/api_documentation/oM/Dimensional/Quantities/Attributes/MomentPerUnitAngle)
    - Quantities.Attributes.[MomentPerUnitLength](/api_documentation/oM/Dimensional/Quantities/Attributes/MomentPerUnitLength)
    - Quantities.Attributes.[OzoneDepletion](/api_documentation/oM/Dimensional/Quantities/Attributes/OzoneDepletion)
    - Quantities.Attributes.[OzoneDepletionPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/OzoneDepletionPerQuantity)
    - Quantities.Attributes.[PhotochemicalOzoneCreation](/api_documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreation)
    - Quantities.Attributes.[PhotochemicalOzoneCreationCML](/api_documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationCML)
    - Quantities.Attributes.[PhotochemicalOzoneCreationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationCMLPerQuantity)
    - Quantities.Attributes.[PhotochemicalOzoneCreationPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationPerQuantity)
    - Quantities.Attributes.[PhotochemicalOzoneCreationTRACI](/api_documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI)
    - Quantities.Attributes.[PhotochemicalOzoneCreationTRACIPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity)
    - Quantities.Attributes.[Pressure](/api_documentation/oM/Dimensional/Quantities/Attributes/Pressure)
    - Quantities.Attributes.[Ratio](/api_documentation/oM/Dimensional/Quantities/Attributes/Ratio)
    - Quantities.Attributes.[SecondMomentOfArea](/api_documentation/oM/Dimensional/Quantities/Attributes/SecondMomentOfArea)
    - Quantities.Attributes.[SectionModulus](/api_documentation/oM/Dimensional/Quantities/Attributes/SectionModulus)
    - Quantities.Attributes.[ShearModulus](/api_documentation/oM/Dimensional/Quantities/Attributes/ShearModulus)
    - Quantities.Attributes.[SpecificEnergy](/api_documentation/oM/Dimensional/Quantities/Attributes/SpecificEnergy)
    - Quantities.Attributes.[Strain](/api_documentation/oM/Dimensional/Quantities/Attributes/Strain)
    - Quantities.Attributes.[Stress](/api_documentation/oM/Dimensional/Quantities/Attributes/Stress)
    - Quantities.Attributes.[Temperature](/api_documentation/oM/Dimensional/Quantities/Attributes/Temperature)
    - Quantities.Attributes.[ThermalExpansionCoefficient](/api_documentation/oM/Dimensional/Quantities/Attributes/ThermalExpansionCoefficient)
    - Quantities.Attributes.[Time](/api_documentation/oM/Dimensional/Quantities/Attributes/Time)
    - Quantities.Attributes.[TorsionConstant](/api_documentation/oM/Dimensional/Quantities/Attributes/TorsionConstant)
    - Quantities.Attributes.[Velocity](/api_documentation/oM/Dimensional/Quantities/Attributes/Velocity)
    - Quantities.Attributes.[Volume](/api_documentation/oM/Dimensional/Quantities/Attributes/Volume)
    - Quantities.Attributes.[VolumePerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/VolumePerQuantity)
    - Quantities.Attributes.[VolumetricFlowRate](/api_documentation/oM/Dimensional/Quantities/Attributes/VolumetricFlowRate)
    - Quantities.Attributes.[WarpingConstant](/api_documentation/oM/Dimensional/Quantities/Attributes/WarpingConstant)
    - Quantities.Attributes.[YoungsModulus](/api_documentation/oM/Dimensional/Quantities/Attributes/YoungsModulus)


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [QuantityAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/Quantities_oM/Attributes/Abstract/QuantityAttribute.cs)

All history and changes of the class can be found by inspection the history.
