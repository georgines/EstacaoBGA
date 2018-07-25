#ifdef __IN_ECLIPSE__
//This is a automatic generated file
//Please do not modify this file
//If you touch this file your change will be overwritten during the next build
//This file has been generated on 2018-07-05 13:50:19

#include "Arduino.h"
#include <LiquidCrystal.h>
#include <EEPROM.h>
#include "AnalogButton_local.h"
#include "PID_v1_local.h"
#include "EEPROMAnything.h"
#include "PID_AutoTune_v0_local.h"
#include "io.h"

void setup() ;
void loop() ;
void drawLCD() ;
void drawItem(byte row, boolean highlight, byte index) ;
byte getValDec(byte index) ;
byte getMenuType(byte index) ;
void back() ;
double getValMin(byte index) ;
double getValMax(byte index) ;
void updown(bool up) ;
void ok() ;
void changeAutoTune() ;
void AutoTuneHelper(boolean start) ;
void StartProfile() ;
void StopProfile() ;
void ProfileRunTime() ;
void calcNextProf() ;
void initializeEEPROM() ;
void EEPROMreset() ;
void EEPROMBackupTunings() ;
void EEPROMRestoreTunings() ;
void EEPROMBackupDash() ;
void EEPROMRestoreDash() ;
void EEPROMBackupATune() ;
void EEPROMRestoreATune() ;
void EEPROMBackupProfile() ;
void EEPROMRestoreProfile() ;
void SerialReceive() ;
void SerialSend() ;

#include "firmware.ino"


#endif
