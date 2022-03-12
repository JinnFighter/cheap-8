using System;

namespace Emulator.Instructions
{
    internal class DisplayInstruction : IInstruction
    {
        private readonly Display _display;
        private readonly int _xIndex;
        private readonly int _yIndex;
        private readonly int _regValue;

        public DisplayInstruction(Display display, int xIndex, int yIndex, int regValue)
        {
            _display = display;
            _xIndex = xIndex;
            _yIndex = yIndex;
            _regValue = regValue;
        }

        public void Execute(Memory memory)
        {
            Console.WriteLine("Draw!");
        }
    }
}
