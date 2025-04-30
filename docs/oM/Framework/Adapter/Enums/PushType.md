---
title: PushType
---

# <small>BH.oM.Adapter.</small>**PushType**

Controls which type of export should be done by the Adapter `Push` action.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| FullPush |  Calls all CRUD methods as appropriate.  |
| CreateOnly |  Uses only the Create CRUD method to export the objects. This may create duplicates if the object already exists.  |
| CreateNonExisting |  Same as FullPush, but does not update pre-existing objects.  |
| UpdateOnly |  Uses only the Update CRUD method to update the objects in the external software. All other objects in the model are left untouched.  |
| UpdateOrCreateOnly |  Attempt to Update the objects if possible, otherwise Create them. Deletion is not included in this type.  |
| DeleteThenCreate |  For all objects being Pushed, identifies their type, calls Delete to remove all of those types, then it Creates them.  |
| AdapterDefault |  AdapterDefault - Picks the value hard-coded in the specific Adapter.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum PushType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Adapter_oM.dll

The enum is defined in C#. The class definition is available on github:

- [PushType.cs](https://github.com/BHoM/BHoM_Adapter/blob/develop/Adapter_oM/Enums\PushType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Adapter_oM/PushType.json}
```

The JSON Schema is available on github here:

- [PushType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Adapter_oM/PushType.json)
