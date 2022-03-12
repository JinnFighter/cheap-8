using System;

namespace Emulator.Instructions
{
    internal class NullInstruction : IInstruction
    {
        public void Execute()
        {
            Console.WriteLine("Null Instruction Executed");
        }
    }
}
