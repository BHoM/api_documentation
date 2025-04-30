---
title: Metadata
---

# <small>BH.oM.Adapters.MidasCivil.</small>**Metadata**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Metadata is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ProjectNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Defines the project number of the project. | - |
| ProjectName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Defines the name of the project. | - |
| Location | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Defines the location of the project. | - |
| Client | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Defines the client of the project. | - |
| DesignStage | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Defines the design stage of the project. | - |
| ProjectLead | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Defines the project lead for the project. | - |
| Revision | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Defines the revision number of the model. | - |
| Author | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Defines the author of the model. | - |
| CreationDate | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | Defines the date the model was created on. | - |
| Email | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Defines the project email address. | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A short description of the project and model. | - |
| Discipline | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The discipline responsible for the model. | - |
| Reviews | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Review](/api/oM/Adapter/Adapters/MidasCivil/Settings/Review)&gt; | A list of reviews containing reviewers, their comments and the date of review. | - |


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
public class Metadata : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: MidasCivil_oM.dll

The class is defined in C#. The class definition is available on github:

- [Metadata.cs](https://github.com/BHoM/MidasCivil_Toolkit/blob/develop/MidasCivil_oM/Settings\Metadata.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/MidasCivil_oM/Metadata.json}
```

The JSON Schema is available on github here:

- [Metadata.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/MidasCivil_oM/Metadata.json)
