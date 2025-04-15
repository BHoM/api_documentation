---
title: XMLConfig
---

# Adapters.XML.XMLConfig

Define configuration settings for pushing and pulling XML files using the XML Adapter.

## Class structure

### Implemented interfaces and base types

???+ bhom "The XMLConfig in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapter.[ActionConfig](/documentation/oM/Framework/Adapter/ActionConfig)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)
    -  Adapters.XML.[IXMLConfig](/documentation/oM/Adapter/Adapters/XML/IXMLConfig)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| File | [FileSettings](/documentation/oM/Framework/Adapter/FileSettings) | File settings for the file to push to or pull from. | - |
| Schema | [Schema](/documentation/oM/Adapter/Adapters/XML/Enums/Schema) | Define the schema which the XML Adapter should be operating with. | - |
| Settings | [IXMLSettings](/documentation/oM/Adapter/Adapters/XML/Settings/IXMLSettings) | Set optional settings to use when pushing or pulling XML based on the chosen schema. | - |
| RemoveNils | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Determine whether 'nil' XML attributes should be removed when pushing to an XML file. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WrapNonBHoMObjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the Push action wraps any non-BHoM type into a BH.oM.Adapter.ObjectWrapper, allowing them to make use of the full Adapter workflow. | - |
| AllowHashForComparing | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true and if no specific EqualityComparer is found for the type, Diffing hashes are computed and used to compare the objects. | - |
| DiffingConfig | [DiffingConfig](/documentation/oM/Framework/Diffing/DiffingConfig) | Configurations for the Diffing hashing. Requires `AllowHashForComparing` to be set to true. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [XMLConfig.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/Config/XMLConfig.cs)

All history and changes of the class can be found by inspection the history.
