################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
INO_SRCS += \
..\firmware.ino 

CPP_SRCS += \
..\AnalogButton.cpp \
..\MAX31855.cpp \
..\PID_AutoTune_v0.cpp \
..\PID_v1.cpp \
..\max6675.cpp \
..\sloeber.ino.cpp 

LINK_OBJ += \
.\AnalogButton.cpp.o \
.\MAX31855.cpp.o \
.\PID_AutoTune_v0.cpp.o \
.\PID_v1.cpp.o \
.\max6675.cpp.o \
.\sloeber.ino.cpp.o 

INO_DEPS += \
.\firmware.ino.d 

CPP_DEPS += \
.\AnalogButton.cpp.d \
.\MAX31855.cpp.d \
.\PID_AutoTune_v0.cpp.d \
.\PID_v1.cpp.d \
.\max6675.cpp.d \
.\sloeber.ino.cpp.d 


# Each subdirectory must supply rules for building sources it contributes
AnalogButton.cpp.o: ..\AnalogButton.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\sloeber_4_2\/arduinoPlugin/packages/arduino/tools/avr-gcc/4.9.2-atmel3.5.4-arduino2/bin/avr-g++" -c -g -Os -Wall -Wextra -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -flto -mmcu=atmega328p -DF_CPU=16000000L -DARDUINO=10802 -DARDUINO_AVR_UNO -DARDUINO_ARCH_AVR   -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\cores\arduino" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\variants\standard" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\libraries\EEPROM" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\libraries\EEPROM\src" -I"C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7" -I"C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7\src" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"  -o  "$@"
	@echo 'Finished building: $<'
	@echo ' '

MAX31855.cpp.o: ..\MAX31855.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\sloeber_4_2\/arduinoPlugin/packages/arduino/tools/avr-gcc/4.9.2-atmel3.5.4-arduino2/bin/avr-g++" -c -g -Os -Wall -Wextra -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -flto -mmcu=atmega328p -DF_CPU=16000000L -DARDUINO=10802 -DARDUINO_AVR_UNO -DARDUINO_ARCH_AVR   -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\cores\arduino" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\variants\standard" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\libraries\EEPROM" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\libraries\EEPROM\src" -I"C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7" -I"C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7\src" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"  -o  "$@"
	@echo 'Finished building: $<'
	@echo ' '

PID_AutoTune_v0.cpp.o: ..\PID_AutoTune_v0.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\sloeber_4_2\/arduinoPlugin/packages/arduino/tools/avr-gcc/4.9.2-atmel3.5.4-arduino2/bin/avr-g++" -c -g -Os -Wall -Wextra -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -flto -mmcu=atmega328p -DF_CPU=16000000L -DARDUINO=10802 -DARDUINO_AVR_UNO -DARDUINO_ARCH_AVR   -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\cores\arduino" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\variants\standard" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\libraries\EEPROM" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\libraries\EEPROM\src" -I"C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7" -I"C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7\src" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"  -o  "$@"
	@echo 'Finished building: $<'
	@echo ' '

PID_v1.cpp.o: ..\PID_v1.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\sloeber_4_2\/arduinoPlugin/packages/arduino/tools/avr-gcc/4.9.2-atmel3.5.4-arduino2/bin/avr-g++" -c -g -Os -Wall -Wextra -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -flto -mmcu=atmega328p -DF_CPU=16000000L -DARDUINO=10802 -DARDUINO_AVR_UNO -DARDUINO_ARCH_AVR   -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\cores\arduino" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\variants\standard" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\libraries\EEPROM" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\libraries\EEPROM\src" -I"C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7" -I"C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7\src" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"  -o  "$@"
	@echo 'Finished building: $<'
	@echo ' '

firmware.o: ..\firmware.ino
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\sloeber_4_2\/arduinoPlugin/packages/arduino/tools/avr-gcc/4.9.2-atmel3.5.4-arduino2/bin/avr-g++" -c -g -Os -Wall -Wextra -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -flto -mmcu=atmega328p -DF_CPU=16000000L -DARDUINO=10802 -DARDUINO_AVR_UNO -DARDUINO_ARCH_AVR   -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\cores\arduino" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\variants\standard" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\libraries\EEPROM" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\libraries\EEPROM\src" -I"C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7" -I"C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7\src" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"  -o  "$@"
	@echo 'Finished building: $<'
	@echo ' '

max6675.cpp.o: ..\max6675.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\sloeber_4_2\/arduinoPlugin/packages/arduino/tools/avr-gcc/4.9.2-atmel3.5.4-arduino2/bin/avr-g++" -c -g -Os -Wall -Wextra -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -flto -mmcu=atmega328p -DF_CPU=16000000L -DARDUINO=10802 -DARDUINO_AVR_UNO -DARDUINO_ARCH_AVR   -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\cores\arduino" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\variants\standard" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\libraries\EEPROM" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\libraries\EEPROM\src" -I"C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7" -I"C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7\src" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"  -o  "$@"
	@echo 'Finished building: $<'
	@echo ' '

sloeber.ino.cpp.o: ..\sloeber.ino.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\sloeber_4_2\/arduinoPlugin/packages/arduino/tools/avr-gcc/4.9.2-atmel3.5.4-arduino2/bin/avr-g++" -c -g -Os -Wall -Wextra -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -flto -mmcu=atmega328p -DF_CPU=16000000L -DARDUINO=10802 -DARDUINO_AVR_UNO -DARDUINO_ARCH_AVR   -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\cores\arduino" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\variants\standard" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\libraries\EEPROM" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\libraries\EEPROM\src" -I"C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7" -I"C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7\src" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"  -o  "$@"
	@echo 'Finished building: $<'
	@echo ' '


