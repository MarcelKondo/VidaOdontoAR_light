// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class VidaOdontoAR_lightTarget : TargetRules
{
	public VidaOdontoAR_lightTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "VidaOdontoAR_light" } );
	}
}
