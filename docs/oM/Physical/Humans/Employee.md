---
title: Employee
---

# Humans.Employee



## Class structure

### Implemented interfaces and base types

???+ bhom "The Employee in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Humans.[IHumanRole](/api_documentation/oM/Physical/Humans/IHumanRole)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Company | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Company the Employee works for. | - |
| Office | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Office assigned to the Employee. | - |
| Discipline | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Discipline the Employee works in. | - |
| Team | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Team the Employee belongs to. | - |
| Manager | [Employee](/api_documentation/oM/Physical/Humans/Employee) | Manager of the Employee. | - |
| Grade | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Seniority of the Employee. | - |
| Email | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Company email of the Employee. | - |
| Phone | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Company phone number of the Employee. | - |
| CodeDevelopmentRole | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| BusinessUnit | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Business Unit the Employee is assigned to. | - |


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

- [Employee.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/Employee.cs)

All history and changes of the class can be found by inspection the history.
