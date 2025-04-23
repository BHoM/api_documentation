---
title: NoAutoConstructorAttribute
---

# Base.Attributes.NoAutoConstructorAttribute

Prevents an auto-constructor component to be available in the UI for the targeted class. This means that `Engine.Create` methods will be the only option to generate instances of that class in the UI.

## Class structure

### Implemented interfaces and base types

???+ bhom "The NoAutoConstructorAttribute in inheriting from the following base type(s) and implements the following interfaces:"

    -  [Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=netstandard-2.0)
    -  Base.[IImmutable](/api/oM/Framework/Base/IImmutable)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties

### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeId | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [NoAutoConstructorAttribute.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Attributes\NoAutoConstructorAttribute.cs)

All history and changes of the class can be found by inspection the history.
