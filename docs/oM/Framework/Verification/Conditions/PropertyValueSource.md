---
title: PropertyValueSource
---

# Verification.Conditions.PropertyValueSource

Object pointing at a property as the source of a value to extract.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PropertyValueSource in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Conditions.[IValueSource](/om_documentation/oM/Framework/Verification/Conditions/IValueSource)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PropertyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the property to get the value from. If the property under given name is not found, other sources are also searched:<br>- CustomData for key matching PropertyName (only for IBHoMObjects)<br>- Fragment with type name matching PropertyName (only for IBHoMObjects)<br>- Parameterless extension method with name matching PropertyName | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IValueSourceLabel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a human readable label for a value source based on provided value condition reporting config. | - | Verification_Engine |
| ValueSourceLabel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a human readable label for a value source based on provided value condition reporting config. | - | Verification_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [PropertyValueSource.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions/Value Sources/PropertyValueSource.cs)

All history and changes of the class can be found by inspection the history.
