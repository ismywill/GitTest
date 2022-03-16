// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GitTestDemo : ModuleRules
{
	public GitTestDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
