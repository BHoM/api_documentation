---
title: IAnalytical
---

# Analytical.IAnalytical



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IAnalytical in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Analytical.Elements.[IEdge](/api/oM/Analytical/Analytical/Elements/IEdge)
    - Analytical.Elements.[IFace](/api/oM/Analytical/Analytical/Elements/IFace)
    - Analytical.Elements.[ILink](/api/oM/Analytical/Analytical/Elements/ILink%601)&lt;[TNode](/api/oM/Analytical/Analytical/Elements/ILink%601#tnode)&gt;
    - Analytical.Elements.[IMesh](/api/oM/Analytical/Analytical/Elements/IMesh%602)&lt;[TNode](/api/oM/Analytical/Analytical/Elements/IMesh%602#tnode), [TFace](/api/oM/Analytical/Analytical/Elements/IMesh%602#tface)&gt;
    - Analytical.Elements.[INode](/api/oM/Analytical/Analytical/Elements/INode)
    - Analytical.Elements.[IOpening](/api/oM/Analytical/Analytical/Elements/IOpening%601)&lt;[TEdge](/api/oM/Analytical/Analytical/Elements/IOpening%601#tedge)&gt;
    - Analytical.Elements.[IPanel](/api/oM/Analytical/Analytical/Elements/IPanel%602)&lt;[TEdge](/api/oM/Analytical/Analytical/Elements/IPanel%602#tedge), [TOpening](/api/oM/Analytical/Analytical/Elements/IPanel%602#topening)&gt;
    - Analytical.Elements.[IRegion](/api/oM/Analytical/Analytical/Elements/IRegion)
    - Analytical.Elements.[ISurface](/api/oM/Analytical/Analytical/Elements/ISurface)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Architecture.Elements.[CeilingTile](/api/oM/Analytical/Architecture/Elements/CeilingTile)
    - Architecture.Elements.[Room](/api/oM/Analytical/Architecture/Elements/Room)
    - Environment.Elements.[Edge](/api/oM/Analytical/Environment/Elements/Edge)
    - Environment.Elements.[Opening](/api/oM/Analytical/Environment/Elements/Opening)
    - Environment.Elements.[Panel](/api/oM/Analytical/Environment/Elements/Panel)
    - Environment.Elements.[Space](/api/oM/Analytical/Environment/Elements/Space)
    - Environment.Elements.[Zone](/api/oM/Analytical/Environment/Elements/Zone)
    - Environment.Analysis.[Node](/api/oM/Analytical/Environment/Analysis/Node)
    - Facade.Elements.[CurtainWall](/api/oM/Analytical/Facade/Elements/CurtainWall)
    - Facade.Elements.[FrameEdge](/api/oM/Analytical/Facade/Elements/FrameEdge)
    - Facade.Elements.[Opening](/api/oM/Analytical/Facade/Elements/Opening)
    - Facade.Elements.[Panel](/api/oM/Analytical/Facade/Elements/Panel)
    - Adapters.GSA.Elements.[Spacer](/api/oM/Adapter/Adapters/GSA/Elements/Spacer)
    - Lighting.Analysis.[Node](/api/oM/Analytical/Lighting/Analysis/Node)
    - MEP.System.[Node](/api/oM/Analytical/MEP/System/Node)
    - Structure.Reinforcement.[ReinforcementRegion](/api/oM/Analytical/Structure/Reinforcement/ReinforcementRegion)
    - Structure.Elements.[Bar](/api/oM/Analytical/Structure/Elements/Bar)
    - Structure.Elements.[Edge](/api/oM/Analytical/Structure/Elements/Edge)
    - Structure.Elements.[FEMesh](/api/oM/Analytical/Structure/Elements/FEMesh)
    - Structure.Elements.[FEMeshFace](/api/oM/Analytical/Structure/Elements/FEMeshFace)
    - Structure.Elements.[Node](/api/oM/Analytical/Structure/Elements/Node)
    - Structure.Elements.[Opening](/api/oM/Analytical/Structure/Elements/Opening)
    - Structure.Elements.[PadFoundation](/api/oM/Analytical/Structure/Elements/PadFoundation)
    - Structure.Elements.[Panel](/api/oM/Analytical/Structure/Elements/Panel)
    - Structure.Elements.[Stem](/api/oM/Analytical/Structure/Elements/Stem)
    - Structure.Elements.[Surface](/api/oM/Analytical/Structure/Elements/Surface)


## Properties

## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IAnalytical.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/IAnalytical.cs)

All history and changes of the class can be found by inspection the history.
