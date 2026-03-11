// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SkillTreeTest : ModuleRules
{
	public SkillTreeTest(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate",
            "GameplayAbilities",
			"GameplayTags",
			"GameplayTasks"
        });

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"SkillTreeTest",
			"SkillTreeTest/Variant_Platforming",
			"SkillTreeTest/Variant_Platforming/Animation",
			"SkillTreeTest/Variant_Combat",
			"SkillTreeTest/Variant_Combat/AI",
			"SkillTreeTest/Variant_Combat/Animation",
			"SkillTreeTest/Variant_Combat/Gameplay",
			"SkillTreeTest/Variant_Combat/Interfaces",
			"SkillTreeTest/Variant_Combat/UI",
			"SkillTreeTest/Variant_SideScrolling",
			"SkillTreeTest/Variant_SideScrolling/AI",
			"SkillTreeTest/Variant_SideScrolling/Gameplay",
			"SkillTreeTest/Variant_SideScrolling/Interfaces",
			"SkillTreeTest/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
