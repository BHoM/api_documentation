---
title: IAnalytical
---

# Analytical.IAnalytical



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IAnalytical in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Analytical.Elements.[IEdge](/om_documentation/oM/Analytical/Analytical/Elements/IEdge)
    - Analytical.Elements.[IFace](/om_documentation/oM/Analytical/Analytical/Elements/IFace)
    - Analytical.Elements.[ILink](/om_documentation/oM/Analytical/Analytical/Elements/ILink%601)&lt;[TNode](/om_documentation/oM/Analytical/Analytical/Elements/ILink%601#tnode)&gt;
    - Analytical.Elements.[IMesh](/om_documentation/oM/Analytical/Analytical/Elements/IMesh%602)&lt;[TNode](/om_documentation/oM/Analytical/Analytical/Elements/IMesh%602#tnode), [TFace](/om_documentation/oM/Analytical/Analytical/Elements/IMesh%602#tface)&gt;
    - Analytical.Elements.[INode](/om_documentation/oM/Analytical/Analytical/Elements/INode)
    - Analytical.Elements.[IOpening](/om_documentation/oM/Analytical/Analytical/Elements/IOpening%601)&lt;[TEdge](/om_documentation/oM/Analytical/Analytical/Elements/IOpening%601#tedge)&gt;
    - Analytical.Elements.[IPanel](/om_documentation/oM/Analytical/Analytical/Elements/IPanel%602)&lt;[TEdge](/om_documentation/oM/Analytical/Analytical/Elements/IPanel%602#tedge), [TOpening](/om_documentation/oM/Analytical/Analytical/Elements/IPanel%602#topening)&gt;
    - Analytical.Elements.[IRegion](/om_documentation/oM/Analytical/Analytical/Elements/IRegion)
    - Analytical.Elements.[ISurface](/om_documentation/oM/Analytical/Analytical/Elements/ISurface)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Architecture.Elements.[CeilingTile](/om_documentation/oM/Analytical/Architecture/Elements/CeilingTile)
    - Architecture.Elements.[Room](/om_documentation/oM/Analytical/Architecture/Elements/Room)
    - Environment.Elements.[Edge](/om_documentation/oM/Analytical/Environment/Elements/Edge)
    - Environment.Elements.[Opening](/om_documentation/oM/Analytical/Environment/Elements/Opening)
    - Environment.Elements.[Panel](/om_documentation/oM/Analytical/Environment/Elements/Panel)
    - Environment.Elements.[Space](/om_documentation/oM/Analytical/Environment/Elements/Space)
    - Environment.Elements.[Zone](/om_documentation/oM/Analytical/Environment/Elements/Zone)
    - Environment.Analysis.[Node](/om_documentation/oM/Analytical/Environment/Analysis/Node)
    - Facade.Elements.[CurtainWall](/om_documentation/oM/Analytical/Facade/Elements/CurtainWall)
    - Facade.Elements.[FrameEdge](/om_documentation/oM/Analytical/Facade/Elements/FrameEdge)
    - Facade.Elements.[Opening](/om_documentation/oM/Analytical/Facade/Elements/Opening)
    - Facade.Elements.[Panel](/om_documentation/oM/Analytical/Facade/Elements/Panel)
    - Adapters.GSA.Elements.[Spacer](/om_documentation/oM/Adapter/Adapters/GSA/Elements/Spacer)
    - Lighting.Analysis.[Node](/om_documentation/oM/Analytical/Lighting/Analysis/Node)
    - MEP.System.[Node](/om_documentation/oM/Analytical/MEP/System/Node)
    - Structure.Reinforcement.[ReinforcementRegion](/om_documentation/oM/Analytical/Structure/Reinforcement/ReinforcementRegion)
    - Structure.Elements.[Bar](/om_documentation/oM/Analytical/Structure/Elements/Bar)
    - Structure.Elements.[Edge](/om_documentation/oM/Analytical/Structure/Elements/Edge)
    - Structure.Elements.[FEMesh](/om_documentation/oM/Analytical/Structure/Elements/FEMesh)
    - Structure.Elements.[FEMeshFace](/om_documentation/oM/Analytical/Structure/Elements/FEMeshFace)
    - Structure.Elements.[Node](/om_documentation/oM/Analytical/Structure/Elements/Node)
    - Structure.Elements.[Opening](/om_documentation/oM/Analytical/Structure/Elements/Opening)
    - Structure.Elements.[PadFoundation](/om_documentation/oM/Analytical/Structure/Elements/PadFoundation)
    - Structure.Elements.[Panel](/om_documentation/oM/Analytical/Structure/Elements/Panel)
    - Structure.Elements.[Stem](/om_documentation/oM/Analytical/Structure/Elements/Stem)
    - Structure.Elements.[Surface](/om_documentation/oM/Analytical/Structure/Elements/Surface)


## Properties

## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IAnalytical.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/IAnalytical.cs)

All history and changes of the class can be found by inspection the history.
