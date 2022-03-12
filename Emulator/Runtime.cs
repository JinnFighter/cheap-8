using Emulator.Instructions;
using System;

namespace Emulator
{
    public class Runtime
    {
        private readonly RegistersContainer _registersContainter;
        private readonly Memory _memory;
        private readonly AddressStack _addressStack;
        private readonly Display _display;

        private bool _isActive;

        private const ushort FirstNibbleMask = 0xF000;
        private const ushort AMask = 0x0FFF;

        public Runtime()
        {
            _registersContainter = new RegistersContainer();
            _memory = new Memory();
            _addressStack = new AddressStack();
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
            ushort nibble = (ushort)(instructionBytes & FirstNibbleMask >> 4);
            IInstruction instruction;
            switch(nibble)
            {
                case 0xA:
                    instruction = new SetIRegisterInstruction(_registersContainter, (ushort)(instructionBytes & AMask));
                    break;
                default:
                    instruction = new NullInstruction();
                    break;
            }
            return instruction;
        }
    }
}
