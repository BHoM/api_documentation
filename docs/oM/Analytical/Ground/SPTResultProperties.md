---
title: SPTResultProperties
---

# Ground.SPTResultProperties

Properties related to the results of the standard penetration test.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SPTResultProperties in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Ground.[ITestProperties](/api_documentation/oM/Analytical/Ground/ITestProperties)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ReportedResult | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Reported standard penetration test result (ISPT_REP. | - |
| SeatingDriveBlows | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of blows for seating drive (ISPT_SEAT). | - |
| MainTestDriveBlows | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of blows for main test drive (ISPT_MAIN). | - |
| SPTN60 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Number of blows for main test drive, with value corrected by energy ratio (ISPT_N60). | - |
| TotalPenetration | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total penetration for seating drive and test drive (ISPT_NPEN). | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| SelfWeightPenetration | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Self weight penetration (ISPT_SWP). | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| SeatBlows1 | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of blows for first increment seating (ISPT_INC1). | - |
| SeatBlows2 | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of blows for second increment seating (ISPT_INC2). | - |
| TestBlows1 | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of blows for first increment test (ISPT_INC3). | - |
| TestBlows2 | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of blows for second increment test (ISPT_INC4). | - |
| TestBlows3 | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of blows for third increment test (ISPT_INC5). | - |
| TestBlows4 | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of blows for fourth increment test (ISPT_INC6). | - |
| SeatPenetration1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Penetration for 1st Increment Seating (ISPT_PEN1). | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| SeatPenetration2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Penetration for 2nd Increment Seating (ISPT_INC2). | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| PenetrationTest1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Penetration for 1st Increment Test (ISPT_PEN3). | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| PenetrationTest2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Penetration for 2nd Increment Test (ISPT_PEN4). | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| PenetrationTest3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Penetration for 3rd Increment Test (ISPT_PEN5). | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| PenetrationTest4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Penetration for 4th Increment Test (ISPT_PEN6). | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |


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

- [SPTResultProperties.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/ITestProperties/SPTResultProperties.cs)

All history and changes of the class can be found by inspection the history.
