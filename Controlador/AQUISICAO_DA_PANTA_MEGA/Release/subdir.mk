################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
INO_SRCS += \
..\AQUISICAO_DA_PANTA_MEGA.ino 

CPP_SRCS += \
..\Executa.cpp \
..\decodificarString.cpp \
..\sloeber.ino.cpp 

LINK_OBJ += \
.\Executa.cpp.o \
.\decodificarString.cpp.o \
.\sloeber.ino.cpp.o 

INO_DEPS += \
.\AQUISICAO_DA_PANTA_MEGA.ino.d 

CPP_DEPS += \
.\Executa.cpp.d \
.\decodificarString.cpp.d \
.\sloeber.ino.cpp.d 


# Each subdirectory must supply rules for building sources it contributes
AQUISICAO_DA_PANTA_MEGA.o: ..\AQUISICAO_DA_PANTA_MEGA.ino
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\sloeber_4_2\/arduinoPlugin/packages/arduino/tools/avr-gcc/4.9.2-atmel3.5.4-arduino2/bin/avr-g++" -c -g -Os -Wall -Wextra -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -flto -mmcu=atmega2560 -DF_CPU=16000000L -DARDUINO=10802 -DARDUINO_AVR_MEGA2560 -DARDUINO_ARCH_AVR   -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\cores\arduino" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\variants\mega" -I"C:\Users\Usuario\Documents\Arduino\libraries\MAX6675_library" -I"C:\Users\Usuario\Documents\Arduino\libraries\PID" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"  -o  "$@"
	@echo 'Finished building: $<'
	@echo ' '

Executa.cpp.o: ..\Executa.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\sloeber_4_2\/arduinoPlugin/packages/arduino/tools/avr-gcc/4.9.2-atmel3.5.4-arduino2/bin/avr-g++" -c -g -Os -Wall -Wextra -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -flto -mmcu=atmega2560 -DF_CPU=16000000L -DARDUINO=10802 -DARDUINO_AVR_MEGA2560 -DARDUINO_ARCH_AVR   -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\cores\arduino" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\variants\mega" -I"C:\Users\Usuario\Documents\Arduino\libraries\MAX6675_library" -I"C:\Users\Usuario\Documents\Arduino\libraries\PID" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"  -o  "$@"
	@echo 'Finished building: $<'
	@echo ' '

decodificarString.cpp.o: ..\decodificarString.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\sloeber_4_2\/arduinoPlugin/packages/arduino/tools/avr-gcc/4.9.2-atmel3.5.4-arduino2/bin/avr-g++" -c -g -Os -Wall -Wextra -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -flto -mmcu=atmega2560 -DF_CPU=16000000L -DARDUINO=10802 -DARDUINO_AVR_MEGA2560 -DARDUINO_ARCH_AVR   -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\cores\arduino" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\variants\mega" -I"C:\Users\Usuario\Documents\Arduino\libraries\MAX6675_library" -I"C:\Users\Usuario\Documents\Arduino\libraries\PID" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"  -o  "$@"
	@echo 'Finished building: $<'
	@echo ' '

sloeber.ino.cpp.o: ..\sloeber.ino.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\sloeber_4_2\/arduinoPlugin/packages/arduino/tools/avr-gcc/4.9.2-atmel3.5.4-arduino2/bin/avr-g++" -c -g -Os -Wall -Wextra -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -flto -mmcu=atmega2560 -DF_CPU=16000000L -DARDUINO=10802 -DARDUINO_AVR_MEGA2560 -DARDUINO_ARCH_AVR   -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\cores\arduino" -I"C:\sloeber_4_2\arduinoPlugin\packages\arduino\hardware\avr\1.6.21\variants\mega" -I"C:\Users\Usuario\Documents\Arduino\libraries\MAX6675_library" -I"C:\Users\Usuario\Documents\Arduino\libraries\PID" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"  -o  "$@"
	@echo 'Finished building: $<'
	@echo ' '


