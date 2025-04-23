---
title: EventMessage
---

# Test.Results.EventMessage

Class to store an event raised during the execution on a TestResult.

## Class structure

### Implemented interfaces and base types

???+ bhom "The EventMessage in inheriting from the following base type(s) and implements the following interfaces:"

    -  Test.[ITestInformation](/api/oM/Framework/Test/ITestInformation)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Message | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Message raised during the execution. | - |
| Status | [TestStatus](/api/oM/Framework/Test/TestStatus) | Severity of the message. | - |
| UTCTime | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | Provides the UTC time of when the event was raised. | - |
| StackTrace | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Original location where the event was generated. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IFullMessage | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - | Test_Engine |
| INewResultAfterCrashFix | [ITestInformation](/api/oM/Framework/Test/ITestInformation) | Gets a ITestInformation back that correspond to a situation where the reference data was showing a crash no longer present.<br>Used when comparing to TestResults against each other and information in the reference can not be found in the new data. | - | InteroperabilityTest_Engine |
| INoReferenceFound | [ITestInformation](/api/oM/Framework/Test/ITestInformation) | Gets a ITestInformation back that correspond to no reference data was available that matching the result.<br>Used when comparing to TestResults against each other and information in the reference can not be found in the new data. | - | InteroperabilityTest_Engine |
| IOnlyReferenceFound | [ITestInformation](/api/oM/Framework/Test/ITestInformation) | Gets a TestInformation result back that correspond to an information only found in the reference set when compared to data just run.<br>Used when comparing to TestResults against each other and information in the reference can not be found in the new data. | - | InteroperabilityTest_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [EventMessage.cs](https://github.com/BHoM/BHoM/blob/develop/Test_oM/Results\EventMessage.cs)

All history and changes of the class can be found by inspection the history.
