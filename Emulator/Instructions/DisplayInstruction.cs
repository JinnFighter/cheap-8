using System;

namespace Emulator.Instructions
{
    internal class DisplayInstruction : IInstruction
    {
        private readonly RegistersContainer _registersContainer;
        private readonly Display _display;


        public DisplayInstruction(RegistersContainer registersContainer, Display display)
        {
            _registersContainer = registersContainer;
            _display = display;
        }

        public void Execute()
        {
            Console.WriteLine("Draw!");
        }
    }
}
