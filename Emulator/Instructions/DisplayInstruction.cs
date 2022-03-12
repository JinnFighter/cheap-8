using System;

namespace Emulator.Instructions
{
    internal class DisplayInstruction : IInstruction
    {
        private readonly Display _display;

        public DisplayInstruction(Display display)
        {
            _display = display;
        }

        public void Execute(Memory memory)
        {
            Console.WriteLine("Draw!");
        }
    }
}
