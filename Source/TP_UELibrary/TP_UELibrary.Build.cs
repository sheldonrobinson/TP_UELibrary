// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TP_UELibrary : ModuleRules
{
	public TP_UELibrary(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		// PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput", "UELibrary" });
		
		PublicDependencyModuleNames.AddRange(
			new string[] { 
				"Core", 
				"Engine", 
				"InputCore"
				});
				
		PrivateDependencyModuleNames.AddRange(new string[] { });
		
		if (Target.bBuildEditor == true)
		{
			PrivateDependencyModuleNames.AddRange(new string[] {
					"SourceControl",
					"EditorFramework",
					"UnrealEd",
					"DesktopPlatform",
					"PIEPreviewDeviceProfileSelector",
			});
			
		} else {
			PrivateDependencyModuleNames.AddRange(new string[] { "ApplicationCore", "Launch"});
		}		
	}
}
