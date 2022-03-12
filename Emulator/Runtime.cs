using Emulator.Instructions;
using System;

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
                var instructionBytes = FetchInstruction();
                var instruction = DecodeInstruction(instructionBytes);
                Console.WriteLine("Executing Instruction");
                instruction.Execute();
                _isActive = false;
            }

            Console.ReadKey();
        }

        private ushort FetchInstruction()
        {
            Console.WriteLine("Fetch instruction");
            var oldCounter = _registersContainter.GetProgramCounter();
            _registersContainter.IncreaseCounterAddress();
            return _memory.GetInstruction(oldCounter);
        }

        private IInstruction DecodeInstruction(ushort instructionBytes)
        {
            Console.WriteLine(instructionBytes);
            Console.WriteLine("Decode instruction");
            return new NullInstruction();
        }
    }
}
