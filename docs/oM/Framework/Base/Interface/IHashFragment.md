---
title: IHashFragment
---

# <small>BH.oM.Base.</small>**IHashFragment**

Stores the hash of the parent BHoMObject.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IHashFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Base.[HashFragment](/api/oM/Framework/Base/HashFragment)
    - BH.oM.Diffing.[RevisionFragment](/api/oM/Framework/Diffing/RevisionFragment)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Hash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Hash of the parent BHoMObject. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IHashFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The interface is defined in C#. The class definition is available on github:

- [IHashFragment.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface\IHashFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/IHashFragment.json}
```

The JSON Schema is available on github here:

- [IHashFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/IHashFragment.json)
