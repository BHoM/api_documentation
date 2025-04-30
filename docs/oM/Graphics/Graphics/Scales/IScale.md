---
title: IScale
---

# <small>BH.oM.Graphics.Scales.</small>**IScale**

Base interface for all graphics scales.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IScale is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Graphics.Scales.[ScaleLinear](/api/oM/Graphics/Graphics/Scales/ScaleLinear)
    - BH.oM.Graphics.Scales.[ScaleOrdinal](/api/oM/Graphics/Graphics/Scales/ScaleOrdinal)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IScale : BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IScale.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Scales\IScale.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Graphics_oM/Scales/IScale.json}
```

The JSON Schema is available on github here:

- [IScale.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Graphics_oM/Scales/IScale.json)
