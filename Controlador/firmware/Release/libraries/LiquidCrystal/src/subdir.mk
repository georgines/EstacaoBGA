################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7\src\LiquidCrystal.cpp 

LINK_OBJ += \
.\libraries\LiquidCrystal\src\LiquidCrystal.cpp.o 

CPP_DEPS += \
.\libraries\LiquidCrystal\src\LiquidCrystal.cpp.d 


# Each subdirectory must supply rules for building sources it contributes
libraries\LiquidCrystal\src\LiquidCrystal.cpp.o: C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7\src\LiquidCrystal.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\sloeber_4_2\/arduinoPlugin/packages/arduino/tools/avr-gcc/4.9.2-atmel3.5.4-arduino2/bin/avr-g++" -c -g -Os -Wall -Wextra -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -flto -mmcu=atmega328p -DF_CPU=16000000L -DARDUINO=10802 -DARDUINO_AVR_UNO -DARDUINO_ARCH_AVR   -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\cores\arduino" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\variants\standard" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\libraries\EEPROM" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\libraries\EEPROM\src" -I"C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7" -I"C:\sloeber_4_2\arduinoPlugin\libraries\LiquidCrystal\1.0.7\src" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"  -o  "$@"
	@echo 'Finished building: $<'
	@echo ' '


