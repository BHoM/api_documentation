---
title: BlankGeologyStrategy
---

# Adapters.AGS.BlankGeologyStrategy

Different approaches for the AGS_Toolkit to handle blank geology.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Replace |  Replace any entries of blank geology with a specificed string.  |
| Description |  Replace any entries of blank geology using the description attribute (GEOL_DESC) with words in CAPS.  |
| Legend |  Replace any entries of blank geology using the legend (GEOL_LEG).  |
| Lexicon |  Replace any entries of blank geology using the lexicon code (GEOL_BGS).  |


## Code and Schema

### C# implementation

The enum is defined in C#. The class definition is available on github:

- [BlankGeologyStrategy.cs](https://github.com/BHoM/AGS_Toolkit/blob/develop/AGS_oM/eNums/BlankGeologyStrategy.cs)

All history and changes of the class can be found by inspection the history.
