---
title: IDesignable
---

# <small>BH.oM.Structure.Design.</small>**IDesignable**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IDesignable is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.Design.[StructuralLayout](/api/oM/Analytical/Structure/Design/StructuralLayout)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IDesignable : BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IDesignable.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Design\IDesignable.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Design/IDesignable.json}
```

The JSON Schema is available on github here:

- [IDesignable.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Design/IDesignable.json)
