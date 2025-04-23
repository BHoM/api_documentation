---
title: IFragment
---

# Base.IFragment

Describes objects that can exist independently or can be attached to other BHoM objects as part of their `FragmentSet` property.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFragment in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Analytical.Fragments.[IDependencyFragment](/api/oM/Analytical/Analytical/Fragments/IDependencyFragment)
    - Analytical.Fragments.[IProjectionFragment](/api/oM/Analytical/Analytical/Fragments/IProjectionFragment)
    - Base.[IAdapterId](/api/oM/Framework/Base/IAdapterId)
    - Base.[IHashFragment](/api/oM/Framework/Base/IHashFragment)
    - Base.[IPersistentAdapterId](/api/oM/Framework/Base/IPersistentAdapterId)
    - Environment.MaterialFragments.[IEnvironmentMaterial](/api/oM/Analytical/Environment/MaterialFragments/IEnvironmentMaterial)
    - Graphics.Fragments.[IRepresentationFragment](/api/oM/Graphics/Graphics/Fragments/IRepresentationFragment)
    - MEP.System.MaterialFragments.[IInsulationMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/IInsulationMaterial)
    - Adapters.Revit.Parameters.[IRevitParameterFragment](/api/oM/Adapter/Adapters/Revit/Parameters/IRevitParameterFragment)
    - Adapters.SAP2000.Fragments.[IPanelOffset](/api/oM/Adapter/Adapters/SAP2000/Fragments/IPanelOffset)
    - Adapters.SAP2000.Fragments.[IPanelAutoMesh](/api/oM/Adapter/Adapters/SAP2000/Fragments/IPanelAutoMesh)
    - Structure.MaterialFragments.[IIsotropic](/api/oM/Analytical/Structure/MaterialFragments/IIsotropic)
    - Structure.MaterialFragments.[IMaterialFragment](/api/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)
    - Structure.MaterialFragments.[IOrthotropic](/api/oM/Analytical/Structure/MaterialFragments/IOrthotropic)
    - Structure.MaterialFragments.[ITimber](/api/oM/Analytical/Structure/MaterialFragments/ITimber)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

    - Analytical.Fragments.[ProjectionFragment](/api/oM/Analytical/Analytical/Fragments/ProjectionFragment)
    - Analytical.Fragments.[RoutingFragment](/api/oM/Analytical/Analytical/Fragments/RoutingFragment)
    - Analytical.Fragments.[SourcesDependencyFragment](/api/oM/Analytical/Analytical/Fragments/SourcesDependencyFragment)
    - Analytical.Fragments.[TargetsDependencyFragment](/api/oM/Analytical/Analytical/Fragments/TargetsDependencyFragment)
    - Base.[HashFragment](/api/oM/Framework/Base/HashFragment)
    - Diffing.[RevisionFragment](/api/oM/Framework/Diffing/RevisionFragment)
    - Environment.MaterialFragments.[GasMaterial](/api/oM/Analytical/Environment/MaterialFragments/GasMaterial)
    - Environment.MaterialFragments.[SolidMaterial](/api/oM/Analytical/Environment/MaterialFragments/SolidMaterial)
    - Environment.Fragments.[AnalyticalConstruction](/api/oM/Analytical/Environment/Fragments/AnalyticalConstruction)
    - Environment.Fragments.[BuildingAnalyticalFragment](/api/oM/Analytical/Environment/Fragments/BuildingAnalyticalFragment)
    - Environment.Fragments.[BuildingContextFragment](/api/oM/Analytical/Environment/Fragments/BuildingContextFragment)
    - Environment.Fragments.[BuildingResultFragment](/api/oM/Analytical/Environment/Fragments/BuildingResultFragment)
    - Environment.Fragments.[CoefficientFragment](/api/oM/Analytical/Environment/Fragments/CoefficientFragment)
    - Environment.Fragments.[EnvironmentConstructionFragment](/api/oM/Analytical/Environment/Fragments/EnvironmentConstructionFragment)
    - Environment.Fragments.[LightReflectanceFragment](/api/oM/Analytical/Environment/Fragments/LightReflectanceFragment)
    - Environment.Fragments.[LightTransmittanceFragment](/api/oM/Analytical/Environment/Fragments/LightTransmittanceFragment)
    - Environment.Fragments.[LoadFragment](/api/oM/Analytical/Environment/Fragments/LoadFragment)
    - Environment.Fragments.[OriginContextFragment](/api/oM/Analytical/Environment/Fragments/OriginContextFragment)
    - Environment.Fragments.[PanelAnalyticalFragment](/api/oM/Analytical/Environment/Fragments/PanelAnalyticalFragment)
    - Environment.Fragments.[PanelContextFragment](/api/oM/Analytical/Environment/Fragments/PanelContextFragment)
    - Environment.Fragments.[RadiationFragment](/api/oM/Analytical/Environment/Fragments/RadiationFragment)
    - Environment.Fragments.[SpaceAnalyticalFragment](/api/oM/Analytical/Environment/Fragments/SpaceAnalyticalFragment)
    - Environment.Fragments.[SpaceContextFragment](/api/oM/Analytical/Environment/Fragments/SpaceContextFragment)
    - Adapters.ETABS.[ETABSId](/api/oM/Adapter/Adapters/ETABS/ETABSId)
    - Adapters.ETABS.Elements.[AutoLengthOffset](/api/oM/Adapter/Adapters/ETABS/Elements/AutoLengthOffset)
    - Adapters.ETABS.Elements.[Diaphragm](/api/oM/Adapter/Adapters/ETABS/Elements/Diaphragm)
    - Adapters.ETABS.Elements.[Pier](/api/oM/Adapter/Adapters/ETABS/Elements/Pier)
    - Adapters.ETABS.Elements.[Spandrel](/api/oM/Adapter/Adapters/ETABS/Elements/Spandrel)
    - Adapters.ETABS.Elements.[InsertionPoint](/api/oM/Adapter/Adapters/ETABS/Elements/InsertionPoint)
    - Adapters.ETABS.Fragments.[ShellTypeFragment](/api/oM/Adapter/Adapters/ETABS/Fragments/ShellTypeFragment)
    - Facade.Fragments.[ConstructionOffset](/api/oM/Analytical/Facade/Fragments/ConstructionOffset)
    - Facade.Fragments.[FrameExtensionBox](/api/oM/Analytical/Facade/Fragments/FrameExtensionBox)
    - Facade.Fragments.[GlazingLocation](/api/oM/Analytical/Facade/Fragments/GlazingLocation)
    - Facade.Fragments.[PsiGlassEdge](/api/oM/Analytical/Facade/Fragments/PsiGlassEdge)
    - Facade.Fragments.[PsiJoint](/api/oM/Analytical/Facade/Fragments/PsiJoint)
    - Facade.Fragments.[UValueCavity](/api/oM/Analytical/Facade/Fragments/UValueCavity)
    - Facade.Fragments.[UValueContinuous](/api/oM/Analytical/Facade/Fragments/UValueContinuous)
    - Facade.Fragments.[UValueFrame](/api/oM/Analytical/Facade/Fragments/UValueFrame)
    - Facade.Fragments.[UValueGlassCentre](/api/oM/Analytical/Facade/Fragments/UValueGlassCentre)
    - Facade.Fragments.[UValueGlassEdge](/api/oM/Analytical/Facade/Fragments/UValueGlassEdge)
    - Graphics.[ColourFragment](/api/oM/Graphics/Graphics/ColourFragment)
    - Graphics.[RenderMesh](/api/oM/Graphics/Graphics/RenderMesh)
    - Graphics.Fragments.[EntityRepresentation](/api/oM/Graphics/Graphics/Fragments/EntityRepresentation)
    - Graphics.Fragments.[GraphRepresentation](/api/oM/Graphics/Graphics/Fragments/GraphRepresentation)
    - Graphics.Fragments.[GroupRepresentation](/api/oM/Graphics/Graphics/Fragments/GroupRepresentation)
    - Graphics.Fragments.[RelationRepresentation](/api/oM/Graphics/Graphics/Fragments/RelationRepresentation)
    - Adapters.GSA.[AnalysisTaskFragment](/api/oM/Adapter/Adapters/GSA/AnalysisTaskFragment)
    - Adapters.GSA.[DummyTag](/api/oM/Adapter/Adapters/GSA/DummyTag)
    - Adapters.GSA.[GSAId](/api/oM/Adapter/Adapters/GSA/GSAId)
    - Adapters.GSA.[IsRigidConstraint](/api/oM/Adapter/Adapters/GSA/IsRigidConstraint)
    - Adapters.GSA.MaterialFragments.[Fabric](/api/oM/Adapter/Adapters/GSA/MaterialFragments/Fabric)
    - Adapters.GSA.Fragments.[PanelBoundaryNodeFragment](/api/oM/Adapter/Adapters/GSA/Fragments/PanelBoundaryNodeFragment)
    - IES.Fragments.[SurfaceIndexFragment](/api/oM/Adapter/IES/Fragments/SurfaceIndexFragment)
    - LifeCycleAssessment.[LifeCycleAssessmentScope](/api/oM/Analytical/LifeCycleAssessment/LifeCycleAssessmentScope)
    - LifeCycleAssessment.[Scope](/api/oM/Analytical/LifeCycleAssessment/Scope)
    - LifeCycleAssessment.Fragments.[AdditionalEPDData](/api/oM/Analytical/LifeCycleAssessment/Fragments/AdditionalEPDData)
    - LifeCycleAssessment.Fragments.[EPDDensity](/api/oM/Analytical/LifeCycleAssessment/Fragments/EPDDensity)
    - Adapters.Lusas.[LusasId](/api/oM/Adapter/Adapters/Lusas/LusasId)
    - Adapters.Lusas.Fragments.[MeshSettings2D](/api/oM/Adapter/Adapters/Lusas/Fragments/MeshSettings2D)
    - Adapters.Lusas.Fragments.[MeshSettings1D](/api/oM/Adapter/Adapters/Lusas/Fragments/MeshSettings1D)
    - MEP.System.MaterialFragments.[InsulationMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/InsulationMaterial)
    - MEP.System.MaterialFragments.[LiningMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/LiningMaterial)
    - MEP.Fragments.[GeometryFragment](/api/oM/Analytical/MEP/Fragments/GeometryFragment)
    - MEP.Fragments.[IdentityFragment](/api/oM/Analytical/MEP/Fragments/IdentityFragment)
    - MEP.Fragments.[PlumbingFlowFragment](/api/oM/Analytical/MEP/Fragments/PlumbingFlowFragment)
    - MEP.Fragments.[PlumbingLoadingFixtureUnitFragment](/api/oM/Analytical/MEP/Fragments/PlumbingLoadingFixtureUnitFragment)
    - Adapters.MidasCivil.[MidasCivilId](/api/oM/Adapter/Adapters/MidasCivil/MidasCivilId)
    - Physical.Reinforcement.[ReinforcementFragment](/api/oM/Physical/Physical/Reinforcement/ReinforcementFragment)
    - Physical.Materials.[VolumetricMaterialTakeoff](/api/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff)
    - Adapters.RAM.[RAMDeckData](/api/oM/Adapter/Adapters/RAM/RAMDeckData)
    - Adapters.RAM.[RAMGridData](/api/oM/Adapter/Adapters/RAM/RAMGridData)
    - Adapters.RAM.[RAMNodeForceData](/api/oM/Adapter/Adapters/RAM/RAMNodeForceData)
    - Adapters.RAM.[RAMFrameData](/api/oM/Adapter/Adapters/RAM/RAMFrameData)
    - Adapters.RAM.[RAMId](/api/oM/Adapter/Adapters/RAM/RAMId)
    - Adapters.Revit.[RevitGeometry](/api/oM/Adapter/Adapters/Revit/RevitGeometry)
    - Adapters.Revit.[RevitRepresentation](/api/oM/Adapter/Adapters/Revit/RevitRepresentation)
    - Adapters.Revit.[RevitTypeFragment](/api/oM/Adapter/Adapters/Revit/RevitTypeFragment)
    - Adapters.Revit.Parameters.[RevitIdentifiers](/api/oM/Adapter/Adapters/Revit/Parameters/RevitIdentifiers)
    - Adapters.Revit.Parameters.[RevitParametersToPush](/api/oM/Adapter/Adapters/Revit/Parameters/RevitParametersToPush)
    - Adapters.Revit.Parameters.[RevitPulledParameters](/api/oM/Adapter/Adapters/Revit/Parameters/RevitPulledParameters)
    - Revit.[RevitHostFragment](/api/oM/Adapter/Revit/RevitHostFragment)
    - Adapters.RFEM5.[RFEM5Id](/api/oM/Adapter/Adapters/RFEM5/RFEM5Id)
    - Adapters.RFEM6.[RFEM6ID](/api/oM/Adapter/Adapters/RFEM6/RFEM6ID)
    - Adapters.RFEM6.[RFEMHinge](/api/oM/Adapter/Adapters/RFEM6/RFEMHinge)
    - Adapters.RFEM6.[RFEMLineSupport](/api/oM/Adapter/Adapters/RFEM6/RFEMLineSupport)
    - Adapters.RFEM6.[RFEMNodalSupport](/api/oM/Adapter/Adapters/RFEM6/RFEMNodalSupport)
    - Adapters.RFEM6.IntermediateDatastructure.Geometry.[RFEMLine](/api/oM/Adapter/Adapters/RFEM6/IntermediateDatastructure/Geometry/RFEMLine)
    - Adapters.RFEM6.IntermediateDatastructure.Geometry.[RFEMOpening](/api/oM/Adapter/Adapters/RFEM6/IntermediateDatastructure/Geometry/RFEMOpening)
    - Adapters.RFEM6.BHoMDataStructure.SupportDatastrures.[RFEM6GeometricalLineLoadTypes](/api/oM/Adapter/Adapters/RFEM6/BHoMDataStructure/SupportDatastrures/RFEM6GeometricalLineLoadTypes)
    - Adapters.Robot.[LoadCaseLabel](/api/oM/Adapter/Adapters/Robot/LoadCaseLabel)
    - Adapters.Robot.[PanelFiniteElementIds](/api/oM/Adapter/Adapters/Robot/PanelFiniteElementIds)
    - Adapters.Robot.[RobotId](/api/oM/Adapter/Adapters/Robot/RobotId)
    - Adapters.Robot.[FramingElementDesignProperties](/api/oM/Adapter/Adapters/Robot/FramingElementDesignProperties)
    - Adapters.SAP2000.[SAP2000Id](/api/oM/Adapter/Adapters/SAP2000/SAP2000Id)
    - Adapters.SAP2000.Elements.[BarInsertionPoint](/api/oM/Adapter/Adapters/SAP2000/Elements/BarInsertionPoint)
    - Adapters.SAP2000.Elements.[BarDesignProcedure](/api/oM/Adapter/Adapters/SAP2000/Elements/BarDesignProcedure)
    - Adapters.SAP2000.Elements.[BarAutoMesh](/api/oM/Adapter/Adapters/SAP2000/Elements/BarAutoMesh)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByCookieCutLines](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByCookieCutLines)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByCookieCutPoints](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByCookieCutPoints)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByGeneralDivide](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByGeneralDivide)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByMaximumSize](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByMaximumSize)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByNumberOfObjects](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByNumberOfObjects)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByPointsOnEdges](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByPointsOnEdges)
    - Adapters.SAP2000.Fragments.[PanelEdgeConstraint](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelEdgeConstraint)
    - Adapters.SAP2000.Fragments.[PanelOffsetByJointPattern](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelOffsetByJointPattern)
    - Adapters.SAP2000.Fragments.[PanelOffsetByPoint](/api/oM/Adapter/Adapters/SAP2000/Fragments/PanelOffsetByPoint)
    - Structure.Reinforcement.[PanelRebarIntent](/api/oM/Analytical/Structure/Reinforcement/PanelRebarIntent)
    - Structure.MaterialFragments.[Aluminium](/api/oM/Analytical/Structure/MaterialFragments/Aluminium)
    - Structure.MaterialFragments.[Concrete](/api/oM/Analytical/Structure/MaterialFragments/Concrete)
    - Structure.MaterialFragments.[GenericIsotropicMaterial](/api/oM/Analytical/Structure/MaterialFragments/GenericIsotropicMaterial)
    - Structure.MaterialFragments.[GenericOrthotropicMaterial](/api/oM/Analytical/Structure/MaterialFragments/GenericOrthotropicMaterial)
    - Structure.MaterialFragments.[Glulam](/api/oM/Analytical/Structure/MaterialFragments/Glulam)
    - Structure.MaterialFragments.[LaminatedVeneerLumberCrossbands](/api/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberCrossbands)
    - Structure.MaterialFragments.[LaminatedVeneerLumberParallel](/api/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberParallel)
    - Structure.MaterialFragments.[SawnTimber](/api/oM/Analytical/Structure/MaterialFragments/SawnTimber)
    - Structure.MaterialFragments.[Steel](/api/oM/Analytical/Structure/MaterialFragments/Steel)
    - Structure.MaterialFragments.[Timber](/api/oM/Analytical/Structure/MaterialFragments/Timber)
    - Structure.Fragments.[ReinforcementDensity](/api/oM/Analytical/Structure/Fragments/ReinforcementDensity)
    - Structure.Fragments.[SectionModifier](/api/oM/Analytical/Structure/Fragments/SectionModifier)
    - Structure.Fragments.[SurfacePropertyModifier](/api/oM/Analytical/Structure/Fragments/SurfacePropertyModifier)
    - Test.Adapter.[TestAdapterId](/api/oM/Framework/Test/Adapter/TestAdapterId)
    - UI.[ParamOldIndexFragment](/api/oM/UI/UI/ParamOldIndexFragment)
    - UI.[PreviousNamesFragment](/api/oM/UI/UI/PreviousNamesFragment)
    - XML.Fragments.[XMLBuildingType](/api/oM/Adapter/XML/Fragments/XMLBuildingType)


## Properties

## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IFragment.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface/IFragment.cs)

All history and changes of the class can be found by inspection the history.
