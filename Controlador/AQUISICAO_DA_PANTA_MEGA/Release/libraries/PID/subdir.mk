################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
C:\Users\Usuario\Documents\Arduino\libraries\PID\PID_v1.cpp 

LINK_OBJ += \
.\libraries\PID\PID_v1.cpp.o 

CPP_DEPS += \
.\libraries\PID\PID_v1.cpp.d 


# Each subdirectory must supply rules for building sources it contributes
libraries\PID\PID_v1.cpp.o: C:\Users\Usuario\Documents\Arduino\libraries\PID\PID_v1.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\sloeber_4_2\/arduinoPlugin/packages/arduino/tools/avr-gcc/4.9.2-atmel3.5.4-arduino2/bin/avr-g++" -c -g -Os -Wall -Wextra -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -flto -mmcu=atmega2560 -DF_CPU=16000000L -DARDUINO=10802 -DARDUINO_AVR_MEGA2560 -DARDUINO_ARCH_AVR   -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\cores\arduino" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\variants\mega" -I"C:\Users\Usuario\Documents\Arduino\libraries\MAX6675_library" -I"C:\Users\Usuario\Documents\Arduino\libraries\PID" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"  -o  "$@"
	@echo 'Finished building: $<'
	@echo ' '


