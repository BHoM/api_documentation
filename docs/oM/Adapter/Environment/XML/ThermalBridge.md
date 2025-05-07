---
title: ThermalBridge
---

# <small>BH.oM.Environment.SAP.XML.</small>**ThermalBridge**



## Class structure

### Implemented interfaces and base types

???+ bhom "The ThermalBridge is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Length of the thermal bridge in metres; only if thermal bridge code is: user defined (individual values). | - |
| PsiValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Linear thermal transmittance (psi-value); only if thermal bridging is user defined individual values. | - |
| PsiSource | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| Type | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Code to indicate a particular type of thermal bridge; only if thermal bridge code is: user defined (individual values). | - |
| CalculationReference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Reference to the details of the calculation of the psi-value. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ThermalBridge : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: SAP_oM.dll

The C# class definition is available on github:

- [ThermalBridge.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML\ThermalBridge.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/XML/ThermalBridge.json"
}
```

The JSON Schema is available on github here:

- [ThermalBridge.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/XML/ThermalBridge.json)
