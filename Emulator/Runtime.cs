﻿using System;

namespace Emulator
{
    public class Runtime
    {
        private readonly RegistersContainer _registersContainter;
        private readonly Memory _memory;
        private readonly AddressStack _addressStack;
        private readonly TimerRegisters _timerRegisters;
        private readonly Display _display;

        private bool _isActive;

        public Runtime()
        {
            _registersContainter = new RegistersContainer();
            _memory = new Memory();
            _addressStack = new AddressStack();
            _timerRegisters = new TimerRegisters();
            _display = new Display();
        }

        public void Run()
        {
            _isActive = true;
            while(_isActive)
            {
                var instruction = FetchInstruction();
                Console.WriteLine(instruction);
                DecodeInstruction();
                ExecuteInstruction();
                _isActive = false;
            }

            Console.ReadKey();
        }

        private ushort FetchInstruction()
        {
            Console.WriteLine("Fetch instruction");
            _registersContainter.IncreaseCounterAddress();
            return _memory.GetInstruction(_registersContainter.GetProgramCounter());
        }

        private void DecodeInstruction()
        {
            Console.WriteLine("Decode instruction");
        }

        private void ExecuteInstruction()
        {
            Console.WriteLine("Execute instruction");
        }
    }
}
