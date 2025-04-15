---
title: IAnalytical
---

# Analytical.IAnalytical



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IAnalytical in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Analytical.Elements.[IEdge](/documentation/oM/Analytical/Analytical/Elements/IEdge)
    - Analytical.Elements.[IFace](/documentation/oM/Analytical/Analytical/Elements/IFace)
    - Analytical.Elements.[ILink](/documentation/oM/Analytical/Analytical/Elements/ILink%601)&lt;[TNode](/documentation/oM/Analytical/Analytical/Elements/ILink%601#tnode)&gt;
    - Analytical.Elements.[IMesh](/documentation/oM/Analytical/Analytical/Elements/IMesh%602)&lt;[TNode](/documentation/oM/Analytical/Analytical/Elements/IMesh%602#tnode), [TFace](/documentation/oM/Analytical/Analytical/Elements/IMesh%602#tface)&gt;
    - Analytical.Elements.[INode](/documentation/oM/Analytical/Analytical/Elements/INode)
    - Analytical.Elements.[IOpening](/documentation/oM/Analytical/Analytical/Elements/IOpening%601)&lt;[TEdge](/documentation/oM/Analytical/Analytical/Elements/IOpening%601#tedge)&gt;
    - Analytical.Elements.[IPanel](/documentation/oM/Analytical/Analytical/Elements/IPanel%602)&lt;[TEdge](/documentation/oM/Analytical/Analytical/Elements/IPanel%602#tedge), [TOpening](/documentation/oM/Analytical/Analytical/Elements/IPanel%602#topening)&gt;
    - Analytical.Elements.[IRegion](/documentation/oM/Analytical/Analytical/Elements/IRegion)
    - Analytical.Elements.[ISurface](/documentation/oM/Analytical/Analytical/Elements/ISurface)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Architecture.Elements.[CeilingTile](/documentation/oM/Analytical/Architecture/Elements/CeilingTile)
    - Architecture.Elements.[Room](/documentation/oM/Analytical/Architecture/Elements/Room)
    - Environment.Elements.[Edge](/documentation/oM/Analytical/Environment/Elements/Edge)
    - Environment.Elements.[Opening](/documentation/oM/Analytical/Environment/Elements/Opening)
    - Environment.Elements.[Panel](/documentation/oM/Analytical/Environment/Elements/Panel)
    - Environment.Elements.[Space](/documentation/oM/Analytical/Environment/Elements/Space)
    - Environment.Elements.[Zone](/documentation/oM/Analytical/Environment/Elements/Zone)
    - Environment.Analysis.[Node](/documentation/oM/Analytical/Environment/Analysis/Node)
    - Facade.Elements.[CurtainWall](/documentation/oM/Analytical/Facade/Elements/CurtainWall)
    - Facade.Elements.[FrameEdge](/documentation/oM/Analytical/Facade/Elements/FrameEdge)
    - Facade.Elements.[Opening](/documentation/oM/Analytical/Facade/Elements/Opening)
    - Facade.Elements.[Panel](/documentation/oM/Analytical/Facade/Elements/Panel)
    - Adapters.GSA.Elements.[Spacer](/documentation/oM/Adapter/Adapters/GSA/Elements/Spacer)
    - Lighting.Analysis.[Node](/documentation/oM/Analytical/Lighting/Analysis/Node)
    - MEP.System.[Node](/documentation/oM/Analytical/MEP/System/Node)
    - Structure.Reinforcement.[ReinforcementRegion](/documentation/oM/Analytical/Structure/Reinforcement/ReinforcementRegion)
    - Structure.Elements.[Bar](/documentation/oM/Analytical/Structure/Elements/Bar)
    - Structure.Elements.[Edge](/documentation/oM/Analytical/Structure/Elements/Edge)
    - Structure.Elements.[FEMesh](/documentation/oM/Analytical/Structure/Elements/FEMesh)
    - Structure.Elements.[FEMeshFace](/documentation/oM/Analytical/Structure/Elements/FEMeshFace)
    - Structure.Elements.[Node](/documentation/oM/Analytical/Structure/Elements/Node)
    - Structure.Elements.[Opening](/documentation/oM/Analytical/Structure/Elements/Opening)
    - Structure.Elements.[PadFoundation](/documentation/oM/Analytical/Structure/Elements/PadFoundation)
    - Structure.Elements.[Panel](/documentation/oM/Analytical/Structure/Elements/Panel)
    - Structure.Elements.[Stem](/documentation/oM/Analytical/Structure/Elements/Stem)
    - Structure.Elements.[Surface](/documentation/oM/Analytical/Structure/Elements/Surface)


## Properties

## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IAnalytical.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/IAnalytical.cs)

All history and changes of the class can be found by inspection the history.
