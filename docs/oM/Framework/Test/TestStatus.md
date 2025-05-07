---
title: TestStatus
---

# <small>BH.oM.Test.</small>**TestStatus**

Defines the status of the Test Information. Designed to be very clear, concrete statuses, with minimal ambiguity.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Error |  The status is such that immediate action should be taken, and workflows should not continue further until this is addressed.  |
| Pass |  Everything is good, as close to perfect as we can get, with no further action needing to be taken.  |
| Warning |  Something hasn't quite gone to plan, but is not sufficient enough to stop everything. It is advised to investigate further before continuing, but you can continue before addressing this.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum TestStatus : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Test_oM.dll

The C# enum definition is available on github:

- [TestStatus.cs](https://github.com/BHoM/BHoM/blob/develop/Test_oM/TestStatus.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Test_oM/TestStatus.json"
}
```

The JSON Schema is available on github here:

- [TestStatus.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Test_oM/TestStatus.json)
