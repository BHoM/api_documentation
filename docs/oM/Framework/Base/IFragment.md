---
title: IFragment
---

# Base.IFragment

Describes objects that can exist independently or can be attached to other BHoM objects as part of their `FragmentSet` property.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFragment in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Analytical.Fragments.[IDependencyFragment](/api_documentation/oM/Analytical/Analytical/Fragments/IDependencyFragment)
    - Analytical.Fragments.[IProjectionFragment](/api_documentation/oM/Analytical/Analytical/Fragments/IProjectionFragment)
    - Base.[IAdapterId](/api_documentation/oM/Framework/Base/IAdapterId)
    - Base.[IHashFragment](/api_documentation/oM/Framework/Base/IHashFragment)
    - Base.[IPersistentAdapterId](/api_documentation/oM/Framework/Base/IPersistentAdapterId)
    - Environment.MaterialFragments.[IEnvironmentMaterial](/api_documentation/oM/Analytical/Environment/MaterialFragments/IEnvironmentMaterial)
    - Graphics.Fragments.[IRepresentationFragment](/api_documentation/oM/Graphics/Graphics/Fragments/IRepresentationFragment)
    - MEP.System.MaterialFragments.[IInsulationMaterial](/api_documentation/oM/Analytical/MEP/System/MaterialFragments/IInsulationMaterial)
    - Adapters.Revit.Parameters.[IRevitParameterFragment](/api_documentation/oM/Adapter/Adapters/Revit/Parameters/IRevitParameterFragment)
    - Adapters.SAP2000.Fragments.[IPanelOffset](/api_documentation/oM/Adapter/Adapters/SAP2000/Fragments/IPanelOffset)
    - Adapters.SAP2000.Fragments.[IPanelAutoMesh](/api_documentation/oM/Adapter/Adapters/SAP2000/Fragments/IPanelAutoMesh)
    - Structure.MaterialFragments.[IIsotropic](/api_documentation/oM/Analytical/Structure/MaterialFragments/IIsotropic)
    - Structure.MaterialFragments.[IMaterialFragment](/api_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)
    - Structure.MaterialFragments.[IOrthotropic](/api_documentation/oM/Analytical/Structure/MaterialFragments/IOrthotropic)
    - Structure.MaterialFragments.[ITimber](/api_documentation/oM/Analytical/Structure/MaterialFragments/ITimber)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

    - Analytical.Fragments.[ProjectionFragment](/api_documentation/oM/Analytical/Analytical/Fragments/ProjectionFragment)
    - Analytical.Fragments.[RoutingFragment](/api_documentation/oM/Analytical/Analytical/Fragments/RoutingFragment)
    - Analytical.Fragments.[SourcesDependencyFragment](/api_documentation/oM/Analytical/Analytical/Fragments/SourcesDependencyFragment)
    - Analytical.Fragments.[TargetsDependencyFragment](/api_documentation/oM/Analytical/Analytical/Fragments/TargetsDependencyFragment)
    - Base.[HashFragment](/api_documentation/oM/Framework/Base/HashFragment)
    - Diffing.[RevisionFragment](/api_documentation/oM/Framework/Diffing/RevisionFragment)
    - Environment.MaterialFragments.[GasMaterial](/api_documentation/oM/Analytical/Environment/MaterialFragments/GasMaterial)
    - Environment.MaterialFragments.[SolidMaterial](/api_documentation/oM/Analytical/Environment/MaterialFragments/SolidMaterial)
    - Environment.Fragments.[AnalyticalConstruction](/api_documentation/oM/Analytical/Environment/Fragments/AnalyticalConstruction)
    - Environment.Fragments.[BuildingAnalyticalFragment](/api_documentation/oM/Analytical/Environment/Fragments/BuildingAnalyticalFragment)
    - Environment.Fragments.[BuildingContextFragment](/api_documentation/oM/Analytical/Environment/Fragments/BuildingContextFragment)
    - Environment.Fragments.[BuildingResultFragment](/api_documentation/oM/Analytical/Environment/Fragments/BuildingResultFragment)
    - Environment.Fragments.[CoefficientFragment](/api_documentation/oM/Analytical/Environment/Fragments/CoefficientFragment)
    - Environment.Fragments.[EnvironmentConstructionFragment](/api_documentation/oM/Analytical/Environment/Fragments/EnvironmentConstructionFragment)
    - Environment.Fragments.[LightReflectanceFragment](/api_documentation/oM/Analytical/Environment/Fragments/LightReflectanceFragment)
    - Environment.Fragments.[LightTransmittanceFragment](/api_documentation/oM/Analytical/Environment/Fragments/LightTransmittanceFragment)
    - Environment.Fragments.[LoadFragment](/api_documentation/oM/Analytical/Environment/Fragments/LoadFragment)
    - Environment.Fragments.[OriginContextFragment](/api_documentation/oM/Analytical/Environment/Fragments/OriginContextFragment)
    - Environment.Fragments.[PanelAnalyticalFragment](/api_documentation/oM/Analytical/Environment/Fragments/PanelAnalyticalFragment)
    - Environment.Fragments.[PanelContextFragment](/api_documentation/oM/Analytical/Environment/Fragments/PanelContextFragment)
    - Environment.Fragments.[RadiationFragment](/api_documentation/oM/Analytical/Environment/Fragments/RadiationFragment)
    - Environment.Fragments.[SpaceAnalyticalFragment](/api_documentation/oM/Analytical/Environment/Fragments/SpaceAnalyticalFragment)
    - Environment.Fragments.[SpaceContextFragment](/api_documentation/oM/Analytical/Environment/Fragments/SpaceContextFragment)
    - Adapters.ETABS.[ETABSId](/api_documentation/oM/Adapter/Adapters/ETABS/ETABSId)
    - Adapters.ETABS.Elements.[AutoLengthOffset](/api_documentation/oM/Adapter/Adapters/ETABS/Elements/AutoLengthOffset)
    - Adapters.ETABS.Elements.[Diaphragm](/api_documentation/oM/Adapter/Adapters/ETABS/Elements/Diaphragm)
    - Adapters.ETABS.Elements.[Pier](/api_documentation/oM/Adapter/Adapters/ETABS/Elements/Pier)
    - Adapters.ETABS.Elements.[Spandrel](/api_documentation/oM/Adapter/Adapters/ETABS/Elements/Spandrel)
    - Adapters.ETABS.Elements.[InsertionPoint](/api_documentation/oM/Adapter/Adapters/ETABS/Elements/InsertionPoint)
    - Adapters.ETABS.Fragments.[ShellTypeFragment](/api_documentation/oM/Adapter/Adapters/ETABS/Fragments/ShellTypeFragment)
    - Facade.Fragments.[ConstructionOffset](/api_documentation/oM/Analytical/Facade/Fragments/ConstructionOffset)
    - Facade.Fragments.[FrameExtensionBox](/api_documentation/oM/Analytical/Facade/Fragments/FrameExtensionBox)
    - Facade.Fragments.[GlazingLocation](/api_documentation/oM/Analytical/Facade/Fragments/GlazingLocation)
    - Facade.Fragments.[PsiGlassEdge](/api_documentation/oM/Analytical/Facade/Fragments/PsiGlassEdge)
    - Facade.Fragments.[PsiJoint](/api_documentation/oM/Analytical/Facade/Fragments/PsiJoint)
    - Facade.Fragments.[UValueCavity](/api_documentation/oM/Analytical/Facade/Fragments/UValueCavity)
    - Facade.Fragments.[UValueContinuous](/api_documentation/oM/Analytical/Facade/Fragments/UValueContinuous)
    - Facade.Fragments.[UValueFrame](/api_documentation/oM/Analytical/Facade/Fragments/UValueFrame)
    - Facade.Fragments.[UValueGlassCentre](/api_documentation/oM/Analytical/Facade/Fragments/UValueGlassCentre)
    - Facade.Fragments.[UValueGlassEdge](/api_documentation/oM/Analytical/Facade/Fragments/UValueGlassEdge)
    - Graphics.[ColourFragment](/api_documentation/oM/Graphics/Graphics/ColourFragment)
    - Graphics.[RenderMesh](/api_documentation/oM/Graphics/Graphics/RenderMesh)
    - Graphics.Fragments.[EntityRepresentation](/api_documentation/oM/Graphics/Graphics/Fragments/EntityRepresentation)
    - Graphics.Fragments.[GraphRepresentation](/api_documentation/oM/Graphics/Graphics/Fragments/GraphRepresentation)
    - Graphics.Fragments.[GroupRepresentation](/api_documentation/oM/Graphics/Graphics/Fragments/GroupRepresentation)
    - Graphics.Fragments.[RelationRepresentation](/api_documentation/oM/Graphics/Graphics/Fragments/RelationRepresentation)
    - Adapters.GSA.[AnalysisTaskFragment](/api_documentation/oM/Adapter/Adapters/GSA/AnalysisTaskFragment)
    - Adapters.GSA.[DummyTag](/api_documentation/oM/Adapter/Adapters/GSA/DummyTag)
    - Adapters.GSA.[GSAId](/api_documentation/oM/Adapter/Adapters/GSA/GSAId)
    - Adapters.GSA.[IsRigidConstraint](/api_documentation/oM/Adapter/Adapters/GSA/IsRigidConstraint)
    - Adapters.GSA.MaterialFragments.[Fabric](/api_documentation/oM/Adapter/Adapters/GSA/MaterialFragments/Fabric)
    - Adapters.GSA.Fragments.[PanelBoundaryNodeFragment](/api_documentation/oM/Adapter/Adapters/GSA/Fragments/PanelBoundaryNodeFragment)
    - IES.Fragments.[SurfaceIndexFragment](/api_documentation/oM/Adapter/IES/Fragments/SurfaceIndexFragment)
    - LifeCycleAssessment.[LifeCycleAssessmentScope](/api_documentation/oM/Analytical/LifeCycleAssessment/LifeCycleAssessmentScope)
    - LifeCycleAssessment.[Scope](/api_documentation/oM/Analytical/LifeCycleAssessment/Scope)
    - LifeCycleAssessment.Fragments.[AdditionalEPDData](/api_documentation/oM/Analytical/LifeCycleAssessment/Fragments/AdditionalEPDData)
    - LifeCycleAssessment.Fragments.[EPDDensity](/api_documentation/oM/Analytical/LifeCycleAssessment/Fragments/EPDDensity)
    - Adapters.Lusas.[LusasId](/api_documentation/oM/Adapter/Adapters/Lusas/LusasId)
    - Adapters.Lusas.Fragments.[MeshSettings2D](/api_documentation/oM/Adapter/Adapters/Lusas/Fragments/MeshSettings2D)
    - Adapters.Lusas.Fragments.[MeshSettings1D](/api_documentation/oM/Adapter/Adapters/Lusas/Fragments/MeshSettings1D)
    - MEP.System.MaterialFragments.[InsulationMaterial](/api_documentation/oM/Analytical/MEP/System/MaterialFragments/InsulationMaterial)
    - MEP.System.MaterialFragments.[LiningMaterial](/api_documentation/oM/Analytical/MEP/System/MaterialFragments/LiningMaterial)
    - MEP.Fragments.[GeometryFragment](/api_documentation/oM/Analytical/MEP/Fragments/GeometryFragment)
    - MEP.Fragments.[IdentityFragment](/api_documentation/oM/Analytical/MEP/Fragments/IdentityFragment)
    - MEP.Fragments.[PlumbingFlowFragment](/api_documentation/oM/Analytical/MEP/Fragments/PlumbingFlowFragment)
    - MEP.Fragments.[PlumbingLoadingFixtureUnitFragment](/api_documentation/oM/Analytical/MEP/Fragments/PlumbingLoadingFixtureUnitFragment)
    - Adapters.MidasCivil.[MidasCivilId](/api_documentation/oM/Adapter/Adapters/MidasCivil/MidasCivilId)
    - Physical.Reinforcement.[ReinforcementFragment](/api_documentation/oM/Physical/Physical/Reinforcement/ReinforcementFragment)
    - Physical.Materials.[VolumetricMaterialTakeoff](/api_documentation/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff)
    - Adapters.RAM.[RAMDeckData](/api_documentation/oM/Adapter/Adapters/RAM/RAMDeckData)
    - Adapters.RAM.[RAMGridData](/api_documentation/oM/Adapter/Adapters/RAM/RAMGridData)
    - Adapters.RAM.[RAMNodeForceData](/api_documentation/oM/Adapter/Adapters/RAM/RAMNodeForceData)
    - Adapters.RAM.[RAMFrameData](/api_documentation/oM/Adapter/Adapters/RAM/RAMFrameData)
    - Adapters.RAM.[RAMId](/api_documentation/oM/Adapter/Adapters/RAM/RAMId)
    - Adapters.Revit.[RevitGeometry](/api_documentation/oM/Adapter/Adapters/Revit/RevitGeometry)
    - Adapters.Revit.[RevitRepresentation](/api_documentation/oM/Adapter/Adapters/Revit/RevitRepresentation)
    - Adapters.Revit.[RevitTypeFragment](/api_documentation/oM/Adapter/Adapters/Revit/RevitTypeFragment)
    - Adapters.Revit.Parameters.[RevitIdentifiers](/api_documentation/oM/Adapter/Adapters/Revit/Parameters/RevitIdentifiers)
    - Adapters.Revit.Parameters.[RevitParametersToPush](/api_documentation/oM/Adapter/Adapters/Revit/Parameters/RevitParametersToPush)
    - Adapters.Revit.Parameters.[RevitPulledParameters](/api_documentation/oM/Adapter/Adapters/Revit/Parameters/RevitPulledParameters)
    - Revit.[RevitHostFragment](/api_documentation/oM/Adapter/Revit/RevitHostFragment)
    - Adapters.RFEM5.[RFEM5Id](/api_documentation/oM/Adapter/Adapters/RFEM5/RFEM5Id)
    - Adapters.RFEM6.[RFEM6ID](/api_documentation/oM/Adapter/Adapters/RFEM6/RFEM6ID)
    - Adapters.RFEM6.[RFEMHinge](/api_documentation/oM/Adapter/Adapters/RFEM6/RFEMHinge)
    - Adapters.RFEM6.[RFEMLineSupport](/api_documentation/oM/Adapter/Adapters/RFEM6/RFEMLineSupport)
    - Adapters.RFEM6.[RFEMNodalSupport](/api_documentation/oM/Adapter/Adapters/RFEM6/RFEMNodalSupport)
    - Adapters.RFEM6.IntermediateDatastructure.Geometry.[RFEMLine](/api_documentation/oM/Adapter/Adapters/RFEM6/IntermediateDatastructure/Geometry/RFEMLine)
    - Adapters.RFEM6.IntermediateDatastructure.Geometry.[RFEMOpening](/api_documentation/oM/Adapter/Adapters/RFEM6/IntermediateDatastructure/Geometry/RFEMOpening)
    - Adapters.RFEM6.BHoMDataStructure.SupportDatastrures.[RFEM6GeometricalLineLoadTypes](/api_documentation/oM/Adapter/Adapters/RFEM6/BHoMDataStructure/SupportDatastrures/RFEM6GeometricalLineLoadTypes)
    - Adapters.Robot.[LoadCaseLabel](/api_documentation/oM/Adapter/Adapters/Robot/LoadCaseLabel)
    - Adapters.Robot.[PanelFiniteElementIds](/api_documentation/oM/Adapter/Adapters/Robot/PanelFiniteElementIds)
    - Adapters.Robot.[RobotId](/api_documentation/oM/Adapter/Adapters/Robot/RobotId)
    - Adapters.Robot.[FramingElementDesignProperties](/api_documentation/oM/Adapter/Adapters/Robot/FramingElementDesignProperties)
    - Adapters.SAP2000.[SAP2000Id](/api_documentation/oM/Adapter/Adapters/SAP2000/SAP2000Id)
    - Adapters.SAP2000.Elements.[BarInsertionPoint](/api_documentation/oM/Adapter/Adapters/SAP2000/Elements/BarInsertionPoint)
    - Adapters.SAP2000.Elements.[BarDesignProcedure](/api_documentation/oM/Adapter/Adapters/SAP2000/Elements/BarDesignProcedure)
    - Adapters.SAP2000.Elements.[BarAutoMesh](/api_documentation/oM/Adapter/Adapters/SAP2000/Elements/BarAutoMesh)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByCookieCutLines](/api_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByCookieCutLines)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByCookieCutPoints](/api_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByCookieCutPoints)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByGeneralDivide](/api_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByGeneralDivide)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByMaximumSize](/api_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByMaximumSize)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByNumberOfObjects](/api_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByNumberOfObjects)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByPointsOnEdges](/api_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByPointsOnEdges)
    - Adapters.SAP2000.Fragments.[PanelEdgeConstraint](/api_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelEdgeConstraint)
    - Adapters.SAP2000.Fragments.[PanelOffsetByJointPattern](/api_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelOffsetByJointPattern)
    - Adapters.SAP2000.Fragments.[PanelOffsetByPoint](/api_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelOffsetByPoint)
    - Structure.Reinforcement.[PanelRebarIntent](/api_documentation/oM/Analytical/Structure/Reinforcement/PanelRebarIntent)
    - Structure.MaterialFragments.[Aluminium](/api_documentation/oM/Analytical/Structure/MaterialFragments/Aluminium)
    - Structure.MaterialFragments.[Concrete](/api_documentation/oM/Analytical/Structure/MaterialFragments/Concrete)
    - Structure.MaterialFragments.[GenericIsotropicMaterial](/api_documentation/oM/Analytical/Structure/MaterialFragments/GenericIsotropicMaterial)
    - Structure.MaterialFragments.[GenericOrthotropicMaterial](/api_documentation/oM/Analytical/Structure/MaterialFragments/GenericOrthotropicMaterial)
    - Structure.MaterialFragments.[Glulam](/api_documentation/oM/Analytical/Structure/MaterialFragments/Glulam)
    - Structure.MaterialFragments.[LaminatedVeneerLumberCrossbands](/api_documentation/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberCrossbands)
    - Structure.MaterialFragments.[LaminatedVeneerLumberParallel](/api_documentation/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberParallel)
    - Structure.MaterialFragments.[SawnTimber](/api_documentation/oM/Analytical/Structure/MaterialFragments/SawnTimber)
    - Structure.MaterialFragments.[Steel](/api_documentation/oM/Analytical/Structure/MaterialFragments/Steel)
    - Structure.MaterialFragments.[Timber](/api_documentation/oM/Analytical/Structure/MaterialFragments/Timber)
    - Structure.Fragments.[ReinforcementDensity](/api_documentation/oM/Analytical/Structure/Fragments/ReinforcementDensity)
    - Structure.Fragments.[SectionModifier](/api_documentation/oM/Analytical/Structure/Fragments/SectionModifier)
    - Structure.Fragments.[SurfacePropertyModifier](/api_documentation/oM/Analytical/Structure/Fragments/SurfacePropertyModifier)
    - Test.Adapter.[TestAdapterId](/api_documentation/oM/Framework/Test/Adapter/TestAdapterId)
    - UI.[ParamOldIndexFragment](/api_documentation/oM/UI/UI/ParamOldIndexFragment)
    - UI.[PreviousNamesFragment](/api_documentation/oM/UI/UI/PreviousNamesFragment)
    - XML.Fragments.[XMLBuildingType](/api_documentation/oM/Adapter/XML/Fragments/XMLBuildingType)


## Properties

## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IFragment.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface/IFragment.cs)

All history and changes of the class can be found by inspection the history.
