namespace Emulator.Instructions
{
    internal class SkipSingleNotEqualInstruction : IInstruction
    {
        private readonly byte _opcode;
        private readonly int _index;

        public SkipSingleNotEqualInstruction(byte opcode, int index)
        {
            _opcode = opcode;
            _index = index;
        }

        public void Execute(Memory memory)
        {
            if (memory.Vs[_index] != _opcode)
            {
                memory.IncreaseCounterAddress();
            }
        }
    }
}
