---
title: IView
---

# <small>BH.oM.Graphics.Views.</small>**IView**

Base interface for all graphics view objects.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IView is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Graphics.Views.[DependencyChart](/api/oM/Graphics/Graphics/Views/DependencyChart)
    - BH.oM.Graphics.Views.[ViewConfig](/api/oM/Graphics/Graphics/Views/ViewConfig)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IView : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IView.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Views\IView.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Graphics_oM/Views/IView.json"
}
```

The JSON Schema is available on github here:

- [IView.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Graphics_oM/Views/IView.json)
