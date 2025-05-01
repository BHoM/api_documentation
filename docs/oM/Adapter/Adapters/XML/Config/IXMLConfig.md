---
title: IXMLConfig
---

# <small>BH.oM.Adapters.XML.</small>**IXMLConfig**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IXMLConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.XML.[XMLConfig](/api/oM/Adapter/Adapters/XML/Config/XMLConfig)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| File | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IXMLConfig : BH.oM.Base.IObject
```

Assembly: XML_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IXMLConfig.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/Config\IXMLConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/XML_oM/IXMLConfig.json"
}
```

The JSON Schema is available on github here:

- [IXMLConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/XML_oM/IXMLConfig.json)
