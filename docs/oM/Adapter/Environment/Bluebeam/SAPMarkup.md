---
title: SAPMarkup
---

# <small>BH.oM.Environment.SAP.Bluebeam.</small>**SAPMarkup**



## Class structure

### Implemented interfaces and base types

???+ bhom "The SAPMarkup is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Environment.SAP.Bluebeam.[BluebeamSAPObject](/api/oM/Adapter/Environment/Bluebeam/BluebeamSAPObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PageLabel | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| Subject | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Space | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Author | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Date | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Colour | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Comments | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Label | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Depth | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | By default this is an XML String representation. Most software will automatically handle the conversion to a numerical representation but users can also use the Query.Depth(Markup) method if necessary. | - |
| Layer | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| TFAFloorType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | This is a custom property which can be added to Bluebeam for SAP workflow interoperability. | - |
| TFADwellingStorey | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | This is a custom property which can be added to Bluebeam for SAP workflow interoperability. | - |
| TFABuildingLevel | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | This is a custom property which can be added to Bluebeam for SAP workflow interoperability. | - |
| TFAHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This is a custom property which can be added to Bluebeam for SAP workflow interoperability. | - |
| RoofType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | This is a custom property which can be added to Bluebeam for SAP workflow interoperability. | - |
| ThermalBridgeType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | This is a custom property which can be added to Bluebeam for SAP workflow interoperability. | - |
| ThermalBridgeLength | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | This is a custom property which can be added to Bluebeam for SAP workflow interoperability. | - |
| OpeningType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | This is a custom property which can be added to Bluebeam for SAP workflow interoperability. | - |
| OpeningLocation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | This is a custom property which can be added to Bluebeam for SAP workflow interoperability. | - |
| OpeningHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This is a custom property which can be added to Bluebeam for SAP workflow interoperability. | - |
| OpeningOrientation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | This is a custom property which can be added to Bluebeam for SAP workflow interoperability. | - |
| OpeningPitch | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | This is a custom property which can be added to Bluebeam for SAP workflow interoperability. | - |
| WallType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | This is a custom property which can be added to Bluebeam for SAP workflow interoperability. | - |
| WallHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This is a custom property which can be added to Bluebeam for SAP workflow interoperability. | - |
| IsCurtainWall | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | This is a custom property which can be added to Bluebeam for SAP workflow interoperability to determine whether this markup is for a Curtain Wall. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SAPMarkup : BH.oM.Environment.SAP.Bluebeam.BluebeamSAPObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: SAP_oM.dll

The C# class definition is available on github:

- [SAPMarkup.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Bluebeam\SAPMarkup.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/Bluebeam/SAPMarkup.json"
}
```

The JSON Schema is available on github here:

- [SAPMarkup.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/Bluebeam/SAPMarkup.json)
