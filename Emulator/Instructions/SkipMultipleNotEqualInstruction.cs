namespace Emulator.Instructions
{
    internal class SkipMultipleNotEqualInstruction : IInstruction
    {
        private readonly int _xIndex;
        private readonly int _yIndex;

        public SkipMultipleNotEqualInstruction(int xIndex, int yIndex)
        {
            _xIndex = xIndex;
            _yIndex = yIndex;
        }

        public void Execute(Memory memory)
        {
            if (memory.Vs[_xIndex] != memory.Vs[_yIndex])
            {
                memory.IncreaseCounterAddress();
            }
        }
    }
}
