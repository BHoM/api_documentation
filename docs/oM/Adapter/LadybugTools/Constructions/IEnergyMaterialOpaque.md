---
title: IEnergyMaterialOpaque
---

# <small>BH.oM.LadybugTools.</small>**IEnergyMaterialOpaque**

An interface for opaque energy materials.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IEnergyMaterialOpaque is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LadybugTools.[ILadybugTools](/api/oM/Adapter/LadybugTools/ILadybugTools)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.LadybugTools.[EnergyMaterial](/api/oM/Adapter/LadybugTools/Constructions/EnergyMaterial)
    - BH.oM.LadybugTools.[EnergyMaterialVegetation](/api/oM/Adapter/LadybugTools/Constructions/EnergyMaterialVegetation)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IEnergyMaterialOpaque : BH.oM.LadybugTools.ILadybugTools, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IEnergyMaterialOpaque.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/Constructions\IEnergyMaterialOpaque.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/IEnergyMaterialOpaque.json}
```

The JSON Schema is available on github here:

- [IEnergyMaterialOpaque.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/IEnergyMaterialOpaque.json)
