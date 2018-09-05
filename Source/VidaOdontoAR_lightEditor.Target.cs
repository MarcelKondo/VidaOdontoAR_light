// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class VidaOdontoAR_lightEditorTarget : TargetRules
{
	public VidaOdontoAR_lightEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "VidaOdontoAR_light" } );
	}
}
