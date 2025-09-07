// Copyright 2020 Dan Kestranek.

using UnrealBuildTool;
using UnrealBuildTool.Rules;

public class GASDocumentation : ModuleRules
{
	public GASDocumentation(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core", "CoreUObject", "Engine", "InputCore",
			"GameplayAbilities", "GameplayTags", "GameplayTasks",
			"UMG", "AIModule"
        });

        PrivateDependencyModuleNames.AddRange(new string[] {
            "Slate", "SlateCore"
        });
    }
}
