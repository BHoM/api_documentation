---
title: BoundCondition
---

# <small>BH.oM.Adapters.Revit.Enums.</small>**BoundCondition**

An enumerator defining possible bound condition of a Revit room/space/area. Below is the meaning of each condition for rooms. The same applies to spaces and areas.- Unplaced: https://help.autodesk.com/view/RVT/2022/ENU/?guid=GUID-BC1DC181-B6D0-4479-8385-363A9EE5E75E- Not Enclosed: https://help.autodesk.com/view/RVT/2022/ENU/?guid=GUID-1AEDF540-7CB3-4CAB-885A-ACDF70154312- Overlapping: Overlaps another space, or 'Redundant' in Revit's term): https://help.autodesk.com/view/RVT/2022/ENU/?guid=GUID-0DF409DD-3BBD-4488-B544-D075D1807747- Bounded (fully bounded on all sides by bounding elements): https://help.autodesk.com/view/RVT/2022/ENU/?guid=GUID-241430FC-8084-43A1-AA3A-681B2883B0FC- No Geometry: the spatial element has a boundary that is too complex for Revit to created its geometric volume. Fixing this will require manually reducing its boundary complexity in the model, such as by using space/room separation lines.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Bounded |  -  |
| Unplaced |  -  |
| NotEnclosed |  -  |
| Overlapping |  -  |
| NoGeometry |  -  |
| Unknown |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum BoundCondition : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Revit_oM.dll

The enum is defined in C#. The class definition is available on github:

- [BoundCondition.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Enums\BoundCondition.cs)

All history and changes of the class can be found by inspection the history.
