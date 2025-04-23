---
title: Ventilation
---

# Environment.SAP.XML.Ventilation

Details of the means by which the building is ventilated.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Ventilation in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ClosedFluesCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The number of Closed Flues or chimneys in the Property. | - |
| BoilerFluesCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The number of Boiler Flues or chimneys in the Property. | - |
| OtherFluesCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The number of Other Flues or chimneys in the Property. | - |
| OpenChimneysCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The number of Open Chimneys in the Property. | - |
| BlockedChimneysCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The number of Blocked Chimneys in the Property. | - |
| OpenFluesCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The number of Open Flues in the Property. | - |
| ExtractFansCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| PSVCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The number of passive stack vents. | - |
| FansVentCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Do not use, for backwards compatibility only. | - |
| FluelessGasFiresCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The number of flueless gas fires in the Property. | - |
| ShelteredSidesCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The number of sheltered sides in the Property. | - |
| PressureTest | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Whether there has been a pressure test, or whether an assumed value is used for the air permeability. | - |
| PressureTestCertificateNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Whether there has been a pressure test, or whether an assumed value is used for the air permeability. | - |
| AirPermeability | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Air permeability; only if pressure test (yes or assumed). | - |
| HasDraughtLobby | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Is there a draft lobby?  Only if no pressure test. | - |
| DraughtStripping | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Draughtstripping percentage; only if no pressure test. | - |
| MechanicalVentilationDataSource | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Source of mechanical ventilation data; only if mechanical ventilation. | - |
| MechanicalVentSystemIndexNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Mechanical vent system index number; if mechanical vent data from database (MEV c, MEV dc, MV, MVHR). | - |
| MechanicalVentComissioningCertificateNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Mechanical ventilation Commissioning certificate number. | - |
| MechanicalVentInstallationEngineer | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Mechanical ventilation installation engineer registration reference. | - |
| MechanicalVentSystemMakeModel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Mechanical ventilation system make and model. | - |
| WetRoomsCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Number of wet rooms, including the kitchen; if mech vent data from manufacturer declaration or database (MEV c, MV, MVHR). | - |
| MechanicalVentSpecificFanPower | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | MEV dc, specific fan power of fans in room, kitchen, in watts per (litres per second); if mechanical vent data from manufacturer declaration (MEV dc). | - |
| MechanicalVentHeatRecoveryEfficiency | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Mechanical vent heat recovery efficiency percentage; if mechanical vent (MVHR). | - |
| MechanicalVentDuctType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Mechanical vent duct type; if MEV c, MV or MVHR. | - |
| MechanicalVentDuctInsulation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Mechanical vent duct insulation; if MVHR. | - |
| MechanicalVentDuctInsulationLevel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Mechanical vent duct insulation; if MVHR. | - |
| MechanicalVentDuctPlacement | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Mechanical ventilation duct insulation; if MVHR. | - |
| MechanicalVentMeasuredInstallation | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Mechanical ventilation SPF measured in situ; if MVHR or balanced. | - |
| KitchenRoomFansCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | MEV dc, number of fans in room, kitchen; if mechanical vent data from database or manufacturer declaration (MEV dc). | - |
| KitchenRoomFansSpecificPower | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | MEV dc, specific fan power of fans in room, kitchen, in watts per (litres per second); if mechanical vent data from manufacturer declaration (MEV dc). | - |
| NonKitchenRoomFansCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | MEV dc, number of fans in room, rooms other than kitchen; if mechanical vent data from database or manufacturer declaration (MEV dc). | - |
| NonKitchenRoomFansSpecificPower | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | MEV dc, specific fan power of fans in room, rooms other than kitchen, in watts per (litres per second); if mechanical vent data from manufacturer declaration (MEV dc). | - |
| KitchenDuctFansCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | MEV dc, number of fans via duct, kitchen; if mechanical vent data from database or manufacturer declaration (MEV dc). | - |
| KitchenDuctFansSpecificPower | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | MEV dc, specific fan power of fans via duct, kitchen, in watts per (litres per second); if mechanical vent data from manufacturer declaration (MEV dc). | - |
| NonKitchenDuctFansCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | MEV dc, number of fans via duct, rooms other than kitchen; if mechanical vent data from database or manufacturer declaration (MEV dc). | - |
| NonKitchenDuctFansSpecificPower | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | MEV dc, specific fan power of fans via duct, rooms other than kitchen, in watts per (litres per second); if mechanical vent data from manufacturer declaration (MEV dc). | - |
| KitchenWallFansCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | MEV dc, number of fans through wall, kitchen; if mechanical vent data from database or manufacturer declaration (MEV dc). | - |
| KitchenWallFansSpecificPower | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | MEV dc, specific fan power of fans through wall, kitchen, in watts per (litres per second); if mechanical vent data from manufacturer declaration (MEV dc). | - |
| NonKitchenWallFansCount | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | MEV dc, number of fans through wall, rooms other than kitchen; if mechanical vent data from database or manufacturer declaration (MEV dc). | - |
| NonKitchenWallFansSpecificPower | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | MEV dc, specific fan power of fans through wall, rooms other than kitchen, in watts per (litres per second); if mechanical vent data from manufacturer declaration (MEV dc). | - |
| IsMechanicalVentApprovedInstallerScheme | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | . | - |
| MechanicalVentDuctsIndexNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Mechanical vent ducts index number; if applicable. | - |
| VentilationType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The type of ventilation. | - |
| GroundFloorType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The type of ground floor; only if no pressure test. | - |
| WallType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The construction of the walls; only if no pressure test. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Ventilation.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML/Ventilation.cs)

All history and changes of the class can be found by inspection the history.
