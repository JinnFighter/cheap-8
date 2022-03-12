using System;

namespace Emulator.Instructions
{
    internal class NullInstruction : IInstruction
    {
        public void Execute(Memory memory)
        {
            Console.WriteLine("Null Instruction Executed");
        }
    }
}
