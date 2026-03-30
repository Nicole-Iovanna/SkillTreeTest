// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "CommonUserWidget.h"
#include "Widgets/CommonActivatableWidgetContainer.h"
#include "HUDStackWidget.generated.h"

class USkillTreeMenuWidget;

/**
 * The Player HUD that all widgets will be contained in
 */
UCLASS()
class SKILLTREETEST_API UHUDStackWidget : public UCommonUserWidget
{
	GENERATED_BODY()

public:

	UFUNCTION(BlueprintCallable)
	void PausePressed();

protected:
	
	UPROPERTY(BlueprintReadWrite)
	bool IsPaused = false;

	UPROPERTY(BlueprintReadWrite, meta=(BindWidget))
	UCommonActivatableWidgetContainerBase* WidgetStack;

	UFUNCTION(BlueprintImplementableEvent, meta = (DisplayName = "OnPause"))
	void OnPausePressed(bool PauseStatus);
	
};
