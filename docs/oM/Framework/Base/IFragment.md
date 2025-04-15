---
title: IFragment
---

# Base.IFragment

Describes objects that can exist independently or can be attached to other BHoM objects as part of their `FragmentSet` property.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFragment in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Analytical.Fragments.[IDependencyFragment](/om_documentation/oM/Analytical/Analytical/Fragments/IDependencyFragment)
    - Analytical.Fragments.[IProjectionFragment](/om_documentation/oM/Analytical/Analytical/Fragments/IProjectionFragment)
    - Base.[IAdapterId](/om_documentation/oM/Framework/Base/IAdapterId)
    - Base.[IHashFragment](/om_documentation/oM/Framework/Base/IHashFragment)
    - Base.[IPersistentAdapterId](/om_documentation/oM/Framework/Base/IPersistentAdapterId)
    - Environment.MaterialFragments.[IEnvironmentMaterial](/om_documentation/oM/Analytical/Environment/MaterialFragments/IEnvironmentMaterial)
    - Graphics.Fragments.[IRepresentationFragment](/om_documentation/oM/Graphics/Graphics/Fragments/IRepresentationFragment)
    - MEP.System.MaterialFragments.[IInsulationMaterial](/om_documentation/oM/Analytical/MEP/System/MaterialFragments/IInsulationMaterial)
    - Adapters.Revit.Parameters.[IRevitParameterFragment](/om_documentation/oM/Adapter/Adapters/Revit/Parameters/IRevitParameterFragment)
    - Adapters.SAP2000.Fragments.[IPanelOffset](/om_documentation/oM/Adapter/Adapters/SAP2000/Fragments/IPanelOffset)
    - Adapters.SAP2000.Fragments.[IPanelAutoMesh](/om_documentation/oM/Adapter/Adapters/SAP2000/Fragments/IPanelAutoMesh)
    - Structure.MaterialFragments.[IIsotropic](/om_documentation/oM/Analytical/Structure/MaterialFragments/IIsotropic)
    - Structure.MaterialFragments.[IMaterialFragment](/om_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)
    - Structure.MaterialFragments.[IOrthotropic](/om_documentation/oM/Analytical/Structure/MaterialFragments/IOrthotropic)
    - Structure.MaterialFragments.[ITimber](/om_documentation/oM/Analytical/Structure/MaterialFragments/ITimber)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

    - Analytical.Fragments.[ProjectionFragment](/om_documentation/oM/Analytical/Analytical/Fragments/ProjectionFragment)
    - Analytical.Fragments.[RoutingFragment](/om_documentation/oM/Analytical/Analytical/Fragments/RoutingFragment)
    - Analytical.Fragments.[SourcesDependencyFragment](/om_documentation/oM/Analytical/Analytical/Fragments/SourcesDependencyFragment)
    - Analytical.Fragments.[TargetsDependencyFragment](/om_documentation/oM/Analytical/Analytical/Fragments/TargetsDependencyFragment)
    - Base.[HashFragment](/om_documentation/oM/Framework/Base/HashFragment)
    - Diffing.[RevisionFragment](/om_documentation/oM/Framework/Diffing/RevisionFragment)
    - Environment.MaterialFragments.[GasMaterial](/om_documentation/oM/Analytical/Environment/MaterialFragments/GasMaterial)
    - Environment.MaterialFragments.[SolidMaterial](/om_documentation/oM/Analytical/Environment/MaterialFragments/SolidMaterial)
    - Environment.Fragments.[AnalyticalConstruction](/om_documentation/oM/Analytical/Environment/Fragments/AnalyticalConstruction)
    - Environment.Fragments.[BuildingAnalyticalFragment](/om_documentation/oM/Analytical/Environment/Fragments/BuildingAnalyticalFragment)
    - Environment.Fragments.[BuildingContextFragment](/om_documentation/oM/Analytical/Environment/Fragments/BuildingContextFragment)
    - Environment.Fragments.[BuildingResultFragment](/om_documentation/oM/Analytical/Environment/Fragments/BuildingResultFragment)
    - Environment.Fragments.[CoefficientFragment](/om_documentation/oM/Analytical/Environment/Fragments/CoefficientFragment)
    - Environment.Fragments.[EnvironmentConstructionFragment](/om_documentation/oM/Analytical/Environment/Fragments/EnvironmentConstructionFragment)
    - Environment.Fragments.[LightReflectanceFragment](/om_documentation/oM/Analytical/Environment/Fragments/LightReflectanceFragment)
    - Environment.Fragments.[LightTransmittanceFragment](/om_documentation/oM/Analytical/Environment/Fragments/LightTransmittanceFragment)
    - Environment.Fragments.[LoadFragment](/om_documentation/oM/Analytical/Environment/Fragments/LoadFragment)
    - Environment.Fragments.[OriginContextFragment](/om_documentation/oM/Analytical/Environment/Fragments/OriginContextFragment)
    - Environment.Fragments.[PanelAnalyticalFragment](/om_documentation/oM/Analytical/Environment/Fragments/PanelAnalyticalFragment)
    - Environment.Fragments.[PanelContextFragment](/om_documentation/oM/Analytical/Environment/Fragments/PanelContextFragment)
    - Environment.Fragments.[RadiationFragment](/om_documentation/oM/Analytical/Environment/Fragments/RadiationFragment)
    - Environment.Fragments.[SpaceAnalyticalFragment](/om_documentation/oM/Analytical/Environment/Fragments/SpaceAnalyticalFragment)
    - Environment.Fragments.[SpaceContextFragment](/om_documentation/oM/Analytical/Environment/Fragments/SpaceContextFragment)
    - Adapters.ETABS.[ETABSId](/om_documentation/oM/Adapter/Adapters/ETABS/ETABSId)
    - Adapters.ETABS.Elements.[AutoLengthOffset](/om_documentation/oM/Adapter/Adapters/ETABS/Elements/AutoLengthOffset)
    - Adapters.ETABS.Elements.[Diaphragm](/om_documentation/oM/Adapter/Adapters/ETABS/Elements/Diaphragm)
    - Adapters.ETABS.Elements.[Pier](/om_documentation/oM/Adapter/Adapters/ETABS/Elements/Pier)
    - Adapters.ETABS.Elements.[Spandrel](/om_documentation/oM/Adapter/Adapters/ETABS/Elements/Spandrel)
    - Adapters.ETABS.Elements.[InsertionPoint](/om_documentation/oM/Adapter/Adapters/ETABS/Elements/InsertionPoint)
    - Adapters.ETABS.Fragments.[ShellTypeFragment](/om_documentation/oM/Adapter/Adapters/ETABS/Fragments/ShellTypeFragment)
    - Facade.Fragments.[ConstructionOffset](/om_documentation/oM/Analytical/Facade/Fragments/ConstructionOffset)
    - Facade.Fragments.[FrameExtensionBox](/om_documentation/oM/Analytical/Facade/Fragments/FrameExtensionBox)
    - Facade.Fragments.[GlazingLocation](/om_documentation/oM/Analytical/Facade/Fragments/GlazingLocation)
    - Facade.Fragments.[PsiGlassEdge](/om_documentation/oM/Analytical/Facade/Fragments/PsiGlassEdge)
    - Facade.Fragments.[PsiJoint](/om_documentation/oM/Analytical/Facade/Fragments/PsiJoint)
    - Facade.Fragments.[UValueCavity](/om_documentation/oM/Analytical/Facade/Fragments/UValueCavity)
    - Facade.Fragments.[UValueContinuous](/om_documentation/oM/Analytical/Facade/Fragments/UValueContinuous)
    - Facade.Fragments.[UValueFrame](/om_documentation/oM/Analytical/Facade/Fragments/UValueFrame)
    - Facade.Fragments.[UValueGlassCentre](/om_documentation/oM/Analytical/Facade/Fragments/UValueGlassCentre)
    - Facade.Fragments.[UValueGlassEdge](/om_documentation/oM/Analytical/Facade/Fragments/UValueGlassEdge)
    - Graphics.[ColourFragment](/om_documentation/oM/Graphics/Graphics/ColourFragment)
    - Graphics.[RenderMesh](/om_documentation/oM/Graphics/Graphics/RenderMesh)
    - Graphics.Fragments.[EntityRepresentation](/om_documentation/oM/Graphics/Graphics/Fragments/EntityRepresentation)
    - Graphics.Fragments.[GraphRepresentation](/om_documentation/oM/Graphics/Graphics/Fragments/GraphRepresentation)
    - Graphics.Fragments.[GroupRepresentation](/om_documentation/oM/Graphics/Graphics/Fragments/GroupRepresentation)
    - Graphics.Fragments.[RelationRepresentation](/om_documentation/oM/Graphics/Graphics/Fragments/RelationRepresentation)
    - Adapters.GSA.[AnalysisTaskFragment](/om_documentation/oM/Adapter/Adapters/GSA/AnalysisTaskFragment)
    - Adapters.GSA.[DummyTag](/om_documentation/oM/Adapter/Adapters/GSA/DummyTag)
    - Adapters.GSA.[GSAId](/om_documentation/oM/Adapter/Adapters/GSA/GSAId)
    - Adapters.GSA.[IsRigidConstraint](/om_documentation/oM/Adapter/Adapters/GSA/IsRigidConstraint)
    - Adapters.GSA.MaterialFragments.[Fabric](/om_documentation/oM/Adapter/Adapters/GSA/MaterialFragments/Fabric)
    - Adapters.GSA.Fragments.[PanelBoundaryNodeFragment](/om_documentation/oM/Adapter/Adapters/GSA/Fragments/PanelBoundaryNodeFragment)
    - IES.Fragments.[SurfaceIndexFragment](/om_documentation/oM/Adapter/IES/Fragments/SurfaceIndexFragment)
    - LifeCycleAssessment.[LifeCycleAssessmentScope](/om_documentation/oM/Analytical/LifeCycleAssessment/LifeCycleAssessmentScope)
    - LifeCycleAssessment.[Scope](/om_documentation/oM/Analytical/LifeCycleAssessment/Scope)
    - LifeCycleAssessment.Fragments.[AdditionalEPDData](/om_documentation/oM/Analytical/LifeCycleAssessment/Fragments/AdditionalEPDData)
    - LifeCycleAssessment.Fragments.[EPDDensity](/om_documentation/oM/Analytical/LifeCycleAssessment/Fragments/EPDDensity)
    - Adapters.Lusas.[LusasId](/om_documentation/oM/Adapter/Adapters/Lusas/LusasId)
    - Adapters.Lusas.Fragments.[MeshSettings2D](/om_documentation/oM/Adapter/Adapters/Lusas/Fragments/MeshSettings2D)
    - Adapters.Lusas.Fragments.[MeshSettings1D](/om_documentation/oM/Adapter/Adapters/Lusas/Fragments/MeshSettings1D)
    - MEP.System.MaterialFragments.[InsulationMaterial](/om_documentation/oM/Analytical/MEP/System/MaterialFragments/InsulationMaterial)
    - MEP.System.MaterialFragments.[LiningMaterial](/om_documentation/oM/Analytical/MEP/System/MaterialFragments/LiningMaterial)
    - MEP.Fragments.[GeometryFragment](/om_documentation/oM/Analytical/MEP/Fragments/GeometryFragment)
    - MEP.Fragments.[IdentityFragment](/om_documentation/oM/Analytical/MEP/Fragments/IdentityFragment)
    - MEP.Fragments.[PlumbingFlowFragment](/om_documentation/oM/Analytical/MEP/Fragments/PlumbingFlowFragment)
    - MEP.Fragments.[PlumbingLoadingFixtureUnitFragment](/om_documentation/oM/Analytical/MEP/Fragments/PlumbingLoadingFixtureUnitFragment)
    - Adapters.MidasCivil.[MidasCivilId](/om_documentation/oM/Adapter/Adapters/MidasCivil/MidasCivilId)
    - Physical.Reinforcement.[ReinforcementFragment](/om_documentation/oM/Physical/Physical/Reinforcement/ReinforcementFragment)
    - Physical.Materials.[VolumetricMaterialTakeoff](/om_documentation/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff)
    - Adapters.RAM.[RAMDeckData](/om_documentation/oM/Adapter/Adapters/RAM/RAMDeckData)
    - Adapters.RAM.[RAMGridData](/om_documentation/oM/Adapter/Adapters/RAM/RAMGridData)
    - Adapters.RAM.[RAMNodeForceData](/om_documentation/oM/Adapter/Adapters/RAM/RAMNodeForceData)
    - Adapters.RAM.[RAMFrameData](/om_documentation/oM/Adapter/Adapters/RAM/RAMFrameData)
    - Adapters.RAM.[RAMId](/om_documentation/oM/Adapter/Adapters/RAM/RAMId)
    - Adapters.Revit.[RevitGeometry](/om_documentation/oM/Adapter/Adapters/Revit/RevitGeometry)
    - Adapters.Revit.[RevitRepresentation](/om_documentation/oM/Adapter/Adapters/Revit/RevitRepresentation)
    - Adapters.Revit.[RevitTypeFragment](/om_documentation/oM/Adapter/Adapters/Revit/RevitTypeFragment)
    - Adapters.Revit.Parameters.[RevitIdentifiers](/om_documentation/oM/Adapter/Adapters/Revit/Parameters/RevitIdentifiers)
    - Adapters.Revit.Parameters.[RevitParametersToPush](/om_documentation/oM/Adapter/Adapters/Revit/Parameters/RevitParametersToPush)
    - Adapters.Revit.Parameters.[RevitPulledParameters](/om_documentation/oM/Adapter/Adapters/Revit/Parameters/RevitPulledParameters)
    - Revit.[RevitHostFragment](/om_documentation/oM/Adapter/Revit/RevitHostFragment)
    - Adapters.RFEM5.[RFEM5Id](/om_documentation/oM/Adapter/Adapters/RFEM5/RFEM5Id)
    - Adapters.RFEM6.[RFEM6ID](/om_documentation/oM/Adapter/Adapters/RFEM6/RFEM6ID)
    - Adapters.RFEM6.[RFEMHinge](/om_documentation/oM/Adapter/Adapters/RFEM6/RFEMHinge)
    - Adapters.RFEM6.[RFEMLineSupport](/om_documentation/oM/Adapter/Adapters/RFEM6/RFEMLineSupport)
    - Adapters.RFEM6.[RFEMNodalSupport](/om_documentation/oM/Adapter/Adapters/RFEM6/RFEMNodalSupport)
    - Adapters.RFEM6.IntermediateDatastructure.Geometry.[RFEMLine](/om_documentation/oM/Adapter/Adapters/RFEM6/IntermediateDatastructure/Geometry/RFEMLine)
    - Adapters.RFEM6.IntermediateDatastructure.Geometry.[RFEMOpening](/om_documentation/oM/Adapter/Adapters/RFEM6/IntermediateDatastructure/Geometry/RFEMOpening)
    - Adapters.RFEM6.BHoMDataStructure.SupportDatastrures.[RFEM6GeometricalLineLoadTypes](/om_documentation/oM/Adapter/Adapters/RFEM6/BHoMDataStructure/SupportDatastrures/RFEM6GeometricalLineLoadTypes)
    - Adapters.Robot.[LoadCaseLabel](/om_documentation/oM/Adapter/Adapters/Robot/LoadCaseLabel)
    - Adapters.Robot.[PanelFiniteElementIds](/om_documentation/oM/Adapter/Adapters/Robot/PanelFiniteElementIds)
    - Adapters.Robot.[RobotId](/om_documentation/oM/Adapter/Adapters/Robot/RobotId)
    - Adapters.Robot.[FramingElementDesignProperties](/om_documentation/oM/Adapter/Adapters/Robot/FramingElementDesignProperties)
    - Adapters.SAP2000.[SAP2000Id](/om_documentation/oM/Adapter/Adapters/SAP2000/SAP2000Id)
    - Adapters.SAP2000.Elements.[BarInsertionPoint](/om_documentation/oM/Adapter/Adapters/SAP2000/Elements/BarInsertionPoint)
    - Adapters.SAP2000.Elements.[BarDesignProcedure](/om_documentation/oM/Adapter/Adapters/SAP2000/Elements/BarDesignProcedure)
    - Adapters.SAP2000.Elements.[BarAutoMesh](/om_documentation/oM/Adapter/Adapters/SAP2000/Elements/BarAutoMesh)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByCookieCutLines](/om_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByCookieCutLines)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByCookieCutPoints](/om_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByCookieCutPoints)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByGeneralDivide](/om_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByGeneralDivide)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByMaximumSize](/om_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByMaximumSize)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByNumberOfObjects](/om_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByNumberOfObjects)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByPointsOnEdges](/om_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByPointsOnEdges)
    - Adapters.SAP2000.Fragments.[PanelEdgeConstraint](/om_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelEdgeConstraint)
    - Adapters.SAP2000.Fragments.[PanelOffsetByJointPattern](/om_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelOffsetByJointPattern)
    - Adapters.SAP2000.Fragments.[PanelOffsetByPoint](/om_documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelOffsetByPoint)
    - Structure.Reinforcement.[PanelRebarIntent](/om_documentation/oM/Analytical/Structure/Reinforcement/PanelRebarIntent)
    - Structure.MaterialFragments.[Aluminium](/om_documentation/oM/Analytical/Structure/MaterialFragments/Aluminium)
    - Structure.MaterialFragments.[Concrete](/om_documentation/oM/Analytical/Structure/MaterialFragments/Concrete)
    - Structure.MaterialFragments.[GenericIsotropicMaterial](/om_documentation/oM/Analytical/Structure/MaterialFragments/GenericIsotropicMaterial)
    - Structure.MaterialFragments.[GenericOrthotropicMaterial](/om_documentation/oM/Analytical/Structure/MaterialFragments/GenericOrthotropicMaterial)
    - Structure.MaterialFragments.[Glulam](/om_documentation/oM/Analytical/Structure/MaterialFragments/Glulam)
    - Structure.MaterialFragments.[LaminatedVeneerLumberCrossbands](/om_documentation/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberCrossbands)
    - Structure.MaterialFragments.[LaminatedVeneerLumberParallel](/om_documentation/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberParallel)
    - Structure.MaterialFragments.[SawnTimber](/om_documentation/oM/Analytical/Structure/MaterialFragments/SawnTimber)
    - Structure.MaterialFragments.[Steel](/om_documentation/oM/Analytical/Structure/MaterialFragments/Steel)
    - Structure.MaterialFragments.[Timber](/om_documentation/oM/Analytical/Structure/MaterialFragments/Timber)
    - Structure.Fragments.[ReinforcementDensity](/om_documentation/oM/Analytical/Structure/Fragments/ReinforcementDensity)
    - Structure.Fragments.[SectionModifier](/om_documentation/oM/Analytical/Structure/Fragments/SectionModifier)
    - Structure.Fragments.[SurfacePropertyModifier](/om_documentation/oM/Analytical/Structure/Fragments/SurfacePropertyModifier)
    - Test.Adapter.[TestAdapterId](/om_documentation/oM/Framework/Test/Adapter/TestAdapterId)
    - UI.[ParamOldIndexFragment](/om_documentation/oM/UI/UI/ParamOldIndexFragment)
    - UI.[PreviousNamesFragment](/om_documentation/oM/UI/UI/PreviousNamesFragment)
    - XML.Fragments.[XMLBuildingType](/om_documentation/oM/Adapter/XML/Fragments/XMLBuildingType)


## Properties

## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IFragment.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface/IFragment.cs)

All history and changes of the class can be found by inspection the history.
