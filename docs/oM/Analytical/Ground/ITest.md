---
title: ITest
---

# Ground.ITest

Base interface for all ground tests.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ITest in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Ground.[InSituVane](/api_documentation/oM/Analytical/Ground/InSituVane)
    - Ground.[SPT](/api_documentation/oM/Analytical/Ground/SPT)
    - Ground.[Triaxial](/api_documentation/oM/Analytical/Ground/Triaxial)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Location identifier relating the borehole to the test(LOCA_ID). | - |
| Top | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Depth to the top of the sample, measured from the top of the borehole (ISPT_TOP, IVAN_DEPTH, SAMP_TOP). | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Properties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ITestProperties](/api_documentation/oM/Analytical/Ground/ITestProperties)&gt; | A list of different properties including references and results. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ITest.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/ITest.cs)

All history and changes of the class can be found by inspection the history.
