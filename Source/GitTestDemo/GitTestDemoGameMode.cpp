// Copyright Epic Games, Inc. All Rights Reserved.

#include "GitTestDemoGameMode.h"
#include "GitTestDemoPawn.h"

AGitTestDemoGameMode::AGitTestDemoGameMode()
{
	// set default pawn class to our flying pawn
	DefaultPawnClass = AGitTestDemoPawn::StaticClass();
}
