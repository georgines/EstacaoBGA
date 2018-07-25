################################################################################
# Automatically-generated file. Do not edit!
################################################################################

-include ..\makefile.init

RM := del 

# All of the sources participating in the build are defined here
-include sources.mk
-include subdir.mk
-include libraries\MAX6675_library\subdir.mk
-include core\core\subdir.mk
-include objects.mk

ifneq ($(MAKECMDGOALS),clean)
ifneq ($(strip $(CC_DEPS)),)
-include $(CC_DEPS)
endif
ifneq ($(strip $(C++_DEPS)),)
-include $(C++_DEPS)
endif
ifneq ($(strip $(C_UPPER_DEPS)),)
-include $(C_UPPER_DEPS)
endif
ifneq ($(strip $(CXX_DEPS)),)
-include $(CXX_DEPS)
endif
ifneq ($(strip $(ASM_DEPS)),)
-include $(ASM_DEPS)
endif
ifneq ($(strip $(INO_DEPS)),)
-include $(INO_DEPS)
endif
ifneq ($(strip $(PDE_DEPS)),)
-include $(PDE_DEPS)
endif
ifneq ($(strip $(S_UPPER_DEPS)),)
-include $(S_UPPER_DEPS)
endif
ifneq ($(strip $(CPP_DEPS)),)
-include $(CPP_DEPS)
endif
ifneq ($(strip $(C_DEPS)),)
-include $(C_DEPS)
endif
endif

-include ..\makefile.defs

# Add inputs and outputs from these tool invocations to the build variables 
AR += \
C:\Users\Usuario\Documents\sloeber-workspace\TESTE_PID_LEONARDO\Release\arduino.ar \

ELF += \
TESTE_PID_LEONARDO.elf \

HEX += \
TESTE_PID_LEONARDO.hex \


# All Target
all: TESTE_PID_LEONARDO

# Tool invocations
TESTE_PID_LEONARDO: $(HEX)
	@echo 'Building target: $@'
	@echo 'Printing size:'
	"C:\sloeber_4_2\/arduinoPlugin/packages/arduino/tools/avr-gcc/4.9.2-atmel3.5.4-arduino2/bin/avr-size" -A "C:/Users/Usuario/Documents/sloeber-workspace/TESTE_PID_LEONARDO/Release/TESTE_PID_LEONARDO.elf"
	@echo 'Finished building target: $@'
	@echo ' '

C:\Users\Usuario\Documents\sloeber-workspace\TESTE_PID_LEONARDO\Release\arduino.ar: $(AR_OBJ)
	@echo 'Starting archiver'
	"C:\sloeber_4_2\/arduinoPlugin/packages/arduino/tools/avr-gcc/4.9.2-atmel3.5.4-arduino2/bin/avr-gcc-ar" rcs    C:/Users/Usuario/Documents/sloeber-workspace/TESTE_PID_LEONARDO/Release/arduino.ar $(AR_OBJ)
	@echo 'Finished building: $@'
	@echo ' '

TESTE_PID_LEONARDO.elf: $(LINK_OBJ) $(AR)
	@echo 'Starting combiner'
	"C:\sloeber_4_2\/arduinoPlugin/packages/arduino/tools/avr-gcc/4.9.2-atmel3.5.4-arduino2/bin/avr-gcc" -Wall -Wextra -Os -g -flto -fuse-linker-plugin -Wl,--gc-sections -mmcu=atmega32u4 -o "C:/Users/Usuario/Documents/sloeber-workspace/TESTE_PID_LEONARDO/Release/TESTE_PID_LEONARDO.elf"   $(LINK_OBJ)   C:/Users/Usuario/Documents/sloeber-workspace/TESTE_PID_LEONARDO/Release/arduino.ar  "-LC:/Users/Usuario/Documents/sloeber-workspace/TESTE_PID_LEONARDO/Release" -lm
	@echo 'Finished building: $@'
	@echo ' '

TESTE_PID_LEONARDO.hex: $(ELF)
	@echo 'Do all objcopy commands'
	${A.RECIPE.OBJCOPY.EEP.PATTERN}
	${A.RECIPE.OBJCOPY.HEX.PATTERN}
	@echo 'Finished building: $@'
	@echo ' '

# Other Targets
clean:
	-$(RM) $(C_UPPER_DEPS)$(PDE_DEPS)$(C_DEPS)$(AR)$(CC_DEPS)$(AR_OBJ)$(C++_DEPS)$(LINK_OBJ)$(CXX_DEPS)$(ASM_DEPS)$(HEX)$(INO_DEPS)$(SIZEDUMMY)$(S_UPPER_DEPS)$(ELF)$(CPP_DEPS)
	-@echo ' '

.PHONY: all clean dependents
.SECONDARY:

-include ..\makefile.targets
