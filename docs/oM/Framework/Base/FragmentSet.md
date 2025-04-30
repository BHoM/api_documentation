---
title: FragmentSet
---

# <small>BH.oM.Base.</small>**FragmentSet**



## Class structure

### Implemented interfaces and base types

???+ bhom "The FragmentSet is inheriting from the following base type(s) and implements the following interfaces:"

    -  [KeyedCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.KeyedCollection-2?view=netstandard-2.0)&lt;[Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0), BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)&gt;
    -  [Collection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.Collection-1?view=netstandard-2.0)&lt;BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)&gt;
    -  [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netstandard-2.0)&lt;BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)&gt;
    -  [ICollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1?view=netstandard-2.0)&lt;BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)&gt;
    -  [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)&gt;
    -  [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable?view=netstandard-2.0)
    -  [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IList?view=netstandard-2.0)
    -  [ICollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ICollection?view=netstandard-2.0)
    -  [IReadOnlyList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1?view=netstandard-2.0)&lt;BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)&gt;
    -  [IReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1?view=netstandard-2.0)&lt;BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)&gt;
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties

### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Comparer | [IEqualityComparer](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netstandard-2.0)&lt;[Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0)&gt; | - | - |
| Item | [IFragment](/api/oM/Framework/Base/Interface/IFragment) | - | - |
| Count | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| Item | [IFragment](/api/oM/Framework/Base/Interface/IFragment) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FragmentSet : System.Collections.ObjectModel.KeyedCollection<System.Type, BH.oM.Base.IFragment>,
System.Collections.ObjectModel.Collection<BH.oM.Base.IFragment>,
System.Collections.Generic.IList<BH.oM.Base.IFragment>,
System.Collections.Generic.ICollection<BH.oM.Base.IFragment>,
System.Collections.Generic.IEnumerable<BH.oM.Base.IFragment>,
System.Collections.IEnumerable,
System.Collections.IList,
System.Collections.ICollection,
System.Collections.Generic.IReadOnlyList<BH.oM.Base.IFragment>,
System.Collections.Generic.IReadOnlyCollection<BH.oM.Base.IFragment>,
BH.oM.Base.IObject
```

Assembly: BHoM.dll

The class is defined in C#. The class definition is available on github:

- [FragmentSet.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/FragmentSet.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/FragmentSet.json}
```

The JSON Schema is available on github here:

- [FragmentSet.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/FragmentSet.json)
