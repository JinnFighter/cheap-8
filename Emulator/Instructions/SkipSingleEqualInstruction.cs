namespace Emulator.Instructions
{
    internal class SkipSingleEqualInstruction : IInstruction
    {
        private readonly byte _opcode;
        private readonly int _index;

        public SkipSingleEqualInstruction(byte opcode, int index)
        {
            _opcode = opcode;
            _index = index;
        }

        public void Execute(Memory memory)
        {
           if(memory.Vs[_index] == _opcode)
           {
                memory.IncreaseCounterAddress();
           }
        }
    }
}
