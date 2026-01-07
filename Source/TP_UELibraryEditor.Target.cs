// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class TP_UELibraryEditorTarget : TargetRules
{
	public TP_UELibraryEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		bCompileAgainstEditor = true;
		DefaultBuildSettings = BuildSettingsVersion.V6;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_7;
		ExtraModuleNames.AddRange(new string [] {"UELibrary", "TP_UELibrary"});

		
	}
}
