using Emulator.Instructions;
using System;

namespace Emulator
{
    public class Runtime
    {
        private readonly Memory _memory;
        private readonly AddressStack _addressStack;
        private readonly Display _display;

        private bool _isActive;

        private const ushort AMask = 0x0FFF;

        public Runtime()
        {
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
                instruction.Execute(_memory);
                _isActive = false;
            }

            Console.ReadKey();
        }

        private ushort FetchInstruction()
        {
            Console.WriteLine("Fetch instruction");
            var oldCounter = _memory.GetProgramCounter();
            _memory.IncreaseCounterAddress();
            return 0xA2F0;
            return _memory.GetInstruction(oldCounter);
        }

        private IInstruction DecodeInstruction(ushort instructionBytes)
        {
            Console.WriteLine(instructionBytes);
            Console.WriteLine("Decode instruction");
            var nibble = (instructionBytes >> 12);
            Console.WriteLine(nibble);
            IInstruction instruction;
            switch(nibble)
            {
                case 0xA:
                    instruction = new SetIRegisterInstruction((ushort)(instructionBytes & AMask));
                    break;
                default:
                    instruction = new NullInstruction();
                    break;
            }
            return instruction;
        }
    }
}
