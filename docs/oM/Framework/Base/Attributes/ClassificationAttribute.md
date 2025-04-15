---
title: ClassificationAttribute
---

# Base.Attributes.ClassificationAttribute

Attribute representing classification of method parameters and object properties, i.e. it tells that a given member is a folder path, quantity etc.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ClassificationAttribute in inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  Base.[IImmutable](/documentation/oM/Framework/Base/IImmutable)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Classes inheriting from this class

??? bhom "The following classes are inheriting from this class:"

    - Base.Attributes.[FilePathAttribute](/documentation/oM/Framework/Base/Attributes/FilePathAttribute)
    - Base.Attributes.[FolderPathAttribute](/documentation/oM/Framework/Base/Attributes/FolderPathAttribute)
    - Quantities.Attributes.[AbioticDepletionMineralsAndMetals](/documentation/oM/Dimensional/Quantities/Attributes/AbioticDepletionMineralsAndMetals)
    - Quantities.Attributes.[AbioticDepletionMineralsAndMetalsPerQuantity](/documentation/oM/Dimensional/Quantities/Attributes/AbioticDepletionMineralsAndMetalsPerQuantity)
    - Quantities.Attributes.[QuantityAttribute](/documentation/oM/Dimensional/Quantities/Attributes/QuantityAttribute)
    - Quantities.Attributes.[Acceleration](/documentation/oM/Dimensional/Quantities/Attributes/Acceleration)
    - Quantities.Attributes.[Acidification](/documentation/oM/Dimensional/Quantities/Attributes/Acidification)
    - Quantities.Attributes.[AcidificationPerQuantity](/documentation/oM/Dimensional/Quantities/Attributes/AcidificationPerQuantity)
    - Quantities.Attributes.[AmountOfSubstance](/documentation/oM/Dimensional/Quantities/Attributes/AmountOfSubstance)
    - Quantities.Attributes.[Angle](/documentation/oM/Dimensional/Quantities/Attributes/Angle)
    - Quantities.Attributes.[AngularAcceleration](/documentation/oM/Dimensional/Quantities/Attributes/AngularAcceleration)
    - Quantities.Attributes.[AngularVelocity](/documentation/oM/Dimensional/Quantities/Attributes/AngularVelocity)
    - Quantities.Attributes.[Area](/documentation/oM/Dimensional/Quantities/Attributes/Area)
    - Quantities.Attributes.[AreaPerUnitLength](/documentation/oM/Dimensional/Quantities/Attributes/AreaPerUnitLength)
    - Quantities.Attributes.[ClimateChange](/documentation/oM/Dimensional/Quantities/Attributes/ClimateChange)
    - Quantities.Attributes.[ClimateChangePerQuantity](/documentation/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity)
    - Quantities.Attributes.[Density](/documentation/oM/Dimensional/Quantities/Attributes/Density)
    - Quantities.Attributes.[ElectricConductance](/documentation/oM/Dimensional/Quantities/Attributes/ElectricConductance)
    - Quantities.Attributes.[ElectricConductivity](/documentation/oM/Dimensional/Quantities/Attributes/ElectricConductivity)
    - Quantities.Attributes.[ElectricCurrent](/documentation/oM/Dimensional/Quantities/Attributes/ElectricCurrent)
    - Quantities.Attributes.[Energy](/documentation/oM/Dimensional/Quantities/Attributes/Energy)
    - Quantities.Attributes.[EnergyPerQuantity](/documentation/oM/Dimensional/Quantities/Attributes/EnergyPerQuantity)
    - Quantities.Attributes.[EnergyPerUnitArea](/documentation/oM/Dimensional/Quantities/Attributes/EnergyPerUnitArea)
    - Quantities.Attributes.[EnergyPerUnitTime](/documentation/oM/Dimensional/Quantities/Attributes/EnergyPerUnitTime)
    - Quantities.Attributes.[EutrophicationAquaticFreshwater](/documentation/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticFreshwater)
    - Quantities.Attributes.[EutrophicationAquaticFreshwaterPerQuantity](/documentation/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticFreshwaterPerQuantity)
    - Quantities.Attributes.[EutrophicationAquaticMarine](/documentation/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticMarine)
    - Quantities.Attributes.[EutrophicationAquaticMarinePerQuantity](/documentation/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticMarinePerQuantity)
    - Quantities.Attributes.[EutrophicationCML](/documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCML)
    - Quantities.Attributes.[EutrophicationCMLPerQuantity](/documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity)
    - Quantities.Attributes.[EutrophicationTerrestrial](/documentation/oM/Dimensional/Quantities/Attributes/EutrophicationTerrestrial)
    - Quantities.Attributes.[EutrophicationTerrestrialPerQuantity](/documentation/oM/Dimensional/Quantities/Attributes/EutrophicationTerrestrialPerQuantity)
    - Quantities.Attributes.[EutrophicationTRACI](/documentation/oM/Dimensional/Quantities/Attributes/EutrophicationTRACI)
    - Quantities.Attributes.[EutrophicationTRACIPerQuantity](/documentation/oM/Dimensional/Quantities/Attributes/EutrophicationTRACIPerQuantity)
    - Quantities.Attributes.[Force](/documentation/oM/Dimensional/Quantities/Attributes/Force)
    - Quantities.Attributes.[ForcePerUnitLength](/documentation/oM/Dimensional/Quantities/Attributes/ForcePerUnitLength)
    - Quantities.Attributes.[Frequency](/documentation/oM/Dimensional/Quantities/Attributes/Frequency)
    - Quantities.Attributes.[Illuminance](/documentation/oM/Dimensional/Quantities/Attributes/Illuminance)
    - Quantities.Attributes.[Length](/documentation/oM/Dimensional/Quantities/Attributes/Length)
    - Quantities.Attributes.[LuminousIntensity](/documentation/oM/Dimensional/Quantities/Attributes/LuminousIntensity)
    - Quantities.Attributes.[Mass](/documentation/oM/Dimensional/Quantities/Attributes/Mass)
    - Quantities.Attributes.[MassFraction](/documentation/oM/Dimensional/Quantities/Attributes/MassFraction)
    - Quantities.Attributes.[MassPerUnitArea](/documentation/oM/Dimensional/Quantities/Attributes/MassPerUnitArea)
    - Quantities.Attributes.[MassPerUnitLength](/documentation/oM/Dimensional/Quantities/Attributes/MassPerUnitLength)
    - Quantities.Attributes.[Molality](/documentation/oM/Dimensional/Quantities/Attributes/Molality)
    - Quantities.Attributes.[Molarity](/documentation/oM/Dimensional/Quantities/Attributes/Molarity)
    - Quantities.Attributes.[Moment](/documentation/oM/Dimensional/Quantities/Attributes/Moment)
    - Quantities.Attributes.[MomentPerUnitAngle](/documentation/oM/Dimensional/Quantities/Attributes/MomentPerUnitAngle)
    - Quantities.Attributes.[MomentPerUnitLength](/documentation/oM/Dimensional/Quantities/Attributes/MomentPerUnitLength)
    - Quantities.Attributes.[OzoneDepletion](/documentation/oM/Dimensional/Quantities/Attributes/OzoneDepletion)
    - Quantities.Attributes.[OzoneDepletionPerQuantity](/documentation/oM/Dimensional/Quantities/Attributes/OzoneDepletionPerQuantity)
    - Quantities.Attributes.[PhotochemicalOzoneCreation](/documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreation)
    - Quantities.Attributes.[PhotochemicalOzoneCreationCML](/documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationCML)
    - Quantities.Attributes.[PhotochemicalOzoneCreationCMLPerQuantity](/documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationCMLPerQuantity)
    - Quantities.Attributes.[PhotochemicalOzoneCreationPerQuantity](/documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationPerQuantity)
    - Quantities.Attributes.[PhotochemicalOzoneCreationTRACI](/documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI)
    - Quantities.Attributes.[PhotochemicalOzoneCreationTRACIPerQuantity](/documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity)
    - Quantities.Attributes.[Pressure](/documentation/oM/Dimensional/Quantities/Attributes/Pressure)
    - Quantities.Attributes.[Ratio](/documentation/oM/Dimensional/Quantities/Attributes/Ratio)
    - Quantities.Attributes.[SecondMomentOfArea](/documentation/oM/Dimensional/Quantities/Attributes/SecondMomentOfArea)
    - Quantities.Attributes.[SectionModulus](/documentation/oM/Dimensional/Quantities/Attributes/SectionModulus)
    - Quantities.Attributes.[ShearModulus](/documentation/oM/Dimensional/Quantities/Attributes/ShearModulus)
    - Quantities.Attributes.[SpecificEnergy](/documentation/oM/Dimensional/Quantities/Attributes/SpecificEnergy)
    - Quantities.Attributes.[Strain](/documentation/oM/Dimensional/Quantities/Attributes/Strain)
    - Quantities.Attributes.[Stress](/documentation/oM/Dimensional/Quantities/Attributes/Stress)
    - Quantities.Attributes.[Temperature](/documentation/oM/Dimensional/Quantities/Attributes/Temperature)
    - Quantities.Attributes.[ThermalExpansionCoefficient](/documentation/oM/Dimensional/Quantities/Attributes/ThermalExpansionCoefficient)
    - Quantities.Attributes.[Time](/documentation/oM/Dimensional/Quantities/Attributes/Time)
    - Quantities.Attributes.[TorsionConstant](/documentation/oM/Dimensional/Quantities/Attributes/TorsionConstant)
    - Quantities.Attributes.[Velocity](/documentation/oM/Dimensional/Quantities/Attributes/Velocity)
    - Quantities.Attributes.[Volume](/documentation/oM/Dimensional/Quantities/Attributes/Volume)
    - Quantities.Attributes.[VolumePerQuantity](/documentation/oM/Dimensional/Quantities/Attributes/VolumePerQuantity)
    - Quantities.Attributes.[VolumetricFlowRate](/documentation/oM/Dimensional/Quantities/Attributes/VolumetricFlowRate)
    - Quantities.Attributes.[WarpingConstant](/documentation/oM/Dimensional/Quantities/Attributes/WarpingConstant)
    - Quantities.Attributes.[YoungsModulus](/documentation/oM/Dimensional/Quantities/Attributes/YoungsModulus)


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
