---
title: UniformLoadSetRecord
---

# Structure.Loads.UniformLoadSetRecord

Definition of a single uniform load in the gravity direction (-Z), to be added to a UniformLoadSet.

## Class structure

### Implemented interfaces and base types

???+ bhom "The UniformLoadSetRecord in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Description of the source of this load, such as: 'Partitions', 'Occupancy', or 'MEP &amp; Ceiling' | - |
| Loadcase | [Loadcase](/om_documentation/oM/Analytical/Structure/Loads/Loadcase) | The Loadcase in which to apply this load. | - |
| Load | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The magnitude of this load, generally to be applied as an AreaUniformLoad in the gravity direction (-Z) | [Pressure](/om_documentation/oM/Dimensional/Quantities/Attributes/Pressure) [Pa] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [UniformLoadSetRecord.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Loads\UniformLoadSetRecord.cs)

All history and changes of the class can be found by inspection the history.
