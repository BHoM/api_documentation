---
title: GBXMLSettings
---

# Adapters.XML.Settings.GBXMLSettings



## Class structure

### Implemented interfaces and base types

???+ bhom "The GBXMLSettings in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Adapters.XML.Settings.[IXMLSettings](/api_documentation/oM/Adapter/Adapters/XML/Settings/IXMLSettings)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ReplaceCurtainWalls | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Set to true if you want to replace curtain walls to have openings the same size as the wall. This is useful for IES exports. Default false | - |
| ReplaceSolidOpeningsIntoDoors | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Set to true if you want to replace an opening which is marked as solid into a door. Useful for IES exports. Default false | - |
| IncludeConstructions | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Set to true if you want to include construction and material data in the export. Default false | - |
| FixIncorrectAirTypes | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Set to true if you want air types with one adjacent space (i.e. external air walls) to have their type fixed based on their tilt. Default false | - |
| NewFile | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Set to false if you want to append to a file when pushing XML. If set to true then a file will be created. If a file exists, it will be overwritten. Default true | - |
| ResultsUnitType | [UnitType](/api_documentation/oM/Adapter/Adapters/XML/Enums/UnitType) | Set the unit type for the results to be either SI or Imperial. Default SI | - |
| ExportDetail | [ExportDetail](/api_documentation/oM/Adapter/Adapters/XML/Enums/ExportDetail) | Set the detail of your export to be either full (whole building), shell (exterior walls only), or spaces (each individual space as its own XML file). Default full | - |
| DistanceTolerance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Set the tolerance for distance between points to define a 'short' segment which should be removed from export, default is set to BH.oM.Geometry.Tolerance.Distance | - |
| PlanarTolerance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Set tolerance for planar surfaces, default is set to BH.oM.Geometry.Tolerance.Distance | - |
| OffsetDistance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Set a distance to offset openings that have a area &gt;= the area of the host panel. Value should be negative. Defaults to -0.001 | - |
| AngleTolerance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Set the tolerance for angle calculations when exporting to XML. Default is set to BH.oM.Geometry.Tolerance.Angle | - |
| RoundingSettings | [RoundingSettings](/api_documentation/oM/Adapter/Adapters/XML/GBXML/RoundingSettings) | Set the rounding options for numerical outputs to be used within gbXML creation. Default is per the Rounding Settings defaults | - |
| UnitSetUp | [GBXMLUnitSetUp](/api_documentation/oM/Adapter/Adapters/XML/GBXMLUnitSetUp) | Set the units to be used for the export of a gbXML file. Default units will be in SI using the defaults of the GBXMLSetUp object if none are provided | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [GBXMLSettings.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/Settings/GBXMLSettings.cs)

All history and changes of the class can be found by inspection the history.
