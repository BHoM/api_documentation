---
title: ClassificationAttribute
---

# Base.Attributes.ClassificationAttribute

Attribute representing classification of method parameters and object properties, i.e. it tells that a given member is a folder path, quantity etc.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ClassificationAttribute in inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  Base.[IImmutable](/om_documentation/oM/Framework/Base/IImmutable)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Classes inheriting from this class

??? bhom "The following classes are inheriting from this class:"

    - Base.Attributes.[FilePathAttribute](/om_documentation/oM/Framework/Base/Attributes/FilePathAttribute)
    - Base.Attributes.[FolderPathAttribute](/om_documentation/oM/Framework/Base/Attributes/FolderPathAttribute)
    - Quantities.Attributes.[AbioticDepletionMineralsAndMetals](/om_documentation/oM/Dimensional/Quantities/Attributes/AbioticDepletionMineralsAndMetals)
    - Quantities.Attributes.[AbioticDepletionMineralsAndMetalsPerQuantity](/om_documentation/oM/Dimensional/Quantities/Attributes/AbioticDepletionMineralsAndMetalsPerQuantity)
    - Quantities.Attributes.[QuantityAttribute](/om_documentation/oM/Dimensional/Quantities/Attributes/QuantityAttribute)
    - Quantities.Attributes.[Acceleration](/om_documentation/oM/Dimensional/Quantities/Attributes/Acceleration)
    - Quantities.Attributes.[Acidification](/om_documentation/oM/Dimensional/Quantities/Attributes/Acidification)
    - Quantities.Attributes.[AcidificationPerQuantity](/om_documentation/oM/Dimensional/Quantities/Attributes/AcidificationPerQuantity)
    - Quantities.Attributes.[AmountOfSubstance](/om_documentation/oM/Dimensional/Quantities/Attributes/AmountOfSubstance)
    - Quantities.Attributes.[Angle](/om_documentation/oM/Dimensional/Quantities/Attributes/Angle)
    - Quantities.Attributes.[AngularAcceleration](/om_documentation/oM/Dimensional/Quantities/Attributes/AngularAcceleration)
    - Quantities.Attributes.[AngularVelocity](/om_documentation/oM/Dimensional/Quantities/Attributes/AngularVelocity)
    - Quantities.Attributes.[Area](/om_documentation/oM/Dimensional/Quantities/Attributes/Area)
    - Quantities.Attributes.[AreaPerUnitLength](/om_documentation/oM/Dimensional/Quantities/Attributes/AreaPerUnitLength)
    - Quantities.Attributes.[ClimateChange](/om_documentation/oM/Dimensional/Quantities/Attributes/ClimateChange)
    - Quantities.Attributes.[ClimateChangePerQuantity](/om_documentation/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity)
    - Quantities.Attributes.[Density](/om_documentation/oM/Dimensional/Quantities/Attributes/Density)
    - Quantities.Attributes.[ElectricConductance](/om_documentation/oM/Dimensional/Quantities/Attributes/ElectricConductance)
    - Quantities.Attributes.[ElectricConductivity](/om_documentation/oM/Dimensional/Quantities/Attributes/ElectricConductivity)
    - Quantities.Attributes.[ElectricCurrent](/om_documentation/oM/Dimensional/Quantities/Attributes/ElectricCurrent)
    - Quantities.Attributes.[Energy](/om_documentation/oM/Dimensional/Quantities/Attributes/Energy)
    - Quantities.Attributes.[EnergyPerQuantity](/om_documentation/oM/Dimensional/Quantities/Attributes/EnergyPerQuantity)
    - Quantities.Attributes.[EnergyPerUnitArea](/om_documentation/oM/Dimensional/Quantities/Attributes/EnergyPerUnitArea)
    - Quantities.Attributes.[EnergyPerUnitTime](/om_documentation/oM/Dimensional/Quantities/Attributes/EnergyPerUnitTime)
    - Quantities.Attributes.[EutrophicationAquaticFreshwater](/om_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticFreshwater)
    - Quantities.Attributes.[EutrophicationAquaticFreshwaterPerQuantity](/om_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticFreshwaterPerQuantity)
    - Quantities.Attributes.[EutrophicationAquaticMarine](/om_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticMarine)
    - Quantities.Attributes.[EutrophicationAquaticMarinePerQuantity](/om_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationAquaticMarinePerQuantity)
    - Quantities.Attributes.[EutrophicationCML](/om_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCML)
    - Quantities.Attributes.[EutrophicationCMLPerQuantity](/om_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity)
    - Quantities.Attributes.[EutrophicationTerrestrial](/om_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationTerrestrial)
    - Quantities.Attributes.[EutrophicationTerrestrialPerQuantity](/om_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationTerrestrialPerQuantity)
    - Quantities.Attributes.[EutrophicationTRACI](/om_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationTRACI)
    - Quantities.Attributes.[EutrophicationTRACIPerQuantity](/om_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationTRACIPerQuantity)
    - Quantities.Attributes.[Force](/om_documentation/oM/Dimensional/Quantities/Attributes/Force)
    - Quantities.Attributes.[ForcePerUnitLength](/om_documentation/oM/Dimensional/Quantities/Attributes/ForcePerUnitLength)
    - Quantities.Attributes.[Frequency](/om_documentation/oM/Dimensional/Quantities/Attributes/Frequency)
    - Quantities.Attributes.[Illuminance](/om_documentation/oM/Dimensional/Quantities/Attributes/Illuminance)
    - Quantities.Attributes.[Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length)
    - Quantities.Attributes.[LuminousIntensity](/om_documentation/oM/Dimensional/Quantities/Attributes/LuminousIntensity)
    - Quantities.Attributes.[Mass](/om_documentation/oM/Dimensional/Quantities/Attributes/Mass)
    - Quantities.Attributes.[MassFraction](/om_documentation/oM/Dimensional/Quantities/Attributes/MassFraction)
    - Quantities.Attributes.[MassPerUnitArea](/om_documentation/oM/Dimensional/Quantities/Attributes/MassPerUnitArea)
    - Quantities.Attributes.[MassPerUnitLength](/om_documentation/oM/Dimensional/Quantities/Attributes/MassPerUnitLength)
    - Quantities.Attributes.[Molality](/om_documentation/oM/Dimensional/Quantities/Attributes/Molality)
    - Quantities.Attributes.[Molarity](/om_documentation/oM/Dimensional/Quantities/Attributes/Molarity)
    - Quantities.Attributes.[Moment](/om_documentation/oM/Dimensional/Quantities/Attributes/Moment)
    - Quantities.Attributes.[MomentPerUnitAngle](/om_documentation/oM/Dimensional/Quantities/Attributes/MomentPerUnitAngle)
    - Quantities.Attributes.[MomentPerUnitLength](/om_documentation/oM/Dimensional/Quantities/Attributes/MomentPerUnitLength)
    - Quantities.Attributes.[OzoneDepletion](/om_documentation/oM/Dimensional/Quantities/Attributes/OzoneDepletion)
    - Quantities.Attributes.[OzoneDepletionPerQuantity](/om_documentation/oM/Dimensional/Quantities/Attributes/OzoneDepletionPerQuantity)
    - Quantities.Attributes.[PhotochemicalOzoneCreation](/om_documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreation)
    - Quantities.Attributes.[PhotochemicalOzoneCreationCML](/om_documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationCML)
    - Quantities.Attributes.[PhotochemicalOzoneCreationCMLPerQuantity](/om_documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationCMLPerQuantity)
    - Quantities.Attributes.[PhotochemicalOzoneCreationPerQuantity](/om_documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationPerQuantity)
    - Quantities.Attributes.[PhotochemicalOzoneCreationTRACI](/om_documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI)
    - Quantities.Attributes.[PhotochemicalOzoneCreationTRACIPerQuantity](/om_documentation/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACIPerQuantity)
    - Quantities.Attributes.[Pressure](/om_documentation/oM/Dimensional/Quantities/Attributes/Pressure)
    - Quantities.Attributes.[Ratio](/om_documentation/oM/Dimensional/Quantities/Attributes/Ratio)
    - Quantities.Attributes.[SecondMomentOfArea](/om_documentation/oM/Dimensional/Quantities/Attributes/SecondMomentOfArea)
    - Quantities.Attributes.[SectionModulus](/om_documentation/oM/Dimensional/Quantities/Attributes/SectionModulus)
    - Quantities.Attributes.[ShearModulus](/om_documentation/oM/Dimensional/Quantities/Attributes/ShearModulus)
    - Quantities.Attributes.[SpecificEnergy](/om_documentation/oM/Dimensional/Quantities/Attributes/SpecificEnergy)
    - Quantities.Attributes.[Strain](/om_documentation/oM/Dimensional/Quantities/Attributes/Strain)
    - Quantities.Attributes.[Stress](/om_documentation/oM/Dimensional/Quantities/Attributes/Stress)
    - Quantities.Attributes.[Temperature](/om_documentation/oM/Dimensional/Quantities/Attributes/Temperature)
    - Quantities.Attributes.[ThermalExpansionCoefficient](/om_documentation/oM/Dimensional/Quantities/Attributes/ThermalExpansionCoefficient)
    - Quantities.Attributes.[Time](/om_documentation/oM/Dimensional/Quantities/Attributes/Time)
    - Quantities.Attributes.[TorsionConstant](/om_documentation/oM/Dimensional/Quantities/Attributes/TorsionConstant)
    - Quantities.Attributes.[Velocity](/om_documentation/oM/Dimensional/Quantities/Attributes/Velocity)
    - Quantities.Attributes.[Volume](/om_documentation/oM/Dimensional/Quantities/Attributes/Volume)
    - Quantities.Attributes.[VolumePerQuantity](/om_documentation/oM/Dimensional/Quantities/Attributes/VolumePerQuantity)
    - Quantities.Attributes.[VolumetricFlowRate](/om_documentation/oM/Dimensional/Quantities/Attributes/VolumetricFlowRate)
    - Quantities.Attributes.[WarpingConstant](/om_documentation/oM/Dimensional/Quantities/Attributes/WarpingConstant)
    - Quantities.Attributes.[YoungsModulus](/om_documentation/oM/Dimensional/Quantities/Attributes/YoungsModulus)


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
