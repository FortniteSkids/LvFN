@echo off
title Fortnite Running Fix
color a

taskkill /f /im FortniteLauncher.exe
taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe
taskkill /f /im FortniteClient-Win64-Shipping.exe
taskruml /f /im EpicGamesLauncher.exe

echo You can now play Real Fortnite Again MadeByLv
timeout /t 3 /nobreak >Nul
GOTO:EOF LAMO
