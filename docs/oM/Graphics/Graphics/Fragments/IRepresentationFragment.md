---
title: IRepresentationFragment
---

# <small>BH.oM.Graphics.Fragments.</small>**IRepresentationFragment**

Base interface for representation fragments.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRepresentationFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Graphics.Fragments.[EntityRepresentation](/api/oM/Graphics/Graphics/Fragments/EntityRepresentation)
    - BH.oM.Graphics.Fragments.[GraphRepresentation](/api/oM/Graphics/Graphics/Fragments/GraphRepresentation)
    - BH.oM.Graphics.Fragments.[GroupRepresentation](/api/oM/Graphics/Graphics/Fragments/GroupRepresentation)
    - BH.oM.Graphics.Fragments.[RelationRepresentation](/api/oM/Graphics/Graphics/Fragments/RelationRepresentation)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IRepresentationFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IRepresentationFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Fragments\IRepresentationFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Graphics_oM/Fragments/IRepresentationFragment.json}
```

The JSON Schema is available on github here:

- [IRepresentationFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Graphics_oM/Fragments/IRepresentationFragment.json)
