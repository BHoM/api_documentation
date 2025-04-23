---
title: ClassificationAttribute
---

# Base.Attributes.ClassificationAttribute

Attribute representing classification of method parameters and object properties, i.e. it tells that a given member is a folder path, quantity etc.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ClassificationAttribute in inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  Base.[IImmutable](/api/oM/Framework/Base/IImmutable)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Classes inheriting from this class

??? bhom "The following classes are inheriting from this class:"

    - Base.Attributes.[FilePathAttribute](/api/oM/Framework/Base/Attributes/FilePathAttribute)
    - Base.Attributes.[FolderPathAttribute](/api/oM/Framework/Base/Attributes/FolderPathAttribute)
    - Quantities.Attributes.[AbioticDepletionMineralsAndMetals](/api/oM/Dimensional/Quantities/Attributes/AbioticDepletionMineralsAndMetals)
    - Quantities.Attributes.[AbioticDepletionMineralsAndMetalsPerQuantity](/api/oM/Dimensional/Quantities/Attributes/AbioticDepletionMineralsAndMetalsPerQuantity)
    - Quantities.Attributes.[QuantityAttribute](/api/oM/Dimensional/Quantities/Attributes/QuantityAttribute)
    - Quantities.Attributes.[Acceleration](/api/oM/Dimensional/Quantities/Attributes/Acceleration)
    - Quantities.Attributes.[Acidification](/api/oM/Dimensional/Quantities/Attributes/Acidification)
    - Quantities.Attributes.[AcidificationPerQuantity](/api/oM/Dimensional/Quantities/Attributes/AcidificationPerQuantity)
    - Quantities.Attributes.[AmountOfSubstance](/api/oM/Dimensional/Quantities/Attributes/AmountOfSubstance)
    - Quantities.Attributes.[Angle](/api/oM/Dimensional/Quantities/Attributes/Angle)
    - Quantities.Attributes.[AngularAcceleration](/api/oM/Dimensional/Quantities/Attributes/AngularAcceleration)
    - Quantities.Attributes.[AngularVelocity](/api/oM/Dimensional/Quantities/Attributes/AngularVelocity)
    - Quantities.Attributes.[Area](/api/oM/Dimensional/Quantities/Attributes/Area)
    - Quantities.Attributes.[AreaPerUnitLength](/api/oM/Dimensional/Quantities/Attributes/AreaPerUnitLength)
    - Quantities.Attributes.[ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange)
    - Quantities.Attributes.[ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity)
    - Quantities.Attributes.[Density](/api/oM/Dimensional/Quantities/Attributes/Density)
    - Quantities.Attributes.[ElectricConductance](/api/oM/Dimensional/Quantities/Attributes/ElectricConductance)
    - Quantities.Attributes.[ElectricConductivity](/api/oM/Dimensional/Quantities/Attributes/ElectricConductivity)
    - Quantities.Attributes.[ElectricCurrent](/api/oM/Dimensional/Quantities/Attributes/ElectricCurrent)
    - Quantities.Attributes.[Energy](/api/oM/Dimensional/Quantities/Attributes/Energy)
    - Quantities.Attributes.[EnergyPerQuantity](/api/oM/Dimensional/Quantities/Attributes/EnergyPerQuantity)
    - Quantities.Attributes.[EnergyPerUnitArea](/api/oM/Dimensional/Quantities/Attributes/EnergyPerUnitArea)
    - Quantities.Attributes.[EnergyPerUnitTime](/api/oM/Dimensional/Quantities/Attributes/EnergyPerUnitTime)
    - Quantities.Attributes.[EutrophicationAquaticFreshwater](/api/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticFreshwater)
    - Quantities.Attributes.[EutrophicationAquaticFreshwaterPerQuantity](/api/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticFreshwaterPerQuantity)
    - Quantities.Attributes.[EutrophicationAquaticMarine](/api/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticMarine)
    - Quantities.Attributes.[EutrophicationAquaticMarinePerQuantity](/api/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticMarinePerQuantity)
    - Quantities.Attributes.[EutrophicationCML](/api/oM/Dimensional/Quantities/Attributes/EutrophicationCML)
    - Quantities.Attributes.[EutrophicationCMLPerQuantity](/api/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity)
    - Quantities.Attributes.[EutrophicationTerrestrial](/api/oM/Dimensional/Quantities/Attributes/EutrophicationTerrestrial)
    - Quantities.Attributes.[EutrophicationTerrestrialPerQuantity](/api/oM/Dimensional/Quantities/Attributes/EutrophicationTerrestrialPerQuantity)
    - Quantities.Attributes.[EutrophicationTRACI](/api/oM/Dimensional/Quantities/Attributes/EutrophicationTRACI)
    - Quantities.Attributes.[EutrophicationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/EutrophicationTRACIPerQuantity)
    - Quantities.Attributes.[Force](/api/oM/Dimensional/Quantities/Attributes/Force)
    - Quantities.Attributes.[ForcePerUnitLength](/api/oM/Dimensional/Quantities/Attributes/ForcePerUnitLength)
    - Quantities.Attributes.[Frequency](/api/oM/Dimensional/Quantities/Attributes/Frequency)
    - Quantities.Attributes.[Illuminance](/api/oM/Dimensional/Quantities/Attributes/Illuminance)
    - Quantities.Attributes.[Length](/api/oM/Dimensional/Quantities/Attributes/Length)
    - Quantities.Attributes.[LuminousIntensity](/api/oM/Dimensional/Quantities/Attributes/LuminousIntensity)
    - Quantities.Attributes.[Mass](/api/oM/Dimensional/Quantities/Attributes/Mass)
    - Quantities.Attributes.[MassFraction](/api/oM/Dimensional/Quantities/Attributes/MassFraction)
    - Quantities.Attributes.[MassPerUnitArea](/api/oM/Dimensional/Quantities/Attributes/MassPerUnitArea)
    - Quantities.Attributes.[MassPerUnitLength](/api/oM/Dimensional/Quantities/Attributes/MassPerUnitLength)
    - Quantities.Attributes.[Molality](/api/oM/Dimensional/Quantities/Attributes/Molality)
    - Quantities.Attributes.[Molarity](/api/oM/Dimensional/Quantities/Attributes/Molarity)
    - Quantities.Attributes.[Moment](/api/oM/Dimensional/Quantities/Attributes/Moment)
    - Quantities.Attributes.[MomentPerUnitAngle](/api/oM/Dimensional/Quantities/Attributes/MomentPerUnitAngle)
    - Quantities.Attributes.[MomentPerUnitLength](/api/oM/Dimensional/Quantities/Attributes/MomentPerUnitLength)
    - Quantities.Attributes.[OzoneDepletion](/api/oM/Dimensional/Quantities/Attributes/OzoneDepletion)
    - Quantities.Attributes.[OzoneDepletionPerQuantity](/api/oM/Dimensional/Quantities/Attributes/OzoneDepletionPerQuantity)
    - Quantities.Attributes.[PhotochemicalOzoneCreation](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreation)
    - Quantities.Attributes.[PhotochemicalOzoneCreationCML](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationCML)
    - Quantities.Attributes.[PhotochemicalOzoneCreationCMLPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationCMLPerQuantity)
    - Quantities.Attributes.[PhotochemicalOzoneCreationPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationPerQuantity)
    - Quantities.Attributes.[PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI)
    - Quantities.Attributes.[PhotochemicalOzoneCreationTRACIPerQuantity](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity)
    - Quantities.Attributes.[Pressure](/api/oM/Dimensional/Quantities/Attributes/Pressure)
    - Quantities.Attributes.[Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio)
    - Quantities.Attributes.[SecondMomentOfArea](/api/oM/Dimensional/Quantities/Attributes/SecondMomentOfArea)
    - Quantities.Attributes.[SectionModulus](/api/oM/Dimensional/Quantities/Attributes/SectionModulus)
    - Quantities.Attributes.[ShearModulus](/api/oM/Dimensional/Quantities/Attributes/ShearModulus)
    - Quantities.Attributes.[SpecificEnergy](/api/oM/Dimensional/Quantities/Attributes/SpecificEnergy)
    - Quantities.Attributes.[Strain](/api/oM/Dimensional/Quantities/Attributes/Strain)
    - Quantities.Attributes.[Stress](/api/oM/Dimensional/Quantities/Attributes/Stress)
    - Quantities.Attributes.[Temperature](/api/oM/Dimensional/Quantities/Attributes/Temperature)
    - Quantities.Attributes.[ThermalExpansionCoefficient](/api/oM/Dimensional/Quantities/Attributes/ThermalExpansionCoefficient)
    - Quantities.Attributes.[Time](/api/oM/Dimensional/Quantities/Attributes/Time)
    - Quantities.Attributes.[TorsionConstant](/api/oM/Dimensional/Quantities/Attributes/TorsionConstant)
    - Quantities.Attributes.[Velocity](/api/oM/Dimensional/Quantities/Attributes/Velocity)
    - Quantities.Attributes.[Volume](/api/oM/Dimensional/Quantities/Attributes/Volume)
    - Quantities.Attributes.[VolumePerQuantity](/api/oM/Dimensional/Quantities/Attributes/VolumePerQuantity)
    - Quantities.Attributes.[VolumetricFlowRate](/api/oM/Dimensional/Quantities/Attributes/VolumetricFlowRate)
    - Quantities.Attributes.[WarpingConstant](/api/oM/Dimensional/Quantities/Attributes/WarpingConstant)
    - Quantities.Attributes.[YoungsModulus](/api/oM/Dimensional/Quantities/Attributes/YoungsModulus)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the method parameter this attribute corresponds to (not relevant in case of object properties). | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Return the custom description of a classification attribute. | - | Reflection_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [ClassificationAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Attributes\ClassificationAttribute.cs)

All history and changes of the class can be found by inspection the history.
