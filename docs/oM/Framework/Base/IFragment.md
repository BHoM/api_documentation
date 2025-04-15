---
title: IFragment
---

# Base.IFragment

Describes objects that can exist independently or can be attached to other BHoM objects as part of their `FragmentSet` property.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFragment in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Analytical.Fragments.[IDependencyFragment](/documentation/oM/Analytical/Analytical/Fragments/IDependencyFragment)
    - Analytical.Fragments.[IProjectionFragment](/documentation/oM/Analytical/Analytical/Fragments/IProjectionFragment)
    - Base.[IAdapterId](/documentation/oM/Framework/Base/IAdapterId)
    - Base.[IHashFragment](/documentation/oM/Framework/Base/IHashFragment)
    - Base.[IPersistentAdapterId](/documentation/oM/Framework/Base/IPersistentAdapterId)
    - Environment.MaterialFragments.[IEnvironmentMaterial](/documentation/oM/Analytical/Environment/MaterialFragments/IEnvironmentMaterial)
    - Graphics.Fragments.[IRepresentationFragment](/documentation/oM/Graphics/Graphics/Fragments/IRepresentationFragment)
    - MEP.System.MaterialFragments.[IInsulationMaterial](/documentation/oM/Analytical/MEP/System/MaterialFragments/IInsulationMaterial)
    - Adapters.Revit.Parameters.[IRevitParameterFragment](/documentation/oM/Adapter/Adapters/Revit/Parameters/IRevitParameterFragment)
    - Adapters.SAP2000.Fragments.[IPanelOffset](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/IPanelOffset)
    - Adapters.SAP2000.Fragments.[IPanelAutoMesh](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/IPanelAutoMesh)
    - Structure.MaterialFragments.[IIsotropic](/documentation/oM/Analytical/Structure/MaterialFragments/IIsotropic)
    - Structure.MaterialFragments.[IMaterialFragment](/documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)
    - Structure.MaterialFragments.[IOrthotropic](/documentation/oM/Analytical/Structure/MaterialFragments/IOrthotropic)
    - Structure.MaterialFragments.[ITimber](/documentation/oM/Analytical/Structure/MaterialFragments/ITimber)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

    - Analytical.Fragments.[ProjectionFragment](/documentation/oM/Analytical/Analytical/Fragments/ProjectionFragment)
    - Analytical.Fragments.[RoutingFragment](/documentation/oM/Analytical/Analytical/Fragments/RoutingFragment)
    - Analytical.Fragments.[SourcesDependencyFragment](/documentation/oM/Analytical/Analytical/Fragments/SourcesDependencyFragment)
    - Analytical.Fragments.[TargetsDependencyFragment](/documentation/oM/Analytical/Analytical/Fragments/TargetsDependencyFragment)
    - Base.[HashFragment](/documentation/oM/Framework/Base/HashFragment)
    - Diffing.[RevisionFragment](/documentation/oM/Framework/Diffing/RevisionFragment)
    - Environment.MaterialFragments.[GasMaterial](/documentation/oM/Analytical/Environment/MaterialFragments/GasMaterial)
    - Environment.MaterialFragments.[SolidMaterial](/documentation/oM/Analytical/Environment/MaterialFragments/SolidMaterial)
    - Environment.Fragments.[AnalyticalConstruction](/documentation/oM/Analytical/Environment/Fragments/AnalyticalConstruction)
    - Environment.Fragments.[BuildingAnalyticalFragment](/documentation/oM/Analytical/Environment/Fragments/BuildingAnalyticalFragment)
    - Environment.Fragments.[BuildingContextFragment](/documentation/oM/Analytical/Environment/Fragments/BuildingContextFragment)
    - Environment.Fragments.[BuildingResultFragment](/documentation/oM/Analytical/Environment/Fragments/BuildingResultFragment)
    - Environment.Fragments.[CoefficientFragment](/documentation/oM/Analytical/Environment/Fragments/CoefficientFragment)
    - Environment.Fragments.[EnvironmentConstructionFragment](/documentation/oM/Analytical/Environment/Fragments/EnvironmentConstructionFragment)
    - Environment.Fragments.[LightReflectanceFragment](/documentation/oM/Analytical/Environment/Fragments/LightReflectanceFragment)
    - Environment.Fragments.[LightTransmittanceFragment](/documentation/oM/Analytical/Environment/Fragments/LightTransmittanceFragment)
    - Environment.Fragments.[LoadFragment](/documentation/oM/Analytical/Environment/Fragments/LoadFragment)
    - Environment.Fragments.[OriginContextFragment](/documentation/oM/Analytical/Environment/Fragments/OriginContextFragment)
    - Environment.Fragments.[PanelAnalyticalFragment](/documentation/oM/Analytical/Environment/Fragments/PanelAnalyticalFragment)
    - Environment.Fragments.[PanelContextFragment](/documentation/oM/Analytical/Environment/Fragments/PanelContextFragment)
    - Environment.Fragments.[RadiationFragment](/documentation/oM/Analytical/Environment/Fragments/RadiationFragment)
    - Environment.Fragments.[SpaceAnalyticalFragment](/documentation/oM/Analytical/Environment/Fragments/SpaceAnalyticalFragment)
    - Environment.Fragments.[SpaceContextFragment](/documentation/oM/Analytical/Environment/Fragments/SpaceContextFragment)
    - Adapters.ETABS.[ETABSId](/documentation/oM/Adapter/Adapters/ETABS/ETABSId)
    - Adapters.ETABS.Elements.[AutoLengthOffset](/documentation/oM/Adapter/Adapters/ETABS/Elements/AutoLengthOffset)
    - Adapters.ETABS.Elements.[Diaphragm](/documentation/oM/Adapter/Adapters/ETABS/Elements/Diaphragm)
    - Adapters.ETABS.Elements.[Pier](/documentation/oM/Adapter/Adapters/ETABS/Elements/Pier)
    - Adapters.ETABS.Elements.[Spandrel](/documentation/oM/Adapter/Adapters/ETABS/Elements/Spandrel)
    - Adapters.ETABS.Elements.[InsertionPoint](/documentation/oM/Adapter/Adapters/ETABS/Elements/InsertionPoint)
    - Adapters.ETABS.Fragments.[ShellTypeFragment](/documentation/oM/Adapter/Adapters/ETABS/Fragments/ShellTypeFragment)
    - Facade.Fragments.[ConstructionOffset](/documentation/oM/Analytical/Facade/Fragments/ConstructionOffset)
    - Facade.Fragments.[FrameExtensionBox](/documentation/oM/Analytical/Facade/Fragments/FrameExtensionBox)
    - Facade.Fragments.[GlazingLocation](/documentation/oM/Analytical/Facade/Fragments/GlazingLocation)
    - Facade.Fragments.[PsiGlassEdge](/documentation/oM/Analytical/Facade/Fragments/PsiGlassEdge)
    - Facade.Fragments.[PsiJoint](/documentation/oM/Analytical/Facade/Fragments/PsiJoint)
    - Facade.Fragments.[UValueCavity](/documentation/oM/Analytical/Facade/Fragments/UValueCavity)
    - Facade.Fragments.[UValueContinuous](/documentation/oM/Analytical/Facade/Fragments/UValueContinuous)
    - Facade.Fragments.[UValueFrame](/documentation/oM/Analytical/Facade/Fragments/UValueFrame)
    - Facade.Fragments.[UValueGlassCentre](/documentation/oM/Analytical/Facade/Fragments/UValueGlassCentre)
    - Facade.Fragments.[UValueGlassEdge](/documentation/oM/Analytical/Facade/Fragments/UValueGlassEdge)
    - Graphics.[ColourFragment](/documentation/oM/Graphics/Graphics/ColourFragment)
    - Graphics.[RenderMesh](/documentation/oM/Graphics/Graphics/RenderMesh)
    - Graphics.Fragments.[EntityRepresentation](/documentation/oM/Graphics/Graphics/Fragments/EntityRepresentation)
    - Graphics.Fragments.[GraphRepresentation](/documentation/oM/Graphics/Graphics/Fragments/GraphRepresentation)
    - Graphics.Fragments.[GroupRepresentation](/documentation/oM/Graphics/Graphics/Fragments/GroupRepresentation)
    - Graphics.Fragments.[RelationRepresentation](/documentation/oM/Graphics/Graphics/Fragments/RelationRepresentation)
    - Adapters.GSA.[AnalysisTaskFragment](/documentation/oM/Adapter/Adapters/GSA/AnalysisTaskFragment)
    - Adapters.GSA.[DummyTag](/documentation/oM/Adapter/Adapters/GSA/DummyTag)
    - Adapters.GSA.[GSAId](/documentation/oM/Adapter/Adapters/GSA/GSAId)
    - Adapters.GSA.[IsRigidConstraint](/documentation/oM/Adapter/Adapters/GSA/IsRigidConstraint)
    - Adapters.GSA.MaterialFragments.[Fabric](/documentation/oM/Adapter/Adapters/GSA/MaterialFragments/Fabric)
    - Adapters.GSA.Fragments.[PanelBoundaryNodeFragment](/documentation/oM/Adapter/Adapters/GSA/Fragments/PanelBoundaryNodeFragment)
    - IES.Fragments.[SurfaceIndexFragment](/documentation/oM/Adapter/IES/Fragments/SurfaceIndexFragment)
    - LifeCycleAssessment.[LifeCycleAssessmentScope](/documentation/oM/Analytical/LifeCycleAssessment/LifeCycleAssessmentScope)
    - LifeCycleAssessment.[Scope](/documentation/oM/Analytical/LifeCycleAssessment/Scope)
    - LifeCycleAssessment.Fragments.[AdditionalEPDData](/documentation/oM/Analytical/LifeCycleAssessment/Fragments/AdditionalEPDData)
    - LifeCycleAssessment.Fragments.[EPDDensity](/documentation/oM/Analytical/LifeCycleAssessment/Fragments/EPDDensity)
    - Adapters.Lusas.[LusasId](/documentation/oM/Adapter/Adapters/Lusas/LusasId)
    - Adapters.Lusas.Fragments.[MeshSettings2D](/documentation/oM/Adapter/Adapters/Lusas/Fragments/MeshSettings2D)
    - Adapters.Lusas.Fragments.[MeshSettings1D](/documentation/oM/Adapter/Adapters/Lusas/Fragments/MeshSettings1D)
    - MEP.System.MaterialFragments.[InsulationMaterial](/documentation/oM/Analytical/MEP/System/MaterialFragments/InsulationMaterial)
    - MEP.System.MaterialFragments.[LiningMaterial](/documentation/oM/Analytical/MEP/System/MaterialFragments/LiningMaterial)
    - MEP.Fragments.[GeometryFragment](/documentation/oM/Analytical/MEP/Fragments/GeometryFragment)
    - MEP.Fragments.[IdentityFragment](/documentation/oM/Analytical/MEP/Fragments/IdentityFragment)
    - MEP.Fragments.[PlumbingFlowFragment](/documentation/oM/Analytical/MEP/Fragments/PlumbingFlowFragment)
    - MEP.Fragments.[PlumbingLoadingFixtureUnitFragment](/documentation/oM/Analytical/MEP/Fragments/PlumbingLoadingFixtureUnitFragment)
    - Adapters.MidasCivil.[MidasCivilId](/documentation/oM/Adapter/Adapters/MidasCivil/MidasCivilId)
    - Physical.Reinforcement.[ReinforcementFragment](/documentation/oM/Physical/Physical/Reinforcement/ReinforcementFragment)
    - Physical.Materials.[VolumetricMaterialTakeoff](/documentation/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff)
    - Adapters.RAM.[RAMDeckData](/documentation/oM/Adapter/Adapters/RAM/RAMDeckData)
    - Adapters.RAM.[RAMGridData](/documentation/oM/Adapter/Adapters/RAM/RAMGridData)
    - Adapters.RAM.[RAMNodeForceData](/documentation/oM/Adapter/Adapters/RAM/RAMNodeForceData)
    - Adapters.RAM.[RAMFrameData](/documentation/oM/Adapter/Adapters/RAM/RAMFrameData)
    - Adapters.RAM.[RAMId](/documentation/oM/Adapter/Adapters/RAM/RAMId)
    - Adapters.Revit.[RevitGeometry](/documentation/oM/Adapter/Adapters/Revit/RevitGeometry)
    - Adapters.Revit.[RevitRepresentation](/documentation/oM/Adapter/Adapters/Revit/RevitRepresentation)
    - Adapters.Revit.[RevitTypeFragment](/documentation/oM/Adapter/Adapters/Revit/RevitTypeFragment)
    - Adapters.Revit.Parameters.[RevitIdentifiers](/documentation/oM/Adapter/Adapters/Revit/Parameters/RevitIdentifiers)
    - Adapters.Revit.Parameters.[RevitParametersToPush](/documentation/oM/Adapter/Adapters/Revit/Parameters/RevitParametersToPush)
    - Adapters.Revit.Parameters.[RevitPulledParameters](/documentation/oM/Adapter/Adapters/Revit/Parameters/RevitPulledParameters)
    - Revit.[RevitHostFragment](/documentation/oM/Adapter/Revit/RevitHostFragment)
    - Adapters.RFEM5.[RFEM5Id](/documentation/oM/Adapter/Adapters/RFEM5/RFEM5Id)
    - Adapters.RFEM6.[RFEM6ID](/documentation/oM/Adapter/Adapters/RFEM6/RFEM6ID)
    - Adapters.RFEM6.[RFEMHinge](/documentation/oM/Adapter/Adapters/RFEM6/RFEMHinge)
    - Adapters.RFEM6.[RFEMLineSupport](/documentation/oM/Adapter/Adapters/RFEM6/RFEMLineSupport)
    - Adapters.RFEM6.[RFEMNodalSupport](/documentation/oM/Adapter/Adapters/RFEM6/RFEMNodalSupport)
    - Adapters.RFEM6.IntermediateDatastructure.Geometry.[RFEMLine](/documentation/oM/Adapter/Adapters/RFEM6/IntermediateDatastructure/Geometry/RFEMLine)
    - Adapters.RFEM6.IntermediateDatastructure.Geometry.[RFEMOpening](/documentation/oM/Adapter/Adapters/RFEM6/IntermediateDatastructure/Geometry/RFEMOpening)
    - Adapters.RFEM6.BHoMDataStructure.SupportDatastrures.[RFEM6GeometricalLineLoadTypes](/documentation/oM/Adapter/Adapters/RFEM6/BHoMDataStructure/SupportDatastrures/RFEM6GeometricalLineLoadTypes)
    - Adapters.Robot.[LoadCaseLabel](/documentation/oM/Adapter/Adapters/Robot/LoadCaseLabel)
    - Adapters.Robot.[PanelFiniteElementIds](/documentation/oM/Adapter/Adapters/Robot/PanelFiniteElementIds)
    - Adapters.Robot.[RobotId](/documentation/oM/Adapter/Adapters/Robot/RobotId)
    - Adapters.Robot.[FramingElementDesignProperties](/documentation/oM/Adapter/Adapters/Robot/FramingElementDesignProperties)
    - Adapters.SAP2000.[SAP2000Id](/documentation/oM/Adapter/Adapters/SAP2000/SAP2000Id)
    - Adapters.SAP2000.Elements.[BarInsertionPoint](/documentation/oM/Adapter/Adapters/SAP2000/Elements/BarInsertionPoint)
    - Adapters.SAP2000.Elements.[BarDesignProcedure](/documentation/oM/Adapter/Adapters/SAP2000/Elements/BarDesignProcedure)
    - Adapters.SAP2000.Elements.[BarAutoMesh](/documentation/oM/Adapter/Adapters/SAP2000/Elements/BarAutoMesh)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByCookieCutLines](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByCookieCutLines)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByCookieCutPoints](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByCookieCutPoints)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByGeneralDivide](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByGeneralDivide)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByMaximumSize](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByMaximumSize)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByNumberOfObjects](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByNumberOfObjects)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByPointsOnEdges](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByPointsOnEdges)
    - Adapters.SAP2000.Fragments.[PanelEdgeConstraint](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelEdgeConstraint)
    - Adapters.SAP2000.Fragments.[PanelOffsetByJointPattern](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelOffsetByJointPattern)
    - Adapters.SAP2000.Fragments.[PanelOffsetByPoint](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelOffsetByPoint)
    - Structure.Reinforcement.[PanelRebarIntent](/documentation/oM/Analytical/Structure/Reinforcement/PanelRebarIntent)
    - Structure.MaterialFragments.[Aluminium](/documentation/oM/Analytical/Structure/MaterialFragments/Aluminium)
    - Structure.MaterialFragments.[Concrete](/documentation/oM/Analytical/Structure/MaterialFragments/Concrete)
    - Structure.MaterialFragments.[GenericIsotropicMaterial](/documentation/oM/Analytical/Structure/MaterialFragments/GenericIsotropicMaterial)
    - Structure.MaterialFragments.[GenericOrthotropicMaterial](/documentation/oM/Analytical/Structure/MaterialFragments/GenericOrthotropicMaterial)
    - Structure.MaterialFragments.[Glulam](/documentation/oM/Analytical/Structure/MaterialFragments/Glulam)
    - Structure.MaterialFragments.[LaminatedVeneerLumberCrossbands](/documentation/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberCrossbands)
    - Structure.MaterialFragments.[LaminatedVeneerLumberParallel](/documentation/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberParallel)
    - Structure.MaterialFragments.[SawnTimber](/documentation/oM/Analytical/Structure/MaterialFragments/SawnTimber)
    - Structure.MaterialFragments.[Steel](/documentation/oM/Analytical/Structure/MaterialFragments/Steel)
    - Structure.MaterialFragments.[Timber](/documentation/oM/Analytical/Structure/MaterialFragments/Timber)
    - Structure.Fragments.[ReinforcementDensity](/documentation/oM/Analytical/Structure/Fragments/ReinforcementDensity)
    - Structure.Fragments.[SectionModifier](/documentation/oM/Analytical/Structure/Fragments/SectionModifier)
    - Structure.Fragments.[SurfacePropertyModifier](/documentation/oM/Analytical/Structure/Fragments/SurfacePropertyModifier)
    - Test.Adapter.[TestAdapterId](/documentation/oM/Framework/Test/Adapter/TestAdapterId)
    - UI.[ParamOldIndexFragment](/documentation/oM/UI/UI/ParamOldIndexFragment)
    - UI.[PreviousNamesFragment](/documentation/oM/UI/UI/PreviousNamesFragment)
    - XML.Fragments.[XMLBuildingType](/documentation/oM/Adapter/XML/Fragments/XMLBuildingType)


## Properties

## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IFragment.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface/IFragment.cs)

All history and changes of the class can be found by inspection the history.
