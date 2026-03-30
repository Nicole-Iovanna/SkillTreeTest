// Fill out your copyright notice in the Description page of Project Settings.


#include "UI/HUDStackWidget.h"
#include "HUDStackWidget.h"

void UHUDStackWidget::PausePressed()
{
	OnPausePressed(IsPaused);
}
