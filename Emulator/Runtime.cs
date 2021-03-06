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
            return 0xDABC;
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
                case 0x0:
                    if((ushort)(instructionBytes & AMask) == 0x0E0)
                    {
                        instruction = new ClearScreenInstruction(_display);
                    }
                    else
                    {
                        instruction = new NullInstruction();
                    }
                    break;
                case 0x1:
                    instruction = new JumpInstruction((ushort)(instructionBytes & AMask));
                    break;
                case 0x6:
                    instruction = new SetRegisterInstruction((ushort)((instructionBytes & 0x0f00) >> 8), (byte)((instructionBytes & 0x00FF)));
                    break;
                case 0x7:
                    instruction = new AddToRegisterInstruction((ushort)((instructionBytes & 0x0f00) >> 8), (byte)((instructionBytes & 0x00FF)));
                    break;
                case 0xA:
                    instruction = new SetIRegisterInstruction((ushort)(instructionBytes & AMask));
                    break;
                case 0xD:
                    instruction = new DisplayInstruction(_display, (ushort)((instructionBytes & 0x0f00) >> 8), (ushort)((instructionBytes & 0x00f0) >> 4), (ushort)((instructionBytes & 0x000f)));
                    break;
                default:
                    instruction = new NullInstruction();
                    break;
            }
            return instruction;
        }
    }
}
