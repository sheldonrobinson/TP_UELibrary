// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class TP_UELibraryTarget : TargetRules
{
	public TP_UELibraryTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
        bShouldCompileAsDLL = true;
        LinkType = TargetLinkType.Monolithic;
		bOverrideBuildEnvironment = true;

        DefaultBuildSettings = BuildSettingsVersion.V6;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_7;
		ExtraModuleNames.AddRange(new string [] {"UELibrary", "TP_UELibrary"});
		
		if (Target.Platform == UnrealTargetPlatform.Win64)
		{
            GlobalDefinitions.AddRange(new string[] { "UE_LIBRARY_ENABLED=1"});
        }

        if (Target.Platform == UnrealTargetPlatform.Android)
        {
            GlobalDefinitions.AddRange(new string[] { "USE_ANDROID_STANDALONE=1", "BUILD_EMBEDDED_APP=1"});
        }
	}
}
